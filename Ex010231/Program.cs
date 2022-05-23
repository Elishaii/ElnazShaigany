using System;


namespace session1
{
    class Program
    {
        static void Main(string[] args)
        {
        
            
        for (int i=1 ; i<6 ;i++)
        {
         for   (int s=1; s<=6-i; s++)
         {
             Console.Write($" ");         
         }  
         for(int j=1; j<=i ; j++)
         {
             Console.Write( j );             
         }
         for (int k=(i-1); k>=1 ;k--)
         {Console.Write( k);
         }
        Console.WriteLine();
    
    
        }
    }
}
}