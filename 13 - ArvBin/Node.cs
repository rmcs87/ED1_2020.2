﻿using System;

public class Node
{
    public int data;
    public Node SAE;
    public Node SAD;
    //Folha
    public Node(int value)
    {
        data = value;
        SAE = null;
        SAD = null;
    }
    //Nó Intermediario
    public Node(int value, Node esq, Node dir)
    {
        data = value;
        SAE = esq;
        SAD = dir;
    }
    public void Print()
    {
        Console.Write("<");
        Console.Write(data);
        if (SAE != null)
            SAE.Print();
        else
            Console.Write("<>");

        if (SAD != null)
            SAD.Print();
        else
            Console.Write("<>");

        Console.Write(">");
    }
}
