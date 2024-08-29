using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Example example = new Example();

        // Tuple Usage
        var tupleData = example.GetData();
        Console.WriteLine($"Tuple - Number: {tupleData.Item1}, Text: {tupleData.Item2}");

        // Named Tuples
        var namedTupleData = example.GetNamedData();
        Console.WriteLine($"Named Tuple - Number: {namedTupleData.Number}, Text: {namedTupleData.Text}");

        // Custom Class
        var customData = example.GetCustomData();
        Console.WriteLine($"Custom Class - Number: {customData.Number}, Text: {customData.Text}");

        // Out Parameters
        example.GetDataWithOut(out int number, out string text);
        Console.WriteLine($"Out Parameters - Number: {number}, Text: {text}");

        // ValueTuple
        var valueTupleData = example.GetValueTupleData();
        Console.WriteLine($"ValueTuple - Number: {valueTupleData.Number}, Text: {valueTupleData.Text}");
    }
}

public class Example
{
    public (int, string) GetData()
    {
        return (42, "Hello, World!");
    }

    public (int Number, string Text) GetNamedData()
    {
        return (Number: 42, Text: "Hello, World!");
    }

    public Data GetCustomData()
    {
        return new Data { Number = 42, Text = "Hello, World!" };
    }

    public void GetDataWithOut(out int number, out string text)
    {
        number = 42;
        text = "Hello, World!";
    }

    public (int Number, string Text) GetValueTupleData()
    {
        return (Number: 42, Text: "Hello, World!");
    }
}

public class Data
{
    public int Number { get; set; }
    public string Text { get; set; }
}
