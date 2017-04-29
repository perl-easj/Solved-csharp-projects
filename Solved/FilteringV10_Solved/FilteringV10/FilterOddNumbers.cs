namespace FilteringV10
{
    class FilterOddNumbers : IFilterCondition
    {
        public bool Condition(int value)
        {
            return ((value % 2) != 0);
        }
    }
}
