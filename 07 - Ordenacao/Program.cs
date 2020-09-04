using System;
using System.Diagnostics;
class Program
{
    static void Main(string[] args)
    {
        Stopwatch sw = new Stopwatch();
        Random random = new Random();

        int[] vetor1 = new int[100000];        
        for (int i = 0; i < vetor1.Length; i++)
        {
            vetor1[i] = random.Next();
        }
        int[] vetor2 = new int[100000];
        vetor1.CopyTo(vetor2,0);
        int[] vetor3 = new int[100000];
        vetor1.CopyTo(vetor3, 0);
        int[] vetor4 = new int[100000];
        vetor1.CopyTo(vetor4, 0);

        Ordenador order = new Ordenador();

        sw.Start();
        order.SelectionSort(vetor1);
        sw.Stop();
        Console.WriteLine($"Selection Sort = {sw.Elapsed.ToString()}");

        sw.Start();
        order.Bubblesort(vetor2);
        sw.Stop();
        Console.WriteLine($"Bubble Sort = {sw.Elapsed.ToString()}");

        sw.Start();
        order.BubblesortV2(vetor2);
        sw.Stop();
        Console.WriteLine($"Bubble Sortv2 = {sw.Elapsed.ToString()}");

        sw.Start();
        order.InstionSort(vetor2);
        sw.Stop();
        Console.WriteLine($"Insertion Sort = {sw.Elapsed.ToString()}");
    }
}
