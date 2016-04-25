using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using static System.Globalization.TextInfo;

namespace TDD_Homework
{
    public static class StringUtils
    {
        public static string ConcatArrayWithSpace(string[] text)
        {
            return string.Join(" ", text);
        }

        public static string Capitalize(string text)
        {
            var words = text.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];

                // Remove numbers
                word = Regex.Replace(word, @"\d*", "");

                // Replace periods with underscore
                word = Regex.Replace(word, @"\.", "_");

                // Capitalize each word (check size if word was a number we just removed)
                if (word.Length > 0)
                {
                    word = char.ToUpper(word[0]) + word.Substring(1);
                }

                // Replace old word
                words[i] = word;
            }

            return string.Join("", words);
        }

        public static string UppercaseFirstEach(string[] input)
        {
            string[] output = new string[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                string word = input[i];
                output[i] = char.ToUpper(word[0]) + word.Substring(1);
            }

            return string.Join(" ", output);
        }
    }
}
