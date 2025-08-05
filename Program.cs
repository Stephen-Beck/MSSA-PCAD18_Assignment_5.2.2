/*
Write a program in C# Sharp to print the first n natural number using recursion.

    Test Data :
        How many numbers to print : 10
        Expected Output :
            1 2 3 4 5 6 7 8 9 10
*/

namespace Assignment_5._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nums = 0;
            while(true)
            {
                Console.Write("How many numbers would you like to print? ");
                if (!int.TryParse(Console.ReadLine(), out nums) || nums < 1)
                    Console.Write("Invalid number. ");
                else break;
            }
            PrintNumber(nums);
        }

        static void PrintNumber(int n)
        {
            if (n > 1)
                PrintNumber(n - 1);

            Console.Write(n + " ");
        }
    }
}
