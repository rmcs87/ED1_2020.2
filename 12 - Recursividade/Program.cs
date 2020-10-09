using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Recursividade");
        Console.WriteLine(fat(5));
    }

    public static int fat(int n)
    {
        if(n > 1)
        {
            return n * fat(n-1);
        }
        else
        {
            return 1;
        }
    }
}
