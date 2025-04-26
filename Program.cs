using System.Diagnostics.CodeAnalysis;
using CSharpFundamentals.Classes;

namespace CSharpFundamentals
{
    class Program
    {
        [RequiresUnreferencedCode(
            "Calls CSharpFundamentals.Classes.AdvancedTopics.HttpClientDemoAsync()"
        )]
        [RequiresDynamicCode(
            "Calls CSharpFundamentals.Classes.AdvancedTopics.HttpClientDemoAsync()"
        )]
        static void Main(string[] args)
        {
            Console.WriteLine("C# Fundamentals");
            Console.WriteLine("==========================================");

            // Uncomment the method you want to run

            //// Basic Types & Operations
            //PrimitiveTypesDemo.ShowPrimitiveTypes(); // Shows basic C# data types and their ranges
            //PrimitiveTypesDemo.ShowTypeConversion(); // Demonstrates implicit, explicit and user-defined conversions
            //PrimitiveTypesDemo.ShowOperators(); // Demonstrates arithmetic, logical, comparison and special operators

            //// Object-Oriented Programming
            //OOPDemo.ShowClasses(); // Demonstrates class instantiation and usage of methods
            //OOPDemo.ShowStructs(); // Structs are value types, classes are reference types

            //// Collections
            //CollectionsDemo.ShowArrays(); // Shows basic array usage with different types
            //CollectionsDemo.ShowArraysDetailed(); // Demonstrates multi-dimensional arrays, jagged arrays and array methods
            //CollectionsDemo.ShowLists(); // Shows List<T> operations like Add, Remove, Find, etc.
            //CollectionExercises.ShowArraysAndListsExercises(); // Practical exercises using arrays and lists

            //// Strings
            //StringDemo.ShowStrings(); // Demonstrates string operations and formatting
            //StringDemo.ShowStringBuilder(); // Shows StringBuilderDemo for efficient string manipulation

            //// Control Flow
            //ControlFlowDemo.ShowControlFlow(); // Shows if-else, switch, loops, and other flow control
            //ControlFlowDemo.ShowRandomClass(); // Demonstrates the Random class for generating random values
            //ControlFlowDemo.ShowControlFlowExercises(); // Practical exercises for control flow statements

            //// Date and Time
            //DateTimeDemo.ShowDateTimeAndTimeSpan(); // Shows DateTime and TimeSpan operations and formatting

            //// Advanced Topics
            //_ = AdvancedTopics.HttpClientDemoAsync(); // Demonstrates async HTTP operations with HttpClient
            //AdvancedTopics.LinqDemo(); // Shows LINQ queries for data manipulation and transformation
            //AdvancedTopics.FileOperationsDemo(); // Demonstrates file and directory creation and management
            //AdvancedTopics.DependencyInjectionDemo(); // Shows basic dependency injection patterns and principles

            // Working with Text
            //var summary = SummarizingText.SummarizeText(LoremIpsum.GenerateWords(35), 21); // Demonstrates text summarization
            //Console.WriteLine(summary);
            //StringBuilderDemo.BuildString();

            //Working with Files
            // FileDemo.RunExamples(); // Demonstrates file reading, writing, and directory operations
            // FileDemo.RunFileSystemExamples();
            PathDemo.RunPathExamples(); // Shows path manipulation and file system operations
        }
    }
}
