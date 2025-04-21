using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace CSharpFundamentals.Classes
{
    /// <summary>
    /// Contains demonstrations of advanced C# topics
    /// </summary>
    public class AdvancedTopics
    {
        #region HTTP Client
        /// <summary>
        /// Demonstrates HTTP client operations using async/await pattern
        /// </summary>
        [RequiresUnreferencedCode(
            "JSON serialization and deserialization might require types that cannot be statically analyzed"
        )]
        [RequiresDynamicCode(
            "JSON serialization and deserialization might require types that cannot be statically analyzed"
        )]
        public static async Task HttpClientDemoAsync()
        {
            Console.WriteLine("\n=== Asynchronous HTTP Requests with HttpClient ===");

            // Note: In production code with AOT compilation, you should:
            // 1. Define a JsonSerializerContext derived class
            // 2. Use the JsonTypeInfo<T> overloads of HttpClient JSON methods
            // Example:
            //   [JsonSourceGenerationOptions(WriteIndented = true)]
            //   [JsonSerializable(typeof(TodoItem))]
            //   internal partial class JsonContext : JsonSerializerContext {}
            //
            //   // Then use with:
            //   var todoItem = await client.GetFromJsonAsync("url", JsonContext.Default.TodoItem);

            // Create an HttpClient (typically you'd use a singleton in real applications)
            using var client = new HttpClient();

            try
            {
                // Make a GET request and await the response
                Console.WriteLine("Making GET request to JSONPlaceholder API...");
                var response = await client.GetAsync(
                    "https://jsonplaceholder.typicode.com/todos/1"
                );

                // Ensure success status code or throw
                response.EnsureSuccessStatusCode();

                // Read response content as string
                var responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Response:\n{responseBody}");

                // Parse response as JSON directly
                var todoItem = await client.GetFromJsonAsync<TodoItem>(
                    "https://jsonplaceholder.typicode.com/todos/2"
                );
                Console.WriteLine($"\nTodo Item #{todoItem?.Id}: {todoItem?.Title}");
                Console.WriteLine($"Completed: {todoItem?.Completed}");

                // POST request with JSON content
                var newTodo = new TodoItem
                {
                    UserId = 1,
                    Title = "Learn advanced C#",
                    Completed = false,
                };

                var postResponse = await client.PostAsJsonAsync(
                    "https://jsonplaceholder.typicode.com/todos",
                    newTodo
                );
                postResponse.EnsureSuccessStatusCode();

                var returnedTodo = await postResponse.Content.ReadFromJsonAsync<TodoItem>();
                Console.WriteLine($"\nCreated Todo with ID: {returnedTodo?.Id}");

                // Additional examples for PUT and DELETE
                Console.WriteLine("\nAdditional HTTP methods:");

                // PUT request to update an existing resource
                var updatedTodo = new TodoItem
                {
                    Id = 1,
                    UserId = 1,
                    Title = "Updated todo item",
                    Completed = true,
                };

                var putResponse = await client.PutAsJsonAsync(
                    "https://jsonplaceholder.typicode.com/todos/1",
                    updatedTodo
                );
                putResponse.EnsureSuccessStatusCode();
                Console.WriteLine("PUT request successful");

                // DELETE request to remove a resource
                var deleteResponse = await client.DeleteAsync(
                    "https://jsonplaceholder.typicode.com/todos/1"
                );
                deleteResponse.EnsureSuccessStatusCode();
                Console.WriteLine("DELETE request successful");
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Request error: {e.Message}");
            }
        }

        // Class to match the JSON structure
        private class TodoItem
        {
            public int Id { get; set; }
            public int UserId { get; set; }
            public required string Title { get; set; }
            public bool Completed { get; set; }
        }
        #endregion

        #region LINQ
        /// <summary>
        /// Demonstrates LINQ (Language Integrated Query) operations
        /// </summary>
        public static void LinqDemo()
        {
            Console.WriteLine("\n=== LINQ (Language Integrated Query) Examples ===");

            // Sample data
            var products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Laptop",
                    Price = 1200,
                    Category = "Electronics",
                },
                new Product
                {
                    Id = 2,
                    Name = "Desk Chair",
                    Price = 250,
                    Category = "Furniture",
                },
                new Product
                {
                    Id = 3,
                    Name = "Headphones",
                    Price = 100,
                    Category = "Electronics",
                },
                new Product
                {
                    Id = 4,
                    Name = "Monitor",
                    Price = 350,
                    Category = "Electronics",
                },
                new Product
                {
                    Id = 5,
                    Name = "Coffee Table",
                    Price = 200,
                    Category = "Furniture",
                },
                new Product
                {
                    Id = 6,
                    Name = "Smartphone",
                    Price = 800,
                    Category = "Electronics",
                },
                new Product
                {
                    Id = 7,
                    Name = "Bookshelf",
                    Price = 150,
                    Category = "Furniture",
                },
            };

            // Basic filtering - Method syntax
            var expensiveItems = products.Where(p => p.Price > 300);
            Console.WriteLine("Expensive items (method syntax):");
            foreach (var item in expensiveItems)
                Console.WriteLine($"- {item.Name}: ${item.Price}");

            // Equivalent query syntax
            var expensiveItemsQuery =
                from product in products
                where product.Price > 300
                select product;

            Console.WriteLine("\nExpensive items (query syntax):");
            foreach (var item in expensiveItemsQuery)
                Console.WriteLine($"- {item.Name}: ${item.Price}");

            // Ordering
            var orderedByPrice = products.OrderBy(p => p.Price);
            Console.WriteLine("\nProducts ordered by price:");
            foreach (var item in orderedByPrice)
                Console.WriteLine($"- {item.Name}: ${item.Price}");

            // Selecting specific properties (projection)
            var productNames = products.Select(p => p.Name);
            Console.WriteLine("\nJust the product names:");
            foreach (var name in productNames)
                Console.WriteLine($"- {name}");

            // Grouping
            var groupedByCategory = products.GroupBy(p => p.Category);
            Console.WriteLine("\nProducts grouped by category:");
            foreach (var group in groupedByCategory)
            {
                Console.WriteLine($"Category: {group.Key}");
                foreach (var item in group)
                    Console.WriteLine($"  - {item.Name}: ${item.Price}");
            }

            // Aggregation functions
            var averagePrice = products.Average(p => p.Price);
            var totalValue = products.Sum(p => p.Price);
            var mostExpensive = products.MaxBy(p => p.Price);

            Console.WriteLine($"\nAverage Price: ${averagePrice}");
            Console.WriteLine($"Total Inventory Value: ${totalValue}");
            Console.WriteLine(
                $"Most Expensive Item: {mostExpensive?.Name} (${mostExpensive?.Price})"
            );

            // Combining multiple operations
            var top3Electronics = products
                .Where(p => p.Category == "Electronics")
                .OrderByDescending(p => p.Price)
                .Take(3);

            Console.WriteLine("\nTop 3 most expensive electronics:");
            foreach (var item in top3Electronics)
                Console.WriteLine($"- {item.Name}: ${item.Price}");

            // FirstOrDefault with predicate
            var laptop = products.FirstOrDefault(p => p.Name == "Laptop");
            Console.WriteLine(
                $"\nFound laptop? {(laptop != null ? $"Yes, price: ${laptop.Price}" : "No")}"
            );

            // Any - check if any item matches a condition
            var hasAffordableFurniture = products.Any(p =>
                p.Category == "Furniture" && p.Price < 200
            );
            Console.WriteLine($"Has affordable furniture: {hasAffordableFurniture}");

            // All - check if all items match a condition
            var allProductsHaveNames = products.All(p => !string.IsNullOrEmpty(p.Name));
            Console.WriteLine($"All products have names: {allProductsHaveNames}");
        }

        private class Product
        {
            public int Id { get; set; }
            public required string Name { get; set; }
            public double Price { get; set; }
            public required string Category { get; set; }
        }
        #endregion

        #region File Operations
        /// <summary>
        /// Demonstrates file and directory operations
        /// </summary>
        public static void FileOperationsDemo()
        {
            Console.WriteLine("\n=== File and Directory Operations ===");

            var directory = Path.Combine(Path.GetTempPath(), "CSharpDemoFiles");
            var textFile = Path.Combine(directory, "sample.txt");
            var csvFile = Path.Combine(directory, "data.csv");
            var binaryFile = Path.Combine(directory, "binary.dat");

            try
            {
                // Create directory if it doesn't exist
                if (!Directory.Exists(directory))
                    Directory.CreateDirectory(directory);

                Console.WriteLine($"Working directory: {directory}");

                // Writing text to a file
                string[] lines =
                [
                    "This is the first line of our sample file.",
                    "Here's the second line with some text.",
                    "And finally a third line to demonstrate file writing.",
                ];

                File.WriteAllLines(textFile, lines);
                Console.WriteLine($"Created text file: {textFile}");

                // Reading from a text file
                Console.WriteLine("\nReading text file line by line:");
                foreach (var line in File.ReadAllLines(textFile))
                {
                    Console.WriteLine($"  > {line}");
                }

                // Appending to a file
                File.AppendAllText(textFile, "\nThis line was appended later.");

                // Reading entire file
                var entireFile = File.ReadAllText(textFile);
                Console.WriteLine($"\nEntire file content:\n{entireFile}");

                // Working with CSV data
                string[][] csvData =
                [
                    ["ID", "Name", "Age"],
                    ["1", "John", "30"],
                    ["2", "Jane", "25"],
                    ["3", "Bob", "45"],
                ];

                // Convert to CSV format and write
                var csvLines = csvData.Select(row => string.Join(",", row)).ToList();
                File.WriteAllLines(csvFile, csvLines);
                Console.WriteLine($"\nCreated CSV file: {csvFile}");

                // Reading and parsing CSV
                Console.WriteLine("\nReading and parsing CSV data:");
                var csvFileLines = File.ReadAllLines(csvFile);
                for (var i = 0; i < csvFileLines.Length; i++)
                {
                    var fields = csvFileLines[i].Split(',');
                    if (i == 0)
                    {
                        Console.WriteLine($"Header: {string.Join(" | ", fields)}");
                        Console.WriteLine(new string('-', 30));
                    }
                    else
                    {
                        Console.WriteLine($"Row {i}: {string.Join(" | ", fields)}");
                    }
                }

                // File information
                var fileInfo = new FileInfo(textFile);
                Console.WriteLine($"\nFile information for {fileInfo.Name}:");
                Console.WriteLine($"Size: {fileInfo.Length} bytes");
                Console.WriteLine($"Created: {fileInfo.CreationTime}");
                Console.WriteLine($"Last modified: {fileInfo.LastWriteTime}");

                // Using Stream for more control
                Console.WriteLine("\nUsing FileStream to write binary data");
                using (var fs = new FileStream(binaryFile, FileMode.Create))
                {
                    byte[] data = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
                    fs.Write(data, 0, data.Length);
                }

                // Stream reading with BinaryReader
                Console.WriteLine("\nReading binary file with BinaryReader:");
                using (var fs = new FileStream(binaryFile, FileMode.Open))
                using (var reader = new BinaryReader(fs))
                {
                    byte[] buffer = reader.ReadBytes(10);
                    Console.WriteLine($"Binary data: {BitConverter.ToString(buffer)}");
                }

                // Using StreamWriter for text
                Console.WriteLine("\nUsing StreamWriter for UTF-8 encoding:");
                using (
                    var writer = new StreamWriter(
                        Path.Combine(directory, "utf8.txt"),
                        false,
                        Encoding.UTF8
                    )
                )
                {
                    writer.WriteLine("This is a UTF-8 encoded text file.");
                    writer.WriteLine("It supports characters like: äöü and 你好.");
                }

                // Clean up created files
                Console.WriteLine("\nDo you want to delete the created files? (y/n)");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    Directory.Delete(directory, true);
                    Console.WriteLine("\nFiles deleted successfully.");
                }
                else
                {
                    Console.WriteLine("\nFiles retained. You can find them at: " + directory);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError: {ex.Message}");
            }
        }
        #endregion

        #region Dependency Injection
        /// <summary>
        /// Demonstrates basic dependency injection principles
        /// </summary>
        public static void DependencyInjectionDemo()
        {
            Console.WriteLine("\n=== Dependency Injection Example ===");
            Console.WriteLine("Creating dependencies and services with manual DI:");

            // Create the dependencies
            ILogger logger = new ConsoleLogger();
            IEmailService emailService = new EmailService(logger);

            // Create the service that depends on other services
            var userService = new UserService(logger, emailService);

            // Use the service
            userService.RegisterUser("johndoe", "john@example.com");

            Console.WriteLine("\nThis demonstrates dependency injection principles:");
            Console.WriteLine("1. Dependencies are created outside the consuming class");
            Console.WriteLine(
                "2. Dependencies are provided via constructor ('Constructor Injection')"
            );
            Console.WriteLine(
                "3. Classes depend on abstractions (interfaces) not concrete implementations"
            );
            Console.WriteLine("4. This enables easier testing and changing implementations");

            Console.WriteLine(
                "\nIn real applications, you would typically use a DI container like:"
            );
            Console.WriteLine("- Microsoft.Extensions.DependencyInjection");
            Console.WriteLine("- Autofac");
            Console.WriteLine("- Ninject");
            Console.WriteLine(
                "Which would automate the creation and lifetime management of dependencies."
            );
        }

        // Interface definitions
        private interface ILogger
        {
            void Log(string message);
        }

        private interface IEmailService
        {
            void SendEmail(string to, string subject, string body);
        }

        // Implementation classes
        private class ConsoleLogger : ILogger
        {
            public void Log(string message)
            {
                Console.WriteLine($"[LOG] {DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}");
            }
        }

        private class EmailService : IEmailService
        {
            private readonly ILogger _logger;

            public EmailService(ILogger logger)
            {
                _logger = logger;
            }

            public void SendEmail(string to, string subject, string body)
            {
                // In a real app, this would send an actual email
                _logger.Log($"Sending email to {to} with subject '{subject}'");
                Console.WriteLine($"Email sent to: {to}");
            }
        }

        private class UserService
        {
            private readonly ILogger _logger;
            private readonly IEmailService _emailService;

            public UserService(ILogger logger, IEmailService emailService)
            {
                _logger = logger;
                _emailService = emailService;
            }

            public void RegisterUser(string username, string email)
            {
                // In a real app, this would save the user to a database
                _logger.Log($"Registering new user: {username}");

                // Send welcome email
                _emailService.SendEmail(
                    email,
                    "Welcome to our service!",
                    $"Hello {username}, thank you for registering with us."
                );

                Console.WriteLine($"User {username} registered successfully!");
            }
        }
        #endregion
    }
}
