namespace LibraryForThird
{
    public class Cottager
    {
        public int Health;
        public int Speed;
        public int PrevW; // запоминаем координату j предыдущей ячейки
        public int PrevH; // запоминаем координату i предыдущей ячейки
        public bool Moved; // проверка на то, что дачник уже перемещался.

        public void Hit(Mole m) // наступил на крота
        {
            m.Hurt();
        }

        public Cottager(int speed, int w, int h)
        {
            Health = GlobalVars.DefaultHealth;
            Speed = speed;
            PrevW = w;
            PrevH = h;
            Moved = false;
        }
    }
}