using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Point
    {
        public int x;
        public int y;
        public char symb;
        public Point()
        {

        }
        public Point(int _x, int _y, char _symb)
        {
            x = _x;
            y = _y;
            symb = _symb;
        }
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            symb = p.symb;
        }
        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.Right)
            {
                x = x + offset;
            }
           else if (direction == Direction.Left)
            {
                x = x - offset;
            }
            else if (direction == Direction.Top)
            {
                y = y - offset;
            }
            else if (direction == Direction.Down)
            {
                y = y + offset;
            }
        }
        public void Clear()
        {
            symb = ' ';
            Draw();
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symb);
        }
        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }
    }
}
