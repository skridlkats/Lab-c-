using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//9 задание
namespace ConsoleApp10
{
    class Program
    {
        public abstract class Figyra  // Создаем абстрактный класс
        {
            public abstract int Raschet();   //абстрактный формат строки для вывода результата который будет переопределен в других классах
            public abstract float Area();  //абстрактный метод расчета по формуле, который будет переопределен в других классах
            public abstract float Perimeter();
        }
        public class Dot : Figyra
        {
            int[,] line = { { 1, 2 } };

            public override int Raschet()
            {
                throw new NotSupportedException();
            }
            public override float Area()
            {
                throw new NotSupportedException();
            }
            public override float Perimeter()
            {
                throw new NotSupportedException();
            }
        }
        public class Line : Figyra
        {
            //ЛИНИЯ         
            int[,] line = { { 1, 2 }, { 3, 4 } };

            public override int Raschet()   // Переопределяем метод vivod()
            {
                return (int)Math.Sqrt(Math.Pow((line[1, 0] - line[0, 0]), 2) + Math.Pow((line[1, 1] - line[0, 1]), 2));
            }
            public override float Area()
            {
                throw new NotSupportedException();
            }
            public override float Perimeter()
            {
                throw new NotSupportedException();
            }
        }

        // КВАДРАТ 
        public class Square : Figyra
        {

            int[,] line = new int[,] { { 0, 0 }, { 4, 0 }, { 4, 4 }, { 0, 4 } };

            public override float Area()
            {
                int d = (line[1, 0] - line[0, 0]) * (line[1, 0] - line[0, 0]) + (line[1, 1] - line[0, 1]) * (line[1, 1] - line[0, 1]);                
                return d * d;
            }
            public override float Perimeter()
            {
                int d = (int)Math.Sqrt(Math.Pow((line[1, 0] - line[0, 0]), 2) + Math.Pow((line[1, 1] - line[0, 1]), 2));
                return d * 4;
            }

            public override int Raschet()   // Переопределяем метод vivod()
            {
                int d = (int)Math.Sqrt(Math.Pow((line[1, 0] - line[0, 0]), 2) + Math.Pow((line[1, 1] - line[0, 1]), 2));

                return d * d;
            }
        }

        public class Rectangle : Figyra
        {
            int[,] line = new int[,] { { 3, 4 }, { 9, 4 }, { 3, 6 }, { 9, 6 } };

            public override int Raschet()
            {
                int d = (int)Math.Sqrt(Math.Pow((line[1, 0] - line[0, 0]), 2) + Math.Pow((line[1, 1] - line[0, 1]), 2));
                int c = (int)Math.Sqrt(Math.Pow((line[1, 1] - line[0, 0]), 2) + Math.Pow((line[1, 1] - line[0, 1]), 2));
                Console.WriteLine("Первая длина стороны равна:{0}", d);
                return c;
            }
            public override float Area()
            {
                int d = (int)Math.Sqrt(Math.Pow((line[1, 0] - line[0, 0]), 2) + Math.Pow((line[1, 1] - line[0, 1]), 2));
                int c = (int)Math.Sqrt(Math.Pow((line[1, 1] - line[0, 0]), 2) + Math.Pow((line[1, 1] - line[0, 1]), 2));
                return d * c;
            }
            public override float Perimeter()
            {
                int d = (int)Math.Sqrt(Math.Pow((line[1, 0] - line[0, 0]), 2) + Math.Pow((line[1, 1] - line[0, 1]), 2));
                int c = (int)Math.Sqrt(Math.Pow((line[1, 1] - line[0, 0]), 2) + Math.Pow((line[1, 1] - line[0, 1]), 2));
                return (d + c) * 2;
            }
        }

        public class Circle : Figyra
        {

            int[,] line = new int[,] { { 7, 7 }, { 2, 7 } };
            public override int Raschet()
            {
                int r = (int)Math.Sqrt(Math.Pow((line[1, 0] - line[0, 0]), 2) + Math.Pow((line[1, 1] - line[0, 1]), 2));
                return r;
            }
            public override float Area()
            {
                int r = (int)Math.Sqrt(Math.Pow((line[1, 0] - line[0, 0]), 2) + Math.Pow((line[1, 1] - line[0, 1]), 2));
                int S = (int)Math.PI * r * r;
                return S;
            }
            public override float Perimeter()
            {
                int r = (int)Math.Sqrt(Math.Pow((line[1, 0] - line[0, 0]), 2) + Math.Pow((line[1, 1] - line[0, 1]), 2));
                int P = (int)(2 * Math.PI * r);
                return P;
            }
        }

        static void Main(string[] args)
        {
            Dot us0 = new Dot();
            Console.WriteLine("ТОЧКА\n координаты точки: [ 1, 2 ], [ 3, 4 ]");
            Line us1 = new Line();
            Console.WriteLine("ОТРЕЗОК\n Длина отрезка равна:{0}", us1.Raschet());
            Square us2 = new Square();
            Console.WriteLine("КВАДРАТ\n Длина стороны равна:{0}\nПлощадь квадрата равна:{1}\nПериметр квадрата равна: {2}", us2.Raschet(), us2.Area(), us2.Perimeter());
            Rectangle us3 = new Rectangle();
            Console.WriteLine("ПРИЯМОУГОЛЬНИК\n Вторая длина стороны равна:{0}\nПлощадь прямоугольника равна:{1}\nПериметр прямоугольника равна: {2}", us3.Raschet(), us3.Area(), us3.Perimeter());
            Circle us4 = new Circle();
            Console.WriteLine("ОКРУЖНОСТЬ\n Радиус равен:{0}\nПлощадь окружности равна:{1}\nПериметр окружности равна: {2}", us4.Raschet(), us4.Area(), us4.Perimeter());
            float[] A = new float[3] { us2.Area(), us3.Area(), us4.Area() };
            double sum = 0;
            for (int i = 0; i < 3; i++)
            {
                sum += A[i];
            }
            Console.WriteLine("Сумма площадей фигур равна:{0}", sum);
        }
    }
}

// полиморфический метод - наследуемый(:)
// abstract класс предназначен только для использования в качестве базового класса для других классов
// new - Применяется для создания объектов и вызова конструкторов
