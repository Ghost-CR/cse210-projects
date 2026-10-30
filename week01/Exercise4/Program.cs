using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user to enter numbers and use 0 to stop.
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers;
        numbers = new List<int>();
        Console.WriteLine("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        int sum = 0;
        int count = 0;

        // Keep reading numbers until the user enters 0.
        while (number != 0)
        {
            count++;
            numbers.Add(number);
            Console.WriteLine("Enter number: ");
            number = int.Parse(Console.ReadLine());
            sum += number;
        }

        // Calculate the average and find the largest and smallest positive values.
        int avg = sum / count;
        int largest = FindLargestNum(numbers);
        int smallest = FindSmallestPositiveNum(numbers);

        // Display the calculated values.
        Console.WriteLine($"The sum is: {number}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
        Console.WriteLine("The sorted list is:");

        // Sort the numbers in ascending order and print each one.
        numbers.Sort();
        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }
        
    }

    // Return the largest number in the list.
    static int FindLargestNum(List<int> numbers)
        {
            int largest = 0;
            foreach (int n in numbers)
            {
                if (n > largest)
                {
                    largest = n;
                }
            }
            return largest;
        }

    // Return the smallest positive number in the list.
    static int FindSmallestPositiveNum(List<int> numbers)
    {
        int smallest = int.MaxValue;
        foreach (int n in numbers)
        {
            if (n > 0 && n < smallest)
            {
                smallest = n;
            }
        }
        return smallest;
    }
}