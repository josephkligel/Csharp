
namespace DiceRollGame
{
    public class Dice
    {
        public int _number { get; private set; }

        public Dice()
        {
            _number = roll();
        }

        private int roll()
        {
            Random randInt = new Random();
            return randInt.Next(1, 7);
        }

    }
}
