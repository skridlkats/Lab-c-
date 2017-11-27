using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_3 {

    class Program
    {
        static void Main()
        {
            double[] x = new double[3];
            double[] y = new double[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Координата {0}-ой точки треугольника:", i + 1);
                Console.Write("X = ");
                x[i] = double.Parse(Console.ReadLine());
                Console.Write("Y = ");
                y[i] = double.Parse(Console.ReadLine());
            }
            double a = GetSide(x[0], y[0], x[1], y[1]);
            double b = GetSide(x[1], y[1], x[2], y[2]);
            double c = GetSide(x[2], y[2], x[0], y[0]);
            double p = a + b + c;
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            Console.WriteLine("c = {0}", c);
            Console.WriteLine("P = {0}", p);
            p /= 2d;
            Console.WriteLine("S = {0}", Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
        }

        static double GetSide(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
   // class Program {
       
        //struct Point
        //{ //Представляет упорядоченную пару из целое число со знаком x и y координаты, определяющую точку на двумерной плоскости.
          //  public double x, y;

//public Point(double x, double y) {
//  this.x = x;
//this.y = y;
//            }
//      }

//        struct Square {
//          public Point[] points;

//        public Square(Point p1, Point p2, Point p3, Point p4) {
//          this.points = new Point[4] {p1, p2, p3, p4};
//    }

//  public double Area() {
//    double[] len = new double[3];
//  len[0] = Math.Sqrt(Math.Pow(this.points[0].x - this.points[1].x, 2) + Math.Pow(this.points[0].y - this.points[1].y, 2));
//               len[1] = Math.Sqrt(Math.Pow(this.points[0].x - this.points[2].x, 2) + Math.Pow(this.points[0].y - this.points[2].y, 2));
//             len[2] = Math.Sqrt(Math.Pow(this.points[0].x - this.points[3].x, 2) + Math.Pow(this.points[0].y - this.points[3].y, 2));
//           double max = Math.Max(len[0], Math.Max(len[1], len[2]));
//         double area = 1;
//       for(int i=0; i<3; i++) {
//         if(len[i] != max)
//           area *= len[i];
// }
//          return area;
//    }
//  }

//static void Main(string[] args) {


//      System.Console.WriteLine("\nSquare points:\n(0, 0)\n(0, 2)\n(2, 0)\n(2, 2)");
//    Square square = new Square(new Point(0, 0), new Point(0, 2), new Point(2, 0), new Point(2, 2));
//  System.Console.WriteLine(String.Format("Its area: {0}", square.Area()));
//     }
//}
//}
