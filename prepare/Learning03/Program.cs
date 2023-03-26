using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning03 World!");

        // Practice setting/getting fractions:
        Fraction myFraction1 = new Fraction();
        Console.WriteLine(myFraction1.GetFractionString());

        Fraction myFraction2 = new Fraction(5);
        Console.WriteLine(myFraction2.GetFractionString());

        Fraction myFraction3 = new Fraction();
        myFraction3.SetNumerator(3);
        myFraction3.SetDenominator(4);
        // Fraction myFraction3 = new Fraction(3, 4);
        // Console.WriteLine($"{myFraction1.GetNumerator()}/{myFraction1.GetDenominator()}");
        Console.WriteLine(myFraction3.GetFractionString());
        // Console.WriteLine(myFraction1.GetDecimalValue());

        Fraction myFraction4 = new Fraction(1, 3);
        Console.WriteLine(myFraction4.GetFractionString());

        // More fractions/decimals:
        Fraction myFraction5 = new Fraction();
        Console.WriteLine($"\n{myFraction5.GetNumerator()}/{myFraction5.GetDenominator()}");
        Console.WriteLine(myFraction5.GetFractionString());
        myFraction5.SetNumerator(5);
        Console.WriteLine($"{myFraction5.GetNumerator()}/{myFraction5.GetDenominator()}");
        Console.WriteLine(myFraction5.GetFractionString());
        myFraction5.SetNumerator(3);
        myFraction5.SetDenominator(4);
        Console.WriteLine(myFraction5.GetFractionString());
        Console.WriteLine(myFraction5.GetDecimalValue());
        myFraction5.SetNumerator(1);
        myFraction5.SetDenominator(3);
        Console.WriteLine(myFraction5.GetFractionString());
        Console.WriteLine(myFraction5.GetDecimalValue());
    }
}