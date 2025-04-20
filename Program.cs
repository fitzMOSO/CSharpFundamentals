using CSharpFundamentals.Classes;
using CSharpFundamentals.Enums;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Fundamentals - Mosh's Ultimate C# Series");
            Console.WriteLine("==========================================");

            //PrimitiveTypes();
            //TypeConversion();
            //Operators();
            //DemonstrateClasses();
            //DemonstrateStructs();
            //DemonstrateArrays();
            //DemonstrateStrings();
            //ControlFlow()
            //RandomClass();
            //ControlFlowExercises();
            //Arrays();
            Lists();
            //ArraysAndListsExercises();
        }

        static void PrimitiveTypes()
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
            string name = null;
            string displayName = name ?? "Unknown";
            Console.WriteLine($"Display name: {displayName}");

            // Null conditional operator
            string text = null;
            int? length = text?.Length;
            Console.WriteLine($"Length: {length ?? 0}");
        }

        static void DemonstrateClasses()
        {
            Console.WriteLine("\n=== Classes and Objects ===");

            // Classes
            Person fitz = new Person
            {
                FirstName = "Fitz",
                LastName = "Moso"
            };
            fitz.Introduce();

            Person john = new Person
            {
                FirstName = "John",
                LastName = "Doe"
            };
            john.Introduce();

            // Static methods
            const int value1 = 5;
            const int value2 = 10;

            int sum = Calculator.Add(value1, value2);
            int difference = Calculator.Subtract(value1, value2);
            double quotient = Calculator.Divide(value1, value2);
            int product = Calculator.Multiply(value1, value2);

            Console.WriteLine(
                $"Addition: {sum}, Subtraction: {difference}, Division: {quotient}, Multiplication: {product}");
        }

        // Structs are value types, while classes are reference types.
        static void DemonstrateStructs()
        {
            Console.WriteLine("\n=== Structs ===");

            var color = new Struct.RgbColor
            {
                Red = 255,
                Green = 0,
                Blue = 0
            };

            Console.WriteLine($"Color: R:{color.Red}, G:{color.Green}, B:{color.Blue}");
        }

        static void DemonstrateArrays()
        {
            Console.WriteLine("\n=== Array Examples ===");

            // Integer array
            var numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine("Integer array:");
            Console.WriteLine($"numbers[0]: {numbers[0]}");
            Console.WriteLine($"numbers[1]: {numbers[1]} (default)");
            Console.WriteLine($"numbers[2]: {numbers[2]} (default)");

            // Boolean array
            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine("\nBoolean array:");
            Console.WriteLine($"flags[0]: {flags[0]}");
            Console.WriteLine($"flags[1]: {flags[1]} (default)");
            Console.WriteLine($"flags[2]: {flags[2]} (default)");

            // String array with initialization
            var names = new string[] { "John", "Jack", "Mary" };

            Console.WriteLine("\nString array:");
            Console.WriteLine($"names[0]: {names[0]}");
            Console.WriteLine($"names[1]: {names[1]}");
            Console.WriteLine($"names[2]: {names[2]}");
        }

        static void DemonstrateStrings()
        {
            Console.WriteLine("\n=== String Operations ===");

            var color = new Struct.RgbColor { Red = 255, Green = 0, Blue = 0 };

            // Different ways to format strings
            Console.WriteLine("String formatting:");
            var stringFormat = string.Format("Color: {0}, {1}, {2}", color.Red, color.Green, color.Blue);
            var stringInterpolation = $"Color: {color.Red}, {color.Green}, {color.Blue}";
            var stringConcatenation = "Color: " + color.Red + ", " + color.Green + ", " + color.Blue;

            Console.WriteLine(stringFormat);
            Console.WriteLine(stringInterpolation);
            Console.WriteLine(stringConcatenation);

            // String joining
            string[] names = ["John", "Jack", "Mary"];
            var list = string.Join(",", names);
            Console.WriteLine($"\nJoined list: {list}");

            // Escape characters
            Console.WriteLine("\nEscape characters:");
            Console.WriteLine("New line: \nThis text is on a new line");
            Console.WriteLine("Tab: This is\ta tab");
            Console.WriteLine("Backslash: This is a \\ backslash");
            Console.WriteLine("Quotes: 'single quote' and \"double quotes\"");

            // Verbatim string
            var verbatim = @"This is a verbatim string \n \t (escape sequences not processed)";
            Console.WriteLine($"\nVerbatim string: {verbatim}");

            // String methods
            Console.WriteLine("\nString methods:");
            var text = "Hello World";
            Console.WriteLine($"Original: '{text}'");
            Console.WriteLine($"Length: {text.Length}");
            Console.WriteLine($"Upper: {text.ToUpper()}");
            Console.WriteLine($"Lower: {text.ToLower()}");
            Console.WriteLine($"IndexOf 'World': {text.IndexOf("world")}");
            Console.WriteLine($"Substring from index 6: '{text.Substring(6)}'");
            Console.WriteLine($"Replace 'World' with 'Fitz': '{text.Replace("World", "Fitz")}'");
        }

        static void ControlFlow()
        {
            Console.WriteLine("\n=== Control Flow ===");

            // If-else statements
            Console.WriteLine("\n--- Conditional Statements ---");
            int hour = 10;

            if (hour > 0 && hour < 12)
                Console.WriteLine("Good morning!");
            else if (hour >= 12 && hour < 18)
                Console.WriteLine("Good afternoon!");
            else
                Console.WriteLine("Good evening!");

            // Switch statement
            int day = 3;
            Console.WriteLine("\n--- Switch Statement ---");
            switch (day)
            {
                case 1: Console.WriteLine("Monday"); break;
                case 2: Console.WriteLine("Tuesday"); break;
                case 3: Console.WriteLine("Wednesday"); break;
                case 4: Console.WriteLine("Thursday"); break;
                case 5: Console.WriteLine("Friday"); break;
                case 6:
                case 7: Console.WriteLine("Weekend"); break;
                default: Console.WriteLine("Invalid day"); break;
            }

            // Loops
            Console.WriteLine("\n--- Different Types of Loops ---");

            // For loop
            Console.WriteLine("For loop:");
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();

            // While loop
            Console.WriteLine("\nWhile loop:");
            int j = 1;
            while (j <= 5)
            {
                Console.Write($"{j} ");
                j++;
            }

            Console.WriteLine();

            // Do-while loop
            Console.WriteLine("\nDo-while loop:");
            int k = 1;
            do
            {
                Console.Write($"{k} ");
                k++;
            } while (k <= 5);

            Console.WriteLine();

            // Foreach loop
            Console.WriteLine("\nForeach loop:");
            string[] fruits = ["Apple", "Banana", "Cherry"];
            foreach (string fruit in fruits)
            {
                Console.Write($"{fruit} ");
            }

            Console.WriteLine();

            // Control flow statements
            Console.WriteLine("\n--- Flow Control Keywords ---");

            // Break example
            Console.WriteLine("Break example:");
            for (int i = 1; i <= 10; i++)
            {
                if (i == 6)
                    break;
                Console.Write($"{i} ");
            }

            Console.WriteLine();

            // Continue example
            Console.WriteLine("\nContinue example:");
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                    continue;
                Console.Write($"{i} ");
            }

            Console.WriteLine();

            // Other operators and examples
            Console.WriteLine("\n--- Other Control Mechanisms ---");

            // Ternary operator
            bool isGoldCustomer = true;
            float price = isGoldCustomer ? 19.99f : 29.99f;
            Console.WriteLine($"Price for {(isGoldCustomer ? "gold" : "regular")} customer: ${price}");

            // Enum example
            Console.WriteLine("\nEnum example:");
            var season = Season.Spring;
            switch (season)
            {
                case Season.Spring:
                    Console.WriteLine("Spring is here!");
                    break;
                case Season.Summer:
                    Console.WriteLine("Summer is here!");
                    break;
                case Season.Fall:
                case Season.Autumn:
                    Console.WriteLine("Fall/Autumn is here!");
                    break;
                case Season.Winter:
                    Console.WriteLine("Winter is here!");
                    break;
                default:
                    Console.WriteLine("Unknown season");
                    break;
            }
        }

        //Random classes are used to generate random numbers.
        static void RandomClass()
        {
            const int passwordLength = 10;

            var random = new Random();
            var buffer = new char[passwordLength];
            for (int i = 0; i < passwordLength; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));
            var password = new string(buffer);

            Console.WriteLine(password);
        }

        static void ControlFlowExercises()
        {
            Exercise1();
            Exercise2();
            Exercise3();
            Exercise4();
            Exercise5();

            static void Exercise1()
            {
                var count = 0;
                for (int i = 1; i < 100; i++)
                {
                    if (i % 3 == 0)
                    {
                        count++;
                        Console.WriteLine(i);
                    }
                }

                Console.WriteLine("total count: " + count);
            }

            static void Exercise2()
            {
                var sum = 0;
                while (true)
                {
                    Console.Write("Enter a number (or 'ok' to exit):");
                    var input = Console.ReadLine();
                    if (input == "ok")
                        break;
                    sum += Convert.ToInt32(input);
                }

                Console.WriteLine(sum);
            }

            static void Exercise3()
            {
                Console.Write("Enter the number of times to repeat: ");
                int number = Convert.ToInt32(Console.ReadLine());

                var factorial = 1;
                for (int i = 1; i <= number; i++)
                    factorial *= i;
                Console.WriteLine("{0}! = {1}", number, factorial);

            }

            static void Exercise4()
            {
                var number = new Random().Next(1, 10);
                Console.WriteLine("Secret number: " + number);

                for (int i = 0; i < 4; i++)
                {
                    Console.Write("Guess the number: ");
                    var guess = Convert.ToInt32(Console.ReadLine());

                    if (guess == number)
                    {
                        Console.WriteLine("You won!");
                        return;
                    }
                }

                Console.WriteLine("You lost!");

            }

            static void Exercise5()
            {
                //Console.Write("Enter numbers separated by commas (,): ");
                //var input = Console.ReadLine();

                //var numbers = Array.ConvertAll(input?.Split(",") ?? [], int.Parse);

                //var max = 0;
                //foreach (var number in numbers)
                //{
                //    max = number < max ? max : number;
                //}

                //Console.WriteLine(max);

                Console.Write("Enter comma separated numbers: ");
                var input = Console.ReadLine();

                var numbers = input.Split(',');

                // Assume the first number is the max 
                var max = Convert.ToInt32(numbers[0]);

                foreach (var str in numbers)
                {
                    var number = Convert.ToInt32(str);
                    if (number > max)
                        max = number;
                }

                Console.WriteLine("Max is " + max);
            }

        }

        //Arrays are fixed size, so you cannot add or remove elements after creation.
        static void Arrays()
        {
            Console.WriteLine("\n=== Arrays ===");

            // Array declaration and initialization
            var numbers = new int[5];
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

            // Rectangular arrays
            var matrix = new int[3, 3];
            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[0, 2] = 3;
            matrix[1, 0] = 4;
            matrix[1, 1] = 5;
            matrix[1, 2] = 6;
            matrix[2, 0] = 7;
            matrix[2, 1] = 8;
            matrix[2, 2] = 9;

            var matrix2 = new int[3, 3]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            // Alternative Rectangular array initialization
            int[,] grid =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            // Accessing Rectangular array elements
            Console.WriteLine($"Matrix[1,2]: {matrix[1, 2]}");
            Console.WriteLine($"Matrix2[1,2]: {matrix2[1, 2]}");
            Console.WriteLine($"Grid[2,0]: {grid[2, 0]}");

            // Jagged arrays (arrays of arrays)
            var jaggedArray = new int[3][];
            jaggedArray[0] = [1, 2, 3];
            jaggedArray[1] = [4, 5];
            jaggedArray[2] = [6, 7, 8, 9];

            // Accessing jagged array elements
            Console.WriteLine($"JaggedArray[0][2]: {jaggedArray[0][2]}");
            Console.WriteLine($"JaggedArray[2][3]: {jaggedArray[2][3]}");

            var numbers2 = new[] { 1, 2, 3, 4, 5 };

            //Length
            Console.WriteLine("Length: " + numbers2.Length);

            //IndexOf()
            var index = Array.IndexOf(numbers2, 3);
            Console.WriteLine(index);

            //Clear()
            Array.Clear(numbers2, 0, 2);

            Console.WriteLine("Effect if Clear()");
            foreach (var n in numbers2)
                Console.WriteLine(n);


            //Copy(
            int[] destinationArray = new int[3];
            Array.Copy(numbers, destinationArray, 3);
            Console.WriteLine("Copied array value: " + string.Join(",", destinationArray));

            //Sort()
            Array.Sort(numbers2);
            Console.WriteLine("Sorted array: " + string.Join(",", numbers2));

            //Reverse()
            Array.Reverse(numbers2);
            Console.WriteLine("Reversed array: " + string.Join(",", numbers2));

        }

        //List is a generic collection that can dynamically resize.
        static void Lists()
        {
            // Base list for examples
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine("Original list: " + string.Join(", ", numbers));

            // Add() - Adds a single element to the end of the list
            numbers.Add(6);
            Console.WriteLine("\nAfter Add(6): " + string.Join(", ", numbers));

            // AddRange() - Adds a collection of elements to the end of the list
            numbers.AddRange(new[] { 7, 8, 9 });
            Console.WriteLine("\nAfter AddRange([7, 8, 9]): " + string.Join(", ", numbers));

            // Insert() - Inserts an element at the specified index
            numbers.Insert(3, 42);
            Console.WriteLine("\nAfter Insert(3, 42): " + string.Join(", ", numbers));

            // InsertRange() - Inserts a collection of elements at the specified index
            numbers.InsertRange(5, new[] { 100, 101 });
            Console.WriteLine("\nAfter InsertRange(5, [100, 101]): " + string.Join(", ", numbers));

            // Remove() - Removes the first occurrence of a specific element
            bool removed = numbers.Remove(4);
            Console.WriteLine("\nAfter Remove(4): " + string.Join(", ", numbers));
            Console.WriteLine($"Element was removed: {removed}");

            // RemoveAt() - Removes the element at the specified index
            numbers.RemoveAt(2);
            Console.WriteLine("\nAfter RemoveAt(2): " + string.Join(", ", numbers));

            // RemoveRange() - Removes a range of elements starting at specified index
            numbers.RemoveRange(1, 3);
            Console.WriteLine("\nAfter RemoveRange(1, 3): " + string.Join(", ", numbers));

            // Contains() - Determines whether an element is in the list
            bool contains5 = numbers.Contains(5);
            bool contains99 = numbers.Contains(99);
            Console.WriteLine($"\nContains(5): {contains5}");
            Console.WriteLine($"Contains(99): {contains99}");

            // IndexOf() - Returns the zero-based index of the first occurrence of a value
            int indexOfFive = numbers.IndexOf(5);
            int indexOfMissing = numbers.IndexOf(999);
            Console.WriteLine($"\nIndexOf(5): {indexOfFive}");
            Console.WriteLine($"IndexOf(999): {indexOfMissing}"); // -1 means not found

            // LastIndexOf() - Returns the zero-based index of the last occurrence of a value
            var repeatedList = new List<int> { 10, 20, 30, 20, 10 };
            int lastIndexOf20 = repeatedList.LastIndexOf(20);
            Console.WriteLine($"\nFor list {string.Join(", ", repeatedList)}:");
            Console.WriteLine($"LastIndexOf(20): {lastIndexOf20}");

            // Sort() - Sorts the elements in the list
            numbers.Sort();
            Console.WriteLine($"\nAfter Sort(): {string.Join(", ", numbers)}");

            // Reverse() - Reverses the order of the elements in the list
            numbers.Reverse();
            Console.WriteLine($"\nAfter Reverse(): {string.Join(", ", numbers)}");

            // Clear() - Removes all elements from the list
            var tempList = new List<int> { 1, 2, 3 };
            Console.WriteLine($"\ntempList before Clear(): {string.Join(", ", tempList)}");
            tempList.Clear();
            Console.WriteLine($"tempList after Clear(): {string.Join(", ", tempList)}");

            // ToArray() - Copies the elements to a new array
            int[] numbersArray = numbers.ToArray();
            Console.WriteLine($"\nAfter ToArray(): {string.Join(", ", numbersArray)}");

            // ToList() - Creates a new List<T> from an IEnumerable<T>
            int[] sourceArray = [100, 200, 300];
            List<int> newList = sourceArray.ToList();
            Console.WriteLine($"\nAfter ToList() from array: {string.Join(", ", newList)}");

            // Additional useful methods:

            // ForEach() - Performs an action on each element
            Console.WriteLine("\nUsing ForEach() to multiply each element by 2:");
            var forEachList = new List<int> { 1, 2, 3, 4 };
            forEachList.ForEach(x => Console.Write(x * 2 + " "));

            // Find() - Returns the first element that matches the conditions
            var findList = new List<int> { 11, 22, 33, 44, 55 };
            int found = findList.Find(x => x > 30);
            Console.WriteLine($"\n\nFirst element > 30: {found}");

            // FindAll() - Returns all elements that match the conditions
            var allFound = findList.FindAll(x => x > 30);
            Console.WriteLine($"All elements > 30: {string.Join(", ", allFound)}");

            // Exists() - Determines whether any element matches the conditions
            bool exists = findList.Exists(x => x % 10 == 0);
            Console.WriteLine($"Exists element divisible by 10: {exists}");

            // TrueForAll() - Determines whether every element matches the conditions
            bool allEven = findList.TrueForAll(x => x % 2 == 0);
            Console.WriteLine($"All elements are even: {allEven}");
        }

        static void ArraysAndListsExercises()
        {
            //Exercise1();
            //Exercise2();
            //Exercise3();
            //Exercise4();
            //Exercise5();
        }
    }
}