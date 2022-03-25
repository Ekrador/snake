using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Walls
    {
        List<Figure> walllist;

        public Walls(int mapWidht, int mapHeight)
        {
            walllist = new List<Figure>();
            HorizontalLines upline = new HorizontalLines(0, mapWidht - 1, 0, '#');
            HorizontalLines downline = new HorizontalLines(0, mapWidht - 1, mapHeight-1, '#');
            VerticalLines leftline = new VerticalLines(0, 0,mapHeight-1, '#');
            VerticalLines rightline = new VerticalLines(mapWidht - 1, 0 ,mapHeight-1, '#');
            walllist.Add(upline);
            walllist.Add(downline);
            walllist.Add(rightline);
            walllist.Add(leftline);
        }
        internal bool IsHit(Figure figure)
        {
            foreach (var wall in walllist)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
                return false;
            

        }
        public void Draw()
        {
            foreach (var wall in walllist)
            {
                wall.Draw();
            }
        }

    }
}
