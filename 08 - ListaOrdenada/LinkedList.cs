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

	/// <summary>
	/// Add at first position.
	/// </summary>
	public void Add(int valor)
	{
		var newNode = new Node(valor);
		newNode.next = head;
		head = newNode;		
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
