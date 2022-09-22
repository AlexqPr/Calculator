namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите операцию");
            Console.WriteLine("1.Сложить 2 числа");
            Console.WriteLine("2.Вычесть первое из второго");
            Console.WriteLine("3.Перемножить два числа");
            Console.WriteLine("4.Разделить первое на второе");
            Console.WriteLine("5.Возвести в степень N первое число");
            Console.WriteLine("6.Найти квадратный корень из числа");
            Console.WriteLine("7.Найти 1 процент от числа");
            Console.WriteLine("8.Найти факториал числа");
            Console.WriteLine("9.Выход из программы");


            int number = Convert.ToInt32(Console.ReadLine());
            while (number != 9)

            {


                if (number == 1)
                {
                    Console.WriteLine("Введите первое");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ваш результат: " + (a + b));
                }
                if (number == 2)
                {
                    Console.WriteLine("Введите первое");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ваш результат: " + (a - b));
                }
                if (number == 3)
                {
                    Console.WriteLine("Введите первое");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ваш результат: " + a * b);
                }
                if (number == 4)
                {
                    Console.WriteLine("Введите первое");
                    float a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе");
                    float b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ваш результат: " + a / b);
                }
                if (number == 5)
                {
                    Console.WriteLine("Введите число");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите степень");
                    int b = Convert.ToInt32(Console.ReadLine());
                    int c = 1;
                    for (int i = 0; i < b; i++)
                    {
                        c = c * a;

                    }
                    Console.WriteLine("Ваш результат: " + c);
                }
                if (number == 6)
                {
                    Console.WriteLine("Введите число");
                    int a = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ваш результат: " + Math.Sqrt(a));
                }
                if (number == 7)
                {
                    Console.WriteLine("Введите число");
                    float a = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ваш результат: " + a / 100);
                }
                if (number == 8)
                {
                    Console.WriteLine("Введите число");


                    int c = 1;
                    int a = Convert.ToInt32(Console.ReadLine());

                    for (int i = 1; i <= a; i++)
                    {
                        c = c * i;
                    }
                    Console.WriteLine("Ваш результат:" + c);
                }
                int jkf = Convert.ToInt32((Console.ReadLine()));
                number = jkf;
            }
        }
    
    }
}