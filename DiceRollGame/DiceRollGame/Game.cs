using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollGame
{
    public class Game
    {
        public bool IsActive = true;

        public bool DidIWin(int diceRoll, int guessInt)
        {
            if(diceRoll == guessInt)
            {
                return true;
            }
            return false;
        }
    }
}
