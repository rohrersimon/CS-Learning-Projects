using System;
using System.Globalization;

public class Course3
{
    public static void Module8()
    {
        Console.WriteLine("test bestanden");
    }
    public static void Module7()
    {
        Console.WriteLine("test bestanden");
    }
    public static void Module6()
    {
        Console.WriteLine("test bestanden");
    }
    public static void Module5()
    {
        Console.WriteLine("test bestanden");
    }
    public static void Module4()
    {
        string fizz = "Fizz";
        string buzz = "Buzz";
        
        for (int number = 1; number <= 100; number++)
        {
            if (number % 3 == 0 && number % 5 == 0)
                Console.WriteLine($"{number} - {fizz}{buzz}");
            else if (number % 3 ==0)
                Console.WriteLine($"{number} - {fizz}");
            else if (number % 5 ==0)
                Console.WriteLine($"{number} - {buzz}");
            else
                Console.WriteLine(number);
        }
    }
    public static void Module3()
    {
        // SKU = Stock Keeping Unit. 
        // SKU value format: <product #>-<2-letter color code>-<size code>
        string sku = "01-MN-L";

        string[] product = sku.Split('-');

        string type = "";
        string color = "";
        string size = "";

        switch (product[0])
        {
            case "01":
                type = "Sweat shirt";
                break;
            case "02":
                type = "T-Shirt";
                break;
            case "03":
                type = "Sweat pants";
                break;
            default:
                type = "Other";
                break;
        }

        switch (product[1])
        {
            case "BL":
                color = "Black";
                break;
            case "MN":
                color = "Maroon";
                break;
            default:
                color = "White";
                break;
        }

        switch (product[2])
        {
            case "S":
                size = "Small";
                break;
            case "M":
                size = "Medium";
                break;
            case "L":
                size = "Large";
                break;
            default:
                size = "One Size Fits All";
                break;
        }

        Console.WriteLine($"Product: {size} {color} {type}");
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