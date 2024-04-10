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
/*
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
*/



/*
Exercise I
string? readResult;
bool validEntry = false;
int outResult;

Console.WriteLine("Write a number between 5 and 10");
do
{
    readResult = Console.ReadLine();

    if (readResult != null)
    {
        validEntry = int.TryParse(readResult, out outResult);
        if (validEntry && (outResult >= 5 && outResult <= 10))
        {
            validEntry = true;

        }
        else
        {
            Console.WriteLine("Try again");
            validEntry = false;

        }
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }


} while (validEntry == false);
Console.WriteLine($"You were accepted witht the number {outResult}");
*/
/*
string? readResult;
string valueEntered = "";
int numValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        valueEntered = readResult;
    }

    validNumber = int.TryParse(valueEntered, out numValue);

    if (validNumber == true)
    {
        if (numValue <= 5 || numValue >= 10)
        {
            validNumber = false;
            Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
        }
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validNumber == false);

Console.WriteLine($"Your input value ({numValue}) has been accepted.");

readResult = Console.ReadLine();
*/
/*

string? readResult;
bool validEntry = false;
int outResult = 0;

Console.WriteLine("Write a number between 5 and 10");

do
{
    readResult = Console.ReadLine();

    if (readResult != null)
    {
        if (int.TryParse(readResult, out outResult))
        {
            if (outResult >= 5 && outResult <= 10)
            {
                validEntry = true;
            }
            else
            {
                Console.WriteLine("Sorry, the number is not between 5 and 10. Please try again.");
            }
        }
        else
        {
            Console.WriteLine("Sorry, you entered an invalid number. Please try again.");
        }
    }
    else
    {
        Console.WriteLine("Sorry, you entered an empty value. Please try again.");
    }

} while (!validEntry);

Console.WriteLine($"You entered the valid number: {outResult}");
*/

//Exercise II
/*
Console.Write("What is your role?");
string? readResult;
bool validEntry = false;
string numericValue = "";
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        numericValue = readResult.Trim().ToLower();
        if (numericValue == "manager" || numericValue == "user" || numericValue == "Administrator")
        {
            validEntry = true;


        }
        else
        {
            Console.WriteLine("You are not authorized");
        }


    }
    else
    {
        Console.WriteLine("Try again");
    }

} while (validEntry == false);
Console.WriteLine("You are in");
*/

//Exercise III

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}


/*
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }

    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}
*/