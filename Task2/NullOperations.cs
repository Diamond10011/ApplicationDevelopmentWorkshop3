using System;

namespace Task2;

public class NullOperations
{
    public void PerformNullCheckers()
    {
        String? username = null;

        // Null-coalescing operator
        String nullCheck = username == null ? "Username is not available" : $"{username}";

        String nullCoalescing = username ?? "Username is not available";

        username ??= "DefaultUser";

        Console.WriteLine($"Null Check: {nullCheck}");
        Console.WriteLine($"Null Coalescing: {nullCoalescing}");
        Console.WriteLine($"Username after null-coalescing assignment: {username}");


    }
}
