public class Pilha
{
	private Node top;
	private int counter;
	//Construtor
	public Pilha()
	{
		counter = 0;
		top = null;
	}
	public void Push(int valor)
	{
		Node novo = new Node(valor);
		novo.next = top;
		top = novo;
		counter++;
	}
	public int Pop()
	{
		if (Empty())
			return -1;

		Node aux = top;
		top = top.next;

		counter--;
		return aux.data;
	}
	public int Count()
	{
		return counter;
	}
	public bool Empty()
	{
		return top == null;
	}
	public void Clear()
	{
		while (!Empty())
		{
			Pop();
		}
	}
	public int Peek()	//Top
	{
		if (Empty())
			return -1;

		return top.data;
	}
}

