/*
 * Name : Finn De Bie   
 * Date : 30 - 1 - 23
 * Desc : age checker
 */

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age : ");
            int userAge = int.Parse(Console.ReadLine());
            // user input

            Console.WriteLine("");

            bool result = AgeCheck(userAge);
            // result brought to main 

            Console.WriteLine($"Can access site? : {result}");
            // display
        }

        static bool AgeCheck(int userAge)
        {
            if (userAge >= 18 && userAge <= 21)
            {
                return true;
            }
            else return false;
            // checks if condition is true 
        }
    }
}