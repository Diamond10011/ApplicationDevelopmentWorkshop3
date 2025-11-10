using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter a number N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        int sum1 = 0;

        for (int i = 1; i <= N; i++)
        {
            sum1 += i;
        }

        Console.WriteLine("Sum from 1 to " + N + " = " + sum1);
        
        
        Console.WriteLine("\nNumbers from 1 to 20 (skip multiples of 4, stop at 15):");
        int j = 1;

        while (j <= 20)
        {
            if (j == 15)
                break; // stop the loop

            if (j % 4 == 0)
            {
                j++;
                continue; // skip multiples of 4
            }

            Console.WriteLine(j);
            j++;
        }

        
        Console.WriteLine("\nSum of array elements:");
        int[] numbers = {1, 5, 8, 3, 10, 2 };
        int sum2 = 0;

        foreach (int num in numbers)
        {
            sum2 += num;
        }

        Console.WriteLine("Sum of array = " + sum2);
    }
}