using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibraryForThird
{
    public class GlobalVars
    {
        public const int DefaultHealth = 10;
        public const int DefaultSpeed = 1;
        public const int MaxHunger = 5;
    }

    public enum GameState
    {
        Playing, 
        СWiNs,
        MWiNs 
    }

    public enum Status
    {
        Alive,
        Dead
    }

    public enum Gender
    {
        Male,
        Female
    }

    public enum Direction
    {
        Left,
        Up,
        Right,
        Down
    }
    
    public class GameCell
    {
        public Plant P;
        public Cottager C;
        public List<Mole> M; 

        public GameCell()
        {
            M = new List<Mole>();
        }
    }

    public class State // current state of the field
    {
        public string[,] Inside; 
        public List<string> Moles;
        public List<string> Plants;

        public State(GameCell[,] field, GameState gs)
        {
            Inside = new string[field.GetLength(0), field.GetLength(1)];
            Moles = new List<string>();
            Plants = new List<string>();

            for (var i = 0; i < field.GetLength(0); i++)
            {
                for (var j = 0; j < field.GetLength(1); j++)
                {
                    if (field[i, j].P != null)
                        Plants.Add("P" + field[i, j].P.Id + ": " + field[i, j].P.Health);

                    foreach (var m in field[i, j].M)
                    {
                        Moles.Add("M" + m.Id + (m.Gender == Gender.Male ? "M" : "F") + ": " + m.Health);
                    }

                    Inside[i, j] = (field[i, j]?.P?.Health > 0 ? "P" + field[i, j].P.Id + " " : "") +
                                   (field[i, j]?.C != null ? "C " : "") +
                                    field[i, j]?.M.Aggregate("",
                                       (current, tmp) => current + "M" + tmp.Id + (tmp.Gender == Gender.Male ? "M " : "F "));
                }
            }

            Plants.Add(string.Empty);
            Plants.Add(gs == GameState.СWiNs ? "Cottager wins!" : gs == GameState.MWiNs ? "Moles wins!" : "");
        }

        public void SetPrevious(int i, int j, GameCell[,] _field, int x)
        {
            _field[i, j].M[x].Moved = true;
            _field[i, j].M[x].PrevW = i;
            _field[i, j].M[x].PrevH = j;
        }
    }
}
