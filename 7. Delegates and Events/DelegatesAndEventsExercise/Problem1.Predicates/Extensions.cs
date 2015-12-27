using System;
using System.Collections.Generic;

namespace Problem1.Predicates
{
    public static class Extensions
    {
        public static T FirstOrD<T>(this IEnumerable<T> collection, Predicate<T> condition)
        {
            foreach (var item in collection)
            {
                if (condition(item))
                {
                    return item;
                }
            }

            return default(T);
        }
    }
}
