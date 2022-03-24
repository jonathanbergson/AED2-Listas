using System;

namespace AED2_01_Ex02
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
            Console.Write("Insira um valor inteiro: ");
            int n = Int32.Parse(Console.ReadLine());
            string nInverted = InvertRec(n);

            Console.WriteLine($"O número original é {n}, ele invertido é {nInverted}");
            Console.WriteLine();
        }

        static string InvertRec(int n, int index = 0)
        {
            string ns = n.ToString();

            if (index >= ns.Length) {
                return "";
            } else {
                int lastCharIndex = ns.Length - index - 1;
                return ns[lastCharIndex] + InvertRec(n, index + 1);
            }
        }
    }
}
