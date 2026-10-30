using System;

class Program
{
    static void Main(string[] args)
    {
        /// type the name of the user
        Console.Write("What is your first name? ");
        string name = Console.ReadLine();
        /// type the last name of the user
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        /// print the name and last name of the user
        Console.WriteLine($"Your name is {lastName}, {name} {lastName}.");
    }
}
