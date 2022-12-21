namespace Циклы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  ЦИКЛ WHILE



            //Console.WriteLine("Введите шаг интерации");    
            //int i = Convert.ToInt32(Console.ReadLine());
            //int j = 0;
            //while(j<100)
            //{
            //    Console.WriteLine(j);
            //    j += i;
            //}




            Console.WriteLine("Введите символ");
            char sym = Convert.ToChar(Console.ReadLine());
            int i = 0;
            while (i != 10)
            {
                Console.WriteLine(sym);
                sym++;
                i++;
            }



            //Console.WriteLine("Введите символ");
            //char sym = Convert.ToChar(Console.ReadLine());
            //Console.WriteLine("Введите количество символов");
            //int count = Convert.ToInt32(Console.ReadLine());
            //int i = 0;  
            //while (i != count)
            //{
            //    Console.WriteLine(sym);
            //    sym++; // если -- то в орбратном порядке
            //    i++;
            //}




            // ЦИКЛ DO WHILE



            // пользователь вводит 2 числа, программа выводит все кратные
            // двум в диапозоне между этими значениями

            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int i = a;
            //do
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;

            //}
            //while (i != b);





            //string stopString = "exit";
            //string text;


            //while (true)
            //{
            //    text = Console.ReadLine();
            //    Console.WriteLine($"количество символов в строке - {text.Length}\n ");

            //    if (text == stopString) break;
            //}


            //string stopString = "exit";
            //string text;
            //int count = 0;

            //while (true)
            //{
            //    text = Console.ReadLine();
            //    count++;

            //    if (text == stopString) break;
            //}
            //Console.WriteLine($"количество введенных строк - {count}\n ");





            //тема_циклы С ПАРАМЕТРОМ 


            //int a = Convert.ToInt32(Console.ReadLine()); // +
            //int b = Convert.ToInt32(Console.ReadLine()); // -

            //for (int i = b; i < a && i >= b; i++)
            //{
            //    Console.Write($"{i}|");
            //}

            //если через вложенный цикл

            //for (int i = b; i<a; i++)
            //{
            //    if (i == a) break;
            //    Console.Write($"{i}|");
            //}



            // вычисление факториала

            //int a = Convert.ToInt32(Console.ReadLine());
            //int i = 1;
            //int result = 1;
            //while(i <= a)
            //{

            //   result *= i;   //*= умножит и перезапишет сразу в эту переменную
            //    i++;

            //}
            //Console.WriteLine(result);

            //факториал в обратную сторону

            //int a = Convert.ToInt32(Console.ReadLine());
            //int i = a;
            //int result = 1;

            //while (i != 1)
            //{
            //    result *= a;
            //    i--;
            //}

            //Console.WriteLine(result);


            // через for

            //int number = Convert.ToInt32(Console.ReadLine());
            //int result=1;
            //for(int i = 1; i <= number; i*= i+1)
            //{
            //    result *= i;   
            //}
            //Console.WriteLine(result);


            //int number = Convert.ToInt32(Console.ReadLine());
            //int result = 1;
            //for (int i = number; i != 0; i--)
            //{
            //    result *= i;
            //}
            //Console.WriteLine(result);




            // вывод степеней 2

            //int pows = Convert.ToInt32(Console.ReadLine());
            //int result = 1;
            //for (int i = 1; i <= pows; i++)
            //{
            //    Console.WriteLine(Math.Pow(2, 1));
            //}
        }
    }
}