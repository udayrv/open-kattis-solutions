using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MainClass
{
    public static void Main (string[] args)
    {
        string N = Console.ReadLine();
        int x = Int32.Parse(N);
        int[] digits = new int[x];
        for (int i = 0; i < x; i++)
        {
            string number = Console.ReadLine();
            digits[i] = number.Length;
        }
        for (int j = 0; j < x; j++)
        {
            Console.WriteLine(digits[j]);
        }
    }
}