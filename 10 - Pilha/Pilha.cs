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
		//remove do topo e retorna o valor
	}
	public bool Empty()
	{
		return top == null;
	}
	public void Clear()
	{
		//Remove todo da Pilha
	}
	public int Count()
	{
		//retornar quantos elementos temos na pilha
	}
}

