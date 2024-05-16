using System;
using System.Text.RegularExpressions;

namespace Text
{
    /// <summary>
    /// Class for String Methods
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Method to check if a given string is a palindrome
        /// </summary>
        /// <param name="s">String to check</param>
        /// <returns>True if yes, false if no</returns>
        public static bool IsPalindrome(string s)
        {
            if (s == null || s.Length <= 1)
            {
                return true;
            }

            s = Regex.Replace(s, "[^a-zA-Z]", "");
            s = s.ToLower();
            string reverse = "";
            foreach (char c in s)
            {
                reverse = c + reverse;
            }

            return reverse == s;
        }
    }
}
