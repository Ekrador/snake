using System;
using System.Collections.Generic;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,5,'*');
          

            p1.Draw();

            Point p2 = new Point(3, 6, '#');
            p2.Draw();
            Point p3 = new Point(5, 6, '$');
            p3.Draw();


            HorizontalLines first = new HorizontalLines(1,33,7,'_');
            VerticalLines second = new VerticalLines(1, 1, 7, '|');
            second.Draw();
            first.Draw();

            Console.ReadLine();
        }
    }
}
