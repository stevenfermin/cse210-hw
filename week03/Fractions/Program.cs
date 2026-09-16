using System;

class Program
{
    static void Main(string[] args)
    {  
        Console.Clear();
        Console.WriteLine("Hello World! This is the Fractions Project.");
        

        Fractions fractions1 = new Fractions();
        Console.WriteLine(fractions1.GetFractioningString());
        Console.WriteLine(fractions1.GetDecimalValue());
        Fractions fraction2 = new Fractions(5);
        Console.WriteLine(fraction2.GetFractioningString());
        Console.WriteLine(fraction2.GetDecimalValue());
        Fractions fraction3 = new Fractions(3,4);
        Console.WriteLine(fraction3.GetFractioningString());
        Console.WriteLine(fraction3.GetDecimalValue());
        Fractions fraction4 = new Fractions(1,3);
        Console.WriteLine(fraction4.GetFractioningString());
        Console.WriteLine(fraction4.GetDecimalValue());

    }
}