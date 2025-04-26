using System.Text;

namespace CSharpFundamentals.Classes
{
    internal class StringBuilderDemo
    {
        public static void BuildString()
        {
            //StringBuilder is just all about manipulating strings
            var builder = new StringBuilder("Hello World"); // You can Initialize a StringBuilder with a string

            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0, 10)
                .Insert(0, new string('-', 10));

            Console.WriteLine(builder);

            //using the build string

            Console.WriteLine("First Char " + builder[0]);
        }
    }
}
