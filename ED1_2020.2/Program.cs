﻿using System;
using System.Diagnostics;
class Program
{
    static void Main(string[] args)
    {
        int[] nums = new int[100000];
        Stopwatch sw = new Stopwatch();
        sw.Start();
        BuildArray(nums);
        DisplayArray(nums);
        sw.Stop();
        Console.WriteLine($"RunTime = {sw.Elapsed.ToString()}");
    }
    public static void BuildArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i;
        }
    }
    public static void DisplayArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}
