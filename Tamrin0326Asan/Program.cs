using System;

namespace tamrin0326 {
    internal class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine($"Enter a base value:");
            int a =Convert.ToInt32( Console.ReadLine());
        Console.WriteLine($"Enter a value of power:");
            int b =Convert.ToInt32( Console.ReadLine());
            int result= power(a,b);
            Console.WriteLine($"Result: {result}");
            
            
        }
    public static int power(int a, int b) {
 
        if (b > 1) {
            return (a*power(a, b-1));
        }
        else{
            return a;
        }
         
    }
    }
}