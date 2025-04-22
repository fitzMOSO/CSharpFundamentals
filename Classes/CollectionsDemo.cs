namespace CSharpFundamentals.Classes
{
    public class CollectionsDemo
    {
        public static void ShowArrays()
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

        public static void ShowArraysDetailed()
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
                { 7, 8, 9 },
            };

            // Alternative Rectangular array initialization
            int[,] grid =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 },
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

        public static void ShowLists()
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
    }
}