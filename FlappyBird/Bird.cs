using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBird
{
     class Bird
    {
        public Bird(int inpoz, bool IsUp, int InWallPos)
        { Position = inpoz; Up = IsUp; WallPos = InWallPos; }
        int Position;
        int WallPos;
        string str = "|";
        string gap = ",";
        bool Up;

        public void Update(int GapPos, int GapSize, bool Over)
        {
           
            if (!Up)
            {
                
                if (WallPos <17)
                {
                    Console.WriteLine($@"          \\\");
                    Console.WriteLine("       >>-;;;-Ó>");
                }
                else if (Position >= GapPos && Position <= GapPos + GapSize)
                {
                   
                    Console.WriteLine($@"          \\\{gap.PadLeft(WallPos - 13)}");
                    Console.WriteLine($"       >>-;;;-Ó>{gap.PadLeft(WallPos - 16)}");
                }
                else
                {
                    Console.WriteLine($@"          \\\{ str.PadLeft(WallPos - 13)}");
                    Console.WriteLine($@"       >>-;;;-Ó>{str.PadLeft(WallPos - 16)}");
                }
            }
            if (Up)
            {
                

                if (WallPos < 17)
                {
                    Console.WriteLine("       >>-;;;-Ó>");
                    Console.WriteLine($@"          ///");

                }
                else if (Position >= GapPos && Position <= GapPos + GapSize)
                {
                    Console.WriteLine($"       >>-;;;-Ó>{gap.PadLeft(WallPos - 16)}");
                    Console.WriteLine($@"          ///{gap.PadLeft(WallPos - 13)}");

                }
                else
                {
                    Console.WriteLine($@"       >>-;;;-Ó>{str.PadLeft(WallPos - 16)}");
                    Console.WriteLine($@"          ///{ str.PadLeft(WallPos - 13)}");
                }

            }
        }





    }
}
