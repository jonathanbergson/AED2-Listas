using System;

namespace AED2_01_Ex04
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
            Console.Write("Insira um valor para n: ");
            int n = Int32.Parse(Console.ReadLine());

            Console.Write("Insira um valor para k: ");
            int k = Int32.Parse(Console.ReadLine());
            int count = CountKRec(n, k);

            Console.WriteLine($"O número {k} se repete {count} vezes no número {n}");
            Console.WriteLine();
        }

        static int CountKRec(int n, int k, int index = 0)
        {
            string ns = n.ToString();

            if (index >= ns.Length) {
                return 0;
            } else {
                int ni = Int32.Parse(ns[index].ToString());
                int count = (ni == k) ? 1 : 0;
                return count + CountKRec(n, k, index + 1);
            }
        }
    }
}
