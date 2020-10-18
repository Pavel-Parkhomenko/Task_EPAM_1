using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library_Epam
{
    public class Circle : IFigure
    {
        Point[] cord = new Point[2];

        private double radius;

        private double area = 1;
        private double perimetr = 0;

        public Circle(params int[] circle)
        {
            for (int i = 0, j = 0; i < circle.Length; j++, i += 2)
            {
                cord[j] = new Point();
                cord[j].SetX(circle[i]);
                cord[j].SetY(circle[i + 1]);
            }
        }

        private void Length()
        {
            radius = Math.Sqrt(Math.Pow(cord[1].GetX() - cord[0].GetX(), 2) + Math.Pow(cord[1].GetY() - cord[0].GetY(), 2));
        }

        public double Area()
        {
            Length();
            area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        public double Perimetr()
        {
            perimetr = radius * 2 * Math.PI;
            return perimetr;
        }

        public void InputArPer(int i)
        {
            Console.WriteLine($"\tПараметры {i} круга:");
            Console.WriteLine($"Площадь: {area:f1}");
            Console.WriteLine($"Периметр: {perimetr:f1}");

        }

    }
}
