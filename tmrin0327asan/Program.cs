
using System;
using System.IO;
using System.Collections.Generic;

namespace tmrin0327asan
{
    internal class Program
    {
        static void Main(string[] args)
        {

        List<int> num = Enumerable.Range(1, 99).ToList();
        num.ForEach(e=>Console.Write(e + ","));
        Console.Write($"100.");
        Console.WriteLine();
        int sum = num.Where(n => n % 2 == 1).Sum();
        System.Console.WriteLine($"sum of odd number is:{sum}"); 

    }
}
}