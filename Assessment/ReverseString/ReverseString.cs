using System.Text;


namespace Assessment.ReverseString
{
    internal class ReverseString
    {
        public string reverseString(string input) {
            //dynamically expands memory to modify string-which is immutable
            StringBuilder reversedStringBuilder = new StringBuilder();

            // Loop through each character
            for (int i = input.Length - 1; i >= 0; i--)
            {
                // Append
                reversedStringBuilder.Append(input[i]);
            }
            // Convert the StringBuilder to a str
            return reversedStringBuilder.ToString();
        }
    }
}
