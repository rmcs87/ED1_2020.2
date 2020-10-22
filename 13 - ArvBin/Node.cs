using System;

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
    public void PrintPreOrdem()
    {
        Console.Write("<");
        Console.Write(data);
        if (SAE != null)
            SAE.PrintPreOrdem();
        else
            Console.Write("<>");

        if (SAD != null)
            SAD.PrintPreOrdem();
        else
            Console.Write("<>");

        Console.Write(">");
    }

    public void PrintIrOrdem()
    {
        Console.Write("<");        
        if (SAE != null)
            SAE.PrintIrOrdem();
        else
            Console.Write("<>");

        Console.Write(data);

        if (SAD != null)
            SAD.PrintIrOrdem();
        else
            Console.Write("<>");

        Console.Write(">");
    }

    public void PrintPosOrdem()
    {
        Console.Write("<");
        if (SAE != null)
            SAE.PrintPosOrdem();
        else
            Console.Write("<>");        

        if (SAD != null)
            SAD.PrintPosOrdem();
        else
            Console.Write("<>");

        Console.Write(data);

        Console.Write(">");
    }

    public bool Pertence(int x)
    {         
        if (data == x)
            return true;

        if (SAE != null && SAE.Pertence(x))
            return true;

        if (SAD != null && SAD.Pertence(x))
            return true;

        return false;
    }
}
