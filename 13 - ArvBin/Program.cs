using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Árvore Binária!");
        int op = 0;
        do
        {
            Console.WriteLine("O Que deseja fazer? \n0 - Sair, \n 1- add \n 2- Print");
            op =  Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                default:
                    Console.WriteLine("opção invalida, tente novamente.");
                    break;
            }
        } while (op != 0);
    }
}

