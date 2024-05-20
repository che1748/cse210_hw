using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction a = new Fraction();
        Fraction b = new Fraction(6);
        Fraction c = new Fraction(6,7);

        Console.WriteLine(c.GetTop());
        Console.WriteLine(c.GetBottom());
        c.SetTop(3);
        c.SetBottom(4);
        Console.WriteLine(c.GetTop());
        Console.WriteLine(c.GetBottom());

        Console.WriteLine(c.GetFractionString());
        Console.WriteLine(c.GetDecimalValue());      
        

        
    }
}