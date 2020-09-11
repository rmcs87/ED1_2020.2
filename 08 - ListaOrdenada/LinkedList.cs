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
	public Node Find(int valor)
	{
		Node aux = head;
		while ( (aux != null) && (aux.data != valor))
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
}
