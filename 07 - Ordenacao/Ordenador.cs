﻿using System;
using System.Collections.Generic;
using System.Text;


public class Ordenador
{
    public void Bubblesort(int[] vetor)
    {
        for (int j = 0; j < vetor.Length; j++)
        {
            for (int i = 0; i < vetor.Length - 1; i++)
            {
                if (vetor[i] > vetor[i + 1])
                {
                    int aux = vetor[i];
                    vetor[i] = vetor[i + 1];
                    vetor[i + 1] = aux;
                }
            }
        }
    }
    public void PrintVetor(int[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine($"V[{i}] = {vetor[i]}");
        }
    }
}

