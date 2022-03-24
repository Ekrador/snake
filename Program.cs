using System;
using System.Collections.Generic;
using System.Threading;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,5,'*');
          

            p1.Draw();

            Point p2 = new Point(3, 5, '#');
         


            HorizontalLines first = new HorizontalLines(1,33,7,'_');
            VerticalLines second = new VerticalLines(1, 1, 7, '+');
            second.Draw();
            first.Draw();
            Snake snake = new Snake(p2, 10, Direction.Right);
            snake.Draw();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Console.ReadLine();
        }
    }
}
