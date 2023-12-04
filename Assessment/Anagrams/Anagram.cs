

namespace Assessment.Anagrams
{
    internal class Anagram
    {
        public bool IsAnagram(string str1, string str2) {
            //string cleanedStr1 = new string(str1.ToLower().Where(c => !char.IsWhiteSpace(c)).ToArray());
            //string cleanedStr2 = new string(str2.ToLower().Where(c => !char.IsWhiteSpace(c)).ToArray());

            // Check if the sorted characters of both strings are the same
            //return string.Concat(cleanedStr1.OrderBy(c => c)) == string.Concat(cleanedStr2.OrderBy(c => c));
        }
    }
}
