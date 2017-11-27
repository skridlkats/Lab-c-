using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// задание 8
namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.Разбить строку на массив строк с помощью символа - разделителя.
            Console.Write("3 задание\n Введите строку:");
            string str = Console.ReadLine();
            string[] words = str.Split(new[] { ' ', ',', ':', '?', '!', ';' }); 
            foreach (string i in words)
            {Console.WriteLine(i);}

            //4.Осуществить форматированный вывод на экран целого и вещественного числа, даты/времени. Использовать не менее трёх вариантов форматирования каждого из выводимых значений (целого и вещественного числа, даты/времени).
            DateTime dt = new DateTime(2017, 10, 15, 21, 17, 0);
            Console.WriteLine("4 задание");
            Console.WriteLine(String.Format("{0:d m yyyy}", dt));
            Console.WriteLine(String.Format("{0:d/M/yyyy HH:mm:ss}", dt));
            Console.WriteLine(String.Format("{0:u}", dt)); // свойство UniversalSortableDateTimePattern	yyyy'-'MM'-'dd HH':'mm':'ss'Z'

            //5.Собрать строку из двух массивов строк с помощью StringBuilder.
            Console.WriteLine("5 задание");
            Console.WriteLine("Введите 1 строчку: ");
            string[] s1 = Console.ReadLine().Split(' '); // каждое слово элемент массива
            Console.WriteLine("Введите 2 строчку: ");
            string[] s2 = Console.ReadLine().Split(' ');

            StringBuilder sb = new StringBuilder(); // Класс предоставляет изменяемую строку символов
            Array.ForEach(s1, st => sb.Append(st));
            Array.ForEach(s2, st => sb.Append(st));
            Console.WriteLine(sb);

            //6.Преобразовать символы в строке из строчных в прописные и обратно.
            Console.WriteLine("6 задание");
            Console.Write("Введите строку из строчных и прописных букв:");
            string str2 = Console.ReadLine();
            Console.WriteLine(str2.ToUpper());
            Console.WriteLine(str2.ToLower());

            //7.Переставить символы в строке в обратном порядке с максимально эффективным использованием памяти.
            Console.WriteLine("7 задание");
            Console.Write("Введите строку, где символы будут расположенные в обратном порядке:");
            string str3 = Console.ReadLine();
            char[] s = str3.ToCharArray(); 
            Array.Reverse(s); 
            Console.WriteLine(s);
        }          
    }
}
