using System;

namespace DiamanteAlfabetico.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaração de variaveis
            char letra;
            string str_alfabeto = "abcdefghijklmnopqrstuvwxyz";
            int espacos_fora, espacos_dentro = 0, metade = 0;

            //entrada de dados
            Console.Write("Digite uma letra qualquer do alfabeto: ");
            letra = Convert.ToChar(Console.ReadLine());

            //converter a string do alfabeto em um vetor em char
            char[] alfabeto = str_alfabeto.ToCharArray();

            //achar o meio do diamante
            for (int i = 0; i < alfabeto.Length; i++)
            {
                if (alfabeto[i] == letra)
                {
                    metade = i;
                }
            }

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

            espacos_fora = 0;
            for (int i = 1; i <= metade; i++)
            {

                espacos_fora = espacos_fora + 1;
                if (i == metade)
                {
                    espacos_dentro = 1;
                }
                if (i != 0 && i != metade)
                {
                    espacos_dentro = espacos_dentro - 2;
                }

                for (int j = 0; j < espacos_fora; j++)
                {
                    Console.Write(" ");
                }

                Console.Write(alfabeto[metade - i]);

                for (int k = 0; k < espacos_dentro; k++)
                {
                    Console.Write(" ");
                }

                if (i != metade)
                {
                    Console.Write(alfabeto[metade - i]);
                }
                Console.WriteLine();
            }
        }
    }
}