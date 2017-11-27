using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

// 6 задание
namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            int[] array = { 90, 76, 54, 23, 56, 12, 48 }; // класс

            int index = 0;
            Console.WriteLine("Данный массив: ");
            // входные параметры с левой стороны лямбда-оператора =>
            for (int i = array.GetLowerBound(0); i <= array.GetUpperBound(0); i++) 
                Console.WriteLine("[{0}]: {1}", i, array[i]);

            //2
            Array.Sort(array);
            Console.WriteLine("Сортированный массив:");
            index = 0;
            for (int i = array.GetLowerBound(0); i <= array.GetUpperBound(0); i++)
            Console.WriteLine("[{0}]: {1}", i, array[i]);
            Console.WriteLine("Индекс 54: " + Array.IndexOf(array, 54));

            //3 
            // Вместо массива мы используем список, который, как уже говорилось ранее, по умолчанию является динамическим.
            List<int> array2 = new List<int> { 90, 76, 54, 23, 56, 12, 48 };
            array2.Remove(56);

            Console.WriteLine("Массив без элмента 56:");
            int[] array3 = array2.ToArray<int>(); // с помощью метода ToArray преобразуем список в массив.
            for (int i = array3.GetLowerBound(0); i <= array3.GetUpperBound(0); i++)
                Console.WriteLine("[{0}]: {1}", i, array3[i]);

            //4 
            int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
            int[,] matrix2 = { { 1, 0 }, { 0, 1 } };
            int[,] matrix3 = new int[2, 2];

            for (int i = 0; i < 2; i++)
            {for (int j = 0; j < 2; j++)
                {for (int k = 0; k < 2; k++)
                    {matrix3[i, j] += matrix1[i, k] * matrix2[k, j];}
                }
            }
            Console.WriteLine("Результат:");
            for (int i = 0; i < 2; i++)
            {for (int j = 0; j < 2; j++)
                {Console.Write(String.Format("{0,2}", matrix3[i, j])); }               
            }

            //5
            Hashtable ht = new Hashtable(); //класс Предоставляет коллекцию пар "ключ-значение"
            ht.Add(90, "Элемент 90"); // add метод
            ht.Add(76, "Элемент 76");
            ht.Add(54, "Элемент 54");
            ht.Add(23, "Элемент 23");
            ht.Add(56, "Элемент 56");
            ht.Add(12, "Элемент 12");
            ht.Add(48, "Элемент 48");
            Console.WriteLine(String.Format("\nПоиск 56: {0}", ht[56]));
        }
    }
}