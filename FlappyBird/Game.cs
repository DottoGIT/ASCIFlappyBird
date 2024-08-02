using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    class Game
    {
        public int smth = 0;
        private int jump = 0;
        private bool IsUp = false;
        int old = 10;
        public int ScreenHeight = 25;
        public int WallPos;
        public int Score = 0;
        Random RNG = new Random();
        public int rng;

        public bool GameOver = false;






        public void Play()
        {

            if (!GameOver)
            {

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo cki;
                    cki = Console.ReadKey();

                    if (cki.Key == ConsoleKey.Enter)
                        jump = 8;
                }
                if (jump == 0)
                {
                    if (!Console.KeyAvailable)
                    { smth++; }
                }



                if (jump > 0)
                { smth--; jump--; }

                if (smth >= ScreenHeight || smth < -1)
                { GameOver = true; }

                if (old > smth || old == smth) IsUp = true;
                else IsUp = false;
                old = smth;



                if (WallPos == 0)
                { WallPos = 120; rng = RNG.Next(18); Score++; }



            }
            var brib = new Bird(smth, IsUp, WallPos);
            var wall = new Wall(ref WallPos, rng, GameOver);
            

            wall.DrawWallUP(ref WallPos, smth);

            brib.Update(wall.GapPos,wall.GapSize, GameOver);

            wall.DrawWallDOWN(smth, ScreenHeight, WallPos, Score);


            if ((smth < wall.GapPos || smth > wall.GapPos + wall.GapSize) && WallPos < 17)
            { GameOver = true; }









        }




    }
}
