using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Backgammon
{
    // One dice. The RunApplication will use 2 dices

    class Dice
    {
        public int RollDice()
        {
            Thread.Sleep(2);
            Random Rolling = new Random();
            return (Convert.ToInt32(Rolling.Next(1, 7)));
        }
    }
}
