using System;
using System.Collections.Generic;
using System.Text;

public class Node
{
    public int data;
    public Node next;

    public Node()
    {
        data = -1;
        next = null;
    }
    public Node(int valor)
    {
        data = valor;
        next = null;
    }
}

