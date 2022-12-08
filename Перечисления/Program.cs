namespace Перечисления
{

    enum Days { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday}

    enum State { alive, died, buffing, almostDied}

    internal class Program
    {
        static void Main(string[] args)
        {

            //foreach (string s in GetShedule(Days.Thursday))
            //{
            //    Console.WriteLine(s);
            //}

            int HP = 20;
            State state = State.alive;
            Console.WriteLine(state);

            Console.WriteLine("Hit the enemy with force: ");
            int force = Convert.ToInt32(Console.ReadLine());

            HP -= force;
            state |= State.almostDied;

            Console.WriteLine(state);

            HP = 0;
            Console.WriteLine(state);
        }



        static string[] GetShedule (Days day)
        {

            switch (day)
            {

                case Days.Monday: return new string[] { "Architecture", "Programming", "Mathematics", "MDK" }; break;

                case Days.Tuesday: return new string[] { "Architecture", "Physical education", "Mathematics" }; break;

                case Days.Wednesday: return new string[] {" ", "Psychology", "Standardization", "MDK"}; break;

                case Days.Thursday: return new string[] { "Programming", "Programming", "Programming", "Physical education"}; break;

                case Days.Friday: return new string[] { " ", " ","MDK", "MDK", "MDK" }; break;

                case Days.Saturday: return new string[] { " ", "MDK", "MDK", "MDK" }; break;

                case Days.Sunday: return new string[] { "Programming", "Programming", "Programming" }; break;


            }
        }
    }
}