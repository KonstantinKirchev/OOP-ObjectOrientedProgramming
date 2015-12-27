using System;

namespace Problem4.GenericListVersion
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class |
        AttributeTargets.Enum | AttributeTargets.Interface |
        AttributeTargets.Method, AllowMultiple = true)]
    public class VersionAttribute : Attribute
    {
        private double v;

        public VersionAttribute(double v)
        {
            this.v = v;
        }
    }
}
