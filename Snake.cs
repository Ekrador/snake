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
            Console.ForegroundColor = ConsoleColor.Green;
            head.Draw();
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.Left;

            if (key == ConsoleKey.RightArrow)
                direction = Direction.Right;

            if (key == ConsoleKey.UpArrow)
                direction = Direction.Top;

            if (key == ConsoleKey.DownArrow)
                direction = Direction.Down;
        }

        internal bool eat(Point food)
        {
            Point head = plist.Last();
            if (head.IsHit(food))
            {
                food.symb = head.symb;
                plist.Add(food);
                return true;
            }
            else
            { return false; }

        }

        public Point GetNextPoint()
        {
            Point head = plist.Last();
            Point NextPoint = new Point(head);
            NextPoint.Move(1, direction);
            return NextPoint;
        }
        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            base.Draw();
            Console.ForegroundColor = ConsoleColor.White;
        }
        internal bool IsHitTail()
        {
            var head = plist.Last();
            for (int i = 0; i < plist.Count - 2; i++)
            {
                if (head.IsHit(plist[i]))
                    return true;
            }
            return false;
        }
        internal bool foodinside(Point p)
        {
            for (int i = 0; i < plist.Count; i++)
            {
                if (p.IsHit(plist[i]))
                {
                    return true;
                }
            }
            return false;

        }
    }
}
