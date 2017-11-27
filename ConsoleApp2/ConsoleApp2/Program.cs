using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program_2
    {
        enum Sweets { торт, пирожное, мороженое, конфета }; 
        static void Main(string[] args)
        {
            double[] x = new double[3]; 
            double[] y = new double[3];

            //1 
            Console.WriteLine("Введите значение для функции 2*x - 3*x*x*x + 3: ");
            int x1 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Oтвет: " + (2 * x1 - 3 * x1 * x1 * x1 + 3));

            //2 
            foreach(int i in Enum.GetValues(typeof(Sweets)))                           //оператор, получиение типа 
            Console.WriteLine(i);           
            
            //3
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Координата {0}-ой точки треугольника:", i + 1);
                Console.Write("X = ");
                x[i] = double.Parse(Console.ReadLine()); 
                Console.Write("Y = ");
                y[i] = double.Parse(Console.ReadLine());
            }

            double a = Math.Sqrt(Math.Pow(x[1] - x[0], 2) + Math.Pow(y[1] - y[0], 2));   // класс и методы
            double b = Math.Sqrt(Math.Pow(x[2] - x[1], 2) + Math.Pow(y[2] - y[1], 2));
            double c = Math.Sqrt(Math.Pow(x[2] - x[0], 2) + Math.Pow(y[2] - y[0], 2));
            double p = a + b + c;
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            Console.WriteLine("c = {0}", c);
            Console.WriteLine("P = {0}", p);
            Console.WriteLine("S = {0}", Math.Sqrt((p/2) * (p/2 - a) * (p/2 - b) * (p/2 - c)));
        }

    }

}

