namespace CSharpFundamentals.Classes
{
    internal class FileDemo
    {
        // public static void RunExamples()
        // {
        //     var path1 = Directory.CreateDirectory(
        //         @"C:\Users\fitzg\OneDrive\Desktop\Git_Repositories_Local\C# Repos\temp-directory1"
        //     );
        //     ;
        //     var path2 = Directory.CreateDirectory(
        //         @"C:\Users\fitzg\OneDrive\Desktop\Git_Repositories_Local\C# Repos\temp-directory2"
        //     );
        //     ;

        //     //File.Copy(@"c:\temp\my-file.jpg", @"d:\temp\my-file.jpg", true);
        //     //File.Move(@"c:\temp\my-file.jpg", @"d:\temp\my-file.jpg");
        //     //File.Delete(path);
        //     if (File.Exists(path1.ToString()))
        //     {
        //         Console.WriteLine("File exists");
        //     }
        //     else
        //     {
        //         Console.WriteLine("File does not exist");
        //     }

        //     //var files = Directory.GetFiles(@"C:\Users\fitzg\OneDrive\Desktop\Git_Repositories_Local\C# Repos", "*.sln", SearchOption.AllDirectories);
        //     //foreach (var file in files)
        //     //    Console.WriteLine(file);

        //     var directories = Directory.GetDirectories(
        //         @"C:\Users\fitzg\OneDrive\Desktop\Git_Repositories_Local\C# Repos",
        //         "*.*",
        //         SearchOption.AllDirectories
        //     );
        //     foreach (var directory in directories)
        //         Console.WriteLine(directory);
        // }

        public static void RunFileSystemExamples()
        {
            Console.WriteLine("===== File System Operations Examples =====\n");

            // Define base paths for examples
            string basePath = @"C:\Users\fitzg\OneDrive\Desktop\Git_Repositories_Local\C# Repos";
            string tempDir1 = Path.Combine(basePath, "temp-directory1");
            string tempDir2 = Path.Combine(basePath, "temp-directory2");
            string tempFile1 = Path.Combine(tempDir1, "example.txt");
            string tempFile2 = Path.Combine(tempDir2, "example-copy.txt");

            try
            {
                // Directory creation examples
                Console.WriteLine("--- Directory Operations ---");
                DirectoryOperations(tempDir1, tempDir2);

                // File operations examples
                Console.WriteLine("\n--- File Operations ---");
                FileOperations(tempDir1, tempDir2, tempFile1, tempFile2);

                // File info and directory info examples
                Console.WriteLine("\n--- FileInfo and DirectoryInfo Examples ---");
                FileAndDirectoryInfoExamples(tempFile1, tempDir1);

                // Path manipulation examples
                Console.WriteLine("\n--- Path Manipulation Examples ---");
                PathManipulationExamples(tempFile1);

                // Search operations
                Console.WriteLine("\n--- Search Operations ---");
                SearchOperations(basePath);

                // File streams examples
                Console.WriteLine("\n--- File Stream Examples ---");
                FileStreamExamples(tempFile1);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                // Clean up created directories (uncomment if needed)
                // CleanupDirectories(tempDir1, tempDir2);
            }
        }

        private static void DirectoryOperations(string dir1, string dir2)
        {
            // Create directories if they don't exist
            if (!Directory.Exists(dir1))
            {
                var dirInfo1 = Directory.CreateDirectory(dir1);
                Console.WriteLine($"Created directory: {dirInfo1.FullName}");
            }
            else
            {
                Console.WriteLine($"Directory already exists: {dir1}");
            }

            if (!Directory.Exists(dir2))
            {
                var dirInfo2 = Directory.CreateDirectory(dir2);
                Console.WriteLine($"Created directory: {dirInfo2.FullName}");
            }

            // Directory existence check
            Console.WriteLine($"Directory exists check: {Directory.Exists(dir1)}");

            // Get creation time
            DateTime creationTime = Directory.GetCreationTime(dir1);
            Console.WriteLine($"Directory creation time: {creationTime}");

            // Get parent directory
            string parentDir = Directory.GetParent(dir1)?.FullName ?? "No parent directory";
            Console.WriteLine($"Parent directory: {parentDir}");

            // Get directory attributes
            var attributes = File.GetAttributes(dir1);
            Console.WriteLine($"Directory attributes: {attributes}");
        }

        private static void FileOperations(string dir1, string dir2, string file1, string file2)
        {
            // Create a sample file
            using (StreamWriter sw = File.CreateText(file1))
            {
                sw.WriteLine("This is an example file.");
                sw.WriteLine("Created for demonstrating C# file operations.");
                sw.WriteLine($"Created at: {DateTime.Now}");
            }
            Console.WriteLine($"Created file: {file1}");

            // File existence check
            bool fileExists = File.Exists(file1);
            Console.WriteLine($"File exists: {fileExists}");

            // Read all text
            string content = File.ReadAllText(file1);
            Console.WriteLine($"File content:\n{content}");

            // Copy file
            File.Copy(file1, file2, true);
            Console.WriteLine($"Copied file to {file2}");

            // Append text
            File.AppendAllText(file2, $"Appended text at: {DateTime.Now}\n");
            Console.WriteLine($"Appended text to {file2}");

            // Read all lines
            string[] lines = File.ReadAllLines(file2);
            Console.WriteLine($"File has {lines.Length} lines");

            // File move example (commented to preserve examples)
            // File.Move(file2, Path.Combine(dir1, "moved-file.txt"), true);
            // Console.WriteLine("Moved file");

            // File deletion example (commented to preserve examples)
            // File.Delete(file2);
            // Console.WriteLine($"Deleted file: {file2}");
        }

        private static void FileAndDirectoryInfoExamples(string filePath, string dirPath)
        {
            // FileInfo examples
            FileInfo fileInfo = new FileInfo(filePath);
            Console.WriteLine($"File name: {fileInfo.Name}");
            Console.WriteLine($"File size: {fileInfo.Length} bytes");
            Console.WriteLine($"File extension: {fileInfo.Extension}");
            Console.WriteLine($"Creation time: {fileInfo.CreationTime}");
            Console.WriteLine($"Last access time: {fileInfo.LastAccessTime}");
            Console.WriteLine($"Last write time: {fileInfo.LastWriteTime}");
            Console.WriteLine($"Is read-only: {fileInfo.IsReadOnly}");

            // DirectoryInfo examples
            DirectoryInfo dirInfo = new DirectoryInfo(dirPath);
            Console.WriteLine($"Directory name: {dirInfo.Name}");
            Console.WriteLine($"Full path: {dirInfo.FullName}");
            Console.WriteLine($"Parent: {dirInfo.Parent?.Name ?? "No parent"}");
            Console.WriteLine($"Root: {dirInfo.Root}");
            Console.WriteLine($"Creation time: {dirInfo.CreationTime}");

            // List files in directory
            FileInfo[] files = dirInfo.GetFiles();
            Console.WriteLine($"Files in directory: {files.Length}");
            foreach (FileInfo file in files)
            {
                Console.WriteLine($" - {file.Name} ({file.Length} bytes)");
            }
        }

        private static void PathManipulationExamples(string filePath)
        {
            Console.WriteLine($"Full path: {filePath}");
            Console.WriteLine($"File name: {Path.GetFileName(filePath)}");
            Console.WriteLine(
                $"File name without extension: {Path.GetFileNameWithoutExtension(filePath)}"
            );
            Console.WriteLine($"Extension: {Path.GetExtension(filePath)}");
            Console.WriteLine($"Directory name: {Path.GetDirectoryName(filePath)}");
            Console.WriteLine($"Root directory: {Path.GetPathRoot(filePath)}");
            Console.WriteLine($"Random file name: {Path.GetRandomFileName()}");
            Console.WriteLine($"Temp file name: {Path.GetTempFileName()}");
            Console.WriteLine($"Temp path: {Path.GetTempPath()}");
        }

        private static void SearchOperations(string basePath)
        {
            // Find all solution files
            var solutionFiles = Directory.GetFiles(basePath, "*.sln", SearchOption.AllDirectories);
            Console.WriteLine($"Found {solutionFiles.Length} solution files:");
            foreach (var file in solutionFiles.Take(5))
            {
                Console.WriteLine($" - {file}");
            }
            if (solutionFiles.Length > 5)
            {
                Console.WriteLine(" - ... (more files)");
            }

            // Find directories
            var directories = Directory.GetDirectories(
                basePath,
                "*",
                SearchOption.TopDirectoryOnly
            );
            Console.WriteLine($"\nFound {directories.Length} top-level directories:");
            foreach (var dir in directories.Take(5))
            {
                Console.WriteLine($" - {dir}");
            }
            if (directories.Length > 5)
            {
                Console.WriteLine(" - ... (more directories)");
            }

            // Using EnumerateFiles for better memory usage with large directories
            Console.WriteLine("\nUsing EnumerateFiles for larger directories:");
            int csFileCount = Directory
                .EnumerateFiles(basePath, "*.cs", SearchOption.AllDirectories)
                .Count();
            Console.WriteLine($"Found {csFileCount} C# files in all subdirectories");
        }

        private static void FileStreamExamples(string filePath)
        {
            // Using FileStream to write binary data
            byte[] data = new byte[100];
            for (int i = 0; i < 100; i++)
            {
                data[i] = (byte)i;
            }

            using (
                FileStream fs = new FileStream(
                    Path.Combine(Path.GetDirectoryName(filePath), "binary-example.dat"),
                    FileMode.Create,
                    FileAccess.Write
                )
            )
            {
                fs.Write(data, 0, data.Length);
                Console.WriteLine($"Wrote {data.Length} bytes to binary file");
            }

            // Using BinaryWriter and BinaryReader
            string binaryFilePath = Path.Combine(Path.GetDirectoryName(filePath), "typed-data.bin");
            using (FileStream fs = new FileStream(binaryFilePath, FileMode.Create))
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                writer.Write(42); // Int32
                writer.Write(3.14159); // Double
                writer.Write("Hello"); // String
                writer.Write(true); // Boolean
                Console.WriteLine("Wrote multiple data types to binary file");
            }

            using (FileStream fs = new FileStream(binaryFilePath, FileMode.Open))
            using (BinaryReader reader = new BinaryReader(fs))
            {
                int intValue = reader.ReadInt32();
                double doubleValue = reader.ReadDouble();
                string stringValue = reader.ReadString();
                bool boolValue = reader.ReadBoolean();

                Console.WriteLine(
                    $"Read from binary file: {intValue}, {doubleValue}, {stringValue}, {boolValue}"
                );
            }
        }

        private static void CleanupDirectories(string dir1, string dir2)
        {
            // Delete directories and all contents
            if (Directory.Exists(dir1))
            {
                Directory.Delete(dir1, true);
                Console.WriteLine($"Cleaned up directory: {dir1}");
            }

            if (Directory.Exists(dir2))
            {
                Directory.Delete(dir2, true);
                Console.WriteLine($"Cleaned up directory: {dir2}");
            }
        }
    }
}
