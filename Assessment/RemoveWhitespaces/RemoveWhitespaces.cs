

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
