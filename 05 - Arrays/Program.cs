using System;

namespace _05___Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[10];
            int[] numbers = new int[] { 0, 5, 10, 15, 20, 25 };
            Console.WriteLine($"Numero no indice 1 = {numbers[1]}");
            numbers[1] = 99;
            Console.WriteLine($"Novo numero no indice 1 = {numbers[1]}");
            int tam = numbers.Length;
            Console.WriteLine($"O tamanho do vetor é =: {tam}");
            Console.WriteLine($"O tamanho do vetor Names é =: {names.Length}");
            Console.WriteLine($"O tipo do vetor Number é =: {numbers.GetType().ToString()}");
            Console.WriteLine($"O tipo do vetor names é =: {names.GetType().ToString()}");
        }
    }
}
