using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library_Epam
{
    public class Figure
    {
        private string line;
        private int start;
        private int end;
        private string comparison;
        private string rezult;
       
        string path = @"D:\Документы Д\Программирование\Task_Epam_1(2)\Task_Epam_1\Epam_Task_1.txt";


        public (int tr, int sq, int cir) QuantityString()
        {
            var numbers = (tr: 0, sq: 0, cir: 0);
            try
            {
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {

                    while ((line = sr.ReadLine()) != null)
                    {
                        start = line.IndexOf("");
                        end = line.IndexOf(':');
                        comparison = line.Substring(start, end - start);
                        if (comparison == "Triangle")
                            numbers.tr++;
                        else if (comparison == "Square")
                            numbers.sq++;
                        else
                            numbers.cir++;
                    }
                }
                return numbers;
            }
            catch
            {
                return numbers;
            }
        }
            

        public void ReadWithFile(Triangle[] triangle, Square[] square, Circle[] circle)
        {
            QuantityString();

            int tr = -1;
            int sq = -1;
            int cir = -1;

            using (StreamReader str = new StreamReader(path, System.Text.Encoding.Default))
            {
                while ((line = str.ReadLine()) != null)
                {
                    start = line.IndexOf("");
                    end = line.IndexOf(':');
                    comparison = line.Substring(start, end - start);

                    if (comparison == "Triangle")
                    {
                        tr++;
                        start = line.IndexOf(':');
                        rezult = line.Substring(start + 1);
                        string[] worrd = rezult.Split(new char[] { ' ' });
                        int[] cord = new int[6];

                        for (int i = 0; i < cord.Length; i++)
                        {
                            cord[i] = int.Parse(worrd[i]);
                        }

                        triangle[tr] = new Triangle(cord);

                        triangle[tr].Area();
                        triangle[tr].Perimetr();
                        triangle[tr].InputArPer(tr + 1);

                    }
                    else if (comparison == "Square")
                    {
                        sq++;
                        start = line.IndexOf(':');
                        rezult = line.Substring(start + 1);
                        string[] worrd = rezult.Split(new char[] { ' ' });
                        int[] cord = new int[8];

                        for (int i = 0; i < cord.Length; i++)
                        {
                            cord[i] = int.Parse(worrd[i]);
                        }

                        square[sq] = new Square(cord);

                        square[sq].Area();
                        square[sq].Perimetr();
                        square[sq].InputArPer(sq + 1);
                    }
                    else if (comparison == "Circle")
                    {
                        cir++;
                        start = line.IndexOf(':');
                        rezult = line.Substring(start + 1);
                        string[] worrd = rezult.Split(new char[] { ' ' });
                        int[] cord = new int[4];

                        for (int i = 0; i < cord.Length; i++)
                        {
                            cord[i] = int.Parse(worrd[i]);
                        }

                        circle[cir] = new Circle(cord);

                        circle[cir].Area();
                        circle[cir].Perimetr();
                        circle[cir].InputArPer(cir + 1);
                    }
                }
            }
        }
    }
}
