using System;
using System.Linq;

namespace CustomStackExample
{
    public class CustomStack<T> 
        where T : IComparable<T>
    {
        private const int DefaultCapacity = 16;

        private T[] elements;
        private int currentIndex;

        public CustomStack(int capacity = DefaultCapacity)
        {
            this.elements = new T[capacity];
            this.currentIndex = 0;
        }

        public int Count
        {
            get { return this.currentIndex; }
        }

        public bool IsEmpty
        {
            get { return currentIndex == 0; }
        }

        public void Push(T element)
        {
            if (this.currentIndex >= this.elements.Length)
            {
                this.Resize();
            }
            this.elements[this.currentIndex] = element;
            this.currentIndex++;
        } 

        public T Pop()
        {
            if (this.currentIndex == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            var currentElement = this.elements[this.currentIndex - 1];
            elements[currentIndex - 1] = default(T);
            currentIndex--;
            return currentElement;

        }

        public void Clear()
        {
            for (int i = 0; i < this.currentIndex; i++)
            {
                this.elements[i] = default(T);
            }
            this.currentIndex = 0;
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < this.currentIndex; i++)
            {
                if (elements[i].CompareTo(element) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public T Min()
        {
            var minElement = this.elements[0];

            for (int i = 0; i < this.currentIndex; i++)
            {
                var currentElement = elements[i];
                if (currentElement.CompareTo(minElement) < 0)
                {
                    minElement = currentElement;
                }
            }
            return minElement;
        }

        public T Max()
        {
            var maxElement = this.elements[0];

            for (int i = 0; i < this.currentIndex; i++)
            {
                var currentElement = elements[i];
                if (currentElement.CompareTo(maxElement) > 0)
                {
                    maxElement = currentElement;
                }
            }
            return maxElement;
        }

        private void Resize()
        {
            var newElements = new T[this.elements.Length * 2];

            for (int i = 0; i < this.elements.Length; i++)
            {
                newElements[i] = this.elements[i];
            }

            this.elements = newElements;
        }

        public override string ToString()
        {
            return string.Join(", ", elements.Take(this.currentIndex));
        }
    }
}
