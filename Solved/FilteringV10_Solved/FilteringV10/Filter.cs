using System;
using System.Collections.Generic;

namespace FilteringV10
{
    public static class Filter
    {
        public static List<int> FilterValues(List<int> values, IFilterCondition filterCondition)
        {
            List<int> filteredValues = new List<int>();

            foreach (var value in values)
            {
                if (filterCondition.Condition(value))
                {
                    filteredValues.Add(value);
                }
            }

            return filteredValues;
        }

        public static List<int> MultipleFilterValues(List<int> values, List<IFilterCondition> filterConditions)
        {
            List<int> filteredValues = values;

            foreach (IFilterCondition filterCondition in filterConditions)
            {
                filteredValues = FilterValues(filteredValues, filterCondition);
            }

            return filteredValues;
        }

        public static List<int> FilterUsingFunctionArgument(List<int> values, Func<int, bool> conditionFunc)
        {
            List<int> filteredValues = new List<int>();

            foreach (var value in values)
            {
                if (conditionFunc(value))
                {
                    filteredValues.Add(value);
                }
            }

            return filteredValues;
        }
    }
}