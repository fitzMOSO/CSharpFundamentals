namespace CSharpFundamentals.Classes
{
    internal class SummarizingText
    {
        //Show text summarization demo
        public static void ShowTextSummarization()
        {
            Console.WriteLine("Text Summarization Demo");
            Console.WriteLine("=======================");

            const string text =
                "This is a very long text that needs to be summarized into a shorter version.";
            Console.WriteLine($"Original text: {text}");

            //Summary
            var summary = SummarizeText(text, 25);
            Console.WriteLine(summary);
        }

        //Summarize text method
        public static string SummarizeText(string text, int maxLength = 20)
        {
            if (text.Length <= maxLength)
                return text;

            var words = text.Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);
                totalCharacters += word.Length + 1; // +1 for the space

                if (totalCharacters > maxLength)
                    break;
            }

            return string.Join(" ", summaryWords) + "...";
        }
    }
}
