using System.Net.Http.Json;

namespace CSharpFundamentals.Classes
{
    internal class Others
    {
        public static async Task HttpRequestsAsync()
        {
            Console.WriteLine("\n=== Asynchronous HTTP Requests ===");

            // Create an HttpClient (typically you'd use a singleton in real applications)
            using var client = new HttpClient();

            try
            {
                // Make a GET request and await the response
                Console.WriteLine("Making GET request to JSONPlaceholder API...");
                var response = await client.GetAsync("https://jsonplaceholder.typicode.com/todos/1");

                // Ensure success status code or throw
                response.EnsureSuccessStatusCode();

                // Read response content as string
                var responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Response:\n{responseBody}");

                // Parse response as JSON directly
                var todoItem = await client.GetFromJsonAsync<TodoItem>("https://jsonplaceholder.typicode.com/todos/2");
                Console.WriteLine($"\nTodo Item #{todoItem?.Id}: {todoItem?.Title}");
                Console.WriteLine($"Completed: {todoItem?.Completed}");

                // POST request with JSON content
                var newTodo = new TodoItem
                {
                    UserId = 1,
                    Title = "Learn advanced C#",
                    Completed = false
                };

                var postResponse = await client.PostAsJsonAsync("https://jsonplaceholder.typicode.com/todos", newTodo);
                postResponse.EnsureSuccessStatusCode();

                var returnedTodo = await postResponse.Content.ReadFromJsonAsync<TodoItem>();
                Console.WriteLine($"\nCreated Todo with ID: {returnedTodo?.Id}");
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
            public string Title { get; set; }
            public bool Completed { get; set; }
        }

        public static void LinqExamples()
        {
            Console.WriteLine("\n=== LINQ Examples ===");

            // Sample data
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 1200, Category = "Electronics" },
                new Product { Id = 2, Name = "Desk Chair", Price = 250, Category = "Furniture" },
                new Product { Id = 3, Name = "Headphones", Price = 100, Category = "Electronics" },
                new Product { Id = 4, Name = "Monitor", Price = 350, Category = "Electronics" },
                new Product { Id = 5, Name = "Coffee Table", Price = 200, Category = "Furniture" },
                new Product { Id = 6, Name = "Smartphone", Price = 800, Category = "Electronics" },
                new Product { Id = 7, Name = "Bookshelf", Price = 150, Category = "Furniture" }
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
            Console.WriteLine($"Most Expensive Item: {mostExpensive?.Name} (${mostExpensive?.Price})");

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
            Console.WriteLine($"\nFound laptop? {(laptop != null ? $"Yes, price: ${laptop.Price}" : "No")}");

            // Any - check if any item matches a condition
            var hasAffordableFurniture = products.Any(p => p.Category == "Furniture" && p.Price < 200);
            Console.WriteLine($"Has affordable furniture: {hasAffordableFurniture}");

            // All - check if all items match a condition
            var allProductsHaveNames = products.All(p => !string.IsNullOrEmpty(p.Name));
            Console.WriteLine($"All products have names: {allProductsHaveNames}");
        }

        private class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
            public string Category { get; set; }
        }

        public static void FileOperations()
        {
            Console.WriteLine("\n=== File I/O Operations ===");

            var directory = Path.Combine(Path.GetTempPath(), "CSharpDemoFiles");
            var textFile = Path.Combine(directory, "sample.txt");
            var csvFile = Path.Combine(directory, "data.csv");

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
                    "And finally a third line to demonstrate file writing."
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
                    ["3", "Bob", "45"]
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

                // Work with FileStream for more control
                Console.WriteLine("\nUsing FileStream to write binary data");
                using (var fs = new FileStream(Path.Combine(directory, "binary.dat"), FileMode.Create))
                {
                    byte[] data = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
                    fs.Write(data, 0, data.Length);
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
                    Console.WriteLine($"\nFiles kept at: {directory}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }


        // Interfaces
        private interface ILogger
        {
            void Log(string message);
        }

        private interface IEmailService
        {
            void SendEmail(string to, string subject, string body);
        }

        // Implementations
        private class ConsoleLogger : ILogger
        {
            public void Log(string message)
            {
                Console.WriteLine($"[LOG] {DateTime.Now}: {message}");
            }
        }

        private class EmailService(ILogger logger) : IEmailService
        {
            // Constructor injection

            public void SendEmail(string to, string subject, string body)
            {
                // In a real app, this would send an actual email
                logger.Log($"Sending email to {to} with subject: {subject}");
                Console.WriteLine($"Email sent to {to}");
            }
        }

        // Service that uses both dependencies
        private class UserService(ILogger logger, IEmailService emailService)
        {
            public void RegisterUser(string username, string email)
            {
                // Registration logic would go here
                logger.Log($"Registering new user: {username}");

                // Send welcome email
                emailService.SendEmail(
                    email,
                    "Welcome to our service!",
                    $"Hi {username}, thanks for registering with us."
                );

                logger.Log($"User {username} registered successfully");
            }
        }

        public static void DependencyInjectionExample()
        {
            Console.WriteLine("\n=== Dependency Injection Example ===");

            // Manual dependency injection (in real apps, you'd use a DI container)
            ILogger logger = new ConsoleLogger();
            IEmailService emailService = new EmailService(logger);

            var userService = new UserService(logger, emailService);

            // Use the service
            userService.RegisterUser("john_doe", "john@example.com");
        }
    }
}
