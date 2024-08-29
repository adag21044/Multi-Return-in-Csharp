# Tuple and Data Handling in C#

This project demonstrates different ways to handle and return data in C# using tuples, named tuples, custom classes, out parameters, and ValueTuples.

## Features

1. **Tuple Usage**: Returning and using tuples in methods.
2. **Named Tuples**: Using named tuples for better readability.
3. **Custom Classes**: Using custom classes to encapsulate data.
4. **Out Parameters**: Returning multiple values using out parameters.
5. **ValueTuples**: Using ValueTuples for lightweight data storage.

## Code Overview

### Program.cs

The `Program` class contains the `Main` method, which demonstrates various ways to handle data:

- **Tuple Usage**: Shows how to use basic tuples.
- **Named Tuples**: Demonstrates the use of named tuples for improved code clarity.
- **Custom Class**: Uses a custom class to encapsulate data.
- **Out Parameters**: Shows how to return multiple values using out parameters.
- **ValueTuple**: Demonstrates the use of ValueTuple for data storage.

### Example.cs

The `Example` class contains methods that return data in various formats:

- `GetData()`: Returns a tuple with an integer and a string.
- `GetNamedData()`: Returns a named tuple with an integer and a string.
- `GetCustomData()`: Returns a custom `Data` class instance.
- `GetDataWithOut(out int number, out string text)`: Uses out parameters to return multiple values.
- `GetValueTupleData()`: Returns a ValueTuple with named properties.

### Data.cs

The `Data` class is a simple custom class with two properties:

- `Number`: An integer value.
- `Text`: A string value.

## Example Output

- **Tuple** - Number: 42, Text: Hello, World!
- **Named Tuple** - Number: 42, Text: Hello, World!
- **Custom Class** - Number: 42, Text: Hello, World!
- **Out Parameters** - Number: 42, Text: Hello, World!
- **ValueTuple** - Number: 42, Text: Hello, World!

