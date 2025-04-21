# C# Fundamentals

This repository contains example code for C# fundamentals.

## Project Structure

After refactoring, the code is organized in the following classes:

### Basic Types & Operations

- `PrimitiveTypesDemo`: Demonstrates primitive types, type conversion, and operators

### Object-Oriented Programming

- `OOPDemo`: Demonstrates classes, objects, and structures
- `Person`: Simple person class with first name and last name properties
- `Calculator`: Static class with basic calculation methods
- `Struct`: Contains RGB color structure

### Collections

- `CollectionsDemo`: Demonstrates arrays and lists
- `CollectionExercises`: Contains exercises with arrays and lists

### Strings

- `StringDemo`: Demonstrates string operations and the StringBuilder class

### Control Flow

- `ControlFlowDemo`: Demonstrates conditionals, loops, and other control structures
- `Season`: Enum for seasons

### Date and Time

- `DateTimeDemo`: Demonstrates DateTime and TimeSpan classes

### Advanced Topics

- `AdvancedTopics`: Contains examples organized into logical sections:
  - HTTP Client operations with async/await
  - LINQ for data querying and transformation
  - File and directory operations
  - Dependency injection patterns and principles

## How to Use

1. Open the solution in Visual Studio or another C# IDE
2. Navigate to `Program.cs`
3. Uncomment the specific demonstration method(s) you want to run
4. Build and run the project

## Requirements

- .NET 9.0 or higher

## Key Features of the Project

- **Nullable Reference Types**: Enabled to promote safer code.
- **Implicit Usings**: Simplifies code by automatically including common namespaces.
- **AOT Compilation**: Configured for Ahead-of-Time (AOT) compilation for improved performance.
- **Docker Support**: Includes Docker configuration for containerized deployment.

## Topics Covered

### 1. Primitive Types

- Demonstrates the use of `byte`, `int`, `float`, `double`, `decimal`, `char`, `bool`, and `string`.
- Shows the range of numeric types using `MinValue` and `MaxValue`.

### 2. Type Conversion

- Implicit and explicit conversions.
- Safe parsing with `int.TryParse`.
- Use of the `Convert` class for type conversion.

### 3. Operators

- Arithmetic, comparison, logical, and assignment operators.
- Ternary operator and null-coalescing operator.

### 4. Control Flow

- Conditional statements (`if-else`, `switch`).
- Loops (`for`, `while`, `do-while`, `foreach`).
- Flow control statements (`break`, `continue`).

### 5. Arrays

- Single-dimensional arrays.
- Multi-dimensional arrays.
- Jagged arrays.

## Contributing

Contributions are welcome! Feel free to fork the repository and submit pull requests with improvements or additional examples.

## License

This project is licensed under the MIT License. See the `LICENSE` file for details.

## Acknowledgments

This project is intended for educational purposes.

---

Happy coding!
