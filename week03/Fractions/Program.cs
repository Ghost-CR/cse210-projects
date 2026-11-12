using System;

class Program
{
    static void Main(string[] args)
    {
        FractionHolder fraction1 = new FractionHolder();
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        FractionHolder fraction2 = new FractionHolder(5);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());    

        FractionHolder fraction34 = new FractionHolder(3, 4);
        Console.WriteLine(fraction34.GetFractionString());
        Console.WriteLine(fraction34.GetDecimalValue());

        FractionHolder fraction13 = new FractionHolder();
        fraction13.SetTop(1);
        fraction13.SetBottom(3);
        Console.WriteLine(fraction13.GetFractionString());
        Console.WriteLine(fraction13.GetDecimalValue());
        
    }
}