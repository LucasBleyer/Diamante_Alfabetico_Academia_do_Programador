using System;

namespace DiamanteAlfabetico.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaração de variaveis
            string str_alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int espacos_fora, espacos_dentro = 0;

            //entrada de dados
            Console.Write("Digite uma letra qualquer do alfabeto: ");
            char letra = Convert.ToChar(Console.ReadLine().ToUpper());

            //converter a string do alfabeto em um vetor em char {'A', 'B', 'C'...}
            char[] alfabeto = str_alfabeto.ToCharArray();

            //achar o meio do diamante
            int meio = 0;
            for (int i = 0; i < alfabeto.Length; i++)
            {
                if (alfabeto[i] == letra)
                {
                    meio = i;
                }
            }

            //achar a parte superior do diamante
            espacos_fora = meio;//setar os espacos de fora para começar no mesmo tanto que a metade
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

            //achar a parte inferior do diamante
            espacos_fora = 0;//setar os espacos de fora igual zero pra adicionar novos espacos externos
            for (int i = 1; i <= meio; i++)
            {
                Console.WriteLine(" ");
                espacos_fora++;

                if (i == meio)
                {
                    espacos_dentro = 1;
                }
                else if (i != 0 && i != meio)
                {
                    espacos_dentro -=2;
                }

                for (int j = 0; j < espacos_fora; j++)
                {
                    Console.Write(" ");
                }

                Console.Write(alfabeto[meio - i]);

                for (int k = 0; k < espacos_dentro; k++)
                {
                    Console.Write(" ");
                }

                if (i != meio)
                {
                    Console.Write(alfabeto[meio - i]);
                }
                Console.WriteLine();
            }
        }
    }
}