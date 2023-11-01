using System;
//using System.Globalization;

public class Course4
{
    public static void Module9()
    {
        decimal price1 = 67.55m;
        decimal salePrice = 59.99m;
        string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price1 - salePrice), price1);
        yourDiscount += $"A discount of {((price1 - salePrice) / price1):P2}!"; //inserted
        Console.WriteLine(yourDiscount);

        decimal tax = .36785m;
        Console.WriteLine($"Tax rate: {tax:P2}");

        decimal measurement = 123456.78912m;
        Console.WriteLine($"Measurement: {measurement:N4} units");

        decimal measurement2 = 123456.78912m;
        Console.WriteLine($"Measurement: {measurement2:N} units");

        decimal price = 123.45m;
        int discount = 50;
        Console.WriteLine($"Price: {price:C} (Save {discount:C})");

        string first = "Hello";
        string second = "World";
        Console.WriteLine($"{first} {second}!");
        Console.WriteLine($"{second} {first}!");
        Console.WriteLine($"{first} {first} {first}!");

        Console.WriteLine("{1} {0}!", first, second);
        Console.WriteLine("{0} {0} {0}!", first, second);
    }
    public static void Module8()
    {
        string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
        string[] orders = orderStream.Split(',');

        Array.Sort(orders);

        for (int i = 0; i < orders.Length; i++)
        {
            if (orders[i].Length == 4)
            {
                Console.WriteLine(orders[i]);
            }
            else
            {
                Console.WriteLine($"{orders[i]}\t- Error");
            }
        }
    }
    public static void Module7()
    {
        string pangram = "The quick brown fox jumps over the lazy dog";
        string correctOutput = "ehT kciuq nworb xof spmuj revo eht yzal god";
        string output = "";

        string[] words = pangram.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            char[] charArray = words[i].ToCharArray();
            Array.Reverse(charArray);
            words[i] = String.Join("", charArray);
        }

        output = String.Join(" ", words);
        Console.WriteLine(output);
        if (output == correctOutput)
        {
            Console.WriteLine("\nThe output is correct!");
        }
    }
    public static void Module6()
    {
        string value = "abc123";
        char[] valueArray = value.ToCharArray();
        Array.Reverse(valueArray);
        // string result = new string(valueArray);
        string result = String.Join(",", valueArray);
        Console.WriteLine(result);

        string[] items = result.Split(',');
        foreach (string item in items)
        {
            Console.WriteLine(item);
        }
    }
    public static void Module5()
    {
        string[] pallets = { "B14", "A11", "B12", "A13" };

        Console.WriteLine("Sorted...");
        Array.Sort(pallets);
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

        Console.WriteLine("");
        Console.WriteLine("Reversed...");
        Array.Reverse(pallets);
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

        string[] pallets3 = { "B14", "A11", "B12", "A13" };
        Console.WriteLine("");

        Array.Clear(pallets3, 0, 2);
        Console.WriteLine($"Clearing 2 ... count: {pallets3.Length}");
        foreach (var pallet in pallets3)
        {
            Console.WriteLine($"-- {pallet}");
        }

        Console.WriteLine("");
        Array.Resize(ref pallets3, 6);
        Console.WriteLine($"Resizing 6 ... count: {pallets3.Length}");

        pallets3[4] = "C01";
        pallets3[5] = "C02";

        foreach (var pallet in pallets3)
        {
            Console.WriteLine($"-- {pallet}");
        }

    }
    public static void Module4()
    {
        int value1 = 12;
        decimal value2 = 6.2m;
        decimal result1;
        decimal result2;
        float value3 = 4.3f;
        float result3;


        result1 = value1 / value2;
        result1 = Convert.ToInt32(result1);
        // Hint: You need to round the result to nearest integer (don't just truncate)
        Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

        result2 = value2 / (decimal)value3;
        Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

        result3 = value3 / value1;
        //result3 = Convert.ToSingle(result3);
        //result3 = (float)result3;
        Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
    }
    public static void Module3()
    {
        string[] values = { "12.3", "45", "ABC", "11", "DEF" };
        string message = "";
        float total = 0.0f;

        foreach (string value in values)
        {
            float parsedValue = 0.0f;

            if (float.TryParse(value, out parsedValue))
            {
                total += parsedValue;
            }
            else
            {
                message += value;
            }
        }

        Console.WriteLine($"Message: {message}");
        Console.WriteLine($"Total: {total}");
    }
    public static void Module2()
    {
        string value5 = "102";
        int result1 = 0;
        if (int.TryParse(value5, out result1)) //magic happens here with 'out' key word
        {
            Console.WriteLine($"Measurement: {result1}");
        }
        else
        {
            Console.WriteLine("Unable to report the measurement.");
        }
        if (result1 > 0)
            Console.WriteLine($"Measurement (w/ offset): {50 + result1}");

        int value3 = (int)1.5m; // casting truncates
        Console.WriteLine(value3);

        int value4 = Convert.ToInt32(1.5m); // converting rounds up
        Console.WriteLine(value4);

        string value1 = "5";
        string value2 = "7";
        int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
        Console.WriteLine(result);

        string first = "5";
        string second = "7";
        int sum = int.Parse(first) + int.Parse(second);
        Console.WriteLine(sum);

        decimal myDecimal = 1.23456789m;
        float myFloat = (float)myDecimal;
        int myInt = (int)myFloat;

        Console.WriteLine($"Decimal: {myDecimal}");
        Console.WriteLine($"Float  : {myFloat}");
        Console.WriteLine($"Int  : {myInt}");
    }
    public static void Module1()
    {
        Console.WriteLine("Signed integral types:");

        Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
        Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
        Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
        Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

        Console.WriteLine("\n");
        Console.WriteLine("Unsigned integral types:");

        Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
        Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
        Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
        Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

        Console.WriteLine("\n");
        Console.WriteLine("Floating point types:");
        Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
        Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
        Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
    }
}