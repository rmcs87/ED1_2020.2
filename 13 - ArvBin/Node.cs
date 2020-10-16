public class Node
{
    public int data;
    public Node SAE;
    public Node SAD;
    public Node(int value)
    {
        data = value;
        SAE = null;
        SAD = null;
    }
    public Node(int value, Node esq, Node dir)
    {
        data = value;
        SAE = esq;
        SAD = dir;
    }
}
