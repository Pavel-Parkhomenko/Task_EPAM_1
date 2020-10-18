using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library_Epam
{
    public class Triangle : IFigure
    {
        private Point[] cord = new Point[3];

        private double LengthAB;
        private double LengthCA;
        private double LengthBC;

        private double area = 0;
        private double perimetr = 0;

        public Triangle(params int[] triagle)
        {
            for (int i = 0, j = 0; i < triagle.Length; j++, i += 2)
            {
                cord[j] = new Point();
                cord[j].SetX(triagle[i]);
                cord[j].SetY(triagle[i + 1]);
            }
        }

        private void Length()
        {
            LengthAB = Math.Sqrt(Math.Pow(cord[1].GetX() - cord[0].GetX(), 2) + Math.Pow(cord[1].GetY() - cord[0].GetY(), 2));

            LengthCA = Math.Sqrt(Math.Pow(cord[2].GetX() - cord[0].GetX(), 2) + Math.Pow(cord[2].GetY() - cord[0].GetY(), 2));

            LengthBC = Math.Sqrt(Math.Pow(cord[2].GetX() - cord[1].GetX(), 2) + Math.Pow(cord[2].GetY() - cord[1].GetY(), 2));
        }

        public double Area()
        {
            Length();
            double CosA = (Math.Pow(LengthAB, 2) + Math.Pow(LengthCA, 2) - Math.Pow(LengthBC, 2)) / (2 * LengthAB * LengthCA);
            double SinA = Math.Sqrt(1 - CosA * CosA);  
            return area = 0.5 * LengthAB * LengthCA * SinA; ;
        }

        public double Perimetr()
        {
            perimetr = LengthAB + LengthCA + LengthBC;
            return perimetr;
        }

        public void InputArPer(int i)
        {
            Console.WriteLine($"\tПараметры {i} треугольника:");
            Console.WriteLine($"Площадь: {area:f1}");
            Console.WriteLine($"Периметр: {perimetr:f1}");

        }
    }
}
