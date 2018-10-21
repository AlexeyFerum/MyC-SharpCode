using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace LibraryForThird
{
    public class Game
    {
        private int _moleId;
        private readonly GameCell[,] _field;
        private readonly Action _update; 
        private readonly Form _form;
        private GameState gs;

        public Game(int width, int height, int moleCount, int plantCount, Form form, Action update)
        {
            _field = new GameCell[width, height];
            for (var i = 0; i < width; i++)
            {
                for (var j = 0; j < height; j++)
                {
                    _field[i, j] = new GameCell();
                }
            }

            var rnd = new Random();

            for (var i = 0; i < plantCount; i++) // define the plant place
            {
                var wp = rnd.Next(0, width);
                var hp = rnd.Next(0, height);
                if (_field[wp, hp].P == null) 
                    _field[wp, hp].P = new Plant(i + 1);
                else i--; 
            }

            _moleId = 1;
            for (var i = 0; i < moleCount; i++) // define the mole place
            {
                var wm = rnd.Next(0, width);
                var hm = rnd.Next(0, height);
                _field[wm, hm].M.Add(new Mole((Gender) rnd.Next(0, 2), GlobalVars.DefaultSpeed, wm, hm, _moleId++));
            }

            var wc = rnd.Next(0, width); // define the cottager place
            var hc = rnd.Next(0, height);
            _field[wc, hc].C = new Cottager(GlobalVars.DefaultSpeed, wc, hc);

            var thread = new Thread(GameProcess);
            _form = form;
            _update = update;
            thread.Start();
        }

        public State GetState()
        {
            return new State(_field, gs);
        }

        private void GameProcess()
        {
            gs = GameState.Playing;
            var rnd = new Random();
            while (gs == GameState.Playing)
            {
                for (var i = 0; i < _field.GetLength(0); i++)
                {
                    for (var j = 0; j < _field.GetLength(1); j++)
                    {
                        if (_field[i, j].M.Count > 0)
                        {
                            if (_field[i, j].M.Count >= 2) // what if female and male moles are in one cell
                            {
                                var femIndex = _field[i, j].M.FindIndex(x => x.Gender == Gender.Female && x.Hunger == GlobalVars.MaxHunger);
                                var malIndex = _field[i, j].M.FindIndex(x => x.Gender == Gender.Male && x.Hunger == GlobalVars.MaxHunger);
                                if (femIndex >= 0 && malIndex >= 0)
                                {
                                    _field[i, j].M.Add(new Mole((Gender)rnd.Next(0, 2), GlobalVars.DefaultSpeed, i, j, _moleId++));
                                }
                            }

                            foreach (var tmp in _field[i, j].M)
                            {
                                tmp.Eat(_field[i, j].P);
                            }

                            if (_field[i, j].P == null || _field[i, j].C != null) // move mole
                            {
                                if (_field[i, j].M.Count == 0)
                                    break;

                                for (var x = 0; x < _field[i, j].M.Count; x++)
                                {
                                    if (_field[i, j].M[x].Moved)
                                        continue;

                                    var succeedMole = false; 
                                    while (!succeedMole) // while it's possible to move
                                    {
                                        var d = (Direction) rnd.Next(0, 4);

                                        switch (d)
                                        {
                                            case Direction.Left:
                                                if (i - 1 >= 0 && i - 1 != _field[i, j].M[x].PrevW)
                                                {
                                                    _field[i, j].M[x].Moved = true;
                                                    _field[i, j].M[x].PrevW = i;
                                                    _field[i, j].M[x].PrevH = j;
                                                    _field[i - 1, j].M.Add(_field[i, j].M[x]);
                                                    _field[i, j].M.Remove(_field[i, j].M[x]);
                                                    succeedMole = true; 
                                                }
                                                break;

                                            case Direction.Up:
                                                if (j - 1 >= 0 && j - 1 != _field[i, j].M[x].PrevH)
                                                {
                                                    _field[i, j].M[x].Moved = true;
                                                    _field[i, j].M[x].PrevW = i;
                                                    _field[i, j].M[x].PrevH = j;
                                                    _field[i, j - 1].M.Add(_field[i, j].M[x]);
                                                    _field[i, j].M.Remove(_field[i, j].M[x]);
                                                    succeedMole = true;
                                                }
                                                break;

                                            case Direction.Right:
                                                if (i + 1 < _field.GetLength(0) && i + 1 != _field[i, j].M[x].PrevW)
                                                {
                                                    _field[i, j].M[x].Moved = true;
                                                    _field[i, j].M[x].PrevW = i;
                                                    _field[i, j].M[x].PrevH = j;
                                                    _field[i + 1, j].M.Add(_field[i, j].M[x]);
                                                    _field[i, j].M.Remove(_field[i, j].M[x]);
                                                    succeedMole = true;
                                                }
                                                break;

                                            case Direction.Down:
                                                if (j + 1 < _field.GetLength(1) && j + 1 != _field[i, j].M[x].PrevH)
                                                {
                                                    _field[i, j].M[x].Moved = true;
                                                    _field[i, j].M[x].PrevW = i;
                                                    _field[i, j].M[x].PrevH = j;
                                                    _field[i, j + 1].M.Add(_field[i, j].M[x]);
                                                    _field[i, j].M.Remove(_field[i, j].M[x]);
                                                    succeedMole = true;
                                                }
                                                break;

                                            default:
                                                throw new ArgumentOutOfRangeException();
                                        }
                                    }
                                }
                            }
                        }

                        if (_field[i, j].C != null) 
                        {
                            {
                                foreach (var tmp in _field[i, j].M)
                                {
                                    _field[i, j].C.Hit(tmp);
                                }

                                if (_field[i, j].M.Count == 0 && !_field[i, j].C.Moved)// moving cottager
                                { // only if there is no mole and he hasn't moved yet                                    _field[i, j].C.PrevW = i;
                                    _field[i, j].C.PrevH = j;
                                    var succeedCottager = false;

                                    while (!succeedCottager)
                                    {
                                        var d = (Direction) rnd.Next(0, 4);
                                        switch (d)
                                        {
                                            case Direction.Left:
                                                if (i - 1 >= 0 && i - 1 != _field[i, j].C.PrevW)
                                                {
                                                    _field[i - 1, j].C = _field[i, j].C;
                                                    _field[i, j].C = null;
                                                    succeedCottager = true;
                                                }
                                                break;

                                            case Direction.Up:
                                                if (j - 1 >= 0 && j - 1 != _field[i, j].C.PrevH)
                                                {
                                                    _field[i, j - 1].C = _field[i, j].C;
                                                    _field[i, j].C = null;
                                                    succeedCottager = true;
                                                }
                                                break;

                                            case Direction.Right:
                                                if (i + 1 < _field.GetLength(0) && i + 1 != _field[i, j].C.PrevW)
                                                {
                                                    _field[i + 1, j].C = _field[i, j].C;
                                                    _field[i, j].C = null;
                                                    succeedCottager = true;
                                                }
                                                break;

                                            case Direction.Down:
                                                if (j + 1 < _field.GetLength(1) && j + 1 != _field[i, j].C.PrevH)
                                                {
                                                    _field[i, j + 1].C = _field[i, j].C;
                                                    _field[i, j].C = null;
                                                    succeedCottager = true;
                                                }
                                                break;

                                            default:
                                                throw new ArgumentOutOfRangeException();
                                        }
                                    }
                                }
                            }
                        }

                        if (_field[i, j].P != null && _field[i, j].P.S == Status.Dead) _field[i, j].P = null;
                        if (_field[i, j].M.Count > 0)
                            _field[i, j].M.RemoveAll(a => a.S == Status.Dead);
                    }
                }
            
                _field.Cast<GameCell>().ToList().ForEach(x => x.M.ForEach(y => y.Moved = false));
                gs = _field.Cast<GameCell>().Count(x => x.P != null) == 0 // number of cell, where plant != null
                    // so, if there is no plants and if there is no mole , then moles wins. Else cottager wins or we continue playing
                    ? GameState.MWiNs
                    : _field.Cast<GameCell>().Count(x => x.M.Count > 0) == 0 ? GameState.СWiNs : GameState.Playing;
                _form.Invoke(_update);
                Thread.Sleep(1000);
            }
        }
    }
}