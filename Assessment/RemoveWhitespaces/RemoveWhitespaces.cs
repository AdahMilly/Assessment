using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.RemoveWhitespaces
{
    internal class RemoveWhitespaces
    {
        public List<int> removeWhitespace(int[] numbers)

        {
            List<int> removed = new List<int>();
            
                foreach(int number in numbers)
                {
                if (number != null)
                {
                    removed.Add(number);
                }
            }
            return removed;
            
        }
    }
}
