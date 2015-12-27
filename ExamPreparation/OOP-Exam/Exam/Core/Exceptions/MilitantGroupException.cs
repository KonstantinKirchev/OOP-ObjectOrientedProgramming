namespace Exam.Core.Exceptions
{
    using System;

    public class MilitantGroupException : Exception
    {
        public MilitantGroupException(string msg)
            : base(msg)
        {
        }
    }
}
