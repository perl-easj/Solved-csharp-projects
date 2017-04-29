namespace WTF
{
    public class MysticNumbers
    {
        #region Methods
        public int ThreeNumbers(int a, int b, int c)
        {
            int result;

            if (b > a)
            {
                result = b;
                if (c > b)
                {
                    result = c;
                }
            }
            else
            {
                result = a;
                if (c > a)
                {
                    result = c;
                }
            }

            return result;
        }

        public int TwoNumbers(int a, int b)
        {
            int result;

            if (b > a)
            {
                result = b;
            }
            else
            {
                result = a;
            }

            return result;
        }

        public int FourNumbers(int a, int b, int c, int d)
        {
            return TwoNumbers(TwoNumbers(a,b),TwoNumbers(c,d));
        } 
        #endregion
    }
}