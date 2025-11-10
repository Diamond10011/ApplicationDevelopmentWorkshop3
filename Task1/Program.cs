namespace Task1;
public class Program
{
    public static void Main(string[] args)
    {
        Operators ops = new Operators();
        int sum = Operators.Add(5, 3);
        int difference = Operators.Subtract(5, 3);
        int product = Operators.Multiply(5, 3);
        int quotient = Operators.Divide(10, 2);
        string oddEven = Operators.OddEvenFinder(5);

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Difference: {difference}");
        Console.WriteLine($"Product: {product}");
        Console.WriteLine($"Quotient: {quotient}");
        Console.WriteLine($"Odd or Even: {oddEven}");
    }
}