namespace Problem2.Func
{
    using System;
    using System.Collections.Generic;

    public static class Extensions
    {
        public static List<T> TakeWhile<T>(this IEnumerable<T> collection, Func<T, bool> conditionFunc)
        {
            var result = new List<T>();

            foreach (var element in collection)
            {

                if (conditionFunc(element))
                {
                    result.Add(element);
                }
                else
                {
                    break;
                }
            }

            return result;
        }
    }
}
