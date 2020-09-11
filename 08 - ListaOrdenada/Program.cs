using System;

class Program
{
    static void Main(string[] args)
    {
        LinkedList lista = new LinkedList();
        lista.AddOrdered(10);
        lista.AddOrdered(1);
        lista.AddOrdered(5);
        lista.AddOrdered(14);
        lista.AddOrdered(99999);

        lista.Print();

        Console.WriteLine();
        Console.WriteLine();
    }
}

