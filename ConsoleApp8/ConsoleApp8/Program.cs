using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// задание 7
namespace ConsoleApp8
{
    class Program7_var17
    {
        static void Main(string[] args)
        {
            //2. Сформировать массив отсортированных по возрастанию дат, отстоящих друг от друга на число дней, 
            //увеличивающееся на указанное в задании количество дней по сравнению с предыдущими датами, 
            //начиная с сегодняшней даты. Длина массива задаётся с консоли. 
            //Результат в виде таблицы элементов полученного массива вывести на консоль. 
            int d;
            Console.Write("Длина массива:");
            d = Convert.ToInt32(Console.ReadLine());
            DateTime[] A = new DateTime[d];
            A[0] = DateTime.Now; // структура.свойство
            int i;
            int b = 6;
            Console.WriteLine(A[0]);
            for (i = 1; i < d; i++)
            {
                A[i] = A[i - 1].AddDays(b); // метод
                b = b + 6;
                Console.WriteLine(A[i]);
            }
        }
    }
    
}
