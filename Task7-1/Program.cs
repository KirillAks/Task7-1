using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_1
{
    class Program
    {
        // Два треугольника заданы длинами своих сторон. Определить, площадь какого из них больше 
        // (создать метод для вычисления  площади  треугольника по длинам его сторон). Для решения задачи можно использовать формулу Герона.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины сторон первого треугольника");
            double x1 = Convert.ToInt32(Console.ReadLine());
            double y1 = Convert.ToInt32(Console.ReadLine());
            double z1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длины сторон вторового треугольника");
            double x2 = Convert.ToInt32(Console.ReadLine());
            double y2 = Convert.ToInt32(Console.ReadLine());
            double z2 = Convert.ToInt32(Console.ReadLine());
            double squareFirstTriangle, squareSecondTriangle;
            DetermineSquareTriangle(x1, y1, z1, x2, y2, z2, out squareFirstTriangle, out squareSecondTriangle);
            if (squareFirstTriangle> squareSecondTriangle)
            {
                Console.WriteLine("Площадь первого треугольника больше {0:f2} > {1:f2}", squareFirstTriangle, squareSecondTriangle);
            }
            if (squareFirstTriangle < squareSecondTriangle)
            {
                Console.WriteLine("Площадь второго треугольника больше {0:f2} < {1:f2}", squareFirstTriangle, squareSecondTriangle);
            }
            else
            {
                Console.WriteLine("Площади треугольников равны {0:f2} = {1:f2}", squareFirstTriangle, squareSecondTriangle);
            }            
            Console.ReadKey();
        }
        static void DetermineSquareTriangle(double x1, double y1, double z1, double x2, double y2, double z2, out double squareFirstTriangle, out double squareSecondTriangle)
        {
            double halfPerimetrFirst =  ((x1 + y1 + z1) / 2);
            squareFirstTriangle = Math.Sqrt(halfPerimetrFirst * (halfPerimetrFirst - x1) * (halfPerimetrFirst - y1) * (halfPerimetrFirst - z1));
            double halfPerimetrSecond = ((x2 + y2 + z2) / 2);
            squareSecondTriangle = Math.Sqrt(halfPerimetrSecond * (halfPerimetrSecond - x2) * (halfPerimetrSecond - y2) * (halfPerimetrSecond - z2));
        }
    }
}
