using System.Text.RegularExpressions;

namespace Aufgabe_5
{
    public static class StringExtensions
    {
        public static int CountWordsRegex(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return 0;
            }

            return Regex.Split(str.Trim(), @"\s+").Length;
        }


        public static int CountWords(this string str)
        {
            var wordCount = 0;
            var chars = str.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (!char.IsWhiteSpace(chars[i]))
                {
                    wordCount++;
                    while (i < chars.Length - 1 && !char.IsWhiteSpace(chars[i]))
                    {
                        i++;
                    }
                }
            }

            return wordCount;
        }
    }
}
