using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program_2
    {
        enum sweets{ торт, пирожное, мороженое, конфета }; // разобраться со 2 заданием
        static void Main(string[] args)
        {

            {
                //1 
                Console.WriteLine("Введите значение для функции 2*x - 3*x*x*x + 3: ");
                int x = Convert.ToInt32(Console.ReadLine()); //Преобразует заданное строковое представление числа в эквивалентное 32-битовое целое число со знаком.
                Console.WriteLine("Oтвет: " + (2 * x - 3 * x * x * x + 3));

                //2 
                int x = (int)sweets.торт;
                int y = (int)sweets.конфета;

            Console.WriteLine("торт ={0}", x);
            Console.WriteLine("конфета = {0}", y);
            }
        }


        
    }

}
