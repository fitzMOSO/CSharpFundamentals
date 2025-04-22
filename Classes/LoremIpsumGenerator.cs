namespace CSharpFundamentals.Classes
{
    /// <summary>
    /// Generates Lorem Ipsum placeholder text with configurable options.
    /// </summary>
    public class LoremIpsum
    {
        private static readonly Random _random = new Random();

        // Standard lorem ipsum starting text
        private const string _loremIpsumStart = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";

        // Collection of Latin words commonly used in lorem ipsum text
        private static readonly string[] _words = new[]
        {
            "a", "ac", "accumsan", "ad", "adipiscing", "aenean", "aliquam", "aliquet",
            "amet", "ante", "aptent", "arcu", "at", "auctor", "augue", "bibendum",
            "blandit", "class", "commodo", "condimentum", "congue", "consectetur",
            "consequat", "conubia", "convallis", "cras", "cubilia", "cum", "curabitur",
            "curae", "cursus", "dapibus", "diam", "dictum", "dictumst", "dignissim",
            "dis", "dolor", "donec", "dui", "duis", "egestas", "eget", "eleifend",
            "elementum", "elit", "enim", "erat", "eros", "est", "et", "etiam", "eu",
            "euismod", "facilisi", "facilisis", "fames", "faucibus", "felis",
            "fermentum", "feugiat", "fringilla", "fusce", "gravida", "habitant",
            "habitasse", "hac", "hendrerit", "himenaeos", "iaculis", "id", "imperdiet",
            "in", "inceptos", "integer", "interdum", "ipsum", "justo", "lacinia",
            "lacus", "laoreet", "lectus", "leo", "libero", "ligula", "litora",
            "lobortis", "lorem", "luctus", "maecenas", "magna", "magnis", "malesuada",
            "massa", "mattis", "mauris", "maximus", "metus", "mi", "molestie",
            "mollis", "montes", "morbi", "mus", "nam", "nascetur", "natoque", "nec",
            "neque", "netus", "nibh", "nisi", "nisl", "non", "nostra", "nulla",
            "nullam", "nunc", "odio", "orci", "ornare", "parturient", "pellentesque",
            "penatibus", "per", "pharetra", "phasellus", "placerat", "platea",
            "porta", "porttitor", "posuere", "potenti", "praesent", "pretium",
            "primis", "proin", "pulvinar", "purus", "quam", "quis", "quisque",
            "ridiculus", "risus", "rutrum", "sagittis", "sapien", "scelerisque",
            "sed", "sem", "semper", "senectus", "sit", "sociis", "sociosqu",
            "sodales", "sollicitudin", "suscipit", "suspendisse", "taciti",
            "tellus", "tempor", "tempus", "tincidunt", "torquent", "tortor",
            "tristique", "turpis", "ullamcorper", "ultrices", "ultricies", "urna",
            "ut", "varius", "vehicula", "vel", "velit", "venenatis", "vestibulum",
            "vitae", "vivamus", "viverra", "volutpat", "vulputate"
        };

        /// <summary>
        /// Generates lorem ipsum text with the specified number of paragraphs.
        /// </summary>
        /// <param name="paragraphs">Number of paragraphs to generate</param>
        /// <param name="startWithLoremIpsum">Whether to start with the traditional "Lorem ipsum" text</param>
        /// <param name="minSentencesPerParagraph">Minimum number of sentences per paragraph</param>
        /// <param name="maxSentencesPerParagraph">Maximum number of sentences per paragraph</param>
        /// <param name="minWordsPerSentence">Minimum number of words per sentence</param>
        /// <param name="maxWordsPerSentence">Maximum number of words per sentence</param>
        /// <returns>Generated lorem ipsum text with paragraphs separated by double newlines</returns>
        public static string Generate(
            int paragraphs = 3,
            bool startWithLoremIpsum = true,
            int minSentencesPerParagraph = 3,
            int maxSentencesPerParagraph = 8,
            int minWordsPerSentence = 5,
            int maxWordsPerSentence = 15)
        {
            if (paragraphs <= 0)
                throw new ArgumentException("Number of paragraphs must be greater than zero", nameof(paragraphs));

            var result = new System.Text.StringBuilder();

            for (int i = 0; i < paragraphs; i++)
            {
                if (i > 0)
                    result.Append(Environment.NewLine + Environment.NewLine);

                var paragraph = GenerateParagraph(
                    i == 0 && startWithLoremIpsum,
                    _random.Next(minSentencesPerParagraph, maxSentencesPerParagraph + 1),
                    minWordsPerSentence,
                    maxWordsPerSentence);

                result.Append(paragraph);
            }

            return result.ToString();
        }

        /// <summary>
        /// Generates a single paragraph of lorem ipsum text.
        /// </summary>
        private static string GenerateParagraph(
            bool startWithLoremIpsum,
            int sentences,
            int minWordsPerSentence,
            int maxWordsPerSentence)
        {
            var paragraph = new System.Text.StringBuilder();

            for (int i = 0; i < sentences; i++)
            {
                if (i == 0 && startWithLoremIpsum)
                {
                    paragraph.Append(_loremIpsumStart + " ");
                    continue;
                }

                int wordsCount = _random.Next(minWordsPerSentence, maxWordsPerSentence + 1);
                var sentence = GenerateSentence(wordsCount);
                paragraph.Append(sentence + " ");
            }

            return paragraph.ToString().TrimEnd();
        }

        /// <summary>
        /// Generates a single sentence with the specified number of words.
        /// </summary>
        private static string GenerateSentence(int wordCount)
        {
            var words = new List<string>();

            // First word with first letter capitalized
            var firstWord = _words[_random.Next(_words.Length)];
            words.Add(char.ToUpper(firstWord[0]) + firstWord.Substring(1));

            // Rest of the words
            for (int i = 1; i < wordCount; i++)
            {
                words.Add(_words[_random.Next(_words.Length)]);
            }

            return string.Join(" ", words) + ".";
        }

        /// <summary>
        /// Generates lorem ipsum text with the specified number of words.
        /// </summary>
        /// <param name="wordCount">Number of words to generate</param>
        /// <param name="startWithLoremIpsum">Whether to start with the traditional "Lorem ipsum" text</param>
        /// <returns>Generated lorem ipsum text</returns>
        public static string GenerateWords(int wordCount, bool startWithLoremIpsum = true)
        {
            if (wordCount <= 0)
                throw new ArgumentException("Word count must be greater than zero", nameof(wordCount));

            var result = new System.Text.StringBuilder();
            int currentWordCount = 0;

            if (startWithLoremIpsum)
            {
                // Count words in the starting phrase
                string[] startingWords = _loremIpsumStart.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                startingWords[startingWords.Length - 1] = startingWords[startingWords.Length - 1].TrimEnd('.');

                result.Append(_loremIpsumStart + " ");
                currentWordCount += startingWords.Length;
            }

            // Generate remaining words
            while (currentWordCount < wordCount)
            {
                string word = _words[_random.Next(_words.Length)];

                // Capitalize first word of a new sentence
                if (result.Length > 0 && result[result.Length - 1] == '.')
                {
                    word = char.ToUpper(word[0]) + word.Substring(1);
                    result.Append(" ");
                }
                else if (result.Length > 0 && result[result.Length - 1] != ' ')
                {
                    result.Append(" ");
                }

                result.Append(word);
                currentWordCount++;

                // Add period after roughly every 8-12 words to create sentences
                if (currentWordCount < wordCount && _random.Next(100) < 15 && currentWordCount > 0)
                {
                    result.Append(".");
                }
            }

            // Ensure text ends with a period
            if (result[result.Length - 1] != '.')
            {
                result.Append(".");
            }

            return result.ToString();
        }
    }

    /// <summary>
    /// Example usage of the Lorem Ipsum generator.
    /// </summary>
    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        // Generate 3 paragraphs with default settings
    //        string lorem1 = LoremIpsum.Generate();
    //        Console.WriteLine(lorem1);
    //        Console.WriteLine("\n---\n");

    //        // Generate 2 paragraphs with custom settings
    //        string lorem2 = LoremIpsum.Generate(
    //            paragraphs: 2,
    //            startWithLoremIpsum: true,
    //            minSentencesPerParagraph: 4,
    //            maxSentencesPerParagraph: 6,
    //            minWordsPerSentence: 6,
    //            maxWordsPerSentence: 12);
    //        Console.WriteLine(lorem2);
    //        Console.WriteLine("\n---\n");

    //        // Generate exactly 50 words
    //        string lorem3 = LoremIpsum.GenerateWords(50);
    //        Console.WriteLine(lorem3);
    //        Console.WriteLine($"Word count: {lorem3.Split(new[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries).Length}");

    //        Console.ReadKey();
    //    }
    //}
}