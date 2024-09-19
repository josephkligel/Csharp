using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollGame
{
    public class GuessValidator
    {

        public GuessValidator() { }

        public bool IsValid(string guessString)
        { 
            if(guessString.All(char.IsDigit))
            {
                int guessInt = Convert.ToInt32(guessString);
                return guessInt >= 1
                && guessInt <= 6;
            }
            return false;     
        }
    }
}
