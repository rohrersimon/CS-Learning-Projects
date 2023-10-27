using System;

public class Course3
{
        public static void Module2()
    {
        Console.WriteLine("test bestanden");
    }
    public static void Module1()
    {
        string pangram = "The quick brown fox jumps over the lazy dog.";
        Console.WriteLine(!pangram.Contains("fox"));
        Console.WriteLine(!pangram.Contains("cow"));
    }
}