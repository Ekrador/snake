using System;
using System.Collections.Generic;
using System.Threading;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
   
            Point p2 = new Point(3, 5, '*');
         


            HorizontalLines upline = new HorizontalLines(0,78,0,'#');
            HorizontalLines downline = new HorizontalLines(0, 78, 24, '#');
            VerticalLines leftline = new VerticalLines(0, 0, 24, '#');
            VerticalLines rightline = new VerticalLines(78, 0, 24, '#');
            upline.Draw();
            downline.Draw();
            leftline.Draw();
            rightline.Draw();
            Snake snake = new Snake(p2, 10, Direction.Right);
            snake.Draw();
            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();
            while (true)
            {   
                if (snake.eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                    
                }
                Thread.Sleep(200);
                snake.Move();
            }
            Console.ReadLine();
        }
    }
}
