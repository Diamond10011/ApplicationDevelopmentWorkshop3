using System;

namespace Task1;

public class Operators
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
    public static int Subtract(int a, int b)
    {
        return a - b;
    }
    public static int Multiply(int a, int b)
    {
        return a * b;
    }
    public static int Divide(int a, int b)
    {
        return a / b;
    }

    public static String OddEvenFinder(int number)
    {
        String result = number % 2 == 0 ? "Even Number" : "Odd Number";
        return result;
    }
}
