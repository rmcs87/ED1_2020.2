using System;
using System.Collections.Generic;
using System.Text;


public class Ordenador
{
    static int partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];

        // index of smaller element 
        int i = (low - 1);
        for (int j = low; j < high; j++)
        {
            // If current element is smaller than the pivot 
            if (arr[j] < pivot)
            {
                i++;
                // swap arr[i] and arr[j] 
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        // swap arr[i+1] and arr[high] (or pivot) 
        int temp1 = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp1;

        return i + 1;
    }

    public static void quickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = partition(arr, low, high);

            quickSort(arr, low, pi - 1);
            quickSort(arr, pi + 1, high);
        }
    }


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
    public void BubblesortV2(int[] vetor)
    {
        for (int j = 0; j < vetor.Length; j++)
        {
            for (int i = 0; i < vetor.Length - 1 - j; i++)
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
    public void SelectionSort(int[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            int menorIndice = i;
            for (int j = i +1; j < vetor.Length; j ++)
            {
                if(vetor[j] < vetor[menorIndice])
                {
                    menorIndice = j;
                }
            }
            int aux = vetor[i];
            vetor[i] = vetor[menorIndice];
            vetor[menorIndice] = aux;
        }
    }
    public void InstionSort(int [] vetor)
    {
        for (int i = 1; i < vetor.Length; i++)
        {
            int aux = vetor[i];
            int indice = i;
            while (indice > 0 
                && aux < vetor[indice - 1])
            {
                vetor[indice] = vetor[indice - 1];
                indice--;
            }
            vetor[indice] = aux;
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

