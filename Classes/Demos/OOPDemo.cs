namespace CSharpFundamentals.Classes
{
    public class OOPDemo
    {
        public static void ShowClasses()
        {
            Console.WriteLine("\n=== Classes and Objects ===");

            // Classes
            Person fitz = new Person { FirstName = "Fitz", LastName = "Moso" };
            fitz.Introduce();

            Person john = new Person { FirstName = "John", LastName = "Doe" };
            john.Introduce();

            // Static methods
            const int value1 = 5;
            const int value2 = 10;

            int sum = Calculator.Add(value1, value2);
            int difference = Calculator.Subtract(value1, value2);
            double quotient = Calculator.Divide(value1, value2);
            int product = Calculator.Multiply(value1, value2);

            Console.WriteLine(
                $"Addition: {sum}, Subtraction: {difference}, Division: {quotient}, Multiplication: {product}"
            );
        }

        public static void ShowStructs()
        {
            Console.WriteLine("\n=== Structs ===");

            var color = new Struct.RgbColor
            {
                Red = 255,
                Green = 0,
                Blue = 0,
            };

            Console.WriteLine($"Color: R:{color.Red}, G:{color.Green}, B:{color.Blue}");
        }
    }
}