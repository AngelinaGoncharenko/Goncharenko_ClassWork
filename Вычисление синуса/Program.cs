namespace Вычисление_синуса
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = Convert.ToInt32(Console.ReadLine());
            double x = Convert.ToDouble(Console.ReadLine());
            double s, t, v;
            if (m < 0)
            {
                s = (m - m * x * x) / (x + 1);
            }
            else
            {
                s = (-10.6 * x);
            }
            if (s > -1)
            {
                t = s - Math.Pow(Math.Cos(s / x), 2);
            }
            else
            {
                t = m * s + Math.Sin(x) + m;
            }
            v = x + 3 * m * s - s * t;
            Console.WriteLine(v);
        }
    }
}