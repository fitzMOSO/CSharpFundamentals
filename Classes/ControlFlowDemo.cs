using System;
using CSharpFundamentals.Enums;

namespace CSharpFundamentals.Classes
{
    public class ControlFlowDemo
    {
        public static void ShowControlFlow()
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
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
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
            Console.WriteLine(
                $"Price for {(isGoldCustomer ? "gold" : "regular")} customer: ${price}"
            );

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

        public static void ShowRandomClass()
        {
            const int passwordLength = 10;

            var random = new Random();
            var buffer = new char[passwordLength];
            for (int i = 0; i < passwordLength; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));
            var password = new string(buffer);

            Console.WriteLine(password);
        }

        public static void ShowControlFlowExercises()
        {
            Exercise1();
            Exercise2();
            Exercise3();
            Exercise4();
            Exercise5();
        }

        private static void Exercise1()
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

        private static void Exercise2()
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

        private static void Exercise3()
        {
            Console.Write("Enter the number of times to repeat: ");
            int number = Convert.ToInt32(Console.ReadLine());

            var factorial = 1;
            for (int i = 1; i <= number; i++)
                factorial *= i;
            Console.WriteLine("{0}! = {1}", number, factorial);
        }

        private static void Exercise4()
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

        private static void Exercise5()
        {
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
}