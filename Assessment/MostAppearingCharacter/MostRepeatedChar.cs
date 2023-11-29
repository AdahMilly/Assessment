using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.MostAppearingCharacter
{
    public class MostRepeatedChar
    {
        public void mostAppearingCharacter(string input)
        {
            input = input.ToLower();

            Dictionary<char,int> result = new Dictionary<char,int>();   

            foreach (char c in input)
            {

                if (result.ContainsKey(c))
                {
                    result[c] = result[c] + 1;
                }
                result[c] = 1;
            }

            int highest = 0;
            string mostappearing = "";
            foreach (char c in result.Keys)
            {
                if (result[c] > highest)
                {
                    highest = result[c];
                    mostappearing = result[c].ToString();
                }
            }

            Console.WriteLine(mostappearing);
        }
    }
}
