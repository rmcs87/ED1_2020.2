using System;

class Program
{
    static void Main(string[] args)
    {
        string s;
        do
        {
            s = Console.ReadLine();
            if(s!= null)
            {
                TemCopa( Convert.ToInt32(s) );
            }
        } while (s != null);
    }
    private static void TemCopa(int v)
    {
        string msg = v > 0 ? "vai ter duas!": "vai ter copa!";
        Console.WriteLine(msg);
    }
}
