using System;
//using System.Globalization;

public class Course4
{
    public static void Module5()
    {
        Console.WriteLine("test bestanden");
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