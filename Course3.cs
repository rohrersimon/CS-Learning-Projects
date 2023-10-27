using System;

public class Course3
{
    public static void Module3()
    {
        Console.WriteLine("test bestanden");
    }
    public static void Module2()
    {
        Console.WriteLine("test bestanden");
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