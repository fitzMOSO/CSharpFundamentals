namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Fundamentals - Mosh's Ultimate C# Series");
            Console.WriteLine("==========================================");

            // Comment/uncomment methods to run different sections
            PrimitiveTypes();
            // TypeConversion();
            // Operators();
            // ControlFlow();
            // Arrays();
        }

        static void PrimitiveTypes()
        {
            Console.WriteLine("\n=== Primitive Types ===");

            // Variable declarations
            byte number = 2;            // 0-255
            int count = 10;             // -2,147,483,648 to 2,147,483,647
            float totalPrice = 20.95f;  // 7-digit precision
            double amount = 99.99;      // 15-16 digit precision
            decimal price = 29.99m;     // 28-29 significant digits
            char letter = 'A';          // Single character
            bool isActive = true;       // true/false
            string firstName = "John";  // String of characters

            // Variable with var keyword (type inference)
            var lastName = "Smith";
            var age = 30;

            // Constants
            const float Pi = 3.14f;

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

        static void TypeConversion()
        {
            Console.WriteLine("\n=== Type Conversion ===");

            // Implicit conversion (no data loss)
            byte b = 1;
            int i = b;
            Console.WriteLine($"Implicit byte to int: {i}");

            // Explicit conversion (may lose data)
            int j = 1000;
            byte c = (byte)j;  // Explicit cast
            Console.WriteLine($"Explicit int to byte: {c}");

            // Possible data loss
            float f = 1.5f;
            int x = (int)f;  // Truncates decimal portion
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

        static void Operators()
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
            Console.WriteLine($"Prefix increment: {++c}");  // c is now 6
            Console.WriteLine($"Postfix increment: {c++}"); // Returns 6, then c becomes 7
            Console.WriteLine($"Current value: {c}");       // c is now 7
            Console.WriteLine($"Prefix decrement: {--c}");  // c is now 6
            Console.WriteLine($"Postfix decrement: {c--}"); // Returns 6, then c becomes 5
            Console.WriteLine($"Final value: {c}");         // c is now 5

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
            d += 5;  // d = d + 5
            Console.WriteLine($"After += 5: {d}");
            d -= 3;  // d = d - 3
            Console.WriteLine($"After -= 3: {d}");
            d *= 2;  // d = d * 2
            Console.WriteLine($"After *= 2: {d}");
            d /= 4;  // d = d / 4
            Console.WriteLine($"After /= 4: {d}");

            // Ternary operator
            int max = (a > b) ? a : b;
            Console.WriteLine($"Max of {a} and {b} is: {max}");

            // Null coalescing operator
            string name = null;
            string displayName = name ?? "Unknown";
            Console.WriteLine($"Display name: {displayName}");

            // Null conditional operator
            string text = null;
            int? length = text?.Length;
            Console.WriteLine($"Length: {length ?? 0}");
        }

        static void ControlFlow()
        {
            Console.WriteLine("\n=== Control Flow ===");

            // If-else statements
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("Good morning!");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("Good afternoon!");
            }
            else
            {
                Console.WriteLine("Good evening!");
            }

            // Switch statement
            int day = 3;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }

            // For loop
            Console.WriteLine("For loop:");
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            // While loop
            Console.WriteLine("While loop:");
            int j = 1;
            while (j <= 5)
            {
                Console.Write($"{j} ");
                j++;
            }
            Console.WriteLine();

            // Do-while loop
            Console.WriteLine("Do-while loop:");
            int k = 1;
            do
            {
                Console.Write($"{k} ");
                k++;
            } while (k <= 5);
            Console.WriteLine();

            // Foreach loop
            Console.WriteLine("Foreach loop:");
            string[] fruits = { "Apple", "Banana", "Cherry" };
            foreach (string fruit in fruits)
            {
                Console.Write($"{fruit} ");
            }
            Console.WriteLine();

            // Break and continue
            Console.WriteLine("Break example:");
            for (int i = 1; i <= 10; i++)
            {
                if (i == 6)
                    break;
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            Console.WriteLine("Continue example:");
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                    continue;
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        static void Arrays()
        {
            Console.WriteLine("\n=== Arrays ===");

            // Array declaration and initialization
            int[] numbers = new int[5];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;

            // Alternative initialization
            int[] scores = new int[] { 90, 85, 95, 80, 88 };

            // Shorter initialization
            string[] names = { "John", "Mary", "Bob", "Alice" };

            // Accessing array elements
            Console.WriteLine($"First number: {numbers[0]}");
            Console.WriteLine($"Third score: {scores[2]}");
            Console.WriteLine($"Second name: {names[1]}");

            // Array length
            Console.WriteLine($"Numbers length: {numbers.Length}");

            // Iterating through an array
            Console.WriteLine("All scores:");
            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write($"{scores[i]} ");
            }
            Console.WriteLine();

            // Using foreach
            Console.WriteLine("All names:");
            foreach (string name in names)
            {
                Console.Write($"{name} ");
            }
            Console.WriteLine();

            // Multi-dimensional arrays
            int[,] matrix = new int[3, 3];
            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[0, 2] = 3;
            matrix[1, 0] = 4;
            matrix[1, 1] = 5;
            matrix[1, 2] = 6;
            matrix[2, 0] = 7;
            matrix[2, 1] = 8;
            matrix[2, 2] = 9;

            // Alternative multi-dimensional array initialization
            int[,] grid = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            // Accessing multi-dimensional array elements
            Console.WriteLine($"Matrix[1,2]: {matrix[1, 2]}");
            Console.WriteLine($"Grid[2,0]: {grid[2, 0]}");

            // Jagged arrays (arrays of arrays)
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 4, 5 };
            jaggedArray[2] = new int[] { 6, 7, 8, 9 };

            // Accessing jagged array elements
            Console.WriteLine($"JaggedArray[0][2]: {jaggedArray[0][2]}");
            Console.WriteLine($"JaggedArray[2][3]: {jaggedArray[2][3]}");
        }
    }
}