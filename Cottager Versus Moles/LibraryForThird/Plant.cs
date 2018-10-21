namespace LibraryForThird
{
    public class Plant
    {
        public int Id { get; } // задаем номер растению, поскольку на участке оно может быть не одно
        public int Health { get; private set; }
        public Status S { get; private set; }

        public Plant(int id)
        {
            Health = GlobalVars.DefaultHealth;
            S = Status.Alive;
            Id = id;
        }

        public bool Hurt()
        {
            if (S == Status.Dead)
                return false;

            Health--;
            if (Health <= 0)
                S = Status.Dead;
            return true;
        }
    }
}