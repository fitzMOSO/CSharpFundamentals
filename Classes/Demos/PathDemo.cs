namespace CSharpFundamentals.Classes
{
    internal class PathDemo
    {
        public static void RunPathExamples()
        {
            Console.WriteLine("===== Path Class Examples =====\n");

            try
            {
                // Basic path operations
                BasicPathOperations();

                // Path combination examples
                PathCombinationExamples();

                // Path validation and normalization
                PathValidationExamples();

                // Path comparison
                PathComparisonExamples();

                // Special path operations
                SpecialPathOperations();

                // Path.Join and Path.TrimEndingDirectorySeparator (newer .NET methods)
                NewerPathMethods();

                // Working with relative paths
                RelativePathExamples();

                // Cross-platform path examples
                CrossPlatformPathExamples();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in path examples: {ex.Message}");
            }
        }

        private static void BasicPathOperations()
        {
            Console.WriteLine("--- Basic Path Operations ---");

            string filePath = @"C:\Users\fitzg\Documents\Projects\example.txt";

            // Get file name from path
            string fileName = Path.GetFileName(filePath);
            Console.WriteLine($"File name: {fileName}");

            // Get file name without extension
            string fileNameWithoutExt = Path.GetFileNameWithoutExtension(filePath);
            Console.WriteLine($"File name without extension: {fileNameWithoutExt}");

            // Get extension
            string extension = Path.GetExtension(filePath);
            Console.WriteLine($"Extension: {extension}");

            // Get directory name
            string directoryName = Path.GetDirectoryName(filePath);
            Console.WriteLine($"Directory name: {directoryName}");

            // Get path root
            string pathRoot = Path.GetPathRoot(filePath);
            Console.WriteLine($"Path root: {pathRoot}");

            Console.WriteLine();
        }

        private static void PathCombinationExamples()
        {
            Console.WriteLine("--- Path Combination Examples ---");

            // Combine path components
            string basePath = @"C:\Users\fitzg\Documents";
            string subDir = "Projects";
            string fileName = "example.txt";

            // Combine two path components
            string combined1 = Path.Combine(basePath, subDir);
            Console.WriteLine($"Combined path (base + subdir): {combined1}");

            // Combine three path components
            string combined2 = Path.Combine(basePath, subDir, fileName);
            Console.WriteLine($"Combined path (base + subdir + file): {combined2}");

            // Combine with relative paths
            string combined3 = Path.Combine(basePath, @"..\Desktop", fileName);
            Console.WriteLine($"Combined with relative path: {combined3}");

            // Combine with absolute path (overwrites previous parts)
            string combined4 = Path.Combine(basePath, @"D:\OtherFolder", fileName);
            Console.WriteLine($"Combined with absolute path: {combined4}");

            Console.WriteLine();
        }

        private static void PathValidationExamples()
        {
            Console.WriteLine("--- Path Validation and Normalization ---");

            // Invalid path characters
            char[] invalidChars = Path.GetInvalidPathChars();
            Console.WriteLine(
                $"Invalid path characters (first 5): {string.Join(", ", invalidChars.Take(5))}..."
            );

            // Invalid file name characters
            char[] invalidFileChars = Path.GetInvalidFileNameChars();
            Console.WriteLine(
                $"Invalid file name characters (first 5): {string.Join(", ", invalidFileChars.Take(5))}..."
            );

            // Check if path has invalid characters
            string potentiallyInvalidPath = @"C:\Test|File.txt";
            bool hasInvalidChars = potentiallyInvalidPath.IndexOfAny(invalidChars) >= 0;
            Console.WriteLine(
                $"Path \"{potentiallyInvalidPath}\" has invalid characters: {hasInvalidChars}"
            );

            // Get full path (normalize)
            string relativePath = @"..\..\Documents\example.txt";
            try
            {
                string fullPath = Path.GetFullPath(relativePath);
                Console.WriteLine($"Full path from relative: {fullPath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting full path: {ex.Message}");
            }

            Console.WriteLine();
        }

        private static void PathComparisonExamples()
        {
            Console.WriteLine("--- Path Comparison Examples ---");

            // Path comparison (case-insensitive on Windows, case-sensitive on Unix)
            string path1 = @"C:\Users\fitzg\Documents\example.txt";
            string path2 = @"c:\users\fitzg\documents\EXAMPLE.txt";

            bool pathsEqual = string.Equals(
                Path.GetFullPath(path1),
                Path.GetFullPath(path2),
                StringComparison.OrdinalIgnoreCase
            );

            Console.WriteLine($"Paths equal (case-insensitive): {pathsEqual}");

            // Compare using FileInfo
            FileInfo file1 = new FileInfo(path1);
            FileInfo file2 = new FileInfo(path2);

            bool fullPathsEqual = string.Equals(
                file1.FullName,
                file2.FullName,
                StringComparison.OrdinalIgnoreCase
            );

            Console.WriteLine($"Full paths equal (case-insensitive): {fullPathsEqual}");

            Console.WriteLine();
        }

        private static void SpecialPathOperations()
        {
            Console.WriteLine("--- Special Path Operations ---");

            // Get random file name
            string randomFileName = Path.GetRandomFileName();
            Console.WriteLine($"Random file name: {randomFileName}");

            // Get temporary file name (creates an empty file)
            string tempFile = Path.GetTempFileName();
            Console.WriteLine($"Temporary file: {tempFile}");

            // Get temp path
            string tempPath = Path.GetTempPath();
            Console.WriteLine($"Temporary path: {tempPath}");

            // Change extension
            string origPath = @"C:\Users\fitzg\Documents\report.docx";
            string newPath = Path.ChangeExtension(origPath, ".pdf");
            Console.WriteLine($"Changed extension: {newPath}");

            // Directory separator character
            char dirSeparator = Path.DirectorySeparatorChar;
            Console.WriteLine($"Directory separator char: '{dirSeparator}'");

            // Alternative directory separator
            char altDirSeparator = Path.AltDirectorySeparatorChar;
            Console.WriteLine($"Alternative directory separator: '{altDirSeparator}'");

            // Volume separator
            char volSeparator = Path.VolumeSeparatorChar;
            Console.WriteLine($"Volume separator char: '{volSeparator}'");

            Console.WriteLine();
        }

        private static void NewerPathMethods()
        {
            Console.WriteLine("--- Newer Path Methods (.NET Core/.NET 5+) ---");

            // Path.Join (more efficient than Path.Combine for known good paths)
            string joinedPath = Path.Join("C:", "Users", "fitzg", "Documents", "example.txt");
            Console.WriteLine($"Path.Join result: {joinedPath}");

            // Path.TrimEndingDirectorySeparator
            string pathWithTrailingSeparator = @"C:\Users\fitzg\Documents\";
            string trimmedPath = Path.TrimEndingDirectorySeparator(pathWithTrailingSeparator);
            Console.WriteLine($"Trimmed path: {trimmedPath}");

            // Path.Join with spans (high performance)
            ReadOnlySpan<char> part1 = @"C:\Users".AsSpan();
            ReadOnlySpan<char> part2 = @"fitzg\Documents".AsSpan();
            ReadOnlySpan<char> part3 = "example.txt".AsSpan();
            string joinedPathWithSpans = Path.Join(
                part1.ToString(),
                part2.ToString(),
                part3.ToString()
            );
            Console.WriteLine($"Path.Join with spans: {joinedPathWithSpans}");

            Console.WriteLine();
        }

        private static void RelativePathExamples()
        {
            Console.WriteLine("--- Relative Path Examples ---");

            // Calculate relative path
            string basePath = @"C:\Users\fitzg\Documents";
            string targetPath = @"C:\Users\fitzg\Pictures\vacation\photo.jpg";

            try
            {
                string relativePath = Path.GetRelativePath(basePath, targetPath);
                Console.WriteLine($"Relative path from base to target: {relativePath}");

                // Get back to absolute path
                string reconstructedPath = Path.GetFullPath(relativePath, basePath);
                Console.WriteLine($"Reconstructed absolute path: {reconstructedPath}");

                // Relative path from current directory
                string relativeToCurrentDir = Path.GetRelativePath(
                    Directory.GetCurrentDirectory(),
                    targetPath
                );
                Console.WriteLine($"Relative path from current directory: {relativeToCurrentDir}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error with relative paths: {ex.Message}");
            }

            Console.WriteLine();
        }

        private static void CrossPlatformPathExamples()
        {
            Console.WriteLine("--- Cross-Platform Path Examples ---");

            // Platform-specific separators
            bool isWindows = Path.DirectorySeparatorChar == '\\';
            Console.WriteLine($"Running on Windows: {isWindows}");

            // Cross-platform path handling
            string[] pathParts = { "Users", "fitzg", "Documents", "example.txt" };
            string platformPath = Path.Combine(pathParts);
            Console.WriteLine($"Platform-specific path: {platformPath}");

            // Using Path.Join for cross-platform paths
            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string documentsPath = Path.Join(userProfile, "Documents");
            Console.WriteLine($"Documents path: {documentsPath}");

            // Convert between path formats
            string windowsPath = @"C:\Users\fitzg\Documents\example.txt";
            string unixPath = windowsPath.Replace('\\', '/');
            Console.WriteLine($"Unix-style path: {unixPath}");

            // Using URI for true cross-platform file references
            string fileUri = new Uri(windowsPath).AbsoluteUri;
            Console.WriteLine($"File URI: {fileUri}");

            Console.WriteLine();
        }
    }
}
