using System;
using System.Collections.Generic;
using System.Threading;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Snake game \nWant start? (y/n):");

            while (true)
            {
                string start = Convert.ToString(Console.ReadLine());
                if (start == "y" || start == "Y")
                {
                    Console.Clear();
                    GameStart();
                }
                else if (start == "n" || start == "N")
                {
                    Environment.Exit(0);
                }
            }
            static void GameStart()
            {
                Console.CursorVisible = false;
                Console.SetWindowSize(80, 25);
                Console.SetBufferSize(80, 25);
                Walls walls = new Walls(80, 25);
                Point p2 = new Point(3, 5, '*');
                walls.Draw();
                int speed = 150;
                int score = 0;

                Snake snake = new Snake(p2, 10, Direction.Right);
                snake.Draw();
                FoodCreator foodCreator = new FoodCreator(80, 25, '$');
                Point food = foodCreator.CreateFood();
                while (snake.foodinside(food))
                {
                    food = foodCreator.CreateFood();
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                food.Draw();
                Console.ForegroundColor = ConsoleColor.White;
                while (true)
                {
                    if (walls.IsHit(snake) || snake.IsHitTail())
                    {
                        Console.Clear();
                        break;
                    }
                    if (snake.eat(food))
                    {
                        food = foodCreator.CreateFood();
                        while (snake.foodinside(food))
                        {
                            food = foodCreator.CreateFood();
                        }
                        speed -= 5;
                        score++;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        food.Draw();
                        Console.ForegroundColor = ConsoleColor.White;


                    }

                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo key = Console.ReadKey();
                        snake.HandleKey(key.Key);

                    }
                    Thread.Sleep(speed);
                    snake.Move();
                }
                Console.WriteLine("Game Over, you lose \nYour score is {0}\nTry again? (y/n)", score);
                while (true)
                {
                    string start = Convert.ToString(Console.ReadLine());
                    if (start == "y" || start == "Y")
                    {
                        Console.Clear();
                        GameStart();
                    }
                    else if (start == "n" || start == "N")
                    {
                        Environment.Exit(0);
                    }
                }







            }



        }
    }
}