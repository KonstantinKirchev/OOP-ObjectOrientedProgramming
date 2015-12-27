namespace Problem1.CustomExtensionMethods
{
    using System;
    using System.Collections.Generic;

    public static class Extensions
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            var result = new List<T>();

            foreach (var element in collection)
            {
                if (!predicate(element))
                {
                    result.Add(element);
                }
            }

            return result;
        }

        public static TSelector Max<TSource, TSelector>
            (this IEnumerable<TSource> collection, Func<TSource, TSelector> conditionFunc)
            where TSelector : IComparable<TSelector>
        {
            var max = default(TSelector);

            foreach (var element in collection)
            {
                TSelector result = conditionFunc(element);
                if (result.CompareTo(max) > 0)
                {
                    max = result;
                }         
            }

            return max;
        }
    }
}
