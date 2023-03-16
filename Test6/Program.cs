using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[10];

        Console.WriteLine("Enter 10 numbers:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Number {0}: ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter a number to check if it exists: ");
        int numberToCheck = int.Parse(Console.ReadLine());

        bool found = CheckIfExists(numbers, numberToCheck);

        if (found)
        {
            Console.WriteLine("{0} exists in the list.", numberToCheck);
        }
        else
        {
            Console.WriteLine("{0} does not exist in the list.", numberToCheck);
        }
    }

    static bool CheckIfExists(int[] array, int number)
    {
        foreach (int element in array)
        {
            if (element == number)
            {
                return true;
            }
        }

        return false;
    }
}