// See https://aka.ms/new-console-template for more information
using Assessment.MostAppearingCharacter;
using Assessment.Palindrome;
using Assessment.PromptUser;
using Assessment.RemoveWhitespaces;
using Assessment.ReverseIntegers;
using Assessment.ReverseString;

MostRepeatedChar mrc= new MostRepeatedChar();
mrc.mostAppearingCharacter("11211234");

RemoveWhitespaces rmw = new RemoveWhitespaces();
//rmw.removeWhitespace([1,0,3,4,5]);

ReverseOrdering ordering = new ReverseOrdering();
Console.WriteLine(ordering.reverseInt(1234));
Console.WriteLine(ordering.ReverseInteger(6784));

PromptUser prompt = new PromptUser();
prompt.promptUser("aeiou");

Console.WriteLine("Enter a string ");
string inputStr = Console.ReadLine();

//int vCount = promptUser(inputStr);
ReverseString reverseStrs = new ReverseString();
Console.WriteLine(reverseStrs.reverseString("mildred")); 

Palindrome palindrome = new Palindrome();
Console.WriteLine(palindrome.IsPalindrome("madam"));
Console.WriteLine(palindrome.IsPalindrome("Ivy"));
