﻿using System;
using System.Collections.Generic;
using System.Text;


public class Fila
{
    public Node filaInicio;
    public Node filaFim;
    public int contador = 0;
    public Fila()
    {
        filaInicio = null;
        filaFim = null;
    }
    public void Insert(Pessoa pessoa)
    {
        Node novo = new Node(pessoa);
        if (IsEmpty())
        {
            filaInicio = novo;
            filaFim = novo;
        }
        else
        {
            filaFim.next = novo;
            filaFim = novo;
        }
        contador++;
    }
    public Pessoa Remove()
    {
        Pessoa p = null;
        if (filaInicio == filaFim)
        {//Fila com um elemento
            p = filaInicio.data;
            filaInicio = null;
            filaFim = null;
            contador--;
        }
        else if (!IsEmpty())
        {//Caso normal (varios elementos)
            p = filaInicio.data;
            filaInicio = filaInicio.next;
            contador--;
        }        
        return p;
    }
    public bool IsEmpty()
    {
        return filaInicio == null;
    }
    public void Clear()
    {
        while (!IsEmpty())
        {
            Remove();
        }
    }
    public int Count()
    {
        return contador;
    }
}

