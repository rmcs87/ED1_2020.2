﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Teste de Fila");
        Fila fila = new Fila();

        fila.Insert(new Pessoa("Ricardo", 32));
        fila.Insert(new Pessoa("Maria", 55));
        fila.Insert(new Pessoa("João", 19));

        Console.WriteLine(fila.Count());

        Pessoa p = fila.Remove();
        Console.WriteLine($"Atender: Nome:{p.nome}");

        Console.WriteLine(fila.Count());

        Pessoa p2 = fila.Remove();
        Console.WriteLine($"Atender: Nome:{p2.nome}");

        Pessoa p3 = fila.Remove();
        Console.WriteLine($"Atender: Nome:{p3.nome}");

    }
}

