using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Teste de Fila");
        Fila fila = new Fila();

        fila.Insert(new Pessoa("Ricardo", 32));
        fila.Insert(new Pessoa("Maria", 55));
        fila.Insert(new Pessoa("Jorão", 19));

    }
}

