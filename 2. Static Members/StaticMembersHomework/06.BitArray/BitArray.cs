using System;


namespace _06.BitArray
{
    class BitArray
    {
        private int num;

       public BitArray(int num)
        {
            this.num = num;
        }
        public int GetBitAtPos(int pos)
        {
            if(pos < 0 || pos > 100000)
            {
                throw new ArgumentOutOfRangeException("position should be int the range [1...100000]");

            }
            return (num >> pos) & 1;
        }
        public void SetBitAtPos(int pos, int bit)
        {
            if (pos < 0 || pos > 100000)
            {
                throw new ArgumentOutOfRangeException("position should be int the range [1...100000]");

            }
            if (bit != 0 && bit != 1)
            {
                throw new ArgumentOutOfRangeException("bit should be 0 or 1");

            }
            this.num &= ~(1 << pos);
            this.num |= bit << pos;
        }
        public int this[int pos]
        {
            get { return this.GetBitAtPos(pos); }
            set { this.SetBitAtPos(pos, value); }
        }

        public override string ToString()
        {
            return num.ToString();
        }

    }
}
