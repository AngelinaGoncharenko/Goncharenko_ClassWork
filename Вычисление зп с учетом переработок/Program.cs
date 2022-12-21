namespace Вычисление_зп_с_учетом_переработок
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вычисление зп с учетом превышения значения данных

            int salary = 0;
            Console.WriteLine("Введите значение отработанных дней:");
            int days = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение заработной платы:");
            int pay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение переработанных дней: ");
            int pererabotka = Convert.ToInt32(Console.ReadLine());
            if (pererabotka > 6 || days > 31)
            {
                Console.WriteLine("Error");
            }
            else if (pererabotka > 3)
            {
                salary += 3000;
                salary = (days + pererabotka) * pay;
                Console.WriteLine("Ваша заработная плата составляет: " + salary);
            }
            else
            {
                salary = (days + pererabotka) * pay;
                Console.WriteLine("Ваша заработная плата составляет: " + salary);
            }
        }
    }
}