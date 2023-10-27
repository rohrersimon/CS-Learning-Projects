using System;

public class Course3
{
    public static void Module4()
    {
        Console.WriteLine("test bestanden");
    }
    public static void Module3()
    {
        int employeeLevel = 100;
        string employeeName = "John Smith";

        string title = "";

        switch (employeeLevel)
        {
            case 100:
            case 200:
                title = "Senior Associate";
                break;
            case 300:
                title = "Manager";
                break;
            case 400:
                title = "Senior Manager";
                break;
            default:
                title = "Associate";
                break;
        }

        Console.WriteLine($"{employeeName}, {title}");
    }
    public static void Module2()
    {
        int[] numbers = { 4, 8, 15, 16, 23, 42 };
        int total = 0;

        foreach (int number in numbers)
        {
            total += number;

            if (number == 42)
                Console.WriteLine("Set contains 42");
        }

        Console.WriteLine($"Total: {total}");

    }
    public static void Module1()
    {
        string permission = "Manager|Admin";
        int level = 56;

        if (permission.Contains("Admin") && level > 55)
            Console.WriteLine("Welcome, Super Admin user.");
        else if (permission.Contains("Admin") && level <= 55)
            Console.WriteLine("Welcome, Admin user.");
        else if (permission.Contains("Manager") && level >= 20)
            Console.WriteLine("Contact an Admin for access.");
        else if (permission.Contains("Manager") && level < 20)
            Console.WriteLine("You do not have sufficient privileges.");
        else if (!permission.Contains("Admin") || !permission.Contains("Manager"))
            Console.WriteLine("You do not have sufficient privileges.");
        
    }
}