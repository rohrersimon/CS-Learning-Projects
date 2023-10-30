using System;
using System.ComponentModel;
using System.Globalization;

public class Course3
{
    public static void CodeProject3()
    {
        string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
        string printable;
        string currentString;

        foreach (string myString in myStrings)
        {
            currentString = myString;
            int index = currentString.IndexOf(".");

            if (index > 0)
            {
                while (index > 0)
                {
                    printable = currentString.Remove(index);
                    Console.WriteLine(printable);
                    
                    currentString = currentString.Substring(index + 1);
                    currentString = currentString.TrimStart();
                    index = currentString.IndexOf(".");
                }
                Console.WriteLine(currentString);
            }
            else
            {
                Console.WriteLine(currentString);
            }
        }
    }
    public static void CodeProject2()
    {
        string? readResult;
        string trimmedResult;
        bool validEntry = false;

        Console.WriteLine("Enter your role name (Administrator, Manager, or User):");

        do
        {
            readResult = Console.ReadLine();
            
            if (readResult == null)
            {
                Console.WriteLine("User input: Null exception.");
            }
            else
            {
                trimmedResult = readResult.Trim().ToLower();
                readResult = readResult.Trim();

                if (trimmedResult == "administrator" || trimmedResult == "manager" || trimmedResult == "user")
                {
                    Console.WriteLine($"Your input value ({readResult}) has been accepted.");
                    validEntry = true;
                }
                else
                {
                    Console.WriteLine($"The role name that you entered, \"{readResult}\" is not valid. Enter your role name (Administrator, Manager, or User)");
                }
            }

        } while (validEntry == false);
    }

    public static void CodeProject1()
    {
        string? readResult;
        bool validEntry = false;
        int numericValue = 0;

        Console.WriteLine("Enter an integer value between 5 and 10:");

        do
        {
            readResult = Console.ReadLine();
            validEntry = int.TryParse(readResult, out numericValue);

            if (validEntry)
            {
                if (numericValue >= 5 && numericValue <= 10)
                {
                    Console.WriteLine($"Your input value ({numericValue}) has been accepted.");
                }
                else
                {
                    Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.");
                    validEntry = false;
                }
            }
            else
            {
                Console.WriteLine("Sorry, you entered an invalid number, please try again.");
            }
        
        } while (validEntry == false);
    }

    public static void Module5b()
    {
        int heroHealth = 10;
        int monsterHealth = 10;
        bool turn = true; //ture > heroe's turn, false > monster's turn
        Random attack = new Random();

        do
        {
            int hit = attack.Next(1, 11);

            if (turn)
            {
                monsterHealth -= hit;
                turn = false;
                Console.WriteLine($"Hero hits Monster for {hit}.\nHero health = {heroHealth}\nMonster health = {monsterHealth}\n");
            }
            else
            {
                heroHealth -= hit;
                turn = true;
                Console.WriteLine($"Monster hits Hero for {hit}.\nHero health = {heroHealth}\nMonster health = {monsterHealth}\n");
            }   

        } while (heroHealth > 0 && monsterHealth > 0);
            
        Console.WriteLine(heroHealth > monsterHealth ? "Hero wins!" : "Monster wins!");
    }


    public static void Module5()
    {
        Random random = new Random();
        int current = random.Next(1, 11);

        do
        {
            current = random.Next(1, 11);

            if (current >= 8) continue;

            Console.WriteLine(current);
        } while (current != 7);


        while (current >= 3)
        {
            Console.WriteLine(current);
            current = random.Next(1, 11);
        }
        Console.WriteLine($"Last number: {current}");
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