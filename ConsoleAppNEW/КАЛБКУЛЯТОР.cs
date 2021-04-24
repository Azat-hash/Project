using System;

namespace ConsoleAppNEW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше первое число и нажмите на ENTER ");
            string value1 = Console.ReadLine();
            int num1 = int.Parse(value1);

            Console.WriteLine("Введите ваше второе  число и нажмите на ENTER");
            string value2 = Console.ReadLine();
            int num2 = int.Parse(value2);

            Console.WriteLine("Выберите вариант");
            Console.WriteLine("1.прибавить +"); // прибавить
            Console.WriteLine("2.вычитать -"); // вычитать
            Console.WriteLine("3.умножить *"); // умножить
            Console.WriteLine("4.делить /"); // делить

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($"Результат: { num1 + num2}");
                    break;
                case "2":
                    Console.WriteLine($"Результат: { num1 - num2}");
                    break;
                case "3":
                    Console.WriteLine($"Результат: { num1 * num2}");
                    break;
                case "4":
                   
                    if (num2 != 0)
                    {
                        Convert.ToString(num1 / num2);
                    }
                    else
                    {
                        throw new Exception("На ноль делить нельзя");
                    }

                    Console.WriteLine($"Результат: {num1 / num2}");
                    break;
            }
            Console.ReadKey();
        }
    }

}

