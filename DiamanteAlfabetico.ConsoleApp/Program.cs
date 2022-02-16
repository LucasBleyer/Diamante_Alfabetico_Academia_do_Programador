using System;

namespace DiamanteAlfabetico.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaração de variaveis
            char letra;
            string str_alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYS";
            int espacos_fora, espacos_dentro = 0;

            //entrada de dados
            Console.Write("Digite uma letra qualquer do alfabeto: ");
            letra = Convert.ToChar(Console.ReadLine().ToUpper());

            //converter a string do alfabeto em um vetor em char {'A', 'B', 'C'...}
            char[] alfabeto = str_alfabeto.ToCharArray();
            
        }
    }
}