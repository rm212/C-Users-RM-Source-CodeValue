using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backgammon
{
    class MovesSetter
    {

        public bool AvailablePosition(Board deployment,int targetPosition ,bool turn)
        {
            // Does the target column available?
            // Available: empty column / same collor / up to one from the other collor
            
            return (false);
        }

        public bool AvailableMoves(Board deployment, bool turn)
        {
            // Is there any pawns in position 0?
                // Does there AvailablePosition in positions 1-6?

            // Is there any pawns in position 1-18?
                // Is there any AvailablePosition for one of the pawns in positions 2-24?

            // Does all pawns in position 19-25?
                // Is there any AvailablePosition for one of the pawns in positions 20-25?

            return (false);
        }

        public bool LegalMove(Board deployment, int targetPosition, bool turn)
        {



            return (false);
        }

        public Board UpdateMove(Board deployment, int targetPosition, bool turn)
        {
            Board NewDeployment = new Board();


            return NewDeployment;
        }


    }
}
