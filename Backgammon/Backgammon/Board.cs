using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backgammon
{
    class Board
    {
        private int[] PawnsInColumn = new int[28] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private char[] PawnsCollorInColumn = new char[28] {'W', 'n', 'n', 'n', 'n', 'n', 'n', 'n', 'n', 'n', 'n', 'n', 'n', 'n', 'n', 'n',
                'n', 'n', 'n', 'n', 'n', 'n', 'n', 'n', 'n', 'W', 'B', 'B'};

        public int GetColumnPawnStatus(int column) { return (PawnsInColumn[column]); }
        public char GetColumnCollorStatus(int column)  { return (PawnsCollorInColumn[column]); }

        public void UpdateBoardPicture(Player playerA, Player playerB)
        {
            // Clean Board
            for (int i = 0; i < 28; i++)
            {
                PawnsInColumn[i] = 0;
                PawnsCollorInColumn[i] = 'n';
            }
            // Build Board
            for (int i = 0; i < 15; i++)
            {
                PawnsInColumn[playerA.GetPawnsPosition(i)] += 1;
                PawnsCollorInColumn[playerA.GetPawnsPosition(i)] = 'W';

                if ((playerB.GetPawnsPosition(i) != 0) && (playerB.GetPawnsPosition(i) != 0))
                {
                    PawnsInColumn[playerB.GetPawnsPosition(i)] += 1;
                    PawnsCollorInColumn[playerB.GetPawnsPosition(i)] = 'B';
                }
                else
                {
                    if (playerB.GetPawnsPosition(i) == 0) { PawnsInColumn[27] += 1; }
                    else { PawnsInColumn[28] += 1; }
                }
            }


        }


        public void TemporaryDisplayPlay(Player first)
        {
            for (int i = 0;  i < 15; i++)
            {
                Console.WriteLine(first.GetPawnsPosition(i));
            }

        }

        //PlayerA.InitializeBorad('B');

        // Severity	Code	Description	Project	File	Line	Column	Suppression State
        // Error CS1579	foreach statement cannot operate on variables of type 'Backgammon.Player' because 'Backgammon.Player' does not contain a public definition for 'GetEnumerator'	Backgammon C:\Users\RM\Source\Repos\C-Users-RM-Source-CodeValue\Backgammon\Backgammon\Board.cs	17	31	Active




    }
}
