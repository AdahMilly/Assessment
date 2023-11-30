// See https://aka.ms/new-console-template for more information
using Assessment.MostAppearingCharacter;
using Assessment.RemoveWhitespaces;
using Assessment.ReverseIntegers;

Console.WriteLine("Hello, World!");


MostRepeatedChar mrc= new MostRepeatedChar();
mrc.mostAppearingCharacter("11211234");

RemoveWhitespaces rmw = new RemoveWhitespaces();
//rmw.removeWhitespace([1,0,3,4,5]);

ReverseOrdering ordering = new ReverseOrdering();
Console.WriteLine(ordering.reverseInt(1234));