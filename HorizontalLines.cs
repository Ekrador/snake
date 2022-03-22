using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class HorizontalLines
    {
        List<Point> plist;
        public HorizontalLines(int x_left, int x_right, int y, char sym)
        {
            plist = new List<Point>();
   
            for (int i =x_left; i <= x_right; i++)
            {
                Point p = new Point(i,y,sym);
                plist.Add(p);

            }
        }

        public void Draw()
        {
            foreach (Point i in plist)
            {
                i.Draw();
            }
        }
    }
}
