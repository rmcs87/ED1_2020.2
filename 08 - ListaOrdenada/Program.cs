using System;

class Program
{
    static void Main(string[] args)
    {
        LinkedList lista = new LinkedList();
        lista.Add(10);
        lista.Add(1);
        lista.Add(5);
        lista.Add(14);
        lista.Add(99999);

        lista.Print();
    }
}

