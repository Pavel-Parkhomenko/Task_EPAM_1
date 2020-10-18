using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library_Epam
{
    public class Point
    {
        private int x;
        private int y;

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        public void SetX(int val)
        {
            x = val;
        }

        public void SetY(int val)
        {
            y = val;
        }


        public Point()
        {

        }

    }
}
