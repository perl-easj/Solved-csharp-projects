namespace FilteringV10
{
    public class FilterDivisibleBy9 : IFilterCondition
    {
        public bool Condition(int value)
        {
            return ((value % 9) == 0);
        }
    }
}