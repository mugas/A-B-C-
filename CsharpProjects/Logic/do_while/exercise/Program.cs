/*
string? readResult;
bool validEntry = false;

Console.WriteLine("Enter a string containing at least three characters:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validEntry == false);
*/

//Exercise I

/*
Console.WriteLine("Enter a number between 5 and 10");
string? readResult = Console.ReadLine();
int newNumber;
bool validNumber = int.TryParse(readResult, out newNumber);

Console.WriteLine("Enter a number between 5 and 10");
while (newNumber < 5 || newNumber > 10)
{

    Console.WriteLine("Try again");
    readResult = Console.ReadLine();
    validNumber = int.TryParse(readResult, out newNumber);


}
Console.WriteLine($"Your input was accepted with the number {newNumber}");
*/
//Exercise II
/*
Console.WriteLine("Enter a Role");
string? readResult = Console.ReadLine()?.Trim().ToLower();
Console.WriteLine(readResult);
string newRole = readResult;
//bool role = string.TryParse(readResult, out newRole);
while (!(newRole == "administrator" || newRole == "manager" || newRole == "User"))
{
    Console.WriteLine("Not a valid entry. Try again");
    readResult = Console.ReadLine()?.Trim().ToLower();
    //role = string.TryParse(readResult, out newRole);
    newRole = readResult;
    Console.WriteLine(newRole);
}
Console.WriteLine("You are in");
*/
//Exercise III
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

int periodLocation;
int startPosition = 0;
foreach (string myString in myStrings)
{

    do
    {
        // Find the location of the next period starting from startPosition
        periodLocation = myString.IndexOf('.', startPosition);
        // If a period is found, extract the sentence from startPosition to periodLocation
        // If no period is found (periodLocation == -1), extract from startPosition to the end of the string
        string sentence = (periodLocation != -1) ? myString.Substring(startPosition, periodLocation - startPosition + 1) : myString.Substring(startPosition);
        string newString = myString.Remove(periodLocation);
        Console.WriteLine(newString);
    } while (periodLocation !== -1);

}