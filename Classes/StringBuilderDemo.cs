using System.Text;

namespace CSharpFundamentals.Classes
{
    internal class StringBuilderDemo
    {
        public static void BuildString()
        {

            var builder = new StringBuilder();

            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);
            builder.Replace('-', '+');
            builder.Remove(0, 10);
            Console.WriteLine(builder);

        }
    }
}