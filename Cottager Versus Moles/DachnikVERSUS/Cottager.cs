namespace LibraryForThird
{
    public class Cottager
    {
        public int Health;
        public int Speed;
        public int PrevW;
        public int PrevH; 
        public bool Moved; 

        public void Hit(Mole m) 
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