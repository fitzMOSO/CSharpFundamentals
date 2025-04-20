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
            //Lists();
            //ArraysAndListsExercises();
            //DateTimeAndTimeSpan();
            //StringBuilder();

            _ = Others.HttpRequestsAsync();
            Others.LinqExamples();
            Others.FileOperations();
            Others.DependencyInjectionExample();


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
            Exercise1();
            Exercise2();
            Exercise3();
            Exercise4();
            Exercise5();

            // <summary>
            // Write a program and continuously ask the user to enter different names, until the user presses Enter 
            // (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.
            // </summary>
            static void Exercise1()
            {
                var names = new List<string>();

                while (true)
                {
                    Console.Write("Type a name (or hit ENTER to quit): ");

                    var input = Console.ReadLine();
                    if (String.IsNullOrWhiteSpace(input))
                        break;
                    names.Add(input);
                }

                if (names.Count > 2)
                    Console.WriteLine("{0}, {1} and {2} others like your post", names[0], names[1], names.Count - 2);
                else if (names.Count == 2)
                    Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
                else if (names.Count == 1)
                    Console.WriteLine("{0} likes your post.", names[0]);
                else
                    Console.WriteLine();
            }

            // <summary>
            // Ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. 
            // Display the reversed name on the console.
            // </summary>
            static void Exercise2()
            {
                Console.Write("What's your name? ");
                var name = Console.ReadLine();

                var array = new char[name.Length];
                for (var i = name.Length; i > 0; i--)
                    array[name.Length - i] = name[i - 1];

                var reversed = new string(array);
                Console.WriteLine("Reversed name: " + reversed);
            }

            // <summary>
            // Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display 
            // an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them 
            // and display the result on the console.
            // </summary>
            static void Exercise3()
            {
                var numbers = new List<int>();

                while (numbers.Count < 5)
                {
                    Console.Write("Enter a number: ");
                    var number = Convert.ToInt32(Console.ReadLine());
                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("You've previously entered " + number);
                        continue;
                    }

                    numbers.Add(number);
                }

                numbers.Sort();

                foreach (var number in numbers)
                    Console.WriteLine(number);
            }

            // <summary>
            // Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may 
            // include duplicates. Display the unique numbers that the user has entered.
            // </summary>
            static void Exercise4()
            {
                var numbers = new List<int>();

                while (true)
                {
                    Console.Write("Enter a number (or 'Quit' to exit): ");
                    var input = Console.ReadLine();

                    if (input.ToLower() == "quit")
                        break;

                    numbers.Add(Convert.ToInt32(input));
                }

                var uniques = new List<int>();
                foreach (var number in numbers)
                {
                    if (!uniques.Contains(number))
                        uniques.Add(number);
                }

                Console.WriteLine("Unique numbers:");
                foreach (var number in uniques)
                    Console.WriteLine(number);
            }


            // <summary>
            // Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is 
            // empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display 
            // the 3 smallest numbers in the list.
            // 
            // </summary>
            static void Exercise5()
            {
                string[] elements;
                while (true)
                {
                    Console.Write("Enter a list of comma-separated numbers: ");
                    var input = Console.ReadLine();

                    if (!String.IsNullOrWhiteSpace(input))
                    {
                        elements = input.Split(',');
                        if (elements.Length >= 5)
                            break;
                    }

                    Console.WriteLine("Invalid List");
                }

                var numbers = new List<int>();
                foreach (var number in elements)
                    numbers.Add(Convert.ToInt32(number));

                var smallest = new List<int>();
                while (smallest.Count < 3)
                {
                    // Assume the first number is the smallest
                    var min = numbers[0];
                    foreach (var number in numbers)
                    {
                        if (number < min)
                            min = number;
                    }
                    smallest.Add(min);

                    numbers.Remove(min);
                }

                Console.WriteLine("The 3 smallest numbers are: ");
                foreach (var number in smallest)
                    Console.WriteLine(number);
            }
        }

        static void DateTimeAndTimeSpan()
        {

            DateTimeStaticMembers();
            DateTimeInstanceMembers();
            TimeSpanStaticMembers();
            TimeSpanInstanceMembers();

            DateTimeDifferences();
            TimeSpanDifferences();

            static void DateTimeStaticMembers()
            {
                Console.WriteLine("=== DateTime Static Members ===");

                // Static properties
                Console.WriteLine($"DateTime.Now: {DateTime.Now}");
                Console.WriteLine($"DateTime.Today: {DateTime.Today}");
                Console.WriteLine($"DateTime.UtcNow: {DateTime.UtcNow}");
                Console.WriteLine($"DateTime.MinValue: {DateTime.MinValue}");
                Console.WriteLine($"DateTime.MaxValue: {DateTime.MaxValue}");

                // Static methods
                Console.WriteLine($"DateTime.IsLeapYear(2024): {DateTime.IsLeapYear(2024)}");
                Console.WriteLine($"DateTime.DaysInMonth(2023, 2): {DateTime.DaysInMonth(2023, 2)}");

                // Parsing methods (static)
                string dateString = "2023-10-01 10:21";
                Console.WriteLine($"DateTime.Parse(\"{dateString}\"): {DateTime.Parse(dateString)}");
                Console.WriteLine($"DateTime.ParseExact(\"{dateString}\", \"yyyy-MM-dd HH:mm\", null): {DateTime.ParseExact(dateString, "yyyy-MM-dd HH:mm", null)}");

                // TryParse methods (static)
                bool success = DateTime.TryParse(dateString, out DateTime result);
                Console.WriteLine($"DateTime.TryParse result: {success}, Value: {result}");

                // Static comparison methods
                var date1 = new DateTime(2023, 10, 1);
                var date2 = new DateTime(2023, 10, 2);
                Console.WriteLine($"DateTime.Compare(date1, date2): {DateTime.Compare(date1, date2)}");

                Console.WriteLine();
            }

            static void DateTimeInstanceMembers()
            {
                Console.WriteLine("=== DateTime Instance Members ===");

                // Create instance
                var dateTime = new DateTime(2023, 10, 1);
                Console.WriteLine($"Instance dateTime: {dateTime}");

                // Instance properties
                Console.WriteLine($"dateTime.Year: {dateTime.Year}");
                Console.WriteLine($"dateTime.Month: {dateTime.Month}");
                Console.WriteLine($"dateTime.Day: {dateTime.Day}");
                Console.WriteLine($"dateTime.Hour: {dateTime.Hour}");
                Console.WriteLine($"dateTime.Minute: {dateTime.Minute}");
                Console.WriteLine($"dateTime.Second: {dateTime.Second}");
                Console.WriteLine($"dateTime.Millisecond: {dateTime.Millisecond}");
                Console.WriteLine($"dateTime.DayOfWeek: {dateTime.DayOfWeek}");
                Console.WriteLine($"dateTime.DayOfYear: {dateTime.DayOfYear}");
                Console.WriteLine($"dateTime.Ticks: {dateTime.Ticks}");
                Console.WriteLine($"dateTime.Kind: {dateTime.Kind}");
                Console.WriteLine($"dateTime.IsDaylightSavingTime(): {dateTime.IsDaylightSavingTime()}");

                // Instance methods for adding/subtracting time
                var now = DateTime.Now;
                Console.WriteLine($"now.AddDays(5): {now.AddDays(5)}");
                Console.WriteLine($"now.AddHours(5): {now.AddHours(5)}");
                Console.WriteLine($"now.AddMinutes(5): {now.AddMinutes(5)}");
                Console.WriteLine($"now.AddSeconds(5): {now.AddSeconds(5)}");
                Console.WriteLine($"now.AddMilliseconds(5): {now.AddMilliseconds(5)}");
                Console.WriteLine($"now.AddMonths(5): {now.AddMonths(5)}");
                Console.WriteLine($"now.AddYears(5): {now.AddYears(5)}");
                Console.WriteLine($"now.AddTicks(5000): {now.AddTicks(5000)}");

                // Instance conversion methods
                Console.WriteLine($"now.ToLocalTime(): {now.ToLocalTime()}");
                Console.WriteLine($"now.ToUniversalTime(): {now.ToUniversalTime()}");
                Console.WriteLine($"now.ToLongDateString(): {now.ToLongDateString()}");
                Console.WriteLine($"now.ToShortDateString(): {now.ToShortDateString()}");
                Console.WriteLine($"now.ToLongTimeString(): {now.ToLongTimeString()}");
                Console.WriteLine($"now.ToShortTimeString(): {now.ToShortTimeString()}");

                // Instance formatting methods
                Console.WriteLine($"now.ToString(\"d\"): {now.ToString("d")}"); //Select a format using intellisense
                Console.WriteLine($"now.ToString(\"HH:mm:ss\"): {now:HH:mm:ss}");
                Console.WriteLine($"now.ToString(\"yyyy-MM-dd HH:mm:ss\"): {now:yyyy-MM-dd HH:mm:ss}");

                // Instance comparison methods
                var date1 = new DateTime(2023, 10, 1);
                var date2 = new DateTime(2023, 10, 2);
                Console.WriteLine($"date1.CompareTo(date2): {date1.CompareTo(date2)}");
                Console.WriteLine($"date1.Equals(date2): {date1.Equals(date2)}");

                Console.WriteLine();
            }

            static void TimeSpanStaticMembers()
            {
                Console.WriteLine("=== TimeSpan Static Members ===");

                // Static properties
                Console.WriteLine($"TimeSpan.Zero: {TimeSpan.Zero}");
                Console.WriteLine($"TimeSpan.MinValue: {TimeSpan.MinValue}");
                Console.WriteLine($"TimeSpan.MaxValue: {TimeSpan.MaxValue}");

                // Static creation methods
                Console.WriteLine($"TimeSpan.FromDays(1): {TimeSpan.FromDays(1)}");
                Console.WriteLine($"TimeSpan.FromHours(2): {TimeSpan.FromHours(2)}");
                Console.WriteLine($"TimeSpan.FromMinutes(3): {TimeSpan.FromMinutes(3)}");
                Console.WriteLine($"TimeSpan.FromSeconds(4): {TimeSpan.FromSeconds(4)}");
                Console.WriteLine($"TimeSpan.FromMilliseconds(5): {TimeSpan.FromMilliseconds(5)}");
                Console.WriteLine($"TimeSpan.FromTicks(6): {TimeSpan.FromTicks(6)}");

                // Static parsing methods
                string timeSpanString = "1:02:03";
                Console.WriteLine($"TimeSpan.Parse(\"{timeSpanString}\"): {TimeSpan.Parse(timeSpanString)}");
                Console.WriteLine($"TimeSpan.ParseExact(\"{timeSpanString}\", \"g\", null): {TimeSpan.ParseExact(timeSpanString, "g", null)}");

                // Static TryParse methods
                bool success = TimeSpan.TryParse(timeSpanString, out TimeSpan result);
                Console.WriteLine($"TimeSpan.TryParse result: {success}, Value: {result}");

                // Static comparison method
                var ts1 = new TimeSpan(1, 0, 0);
                var ts2 = new TimeSpan(2, 0, 0);
                Console.WriteLine($"TimeSpan.Compare(ts1, ts2): {TimeSpan.Compare(ts1, ts2)}");

                Console.WriteLine();
            }

            static void TimeSpanInstanceMembers()
            {
                Console.WriteLine("=== TimeSpan Instance Members ===");

                // Create instance
                var timeSpan = new TimeSpan(1, 2, 3);
                Console.WriteLine($"Instance timeSpan: {timeSpan}");

                // Instance properties
                Console.WriteLine($"timeSpan.Days: {timeSpan.Days}");
                Console.WriteLine($"timeSpan.Hours: {timeSpan.Hours}");
                Console.WriteLine($"timeSpan.Minutes: {timeSpan.Minutes}");
                Console.WriteLine($"timeSpan.Seconds: {timeSpan.Seconds}");
                Console.WriteLine($"timeSpan.Milliseconds: {timeSpan.Milliseconds}");
                Console.WriteLine($"timeSpan.Ticks: {timeSpan.Ticks}");

                // Total properties (instance)
                Console.WriteLine($"timeSpan.TotalDays: {timeSpan.TotalDays}");
                Console.WriteLine($"timeSpan.TotalHours: {timeSpan.TotalHours}");
                Console.WriteLine($"timeSpan.TotalMinutes: {timeSpan.TotalMinutes}");
                Console.WriteLine($"timeSpan.TotalSeconds: {timeSpan.TotalSeconds}");
                Console.WriteLine($"timeSpan.TotalMilliseconds: {timeSpan.TotalMilliseconds}");

                // Instance arithmetic methods
                var ts1 = new TimeSpan(1, 0, 0);
                var ts2 = new TimeSpan(0, 30, 0);
                Console.WriteLine($"ts1.Add(ts2): {ts1.Add(TimeSpan.FromMinutes(5))}");
                Console.WriteLine($"ts1.Subtract(ts2): {ts1.Subtract(ts2)}");
                Console.WriteLine($"ts1.Negate(): {ts1.Negate()}");
                Console.WriteLine($"ts1.Duration(): {ts1.Duration()}");
                Console.WriteLine($"TimeSpan.FromDays(-1).Duration(): {TimeSpan.FromDays(-1).Duration()}");

                // Instance comparison methods
                Console.WriteLine($"ts1.CompareTo(ts2): {ts1.CompareTo(ts2)}");
                Console.WriteLine($"ts1.Equals(ts2): {ts1.Equals(ts2)}");

                // Instance formatting methods
                Console.WriteLine($"timeSpan.ToString(): {timeSpan.ToString()}");
                Console.WriteLine($"timeSpan.ToString(\"g\"): {timeSpan.ToString("g")}");
                Console.WriteLine($"timeSpan.ToString(\"c\"): {timeSpan.ToString("c")}");

                Console.WriteLine();
            }

            //Getting the Diff of two Dates/TimeSpans

            static void DateTimeDifferences()
            {
                Console.WriteLine("=== DateTime Differences ===");

                // Create sample dates
                DateTime past = new DateTime(2023, 1, 1, 8, 30, 0);
                DateTime now = DateTime.Now;
                DateTime future = new DateTime(2025, 12, 31, 23, 59, 59);

                Console.WriteLine($"Past date: {past:yyyy-MM-dd HH:mm:ss}");
                Console.WriteLine($"Current date: {now:yyyy-MM-dd HH:mm:ss}");
                Console.WriteLine($"Future date: {future:yyyy-MM-dd HH:mm:ss}\n");

                // Method 1: Subtract dates to get TimeSpan
                Console.WriteLine("Method 1: Subtract dates directly to get TimeSpan");
                TimeSpan difference1 = now - past;
                TimeSpan difference2 = future - now;

                Console.WriteLine($"Time elapsed since past date: {difference1.Days} days, {difference1.Hours} hours, {difference1.Minutes} minutes");
                Console.WriteLine($"Time until future date: {difference2.Days} days, {difference2.Hours} hours, {difference2.Minutes} minutes\n");

                // Method 2: Using TimeSpan properties for total values
                Console.WriteLine("Method 2: Using TimeSpan properties for total values");
                Console.WriteLine($"Total days since past date: {difference1.TotalDays} days");
                Console.WriteLine($"Total hours since past date: {difference1.TotalHours} hours");
                Console.WriteLine($"Total minutes since past date: {difference1.TotalMinutes} minutes");
                Console.WriteLine($"Total seconds since past date: {difference1.TotalSeconds} seconds\n");

                // Method 3: Using DateTime.Subtract method
                Console.WriteLine("Method 3: Using DateTime.Subtract method");
                TimeSpan subtractDifference = now.Subtract(past);
                Console.WriteLine($"Time since past date: {subtractDifference.Days} days, {subtractDifference.Hours} hours, {subtractDifference.Minutes} minutes\n");

                // Method 4: Calculate specific time units
                Console.WriteLine("Method 4: Calculate specific time units");

                // Calculate years, months and remaining days between dates
                int yearsPassed = CalculateYears(past, now);
                int monthsPassed = CalculateMonths(past, now);
                int remainingDays = CalculateRemainingDays(past, now);

                Console.WriteLine($"Years since past date: {yearsPassed}");
                Console.WriteLine($"Months since past date: {monthsPassed}");
                Console.WriteLine($"Approximate years and months: {yearsPassed} years, {monthsPassed % 12} months, {remainingDays} days\n");

                // Method 5: Getting specific date components
                Console.WriteLine("Method 5: Getting time between specific date components");
                DateTime today = DateTime.Today;
                DateTime yesterday = today.AddDays(-1);
                DateTime tomorrow = today.AddDays(1);
                DateTime nextWeek = today.AddDays(7);
                DateTime nextMonth = today.AddMonths(1);
                DateTime nextYear = today.AddYears(1);

                Console.WriteLine($"Hours since midnight: {(DateTime.Now - today).TotalHours:F2}");
                Console.WriteLine($"Hours until midnight: {(today.AddDays(1) - DateTime.Now).TotalHours:F2}");
                Console.WriteLine($"Hours until tomorrow: {(tomorrow - DateTime.Now).TotalHours:F2}");
                Console.WriteLine($"Days until next week: {(nextWeek - today).TotalDays:F0}");
                Console.WriteLine($"Days until next month: {(nextMonth - today).Days}");
                Console.WriteLine($"Days until next year: {(nextYear - today).Days}\n");

                // Method 6: Business days calculation
                Console.WriteLine("Method 6: Business days calculation");
                DateTime startDate = new DateTime(2023, 4, 10); // Monday
                DateTime endDate = new DateTime(2023, 4, 21);   // Friday

                int businessDays = CalculateBusinessDays(startDate, endDate);
                Console.WriteLine($"Business days between {startDate:yyyy-MM-dd} and {endDate:yyyy-MM-dd}: {businessDays}");

                Console.WriteLine();
            }

            static void TimeSpanDifferences()
            {
                Console.WriteLine("=== TimeSpan Differences ===");

                // Create sample TimeSpans
                TimeSpan workDay = new TimeSpan(8, 0, 0); // 8 hours
                TimeSpan breakTime = new TimeSpan(0, 30, 0); // 30 minutes
                TimeSpan lunchTime = new TimeSpan(1, 0, 0); // 1 hour
                TimeSpan meetingTime = new TimeSpan(1, 30, 0); // 1 hour 30 minutes

                Console.WriteLine($"Work day duration: {workDay}");
                Console.WriteLine($"Break time: {breakTime}");
                Console.WriteLine($"Lunch time: {lunchTime}");
                Console.WriteLine($"Meeting time: {meetingTime}\n");

                // Method 1: Subtract TimeSpans
                Console.WriteLine("Method 1: Subtract TimeSpans");
                TimeSpan workMinusBreaks = workDay - (breakTime + lunchTime);
                Console.WriteLine($"Work time minus breaks: {workMinusBreaks}");
                Console.WriteLine($"Actual working hours: {workMinusBreaks.TotalHours:F2} hours\n");

                // Method 2: Difference between TimeSpans
                Console.WriteLine("Method 2: Difference between TimeSpans");
                TimeSpan difference = lunchTime - breakTime;
                Console.WriteLine($"Difference between lunch and break: {difference}");
                Console.WriteLine($"Lunch is {difference.TotalMinutes:F0} minutes longer than a break\n");

                // Method 3: Calculate percentage of time
                Console.WriteLine("Method 3: Calculate percentage of time");
                double meetingPercentage = (meetingTime.TotalMinutes / workDay.TotalMinutes) * 100;
                double breakPercentage = (breakTime.TotalMinutes / workDay.TotalMinutes) * 100;
                double lunchPercentage = (lunchTime.TotalMinutes / workDay.TotalMinutes) * 100;
                double productiveTimePercentage = ((workDay - (meetingTime + breakTime + lunchTime)).TotalMinutes / workDay.TotalMinutes) * 100;

                Console.WriteLine($"Meetings take {meetingPercentage:F1}% of work day");
                Console.WriteLine($"Breaks take {breakPercentage:F1}% of work day");
                Console.WriteLine($"Lunch takes {lunchPercentage:F1}% of work day");
                Console.WriteLine($"Productive time is {productiveTimePercentage:F1}% of work day\n");

                // Method 4: Comparing TimeSpans
                Console.WriteLine("Method 4: Comparing TimeSpans");
                Console.WriteLine($"Is meeting longer than lunch? {meetingTime > lunchTime}");
                Console.WriteLine($"Is break shorter than lunch? {breakTime < lunchTime}");
                Console.WriteLine($"Is meeting equal to 1.5 hours? {meetingTime == TimeSpan.FromHours(1.5)}\n");

                // Method 5: Formatting TimeSpan differences
                Console.WriteLine("Method 5: Formatting TimeSpan differences");
                TimeSpan workWeek = TimeSpan.FromHours(40);
                TimeSpan actualWorked = TimeSpan.FromHours(43.5);
                TimeSpan overtime = actualWorked - workWeek;

                Console.WriteLine($"Standard work week: {FormatTimeSpan(workWeek)}");
                Console.WriteLine($"Actual hours worked: {FormatTimeSpan(actualWorked)}");
                Console.WriteLine($"Overtime: {FormatTimeSpan(overtime)}");
                Console.WriteLine($"Overtime in minutes: {overtime.TotalMinutes:F0} minutes");

                Console.WriteLine();
            }

            // Helper methods for working with date differences

            static int CalculateYears(DateTime startDate, DateTime endDate)
            {
                int years = endDate.Year - startDate.Year;

                // Adjust for incomplete years
                if (endDate.Month < startDate.Month ||
                    (endDate.Month == startDate.Month && endDate.Day < startDate.Day))
                {
                    years--;
                }

                return years;
            }

            static int CalculateMonths(DateTime startDate, DateTime endDate)
            {
                return (endDate.Year - startDate.Year) * 12 + endDate.Month - startDate.Month;
            }

            static int CalculateRemainingDays(DateTime startDate, DateTime endDate)
            {
                DateTime tempDate = startDate.AddMonths(CalculateMonths(startDate, endDate));
                return (endDate - tempDate).Days;
            }

            static int CalculateBusinessDays(DateTime startDate, DateTime endDate)
            {
                // Initialize count with number of days between dates
                int businessDays = 0;
                DateTime currentDate = startDate;

                while (currentDate <= endDate)
                {
                    // Check if current day is not Saturday (6) or Sunday (0)
                    if (currentDate.DayOfWeek != DayOfWeek.Saturday && currentDate.DayOfWeek != DayOfWeek.Sunday)
                    {
                        businessDays++;
                    }

                    currentDate = currentDate.AddDays(1);
                }

                return businessDays;
            }

            static string FormatTimeSpan(TimeSpan timeSpan)
            {
                return $"{(int)timeSpan.TotalHours} hours, {timeSpan.Minutes} minutes";
            }
        }

        static void StringBuilder()
        {
            Console.WriteLine("=== String Basics ===");

            // String initialization
            string str1 = "Hello";
            string str2 = "World";
            string str3 = string.Empty; // Same as ""
            string str4 = null;

            Console.WriteLine($"str1: {str1}");
            Console.WriteLine($"str2: {str2}");
            Console.WriteLine($"Empty string: '{str3}'");
            Console.WriteLine($"Null string: {str4 ?? "null"}");

            // String concatenation
            Console.WriteLine("\n=== String Concatenation ===");
            string concatenated1 = str1 + " " + str2;
            string concatenated2 = string.Concat(str1, " ", str2);
            string concatenated3 = $"{str1} {str2}"; // String interpolation

            Console.WriteLine($"Using + operator: {concatenated1}");
            Console.WriteLine($"Using string.Concat: {concatenated2}");
            Console.WriteLine($"Using string interpolation: {concatenated3}");

            // String properties
            Console.WriteLine("\n=== String Properties ===");
            Console.WriteLine($"Length of '{str1}': {str1.Length}");
            Console.WriteLine($"Is str3 empty? {string.IsNullOrEmpty(str3)}");
            Console.WriteLine($"Is str4 null or empty? {string.IsNullOrEmpty(str4)}");
            Console.WriteLine($"Is str3 null or whitespace? {string.IsNullOrWhiteSpace(str3)}");

            // Accessing characters
            Console.WriteLine("\n=== Accessing Characters ===");
            Console.WriteLine($"First character of '{str1}': {str1[0]}");
            Console.WriteLine($"Last character of '{str1}': {str1[^1]}");

            // String comparison
            Console.WriteLine("\n=== String Comparison ===");
            Console.WriteLine($"str1 == 'Hello': {str1 == "Hello"}");
            Console.WriteLine($"str1.Equals('hello'): {str1.Equals("hello")}");
            Console.WriteLine($"str1.Equals('hello', StringComparison.OrdinalIgnoreCase): {str1.Equals("hello", StringComparison.OrdinalIgnoreCase)}");
            Console.WriteLine($"string.Compare(str1, 'hello'): {string.Compare(str1, "hello")}");
            Console.WriteLine($"string.Compare(str1, 'hello', true): {string.Compare(str1, "hello", true)}");

            // String searching
            Console.WriteLine("\n=== String Searching ===");
            string sentence = "The quick brown fox jumps over the lazy dog";
            Console.WriteLine($"Sentence: {sentence}");
            Console.WriteLine($"Contains 'fox': {sentence.Contains("fox")}");
            Console.WriteLine($"Contains 'FOX' (case insensitive): {sentence.Contains("FOX", StringComparison.OrdinalIgnoreCase)}");
            Console.WriteLine($"Starts with 'The': {sentence.StartsWith("The")}");
            Console.WriteLine($"Ends with 'dog': {sentence.EndsWith("dog")}");
            Console.WriteLine($"Index of 'quick': {sentence.IndexOf("quick")}");
            Console.WriteLine($"Last index of 'the': {sentence.LastIndexOf("the")}");

            // Substring
            Console.WriteLine("\n=== Substring Operations ===");
            Console.WriteLine($"Substring(4, 5): {sentence.Substring(4, 5)}"); // "quick"
            Console.WriteLine($"Substring(16): {sentence.Substring(16)}"); // "fox jumps over the lazy dog"

            // String manipulation
            Console.WriteLine("\n=== String Manipulation ===");
            Console.WriteLine($"ToUpper: {sentence.ToUpper()}");
            Console.WriteLine($"ToLower: {sentence.ToLower()}");
            Console.WriteLine($"Replace 'fox' with 'cat': {sentence.Replace("fox", "cat")}");
            Console.WriteLine($"Remove(0, 4): {sentence.Remove(0, 4)}"); // Removes "The "

            // Trimming
            Console.WriteLine("\n=== String Trimming ===");
            string paddedString = "   Hello World   ";
            Console.WriteLine($"Original: '{paddedString}'");
            Console.WriteLine($"Trim: '{paddedString.Trim()}'");
            Console.WriteLine($"TrimStart: '{paddedString.TrimStart()}'");
            Console.WriteLine($"TrimEnd: '{paddedString.TrimEnd()}'");

            // Splitting
            Console.WriteLine("\n=== String Splitting ===");
            string csvLine = "John,Doe,42,New York";
            string[] parts = csvLine.Split(',');
            Console.WriteLine("CSV parts:");
            foreach (var part in parts)
            {
                Console.WriteLine($"  - {part}");
            }

            // Joining
            Console.WriteLine("\n=== String Joining ===");
            string[] words = { "Hello", "World", "C#", "Programming" };
            string joined = string.Join(" ", words);
            Console.WriteLine($"Joined string: {joined}");

            // Format strings
            Console.WriteLine("\n=== String Formatting ===");
            decimal price = 123.45m;
            DateTime now = DateTime.Now;
            Console.WriteLine($"Currency format: {price:C}");
            Console.WriteLine($"Number format with 2 decimals: {price:F2}");
            Console.WriteLine($"Percent format: {0.75:P}");
            Console.WriteLine($"Date format: {now:yyyy-MM-dd}");
            Console.WriteLine($"Time format: {now:HH:mm:ss}");

            // String.Format method
            Console.WriteLine("\n=== String.Format Method ===");
            string formattedString = string.Format("Name: {0}, Age: {1}, City: {2}", "John", 30, "New York");
            Console.WriteLine(formattedString);

            // StringBuilder (for performance when building large strings)
            Console.WriteLine("\n=== StringBuilder Example ===");
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("Hello");
            sb.Append(" ");
            sb.Append("World");
            sb.AppendLine("!");
            sb.AppendFormat("Today is {0:d}", DateTime.Now);
            Console.WriteLine(sb.ToString());

            // String interpolation vs string.Format
            Console.WriteLine("\n=== String Interpolation vs Format ===");
            string name = "John";
            int age = 30;
            string withFormat = string.Format("Name: {0}, Age: {1}", name, age);
            string withInterpolation = $"Name: {name}, Age: {age}";
            Console.WriteLine($"With Format: {withFormat}");
            Console.WriteLine($"With Interpolation: {withInterpolation}");

            // Verbatim strings
            Console.WriteLine("\n=== Verbatim Strings ===");
            string path = "C:\\Program Files\\dotnet";
            string verbatimPath = @"C:\Program Files\dotnet";
            Console.WriteLine($"Regular path: {path}");
            Console.WriteLine($"Verbatim path: {verbatimPath}");
            Console.WriteLine(@"Verbatim strings can span multiple lines without escape characters.");

            // String parsing
            Console.WriteLine("\n=== String Parsing ===");
            string numberStr = "42";
            int number = int.Parse(numberStr);
            Console.WriteLine($"Parsed number: {number}");

            bool parseSuccess = int.TryParse("abc", out int result);
            Console.WriteLine($"Parse 'abc' success: {parseSuccess}, result: {result}");

            // String immutability example
            Console.WriteLine("\n=== String Immutability ===");
            string original = "Hello";
            string modified = original;
            modified += " World"; // Creates a new string, doesn't modify 'original'
            Console.WriteLine($"Original: {original}");
            Console.WriteLine($"Modified: {modified}");

            // Case conversion
            Console.WriteLine("\n=== Case Conversion ===");
            string mixedCase = "ThIs Is MiXeD cAsE";
            Console.WriteLine($"Original: {mixedCase}");
            Console.WriteLine($"ToLower: {mixedCase.ToLower()}");
            Console.WriteLine($"ToUpper: {mixedCase.ToUpper()}");
            Console.WriteLine($"ToLowerInvariant: {mixedCase.ToLowerInvariant()}");
            Console.WriteLine($"ToUpperInvariant: {mixedCase.ToUpperInvariant()}");

            // String padding
            Console.WriteLine("\n=== String Padding ===");
            string shortText = "Hi";
            Console.WriteLine($"Original: '{shortText}'");
            Console.WriteLine($"PadLeft(5): '{shortText.PadLeft(5)}'");
            Console.WriteLine($"PadRight(5): '{shortText.PadRight(5)}'");
            Console.WriteLine($"PadLeft(5, '*'): '{shortText.PadLeft(5, '*')}'");
            Console.WriteLine($"PadRight(5, '*'): '{shortText.PadRight(5, '*')}'");

            // String.IsNullOrEmpty vs String.IsNullOrWhiteSpace
            Console.WriteLine("\n=== IsNullOrEmpty vs IsNullOrWhiteSpace ===");
            string emptyString = "";
            string whitespaceString = "   ";
            Console.WriteLine($"IsNullOrEmpty(emptyString): {string.IsNullOrEmpty(emptyString)}");
            Console.WriteLine($"IsNullOrEmpty(whitespaceString): {string.IsNullOrEmpty(whitespaceString)}");
            Console.WriteLine($"IsNullOrWhiteSpace(emptyString): {string.IsNullOrWhiteSpace(emptyString)}");
            Console.WriteLine($"IsNullOrWhiteSpace(whitespaceString): {string.IsNullOrWhiteSpace(whitespaceString)}");

            //Converting Numbers to Strings
            Console.WriteLine("\n=== Converting Numbers to Strings ===");
            int numberToConvert = 12345;
            string numberString = numberToConvert.ToString();
            string formattedNumber = numberToConvert.ToString("N0"); // Number with commas
            string currencyString = numberToConvert.ToString("C"); // Currency format
            string hexString = numberToConvert.ToString("X"); // Hexadecimal format
            Console.WriteLine($"Number: {numberToConvert}");
            Console.WriteLine($"ToString(): {numberString}");
            Console.WriteLine($"ToString(\"N0\"): {formattedNumber}");
            Console.WriteLine($"ToString(\"C\"): {currencyString}");
            Console.WriteLine($"ToString(\"X\"): {hexString}");

            // Additional formatting examples
            Console.WriteLine("\n=== Additional Number Format Specifiers ===");
            Console.WriteLine($"Scientific notation (E): {numberToConvert.ToString("E")}");
            Console.WriteLine($"Percent (P): {(numberToConvert / 100000.0).ToString("P")}");
            Console.WriteLine($"Fixed-point (F2): {numberToConvert.ToString("F2")}");
            Console.WriteLine($"Custom (#,##0.00): {numberToConvert.ToString("#,##0.00")}");

            // Padding and alignment
            Console.WriteLine("\n=== Padding and Alignment ===");
            Console.WriteLine($"Left-padded to 10 chars: {numberToConvert.ToString().PadLeft(10, '0')}");
            Console.WriteLine($"Right-padded to 10 chars: {numberToConvert.ToString().PadRight(10, '-')}");

            // Culture-aware formatting without specific culture instances
            Console.WriteLine("\n=== Culture-Aware Formatting ===");
            Console.WriteLine($"Current culture currency: {numberToConvert.ToString("C")}");

            // Alternative approach using CultureInfo.InvariantCulture
            Console.WriteLine("\n=== Invariant Culture Formatting ===");
            Console.WriteLine($"Invariant culture: {numberToConvert.ToString("N2", System.Globalization.CultureInfo.InvariantCulture)}");


        }

    }
}