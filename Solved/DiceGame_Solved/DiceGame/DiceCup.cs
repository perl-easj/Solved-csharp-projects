namespace DiceGame
{
    /// <summary>
    /// This class represents a dice cup containing two dice.
    /// </summary>
    public class DiceCup
    {
        #region Instance fields
        private Die _die1;
        private Die _die2;
        #endregion

        #region Constructor
        public DiceCup()
        {
            // VERY IMPORTANT! When we have instance fields of a class type,
            // we MUST remember to create actual objects in the constructor,
            // that the instance fields can then point to.
            _die1 = new Die();
            _die2 = new Die();
        }
        #endregion

        #region Properties
        public int TotalValue
        {
            get { return (_die1.FaceValue + _die2.FaceValue); }
        }
        #endregion

        #region Methods
        public void Shake()
        {
            _die1.Roll();
            _die2.Roll();
        } 
        #endregion
    }
}