using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollGame
{
    
    public class Guess
    {
        private readonly GuessValidator _guessValidator = new();
        private int _number;
        public int Number
        {
            get { return _number;  }

            set 
            {
                _number = value;
            }
        }
    }
}
