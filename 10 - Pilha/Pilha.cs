public class Pilha
{
	private Node top;
	//Construtor
	public Pilha()
	{
		top = null;
	}
	public void Push(int valor)
	{
		Node novo = new Node(valor);
		novo.next = top;
		top = novo;
	}
	public int Pop()
	{
		if (Empty())
			return -1;

		Node aux = top;
		top = top.next;
		return aux.data;
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
	public int Count()
	{
		//retornar quantos elementos temos na pilha
	}
}

