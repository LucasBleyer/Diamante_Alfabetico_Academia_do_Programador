using System;

namespace DiamanteAlfabetico.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str_alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int espacos_fora, espacos_dentro = 0;

            Console.Write("Digite uma letra qualquer do alfabeto: ");
            char letra = Convert.ToChar(Console.ReadLine().ToUpper());

            char[] alfabeto = str_alfabeto.ToCharArray();

            int meio = 0;
            for (int i = 0; i < alfabeto.Length; i++)
            {
                if (alfabeto[i] == letra)
                {
                    meio = i;
                }
            }

            espacos_fora = meio;
            for (int i = 0; i <= meio; i++)
            {
                Console.WriteLine(" ");
                for (int j = 0; j < espacos_fora; j++)
                {
                    Console.Write(" ");
                }

                Console.Write(alfabeto[i]);

                for (int k = 0; k < espacos_dentro; k++)
                {
                    Console.Write(" ");
                }

                if (i != 0)
                {
                    Console.Write(alfabeto[i]);
                }

                Console.WriteLine();
                espacos_fora--;

                if (i == 0)
                {
                    espacos_dentro = 1;
                }
                else if (i != 0 && i != meio)
                {
                    espacos_dentro = espacos_dentro + 2;
                }
            }

            espacos_fora = 1;
            espacos_dentro = meio - 1;
            for (int i = (meio - 1); i >= 0; i--)
            {
                Console.WriteLine(" ");
                for (int j = 0; j < espacos_fora; j++)
                {
                    Console.Write(" ");
                }
                Console.Write(alfabeto[i]);

                for (int k = espacos_dentro; k >= 0; k--)
                {
                    Console.Write(" ");
                }

                if (i != 0)
                {
                    Console.Write(alfabeto[i]);
                }
                Console.WriteLine();

                espacos_fora++;
                espacos_dentro -= 2;
            }
        }
    }
}