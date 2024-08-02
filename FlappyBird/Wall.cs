using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBird
{
    public class Wall
    {
        
        public Wall(ref int PositionX, int WheresGapUP, bool Over)
        {
            GapPos = WheresGapUP;
            if(!Over)
            PositionX -= 2;
        }
        public int GapPos;
        public int GapSize = 8;
        string str = "|";
        string gap = ",";

        
        public void DrawWallUP(ref int PositionX, int BirdPos)
        {
           

            for (int ch = 0; ch < BirdPos; ch++)
            {
                if (ch > GapPos && ch < GapPos + GapSize)
                { 
                Console.WriteLine(gap.PadLeft(PositionX+2));
                }
                else Console.WriteLine(str.PadLeft(PositionX+2));
            }
            
        }
        public void DrawWallDOWN(int BirdPos, int height, int PositionX, int score)
        {
            for (int ch = 0; ch <= height - BirdPos; ch++)
            {
                if (ch + BirdPos+2 > GapPos && ch + BirdPos+2 < GapPos + GapSize)
                {
                    Console.WriteLine(gap.PadLeft(PositionX+2));
                }
               else Console.WriteLine(str.PadLeft(PositionX + 2));
            }
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.WriteLine($"SCORE: {score-1}");
        }
        
    }
}
