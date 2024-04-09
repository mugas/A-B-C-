/* for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

for (int j = 0; j < 10; j++)
{
    Console.WriteLine(j);
    if (j == 7)
        break;
} */

string[] names = { "Alex", "Eddy", "John", "Michael" };

/* for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
} 


for (int j = 0; j < names.Length; j++)
{
    if (names[j] == "John") names[j] = "Sammy";
    Console.WriteLine(names[j]);
}

foreach (var name in names)
{
    Console.WriteLine(name);
}
*/

/*Exercise*/

Random crazyDice = new Random();
int flipCoin = crazyDice.Next(0, 100);


if (flipCoin % 3 == 0 && flipCoin % 5 == 0)
{
    Console.WriteLine($"{flipCoin} FizzBuzz");
}
else if (flipCoin % 3 == 0)
{
    Console.WriteLine($"{flipCoin} Fizz");
}
else if (flipCoin % 5 == 0)
{
    Console.WriteLine($"{flipCoin} Buzz");
}
else
{
    Console.WriteLine(flipCoin);
}
/* 
for (int i = 0; i < 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine($"{i} FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine($"{i} Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine($"{i} Buzz");
    }

    else
    {
        Console.WriteLine(i);
    }

} */