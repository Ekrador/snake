using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Snake : Figure
    {
        Direction direction;
        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            plist = new List<Point>();
            for (int i = 0; i < length; i++)
            {
           
                Point p = new Point(tail);
                p.Move(i, direction);
                plist.Add(p);
                    
            }
        }

        internal void Move()
        {
            Point tail = plist.First();
            plist.Remove(tail);
            Point head = GetNextPoint();
            plist.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = plist.Last();
            Point NextPoint = head;
            NextPoint.Move(1, direction);
            return NextPoint;
        }
    }
}
