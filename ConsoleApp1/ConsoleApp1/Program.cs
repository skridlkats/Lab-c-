using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1_var17
{
    class Program
    {
        static void Main(string[] args)   
        {
            //1 Запросить через консоль имя человека, а затем поздороваться с этим человеком
            Console.WriteLine("Input name"); // line переведет его в начало следующей строчки
            string s = Console.ReadLine();
            Console.WriteLine("Hello, {0}", s);

            //2 Установить название окна консоли в соответствии с именем студента
            Console.Title = s; //Возвращает или задает заголовок для отображения в строке заголовка консоли.

            //3 Выдать звуковой сигнал
            Console.Beep();

            //4 Отобразить состояние CapsLock и NumLock
            Console.WriteLine("CapsLock: {0}", Console.CapsLock);
            Console.WriteLine("NumLock: {0}", Console.NumberLock);
        }
    }
}