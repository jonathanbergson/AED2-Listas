using System;

namespace AED2_01_Ex01
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] values = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sum = SumRec(values);

            Console.WriteLine();
            Console.WriteLine($"A soma do vetor é {sum}");
            Console.WriteLine();
        }

        static int SumRec(int[] n, int index = 0)
        {
            if (index >= n.Length) return 0;
            return n[index] + SumRec(n, index + 1);
        }
    }
}
