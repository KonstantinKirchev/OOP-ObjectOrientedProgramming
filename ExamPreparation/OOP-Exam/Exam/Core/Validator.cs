namespace Exam.Core
{
    using System;

    public static class Validator
    { 
        public static void CheckIfStringIsNullOrEmpty(string text, string message = null)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentNullException(message);
            }
        }

        public static void CheckIfStringLengthIsValid(string text, int max, int min = 1, string message = null)
        {
            if (text.Length < min || max < text.Length)
            {
                throw new ArgumentOutOfRangeException(message);
            }
        }

        public static void CheckIfNumberIsNegative(int value, int min = 1, string message = null)
        {
            if (value < min)
            {
                throw new ArgumentOutOfRangeException(message);
            }
        }
    }
}
