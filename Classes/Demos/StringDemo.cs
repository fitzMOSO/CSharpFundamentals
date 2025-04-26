namespace CSharpFundamentals.Classes
{
    public class StringDemo
    {
        public static void ShowStrings()
        {
            Console.WriteLine("\n=== String Operations ===");

            var color = new Struct.RgbColor
            {
                Red = 255,
                Green = 0,
                Blue = 0,
            };

            // Different ways to format strings
            Console.WriteLine("String formatting:");
            var stringFormat = string.Format(
                "Color: {0}, {1}, {2}",
                color.Red,
                color.Green,
                color.Blue
            );
            var stringInterpolation = $"Color: {color.Red}, {color.Green}, {color.Blue}";
            var stringConcatenation =
                "Color: " + color.Red + ", " + color.Green + ", " + color.Blue;

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

        public static void ShowStringBuilder()
        {
            Console.WriteLine("=== String Basics ===");

            // String initialization
            string str1 = "Hello";
            string str2 = "World";
            string str3 = string.Empty; // Same as ""
            string? str4 = null;

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
            Console.WriteLine(
                $"str1.Equals('hello', StringComparison.OrdinalIgnoreCase): {str1.Equals("hello", StringComparison.OrdinalIgnoreCase)}"
            );
            Console.WriteLine($"string.Compare(str1, 'hello'): {string.Compare(str1, "hello")}");
            Console.WriteLine(
                $"string.Compare(str1, 'hello', true): {string.Compare(str1, "hello", true)}"
            );

            // String searching
            Console.WriteLine("\n=== String Searching ===");
            string sentence = "The quick brown fox jumps over the lazy dog";
            Console.WriteLine($"Sentence: {sentence}");
            Console.WriteLine($"Contains 'fox': {sentence.Contains("fox")}");
            Console.WriteLine(
                $"Contains 'FOX' (case insensitive): {sentence.Contains("FOX", StringComparison.OrdinalIgnoreCase)}"
            );
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
            string formattedString = string.Format(
                "Name: {0}, Age: {1}, City: {2}",
                "John",
                30,
                "New York"
            );
            Console.WriteLine(formattedString);

            // StringBuilderDemo (for performance when building large strings)
            Console.WriteLine("\n=== StringBuilderDemo Example ===");
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
            Console.WriteLine(
                @"Verbatim strings can span multiple lines without escape characters."
            );

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
            Console.WriteLine(
                $"IsNullOrEmpty(whitespaceString): {string.IsNullOrEmpty(whitespaceString)}"
            );
            Console.WriteLine(
                $"IsNullOrWhiteSpace(emptyString): {string.IsNullOrWhiteSpace(emptyString)}"
            );
            Console.WriteLine(
                $"IsNullOrWhiteSpace(whitespaceString): {string.IsNullOrWhiteSpace(whitespaceString)}"
            );

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
            Console.WriteLine(
                $"Left-padded to 10 chars: {numberToConvert.ToString().PadLeft(10, '0')}"
            );
            Console.WriteLine(
                $"Right-padded to 10 chars: {numberToConvert.ToString().PadRight(10, '-')}"
            );

            // Culture-aware formatting without specific culture instances
            Console.WriteLine("\n=== Culture-Aware Formatting ===");
            Console.WriteLine($"Current culture currency: {numberToConvert.ToString("C")}");

            // Alternative approach using CultureInfo.InvariantCulture
            Console.WriteLine("\n=== Invariant Culture Formatting ===");
            Console.WriteLine(
                $"Invariant culture: {numberToConvert.ToString("N2", System.Globalization.CultureInfo.InvariantCulture)}"
            );
        }
    }
}