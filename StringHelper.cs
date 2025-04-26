using System.Text.RegularExpressions;

namespace Utils
{
    public static class StringHelper
    {
        /// <summary>
        /// Удаление слова wordsToRemove из строки input
        /// </summary>
        /// <param name="input"></param>
        /// <param name="wordsToRemove"></param>
        /// <returns></returns>
        public static string RemoveWords(string input, string[] wordsToRemove)
        {
            string pattern = @"\b(" + string.Join("|", wordsToRemove.Select(Regex.Escape)) + @")\b";
            return Regex.Replace(input, pattern, "", RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// Удаление слова wordsToRemove и лишних пробелов из строки input 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="wordsToRemove"></param>
        /// <returns></returns>
        public static string RemoveWordsClean(string input, string[] wordsToRemove)
        {
            string pattern = @"\s*\b(" + string.Join("|", wordsToRemove.Select(Regex.Escape)) + @")\b\s*";
            string result = Regex.Replace(input, pattern, " ", RegexOptions.IgnoreCase);
            return Regex.Replace(result, @"\s+", " ").Trim();
        }
    }
}
