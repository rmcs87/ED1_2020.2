﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Árvore Binária!");

        Node raiz;
        raiz = new Node(5, 
                    new Node(4),
                    new Node(6,
                            null,
                            new Node(7)
                    )
                );
        raiz.Print();
        Console.WriteLine();
        Console.WriteLine(raiz.Pertence(7));
        Console.WriteLine(raiz.Pertence(100));
    }
}

