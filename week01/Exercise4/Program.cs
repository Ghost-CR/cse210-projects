using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Diagnostics.Tracing;

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
            sum += number;
            number = int.Parse(Console.ReadLine());
        }
        
        if (count > 0)
        {
            // Calculate the average and find the largest and smallest positive values.
            double avg = (double)sum / count;
            int largest = FindLargestNum(numbers);
            bool foundPositive = false;
            int smallest = FindSmallestPositiveNum(numbers, out foundPositive);
            

            // Display the calculated values.
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {avg}");
            Console.WriteLine($"The largest number is: {largest}");
            if (foundPositive)
            {
                Console.WriteLine($"The smallest positive number is: {smallest}");
            }
            else
            {
                Console.WriteLine("No positive numbers were entered");
            }
            Console.WriteLine("The sorted list is:");

            // Sort the numbers in ascending order and print each one.
            numbers.Sort();
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }

    // Return the largest number in the list.
    static int FindLargestNum(List<int> numbers)
        {
            int largest = numbers[0];
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
    static int FindSmallestPositiveNum(List<int> numbers, out bool foundPositive)
    {
        int smallest = 0;
        foundPositive = false;
        foreach (int n in numbers)
        {
            if ((!foundPositive || n < smallest) && n > 0)
            {
                smallest = n;
                foundPositive = true;
            }
        }
        return smallest;
    }
}