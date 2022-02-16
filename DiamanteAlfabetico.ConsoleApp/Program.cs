using System;

namespace DiamanteAlfabetico.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letra;
            string str_alfabeto = "abcdefghijklmnopqrstuvwxyz";
            int espacos_fora, espacos_dentro = 0, metade = 0;

            Console.Write("Digite uma letra qualquer do alfabeto: ");
            letra = Convert.ToChar(Console.ReadLine());

            char[] alfabeto = str_alfabeto.ToCharArray();

            espacos_fora = metade;
            for (int i = 0; i <= metade; i++)
            {
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

                espacos_fora = espacos_fora - 1;
                if (i == 0)
                {
                    espacos_dentro = 1;
                }
                if (i != 0 && i != metade)
                {
                    espacos_dentro = espacos_dentro + 2;
                }
            }
        }
    }
}