Console.WriteLine("Hello World!");
Console.WriteLine("Reverse It");
bool playAgain = true;
while (playAgain)
{
Console.WriteLine();
Console.WriteLine("Pick one:");
Console.WriteLine("1. Reverse a word");
Console.WriteLine("2. Reverse a number");
string choice = Console.ReadLine();
// STRING VERSION
if (choice == "1")
{
Console.Write("Enter some text: ");
string text = Console.ReadLine();
if (text != null && text.Length > 0)
{
Console.WriteLine("Original: " + text);
string backwards = "";
for (int i = text.Length - 1; i >= 0; i--)
{
backwards = backwards + text[i];
}
Console.WriteLine("Reversed: " + backwards);
}
else
{
Console.WriteLine("You need to enter something.");
}
}
// NUMBER VERSION
else if (choice == "2")
{
Console.Write("Enter a whole number: ");
string input = Console.ReadLine();
bool goodNumber = true;
if (input == null || input.Length == 0)
{
goodNumber = false;
}
else
{
for (int i = 0; i < input.Length; i++)
{
if (input[i] < '0' || input[i] > '9')
{
goodNumber = false;
}
}
}
if (goodNumber)
{
int number = 0;
// Turn characters into a number manually
for (int i = 0; i < input.Length; i++)
{
number = number * 10 + (input[i] - '0');
}
Console.WriteLine("Original: " + number);
int reversedNumber = 0;
// Reverse the integer separately
while (number > 0)
{
int lastNumber = number % 10;
reversedNumber = reversedNumber * 10 + lastNumber;
number = number / 10;
}
Console.WriteLine("Reversed: " + reversedNumber);
}
else
{
Console.WriteLine("That is not a whole number.");
}
}
else
{
Console.WriteLine("Please enter 1 or 2.");
}
// PLAY AGAIN VALIDATION
bool validAnswer = false;
while (!validAnswer)
{
Console.Write("Play again? y/n: ");
string answer = Console.ReadLine();
if (answer == "y" || answer == "Y")
{
validAnswer = true;
}
else if (answer == "n" || answer == "N")
{
validAnswer = true;
playAgain = false;
}
else
{
Console.WriteLine("Please enter y or n.");
}
}
}
Console.WriteLine("Goodbye!");