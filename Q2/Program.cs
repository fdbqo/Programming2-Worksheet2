/*
 * Name : Finn De Bie   
 * Date : 30 - 1 - 23
 * Desc : odd numbers between 2 values added
 */

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter amount of numbers to enter : ");
            int value = int.Parse(Console.ReadLine());

            int[] array = new int[value];
            // array defined 

            Console.WriteLine();

            for (int i = 0; i < value; i++)
            {
                Console.Write($"Enter integer {i+1} : ");
                array[i] = int.Parse(Console.ReadLine());
                
            }
            // user input

            bool result = IsSorted(array);
            // gets result

            Console.WriteLine($"\nArray is sorted? : {result}");
        } 

        static bool IsSorted(int[] array)
        {
            
            for (int i = 0; i <= array.Length; i++)
            {
                if (array[i] < array[i + 1])
                {
                    return true;
                }
                else return false;
                // checks if array is sorted
                
               
            }

            return true;
        }
    }

}