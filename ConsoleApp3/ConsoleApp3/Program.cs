using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3_var17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] year = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            Console.WriteLine("Введите номер дня");
            int day = Convert.ToInt16(Console.ReadLine()); 

            if (day > 366)
                Console.WriteLine("Некорректно введен номер дня!");

            Console.WriteLine("Какой сейчас год?");
            int yearnum = Convert.ToInt16(Console.ReadLine());

            if (yearnum % 4 == 0)
                year[1] = 29;
            int sum = 0;
            int i = 0;
            while (sum < day)
            {
                sum += year[i++];
            }
            sum = day - (sum - year[i - 1]);

            Console.WriteLine("{0}-й день в {1}-м году это {2}-е число {3}-го месяца", day, yearnum, sum, i);
            Console.ReadLine();

        }
    }
}
