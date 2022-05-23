namespace ex010302
{
    class Program
    {
        static void Main()
        {
         int s = 0;  // for sum      
         System.Console.Write($"Enter a number: ");
        string num=Console.ReadLine();
        long Number=Convert.ToInt64(num);
        for (int i=0; i<= Number; i++){
            if(i%2==1){
                s=s+i;
            }
        }
            Console.WriteLine($"Sum of odd number is :  {s}");

        }
    }
}



