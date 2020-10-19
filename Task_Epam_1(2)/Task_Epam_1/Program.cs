using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Class_Library_Epam;

namespace Task_Epam_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure();
            var numbers = figure.QuantityString();

            if (numbers.tr == 0 && numbers.sq == 0 && numbers.cir == 0)
                Console.WriteLine("Файл отсуствует!");
            else
            {

                Triangle[] triangle = new Triangle[numbers.tr];
                Square[] square = new Square[numbers.sq];
                Circle[] circle = new Circle[numbers.cir];

                int colAreas = numbers.tr + numbers.sq + numbers.cir;

                figure.ReadWithFile(triangle, square, circle);

                double[] areas = new double[colAreas];
                for (int i = 0, j = 0; i < areas.Length; i += 3, j++)
                {
                    areas[i] = triangle[j].Area();
                    areas[i + 1] = square[j].Area();
                    areas[i + 2] = circle[j].Area();
                }

                double[] perimetrTriangeles = new double[numbers.tr];
                for (int i = 0; i < perimetrTriangeles.Length; i++)
                {
                    perimetrTriangeles[i] = triangle[i].Perimetr();
                }

                double[] perimetrSquare = new double[numbers.sq];
                for (int i = 0; i < perimetrSquare.Length; i++)
                {
                    perimetrSquare[i] = square[i].Perimetr();
                }

                double[] perimetrCircle = new double[numbers.cir];
                for (int i = 0; i < perimetrCircle.Length; i++)
                {
                    perimetrCircle[i] = circle[i].Perimetr();
                }

                double[] middlePerimetr = new double[3];

                middlePerimetr[0] = MiddlePerimetr(perimetrTriangeles);
                middlePerimetr[1] = MiddlePerimetr(perimetrSquare);
                middlePerimetr[2] = MiddlePerimetr(perimetrCircle);

                Console.WriteLine();
                MaxArea(areas);
                СomparisonMiddlePerimetr(middlePerimetr);
            }

            Console.ReadKey();
        }

        static public void MaxArea(params double[] areas)
        {
            double max = areas[0];
            int i = 0;
            for (int j = 0; j < areas.Length; j++)
            {
                if (areas[j] > max)
                {
                    max = areas[j];
                    i = j;
                }
            }
            for (int j = 1, h = 0; j < 3; j++, h += 3)
            {
                if (i == h)
                    Console.WriteLine($"Максимальную площадь ({max:f1}) имеет: {j} треугольник");
                else if (i == h + 1)
                    Console.WriteLine($"Максимальную площадь ({max:f1}) имеет: {j} квадрат");
                else if (i == h + 2)
                    Console.WriteLine($"Максимальную площадь ({max:f1}) имеет: {j} круг");
            }
        }

        static void СomparisonMiddlePerimetr(params double[] arr)
        {
            double max = arr[0];
            int i = 0;
            for(int j = 0; j < arr.Length; j++)
            {
                if (arr[j] > max)
                {
                    max = arr[j];
                    i = j;
                }            
            }
            if (i == 0)
                Console.WriteLine($"Максимальный средний периметр ({max:f1}) имеет тип: треугольник");
            else if (i == 1)
                Console.WriteLine($"Максимальный средний периметр ({max:f1}) имеет тип: квадрат");
            else
                Console.WriteLine($"Максимальный средний периметр ({max:f1}) имеет тип: круг");
        }

        static double MiddlePerimetr(params double[] periment)
        {
            double middlePerimetr = 0;
            int i;
            for(i = 0; i < periment.Length; i++)
            {
                middlePerimetr += periment[i];
            }
            return middlePerimetr / i;
        }
    }
}
