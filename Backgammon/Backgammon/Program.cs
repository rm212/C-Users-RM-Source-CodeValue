using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backgammon
{
    class Program
    {
        static void Main(string[] args)
        {
            Board Controller = new Board();

            Player PlayerA = new Player();
            Player PlayerB = new Player();
            PlayerB.InitializeBorad('B');
            Dice[] Dices = new Dice[2];
            Controller.UpdateBoardPicture(PlayerA, PlayerB);

            BoardDisplay Board = new BoardDisplay();
            Board.InitializeGameBoard();
            Board.DisplayBoard();
            Board.UpdateBoard(Controller);
            Board.DisplayBoard();
            

            Console.ReadLine();

        }
    }
}
