
using System.Text;

namespace Assessment.Palindrome
{
    internal class Palindrome
    {
        public string ReversedStr(string val) {
            StringBuilder sb = new StringBuilder();


            for(int i = val.Length - 1; i >= 0; i--)
            {
                // Append
                sb.Append(val[i]);
            }
            // Convert the StringBuilder to a string
            return sb.ToString();
        }
        public bool IsPalindrome(string input)
        {
            string cleanedVal = input.Replace(" ", "").ToLower();

            // Compare string with its reverse
            string reversedString = ReversedStr(cleanedVal);

            return cleanedVal == reversedString;
        }
    }
}
