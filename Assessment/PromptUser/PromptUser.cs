﻿

namespace Assessment.PromptUser
{
    internal class PromptUser
    {
        public int promptUser(string val) {
            string vowels = "aeiou";

            int count = 0;
            foreach (char character in val)
            {
                if (vowels.Contains(character))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
