using System;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1;
            int y1 = 4;
            char sym1 = '*';
            Draw(x1, y1, sym1);

            Console.ReadLine();
        }
        static void Draw(int x, int y, char symb)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symb);
        }
    }
}
