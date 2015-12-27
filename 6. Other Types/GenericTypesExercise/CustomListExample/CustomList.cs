using System;
using System.Linq;

namespace CustomListExample
{
    public class CustomList<T>
        where T : IComparable<T>
    {
        private const int DefaultCapacity = 16;
        private T[] elements;
        private int currentIndex;

        public CustomList(int capacity = DefaultCapacity)
        {
            this.elements = new T[capacity];
            this.currentIndex = 0;
        }

        public int Count()
        {
            return this.currentIndex;
        }

        public bool IsEmpty()
        {
            return this.currentIndex == 0;
        }

        public void Add(T element)
        {
            if (currentIndex >= elements.Length)
            {
                this.Resize();
            }
            this.elements[this.currentIndex] = element;
            this.currentIndex++;
        }

        public int IndexOf(T element)
        {
            for (int i = 0; i < this.currentIndex; i++)
            {
                if (elements[i].Equals(element))
                {
                    return i;
                }
            }

            return -1;
        }

        public void Remove(T element)
        {
            var index = this.IndexOf(element);

            if (index == -1)
            {
                throw new ArgumentException("The specified element was not found.");
            }

            for (int j = index; j < this.currentIndex - 1; j++)
            {
                this.elements[j] = elements[j + 1];
            }

            this.currentIndex--;
            this.elements[this.currentIndex] = default(T);
        }

        public T this[int i]
        {
            get
            {
                if (i < 0 || i >= this.currentIndex)
                {
                    throw new IndexOutOfRangeException($"Index should be in range [0..{this.currentIndex - 1}]");
                }

                return this.elements[i];
            }
            set
            {
                if (i < 0 || i >= this.currentIndex)
                {
                    throw new IndexOutOfRangeException($"Index should be in range [0..{this.currentIndex - 1}]");
                }

                this.elements[i] = value;
            }
        }

        public T Min()
        {
            if (this.currentIndex == 0)
            {
                throw new ArgumentException("The list is empty.");
            }

            var minElement = elements[0];
            for (int i = 0; i < this.currentIndex; i++)
            {
                var currentElement = this.elements[i];
                if (currentElement.CompareTo(minElement) < 0)
                {
                    minElement = currentElement;
                }
            }

            return minElement;
        }

        public T Max()
        {
            if (this.currentIndex == 0)
            {
                throw new ArgumentException("The list is empty.");
            }

            var maxElement = elements[0];
            for (int i = 0; i < this.currentIndex; i++)
            {
                var currentElement = this.elements[i];
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
            return string.Join(" ", elements.Take(this.currentIndex));
        }
    }
}
