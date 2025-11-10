public class Program
{
    public static void Main(string[] args)
    {
        
        Console.Write("Enter a number: ");
        try
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered: " + number);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number format");
        }
        finally
        {
            Console.WriteLine("Program Executed");
        }

        try
        {
            
        Console.Write("\nEnter a password: ");
        string password = Console.ReadLine();

        try
        {
            if (password.Length < 6)
            {
                throw new Exception("Password must be at least 6 characters.");
            }

            Console.WriteLine("Password satisfied the requirement");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        }
        catch (Exception)
        {
            Console.WriteLine("An error occurred while processing the password.");
        }
    }
}