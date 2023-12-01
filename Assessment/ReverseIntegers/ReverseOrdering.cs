
namespace Assessment.ReverseIntegers
{
    internal class ReverseOrdering
    {
        public int reverseInt(int input)
        {
            string numberConversion = input.ToString(); //convert to string
            List<string> numbers = new List<string>();
           foreach(var letter in numberConversion)
            {
                numbers.Add(letter.ToString());
            }// convert to character array

            numbers.Reverse();
            string concatenatedString="";
            foreach(var number in numbers)
            {
                concatenatedString =concatenatedString+number;
            }

           return Convert.ToInt32(concatenatedString);
        }
        public int ReverseInteger(int val)
        {
            string convertNumber = val.ToString(); //convert to str
            char[] convertedNumber = convertNumber.ToCharArray(); //convert to char array
            Array.Reverse(convertedNumber);

            string reversedArr = new string(convertedNumber);

            int reversedVal;
            int.TryParse(reversedArr, out reversedVal);

            return reversedVal;
        }

    }
}
