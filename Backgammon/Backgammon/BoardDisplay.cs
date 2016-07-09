using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backgammon
{
    class BoardDisplay
    {
        // Initialize the board game for display

        private string[] gameBoard = new string[17];
        public void InitializeGameBoard()
        {
            for (int i = 0; i < boardDefault.Length; i++)
            { gameBoard[i] = string.Copy(boardDefault[i]); }
            //{ gameBoard[i] = boardDefault[i]; }
        }

        public void UpdateBoard(Board board)
        {
            this.InitializeGameBoard();
            for (int i = 1; i <= 24; i++)
            {
                if (board.GetColumnPawnStatus(i) > 1)
                {
                    string valueForColumnI = (board.GetColumnPawnStatus(i) < 10) ? Convert.ToString(board.GetColumnPawnStatus(i) + " ") : Convert.ToString(board.GetColumnPawnStatus(i));
                    int positionToReplace = ((i >= 7) && (i <= 12)) ? (5 + (12 - i) * 5) :
                        ((i >= 1) && (i <= 6)) ? (5 + (12 - i) * 5 + 3) :
                        ((i >= 13) && (i <= 18)) ? (5 + (i - 13) * 5) :
                        (5 + (i - 13) * 5 + 3);

                    // Update number of pawns in each column (if there is / are any)
                    if (i <= 12)
                    {
                        gameBoard[3] = gameBoard[3].Remove(positionToReplace, 2);
                        gameBoard[3] = gameBoard[3].Insert(positionToReplace, valueForColumnI);

                        gameBoard[4] = gameBoard[4].Remove(positionToReplace, 1);
                        gameBoard[4] = gameBoard[4].Insert(positionToReplace, Convert.ToString(board.GetColumnCollorStatus(i)));
                    }
                    else
                    {
                        gameBoard[13] = gameBoard[13].Remove(positionToReplace, 2);
                        gameBoard[13] = gameBoard[13].Insert(positionToReplace, valueForColumnI);

                        gameBoard[12] = gameBoard[12].Remove(positionToReplace, 1);
                        gameBoard[12] = gameBoard[12].Insert(positionToReplace, Convert.ToString(board.GetColumnCollorStatus(i)));
                    }

                    // Update collor of pawn in the column (if there is / are any)

                }
            }
        }

        public void DisplayBoard()
        {
            foreach (string line in gameBoard)
            {
                Console.WriteLine(line);
            }
        }

        //Clean Board and Clean Dice
        //(17 Lines x 69 Columns)
        private string[] boardDefault = new string[17]
        {
            "____________________________________________________________________",
            "|H||C12||C11||C10||C 9||C 8||C 7||H||C 6||C 5||C 4||C 3||C 2||C 1||H|",
            "|H|| H || H || H || H || H || H ||H|| H || H || H || H || H || H ||H|        ---------",
            "|H||   ||   ||   ||   ||   ||   ||H||   ||   ||   ||   ||   ||   ||H|       |         |",
            "|H||   ||   ||   ||   ||   ||   ||H||   ||   ||   ||   ||   ||   ||H|       |         |",
            "|H||___||___||___||___||___||___||H||___||___||___||___||___||___||H|       |         |",
            "|H|                              |H|                              |H|        ---------",
            "|H|                              |H|                              |H|",
            "|H|------------------------------|H|------------------------------|H|",
            "|H|                              |H|                              |H|",
            "|H| ___  ___  ___  ___  ___  ___ |H| ___  ___  ___  ___  ___  ___ |H|        ---------",
            "|H||   ||   ||   ||   ||   ||   ||H||   ||   ||   ||   ||   ||   ||H|       |         |",
            "|H||   ||   ||   ||   ||   ||   ||H||   ||   ||   ||   ||   ||   ||H|       |         |",
            "|H||   ||   ||   ||   ||   ||   ||H||   ||   ||   ||   ||   ||   ||H|       |         |",
            "|H|| H || H || H || H || H || H ||H|| H || H || H || H || H || H ||H|        ---------",
            "|H||C13||C14||C15||C16||C17||C18||H||C19||C20||C21||C22||C23||C24||H|",
            "--------------------------------------------------------------------",
        };

    }
}
