using System;

namespace AED2_01_Ex05
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
            Console.Write("Escolha um número inteiro: ");
            int n = Int32.Parse(Console.ReadLine());

            GetOddNumbersRec(n);
            Console.WriteLine();
        }

        static void GetOddNumbersRec(int n, int from = 1)
        {
            if (from <= n) {
                if (from % 2 == 0) Console.WriteLine(from);
                GetOddNumbersRec(n, from + 1);
            }
        }
    }
}
