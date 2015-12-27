namespace Exam.Core.Exceptions
{
    public class UnsufficiantHealthException : MilitantGroupException
    {
        public UnsufficiantHealthException(string msg)
            : base(msg)
        {
        }
    }
}
