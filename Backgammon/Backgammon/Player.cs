using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backgammon
{
    class Player
    {
        public int[] BackgammonPawns = new int[15] { 1, 1, 12, 12, 12, 12, 12, 17, 17, 17, 17, 17, 20, 20, 20 };

        // Constructor for the first setup:
        public void InitializeBorad(Char playerAorB)
        {
            if (playerAorB == 'B')
            {
                for (int i = 0; i<15;i++)
                {
                    BackgammonPawns[i] = 25 - BackgammonPawns[i];
                }

                //foreach (int i in BackgammonPawns) { BackgammonPawns[i] = 25 - BackgammonPawns[i]; }
            }
        }



        public void SetPawnsPosition(int pawnNumber,int newPosition)
        {
            BackgammonPawns[pawnNumber] = newPosition;
        }

        public int GetPawnsPosition(int pawnNumber)
        {
            return (BackgammonPawns[pawnNumber]);
        }



        /*
                private class BackgammonPawn1
                {
                    int PionPosition;           // Penalty Position = 0 ;   Field Position: 1 to 24       ; Out = 25

        //            char PionColor;             // B / W / n
        //            int PionMirrorPosition;     // Penalty Position = 0 ;   Field Position: 25-(1 to 24)  ; Out = 25
                }

                private BackgammonPawn1[] BackgammonPions = new BackgammonPawn1[15];


                // Constructor for the first setup:
                public void InitializeBorad1(Char playerAorB)
                {
                    int mirrorPositionForPlayerB = (playerAorB == 'B') ?1:1;
                  //  BackgammonPions[0] = 1;

                }
        */
    }
}
