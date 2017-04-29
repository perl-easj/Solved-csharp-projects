namespace DiceGame
{
    public class DiceCup
    {
        private Die _die1;
        private Die _die2;

        public DiceCup()
        {
            // VERY IMPORTANT! When we have instance fields of a class type,
            // we MUST remember to create actual objects in the constructor,
            // that the instance fields can then point to.
            _die1 = new Die();
            _die2 = new Die();
        }

        // Implement a property TotalValue: the sum of the values of the dice in the cup
        public int TotalValue
        {
            get { return (_die1.Value + _die2.Value); }
        }


        // Implement a method Shake: all the dice in the cup should be rolled
        public void Shake()
        {
            _die1.Roll();
            _die2.Roll();
        }
    }
}