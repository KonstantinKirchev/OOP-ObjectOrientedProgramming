using System;
using System.Linq;
using Problem4.GenericListVersion;

namespace Problem3.GenericList
{
    [Version(2.11)]
    public class GenericList<T>
        where T : IComparable<T>
    {
        private const int DefaultCapacity = 16;
        private T[] elements;
        private int currentIndex;

        public GenericList(int capacity = DefaultCapacity)
        {
            elements = new T[capacity];
            currentIndex = 0;
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
            if (this.currentIndex >= elements.Length)
            {
                this.Resize();
            }
            this.elements[this.currentIndex] = element;
            this.currentIndex++;
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

        public void Remove(int index)
        {
            if (index < 0 || index > this.currentIndex - 1)
            {
                throw new ArgumentOutOfRangeException($"The index should be in the range [0..{this.currentIndex - 1}]");
            }

            for (int i = 0; i < this.currentIndex; i++)
            {
                if (i == index)
                {
                    for (int j = i; j < this.currentIndex - 1; j++)
                    {
                        this.elements[j] = this.elements[j + 1];
                    }

                    this.currentIndex--;
                    this.elements[this.currentIndex] = default(T);
                }
            }
        }

        public void Insert(T element, int index)
        {
            if (index < 0 || index > this.currentIndex - 1)
            {
                throw new ArgumentOutOfRangeException($"The index should be in the range [0..{this.currentIndex - 1}]");
            }

            for (int i = 0; i < this.currentIndex; i++)
            {
                if (i == index)
                {
                    if (this.currentIndex >= elements.Length)
                    {
                        this.Resize();
                    }

                    var nextElement = elements[i + 1];

                    this.elements[i + 1] = this.elements[i];

                    i += 2;

                    for (int j = i; j <= this.currentIndex; j++)
                    {
                        var prevElement = this.elements[j];
                        this.elements[j] = nextElement;
                        nextElement = prevElement;
                    }

                    this.elements[index] = element;

                    this.currentIndex++;
                }
            }
        }

        public void Clear()
        {
            if (this.currentIndex == 0)
            {
                throw new ArgumentException("The list is already cleared.");
            }

            for (int i = 0; i < this.currentIndex; i++)
            {
                this.elements[i] = default(T);
            }

            this.currentIndex = 0;
        }

        public int IndexOf(T element)
        {
            for (int i = 0; i < this.currentIndex; i++)
            {
                if (this.elements[i].Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < this.currentIndex; i++)
            {
                if (this.elements[i].Equals(element))
                {
                    return true;
                }
            }

            return false;
        }

        public T Min()
        {
            if (this.currentIndex == 0)
            {
                throw new ArgumentException("The list is empty.");
            }

            var minElement = this.elements[0];

            for (int i = 1; i < this.currentIndex; i++)
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

            var maxElement = this.elements[0];

            for (int i = 1; i < this.currentIndex; i++)
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
            return  currentIndex != 0 ? string.Join(", ", this.elements.Take(this.currentIndex)) : "Sorry :( The list is empty. Try again later :)";
        }
    }
}
