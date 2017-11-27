using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 5 задание
namespace ConsoleApp6
{
    class Program
    {
        // 1. Разработать структуру прямоугольника
        struct Rectangle
        {
            public static double[] x = new double[4];  // public модификатор доступа static модификатор статичного типа
            public static double[] y = new double[4];

            public static double LengthA()
            {
                return Math.Sqrt(Math.Pow(x[1] - x[0], 2) + Math.Pow(y[1] - y[0], 2)); 
            }
            public static double LengthB()
            {
                return Math.Sqrt(Math.Pow(x[3] - x[0], 2) + Math.Pow(y[3] - y[0], 2)); 
            }
        }

        // 2. Реализовать метод, производящий сложение произвольного количества чисел. тип значения групп
        struct Sum
        {
            public static void Summa(params int[] list)
            {
                
                for (int i = 0; i < list.Length; i++)
                {
                    //ch = 0;
                    Console.Write(list[i] + " ");
                    //ch = ch + list[i];
                    Console.Write(list.Select(x => Convert.ToInt32(x)).ToList().Sum());
                }

                //return ch//list.Split(StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt32(x)).ToList().Sum();
            }
        }

        // 4.5 Реализовать метод, вычисляющий факториал заданного числа, без использования рекурсии/ c использованием рекурсии 
        struct Factorial
        {
            public static int Fact(int n)
            {
                int result = 1;
                try
                {
                    while (n > 0)
                    { result = checked(result * n--); }
                    return result;
                }
                catch (OverflowException)
                {
                    return 0;
                }
            }
            public static int FactRec(int x)
            {
                if (x == 0)
                {return 1;}
                else
                {return x * FactRec(x - 1);}
            }

            static void Main(string[] args)
            {
                //1   
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine("Координата {0}-ой точки приямоугольника:", i + 1);
                    Console.Write("X = ");
                    Rectangle.x[i] = double.Parse(Console.ReadLine());
                    Console.Write("Y = ");
                    Rectangle.y[i] = double.Parse(Console.ReadLine());
                }
                Console.WriteLine("Area of square: " + Rectangle.LengthA() * Rectangle.LengthB());
                Console.WriteLine("And perimeter of square: " + (2 * (Rectangle.LengthA() + Rectangle.LengthB())));
                //2
                Console.WriteLine("Введите числа через пробел и нажмите Enter:");
                Console.WriteLine(Sum.Summa(Console.ReadLine()));
                //4
                Console.WriteLine("Введите факториал числа(без рекурсии):");
                Console.WriteLine(String.Format("factorial in cycle  = {0}", Factorial.Fact(Convert.ToInt32(Console.ReadLine()))));
                //5
                Console.WriteLine("Введите факториал числа(с рекурсии):");
                Console.WriteLine(String.Format("factorial with recursion  = {0}", Factorial.FactRec(Convert.ToInt32(Console.ReadLine()))));

            }
        }
    }
}

