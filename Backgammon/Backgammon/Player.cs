using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backgammon
{
    class Player
    {


        private class BackgammonPion
        {
            char PionColor;             // B / W / n
            int PionPosition;           // Penalty Position = 0 ;   Field Position: 1 to 24       ; Out = 25
            int PionMirrorPosition;     // Penalty Position = 0 ;   Field Position: 25-(1 to 24)  ; Out = 25
        }

        //BackgammonPion[] BackgammonPions = new BackgammonPion();


    }
}
