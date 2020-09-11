using System;
using System.Collections.Generic;
using System.Text;


public class LinkedList
{
    public Node head;

    public LinkedList()
    {
        head = null;
    }
    public void Add(int valor)
    {
        var newNode = new Node(valor);
        newNode.next = head;
        head = newNode;
    }
    public void AddOrdered(int valor)
    {
        var newNode = new Node(valor);
        Node aux = head;
        //Trata lista vazia e inserir o menor valor da lista
        if (head == null || valor < head.data)
        {
            newNode.next = head;
            head = newNode;
            return;
        }
        while ((aux.next != null)&&(valor > aux.next.data))
        {
            aux = aux.next;
        }        
        newNode.next = aux.next;
        aux.next = newNode;
    }
    public Node Find(int valor)
    {
        Node aux = head;
        while ((aux != null) && (aux.data != valor))
        {
            aux = aux.next;
        }
        return aux;
    }
    public bool IsEmpty()
    {
        return (head == null);
    }
    public void Print()
    {
        Console.Write("[HEAD]");
        var aux = head;

        while (aux != null)
        {
            Console.Write($"-> [{aux.data}]");
            aux = aux.next;
        }
        Console.Write("-> [NULL]");
    }
    public void Remove(int valor)
    {
        if (this.IsEmpty())
        {
            return;
        }
        Node aux = head;
        Node ant = null;
        while ((aux != null) && (aux.data != valor))
        {
            ant = aux;
            aux = aux.next;
        }
        if (ant == null) //remover primeiro NÓ
        {
            head = aux.next;
        }
        else //Qualquer outro caso
        {
            ant.next = aux.next;
        }
        //no é removido da MEM. by GC
    }
}
