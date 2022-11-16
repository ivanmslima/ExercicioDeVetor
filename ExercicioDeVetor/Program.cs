using System;
using System.Globalization;

namespace curso
{
    class Progam
    {
        static void Main(string[] args)
        {

            int N;
            int[] vet;
            Console.Write("Primeiro digite a quantidade de números que vai digitar, em seguida o programa irá separar os números negativos: ");


            N = int.Parse(Console.ReadLine());
            vet = new int[N];

            string[] s = Console.ReadLine().Split(' ');
            for (int i= 0; i < N; i++)
            {
                vet[i] = int.Parse(s[i]);
            }

            for (int i=0; i < N; i++)
            {
                if (vet[i] < 0)
                {
                    Console.WriteLine(vet[i]);
                }
            }


            Console.ReadLine();
        }
    }
}