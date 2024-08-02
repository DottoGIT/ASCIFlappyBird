using System;

namespace FlappyBird
{
    class Program
    {
        static void Main(string[] args)
        {

            
            for (; ; )
            {
                var game = new Game();
                game.Score = 0;
                bool CanLeave = false;
                for (; ; )
                {

                    game.Play();
                    System.Threading.Thread.Sleep(50);
                    Console.Clear();
                    if (game.GameOver)
                    break;


                }
                while(game.smth!=game.ScreenHeight)
                {
                    game.Play();
                    System.Threading.Thread.Sleep(50);
                    Console.Clear();
                    game.smth++;
                    
                }

                //DRAW GAME OVER SCREEN


                while (CanLeave == false)
                {
                    
                     Console.WriteLine("");
                     Console.WriteLine("");
                     Console.WriteLine("");
                     Console.WriteLine("");
                     Console.WriteLine("");
                     Console.WriteLine("");
                     Console.WriteLine("");
                     Console.WriteLine("");
                     Console.WriteLine("");
                     Console.WriteLine("");
                     Console.WriteLine("");
                     Console.WriteLine("");
                     Console.WriteLine("");
                     Console.WriteLine("                                                        GAME OVER");
                     Console.WriteLine($"                                                 You've scored: {game.Score-1} points");
                     Console.WriteLine("");
                     Console.WriteLine("");
                     Console.WriteLine("");
                     Console.WriteLine("");
                     Console.WriteLine("");
                     Console.WriteLine($" Click ENTER to restart");
                     Console.WriteLine($" Click ESCAPE to exit");
                    
                        
                             ConsoleKeyInfo cki = Console.ReadKey();
                             if (cki.Key == ConsoleKey.Escape)
                             { Environment.Exit(0); }

                             if (cki.Key == ConsoleKey.Enter)
                             { CanLeave = true; }
                         
                }
                
            }
        }
    }
}
