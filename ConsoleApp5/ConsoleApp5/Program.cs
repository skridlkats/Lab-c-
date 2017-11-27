using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class MySqrtEx : Exception // представляет ошибку, происходящая во время выполнения приложения
    {
    }
    class Program_4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение для функции 2*x^(1/2) - 3/x^2 +3 при условии x != 0 и x >= 0: ");
            int x = Convert.ToInt32(Console.ReadLine());

            try
            {
                Console.WriteLine(formula(x));
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Деление на ноль");
                //Console.WriteLine(e.Message);

            }
            catch (MySqrtEx e)
            {
                Console.WriteLine("Корень из отрицательного числа");
                //Console.WriteLine(e.Message);
            }
        }

        public static double formula(int x)
        {
            if (x == 0) throw new DivideByZeroException();
            if (x < 0) throw new MySqrtEx();
            double result = 2 * (Math.Pow(x,1 / 2)) - 3 / (Math.Pow(x, 2)) + 3;
            return result;

        }
    }
}
