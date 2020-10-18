using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library_Epam
{
    public class Square : IFigure
    {
        private Point[] cord = new Point[4];

        private double LengthA;
        private double LengthB;
        private double LengthC;
        private double LengthD;

        private double area = 1;
        private double perimetr = 0;

        public Square(params int[] square)
        {
            for (int i = 0, j = 0; i < square.Length; j++, i += 2)
            {
                cord[j] = new Point();
                cord[j].SetX(square[i]);
                cord[j].SetY(square[i + 1]);
            }
        }

        private void Length()
        {
            LengthA = Math.Sqrt(Math.Pow(cord[1].GetX() - cord[0].GetX(), 2) + Math.Pow(cord[1].GetY() - cord[0].GetY(), 2));

            LengthB = Math.Sqrt(Math.Pow(cord[2].GetX() - cord[1].GetX(), 2) + Math.Pow(cord[2].GetY() - cord[1].GetY(), 2));

            LengthC = Math.Sqrt(Math.Pow(cord[3].GetX() - cord[2].GetX(), 2) + Math.Pow(cord[3].GetY() - cord[2].GetY(), 2));

            LengthD = Math.Sqrt(Math.Pow(cord[3].GetX() - cord[0].GetX(), 2) + Math.Pow(cord[3].GetY() - cord[0].GetY(), 2));
        }

        public double Area()
        {
            Length();
            return area = LengthD * LengthC;
        }

        public double Perimetr()
        {
            return perimetr = LengthA + LengthB + LengthC + LengthD; ;
        }

        public void InputArPer(int i)
        {
            Console.WriteLine($"\tПараметры {i} квадрата:");
            Console.WriteLine($"Площадь: {area:f1}");
            Console.WriteLine($"Периметр: {perimetr:f1}");
        }
    }
}
