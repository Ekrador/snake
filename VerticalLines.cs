using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class VerticalLines : Figure
    {
      

        public VerticalLines(int x, int y_up, int y_down, char symb)
        {
            plist = new List<Point>();
            for (int i = y_up; i <= y_down; i++)
            {
                Point p = new Point(x, i, symb);
                plist.Add(p);
            }

        }
  

    }
}
