using System;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 1;
            p1.y = 5;
            p1.symb = '*';

            p1.Draw();

            Console.ReadLine();
        }
       
    }
}
