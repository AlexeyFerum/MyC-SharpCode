namespace LibraryForThird
{
    public class Mole
    {
        public int Id { get; } // номер крота
        public int Health { get; private set; }
        public int Hunger { get; private set; } // чувство голода
        public int Speed;
        public Gender Gender { get; }
        public Status S { get; private set; }
        public int PrevW;
        public int PrevH;
        public bool Moved;

        public Mole(Gender g, int speed, int w, int h, int id)
        {
            Health = GlobalVars.DefaultHealth;
            Gender = g;
            Speed = speed;
            Hunger = GlobalVars.MaxHunger;
            S = Status.Alive;
            PrevH = h;
            PrevW = w;
            Moved = false;
            Id = id;
        }

        //public bool Hurt()
        //{
        //    if (S == Status.Dead)
        //        return false;

        //    Health--;
        //    if (Health <= 0)
        //        S = Status.Dead;
        //    return true;
        //}

        public void Hurt()
        {
            if (S == Status.Dead)
                return;

            Health--;
            if (Health <= 0)
                S = Status.Dead;
        }

        public void Eat(Plant p)
        {
            if (S == Status.Dead)
                return;

            if (p == null)
            {
                Hunger--;
                Health += Hunger < 0 ? Hunger : 0;
                if (Health <= 0)
                    S = Status.Dead;
                return;
            }

            if (!p.Hurt())
                return;

            Health++;
            Hunger = GlobalVars.MaxHunger;
        }
    }
}