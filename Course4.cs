using System;

public class Course4
{
    public static void Module3()
    {

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