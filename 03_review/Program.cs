using System;
using System.Collections.Generic;

namespace _03_review
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> matilha = new List<Animal>();
            matilha.Add(new Cat());
            matilha.Add(new Cat());
            matilha.Add(new Cat());
            matilha.Add(new Dog());
            matilha.Add(new Dog());

            foreach (var animal in matilha)
            {
                animal.MakeSound();
            }
        }
    }
}
