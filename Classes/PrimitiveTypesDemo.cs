using System;

namespace CSharpFundamentals.Classes
{
    public class PrimitiveTypesDemo
    {
        public static void ShowPrimitiveTypes()
        {
            Console.WriteLine("\n=== Primitive Types ===");

            // Variable declarations
            byte number = 2; // 0-255
            int count = 10; // -2,147,483,648 to 2,147,483,647
            float totalPrice = 20.95f; // 7-digit precision
            double amount = 99.99; // 15-16 digit precision
            decimal price = 29.99m; // 28-29 significant digits
            char letter = 'A'; // Single character
            bool isActive = true; // true/false
            string firstName = "John"; // String of characters

            // Variable with var keyword (type inference)
            var lastName = "Smith";
            var age = 30;

            // Constants
            const float Pi = 3.14f;

            Console.WriteLine($"Last Name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Pi: {Pi}");

            // Output values
            Console.WriteLine($"Byte: {number}");
            Console.WriteLine($"Int: {count}");
            Console.WriteLine($"Float: {totalPrice}");
            Console.WriteLine($"Double: {amount}");
            Console.WriteLine($"Decimal: {price}");
            Console.WriteLine($"Char: {letter}");
            Console.WriteLine($"Bool: {isActive}");
            Console.WriteLine($"String: {firstName}");

            // Min/Max values for numeric types
            Console.WriteLine($"Byte range: {byte.MinValue} to {byte.MaxValue}");
            Console.WriteLine($"Int range: {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"Float range: {float.MinValue} to {float.MaxValue}");
            Console.WriteLine($"Double range: {double.MinValue} to {double.MaxValue}");
            Console.WriteLine($"Decimal range: {decimal.MinValue} to {decimal.MaxValue}");
        }

        public static void ShowTypeConversion()
        {
            Console.WriteLine("\n=== Type Conversion ===");

            // Implicit conversion (no data loss)
            byte b = 1;
            int i = b;
            Console.WriteLine($"Implicit byte to int: {i}");

            // Explicit conversion (may lose data)
            int j = 1000;
            byte c = (byte)j; // Explicit cast
            Console.WriteLine($"Explicit int to byte: {c}");

            // Possible data loss
            float f = 1.5f;
            int x = (int)f; // Truncates decimal portion
            Console.WriteLine($"Float to int (truncated): {x}");

            // Non-compatible types
            string number = "123";
            int parsedInt = int.Parse(number);
            Console.WriteLine($"String parsed to int: {parsedInt}");

            // Convert class methods
            string amount = "150";
            int convertedInt = Convert.ToInt32(amount);
            float convertedFloat = Convert.ToSingle(amount);
            bool convertedBool = Convert.ToBoolean("true");
            Console.WriteLine($"Convert.ToInt32: {convertedInt}");
            Console.WriteLine($"Convert.ToSingle: {convertedFloat}");
            Console.WriteLine($"Convert.ToBoolean: {convertedBool}");

            // TryParse for safer conversion
            string possiblyInvalid = "abc";
            if (int.TryParse(possiblyInvalid, out int result))
                Console.WriteLine($"Successfully parsed: {result}");
            else
                Console.WriteLine($"Could not parse '{possiblyInvalid}' to an integer");
        }

        public static void ShowOperators()
        {
            Console.WriteLine("\n=== Operators ===");

            // Arithmetic operators
            int a = 10;
            int b = 3;
            Console.WriteLine($"Addition: {a} + {b} = {a + b}");
            Console.WriteLine($"Subtraction: {a} - {b} = {a - b}");
            Console.WriteLine($"Multiplication: {a} * {b} = {a * b}");
            Console.WriteLine($"Division: {a} / {b} = {a / b}");
            Console.WriteLine($"Modulus: {a} % {b} = {a % b}");

            // Increment/decrement
            int c = 5;
            Console.WriteLine($"Original value: {c}");
            Console.WriteLine($"Prefix increment: {++c}"); // c is now 6
            Console.WriteLine($"Postfix increment: {c++}"); // Returns 6, then c becomes 7
            Console.WriteLine($"Current value: {c}"); // c is now 7
            Console.WriteLine($"Prefix decrement: {--c}"); // c is now 6
            Console.WriteLine($"Postfix decrement: {c--}"); // Returns 6, then c becomes 5
            Console.WriteLine($"Final value: {c}"); // c is now 5

            // Comparison operators
            bool isEqual = a == b;
            bool isNotEqual = a != b;
            bool isGreater = a > b;
            bool isLess = a < b;
            bool isGreaterOrEqual = a >= b;
            bool isLessOrEqual = a <= b;
            Console.WriteLine($"{a} == {b}: {isEqual}");
            Console.WriteLine($"{a} != {b}: {isNotEqual}");
            Console.WriteLine($"{a} > {b}: {isGreater}");
            Console.WriteLine($"{a} < {b}: {isLess}");
            Console.WriteLine($"{a} >= {b}: {isGreaterOrEqual}");
            Console.WriteLine($"{a} <= {b}: {isLessOrEqual}");

            // Logical operators
            bool t = true;
            bool f = false;
            Console.WriteLine($"AND: {t} && {f} = {t && f}");
            Console.WriteLine($"OR: {t} || {f} = {t || f}");
            Console.WriteLine($"NOT: !{t} = {!t}");

            // Assignment operators
            int d = 10;
            d += 5; // d = d + 5
            Console.WriteLine($"After += 5: {d}");
            d -= 3; // d = d - 3
            Console.WriteLine($"After -= 3: {d}");
            d *= 2; // d = d * 2
            Console.WriteLine($"After *= 2: {d}");
            d /= 4; // d = d / 4
            Console.WriteLine($"After /= 4: {d}");

            // Ternary operator
            int max = (a > b) ? a : b;
            Console.WriteLine($"Max of {a} and {b} is: {max}");

            // Null coalescing operator
            string? name = null;
            string displayName = name ?? "Unknown";
            Console.WriteLine($"Display name: {displayName}");

            // Null conditional operator
            string? text = null;
            int? length = text?.Length;
            Console.WriteLine($"Length: {length ?? 0}");
        }
    }
}
