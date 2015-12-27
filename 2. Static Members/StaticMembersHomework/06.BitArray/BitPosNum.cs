using System;

namespace _06.BitArray
{
    class BitPosNum
    {
        static void Main()
        {
            BitArray bits= new BitArray(30);

            bits[999] = 1;
            Console.WriteLine(bits.ToString());
        }
    }
}
