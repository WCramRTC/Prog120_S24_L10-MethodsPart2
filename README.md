Sure, let's cover these different ways of passing arguments and handling return values in C# through examples. 

### Passing by Value

By default, arguments are passed by value. This means that a copy of the argument's value is passed to the method.

```csharp
using System;

class Program
{
    static void Main()
    {
        int value = 10;
        PassByValue(value);
        Console.WriteLine("After PassByValue: " + value); // Output: 10
    }

    static void PassByValue(int val)
    {
        val = 20;
    }
}
```

### Passing by Reference

Using the `ref` keyword allows you to pass an argument by reference, so changes to the parameter will affect the original argument.

```csharp
using System;

class Program
{
    static void Main()
    {
        int value = 10;
        PassByRef(ref value);
        Console.WriteLine("After PassByRef: " + value); // Output: 20
    }

    static void PassByRef(ref int val)
    {
        val = 20;
    }
}
```

### Using the `out` Keyword

The `out` keyword is similar to `ref`, but it is used to indicate that the method will initialize the parameter before returning. It is typically used to return multiple values from a method.

```csharp
using System;

class Program
{
    static void Main()
    {
        int value;
        PassByOut(out value);
        Console.WriteLine("After PassByOut: " + value); // Output: 30
    }

    static void PassByOut(out int val)
    {
        val = 30; // Must be assigned before the method returns
    }
}
```

### Returning Reference Types

When working with reference types (like arrays or objects), you can modify their contents within a method without needing `ref` or `out`.

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3 };
        ModifyArray(array);
        Console.WriteLine("After ModifyArray: " + string.Join(", ", array)); // Output: 10, 2, 3
    }

    static void ModifyArray(int[] arr)
    {
        arr[0] = 10;
    }
}
```

### Combining Methods

Here's a combined example that demonstrates passing by value, passing by reference using `ref`, using `out`, and modifying a reference type.

```csharp
using System;

class Program
{
    static void Main()
    {
        // Pass by value
        int value = 10;
        PassByValue(value);
        Console.WriteLine("After PassByValue: " + value); // Output: 10

        // Pass by reference
        PassByRef(ref value);
        Console.WriteLine("After PassByRef: " + value); // Output: 20

        // Using out keyword
        int result;
        CalculateSum(5, 15, out result);
        Console.WriteLine("After CalculateSum: " + result); // Output: 20

        // Returning reference types
        int[] array = { 1, 2, 3 };
        ModifyArray(array);
        Console.WriteLine("After ModifyArray: " + string.Join(", ", array)); // Output: 10, 2, 3
    }

    static void PassByValue(int val)
    {
        val = 20;
    }

    static void PassByRef(ref int val)
    {
        val = 20;
    }

    static void CalculateSum(int a, int b, out int sum)
    {
        sum = a + b;
    }

    static void ModifyArray(int[] arr)
    {
        arr[0] = 10;
    }
}
```

### Explanation

1. **Pass by Value**: `PassByValue` changes a local copy of the variable, so the original remains unchanged.
2. **Pass by Reference**: `PassByRef` uses the `ref` keyword to modify the original variable.
3. **Using `out` Keyword**: `CalculateSum` initializes the `out` parameter to return a result.
4. **Returning Reference Types**: `ModifyArray` directly modifies the contents of the array.

These examples should help you understand the different ways of passing parameters and returning values in C#.