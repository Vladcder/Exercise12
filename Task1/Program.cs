using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение радиуса круга: ");
            double radius=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Длина окружности равна "+ Circle.CalculateLength(radius));
            Console.WriteLine("Площадь окружности равна " + Circle.CalculateArea(radius));
            Console.Write("Введите координату x0 центра окружности ");
            double x0 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату y0 центра окружности ");
            double y0 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату точки x ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату точки y ");
            double y = Convert.ToDouble(Console.ReadLine());
            if (Circle.IsPointInCircle(x,y,radius,x0,y0))
            {
                Console.WriteLine($"Точка ({x},{y}) лежит в окружности с радиусом {radius} и центром в точке ({x0},{y0})");
            }
            else
            {
                Console.WriteLine($"Точка ({x},{y}) не лежит в окружности с радиусом {radius} и центром в точке ({x0},{y0})");

            }
        }
    }
}
