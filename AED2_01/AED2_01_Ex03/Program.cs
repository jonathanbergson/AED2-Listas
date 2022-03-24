using System;

namespace AED2_01_Ex03
{
    class Program
    {
        public static void Main(string[] args)
        {
            float[] vetRef = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            float[] vetInverted = InvertRec(vetRef, 0, vetRef.Length -1);

            Console.WriteLine();
            for (int i = 0; i < vetInverted.Length; i++)
            {
                Console.WriteLine(vetInverted[i]);
            }
            Console.WriteLine();
        }

        static float[] InvertRec(float[] vet, int head, int tail)
        {
            if (head >= tail) {
                return vet;
            } else {
                float headValue = vet[head];
                float tailValue = vet[tail];

                vet[head] = tailValue;
                vet[tail] = headValue;

                return InvertRec(vet, head + 1, tail - 1);
            }
        }
    }
}
