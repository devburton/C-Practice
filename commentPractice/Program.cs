/* This program takes an input string reversed it and counts the numer of times the letter o appears in the string */

string inputString = "The quick brown fox jumps over the lazy dog.";
char[] charString = inputString.ToCharArray();
Array.Reverse(charString);
int letterCount = 0;

foreach (char letter in charString) 
{ 
    if (letter == 'o') 
    { 
        letterCount++; 
    } 
}

string newMessage = new String(charString);
Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");