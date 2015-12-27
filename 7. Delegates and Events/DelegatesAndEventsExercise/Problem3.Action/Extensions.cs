namespace Problem3.Action
{
    using System;
    using System.Collections.Generic;

    public static class Extensions
    {
        public static void MyForEach<T>(this IEnumerable<T> collection, Action<T> action)
        {
            foreach (var element in collection)
            {
                action(element);
            }
        }
    }
}
