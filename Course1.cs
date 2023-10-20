using System;

public class Course1
{
    public static void ExerciseForeach()
    {
        int[] inventory = { 200, 450, 700, 175, 250 };
        int sum = 0;
        int bin = 0;
        foreach (int items in inventory)
        {
            sum += items;
            bin++;
            Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
        }
        Console.WriteLine($"We have {sum} items in inventory.");
    }

    public static void ExerciseFraudID()
    {
        string[] orders = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

        foreach (string orderID in orders)
        {
            char firstletter = orderID.First();
            if(firstletter == 'B')
            {
                Console.WriteLine($"{orderID} is at risk of fraud.");
            }
        }
    }

    public static void ExerciseSpacing()
    {
        /*
            Reverse a string and count the number of times a particular character appears
        */

        string str = "The quick brown fox jumps over the lazy dog.";

        char[] charMessage = str.ToCharArray();
        Array.Reverse(charMessage);

        int x = 0;
        foreach (char i in charMessage)
        {
            if (i == 'o')
            {
                x++;
            }
        }

        string new_message = new String(charMessage);

        Console.WriteLine(new_message);
        Console.WriteLine($"'o' appears {x} times.");
    }
}