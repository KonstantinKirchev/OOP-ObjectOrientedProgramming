using System;

namespace Problem4.StudentClass
{
    public class PropertyChangedEventArgs : EventArgs
    {
        public PropertyChangedEventArgs(string oldValue, string newValue, string propertyName)
        {
            this.OldValue = oldValue;
            this.NewValue = newValue;
            this.PropertyName = propertyName;
        }

        public string PropertyName { get; set; }

        public string OldValue { get; set; }

        public string NewValue { get; set; }
    }
}
