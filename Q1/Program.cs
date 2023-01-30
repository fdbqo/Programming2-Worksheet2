/*
 * Name : Finn De Bie   
 * Date : 30 - 1 - 23
 * Desc : odd numbers between 2 values added
 */
namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"-- Enter range of integers --");
            Console.Write($"Enter min : ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write($"Enter max : ");
            int n2 = int.Parse(Console.ReadLine());
            // user input
            
            int result = Sum(n1, n2);

            Console.WriteLine($"\nResult : {result}");
        }

        static int Sum(int n1, int n2)
        {
            int total = 0;

            for (int i = n1; i <= n2; i++)
            {
         
                if (i % 2 != 0)
                {
                    total += i;
                }
                // adds the value of odd numbers to the total
            }
            // loops through all the numbers from min to max 

            return total;
        }
    }
}
