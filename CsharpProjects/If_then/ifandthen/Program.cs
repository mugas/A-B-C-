/* // Exercise of If codition about Subscription
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;


if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
    Console.WriteLine(daysUntilExpiration);
}
else if (daysUntilExpiration == 1)
{
    discountPercentage = 20;
    Console.WriteLine("Your subscription expires within a day!");
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
    Console.WriteLine(daysUntilExpiration);
}
else if (daysUntilExpiration <= 5)
{
    discountPercentage = 10;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
    Console.WriteLine(daysUntilExpiration);
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
    Console.WriteLine(daysUntilExpiration);
}


// Exercise of if condition about dice roll 
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

if (total >= 15)
{
    Console.WriteLine("You win!");
}
else
{
    Console.WriteLine("Sorry, you lose.");
} */

//Exercise of if about celsis

/* Random temperature = new Random();
int celsius = temperature.Next(-50, 50);
decimal fahrenheit = (decimal)(celsius * 9 / 5) + 32;
decimal kelvin = (decimal)(celsius + 273.15);

if (celsius > 0)
{
    Console.WriteLine($"Your temperature is {celsius} celsius and is {fahrenheit} in fahrenheit");

    if (celsius > 5)
    {
        Console.WriteLine("It works");
    }

}

else
{
    Console.WriteLine($"Your temperature is {celsius} celsius and is {kelvin} in Kelvin");
}
Console.WriteLine(celsius); */

// Exercise of if about Grade calculator

Random grade = new Random();
int evaluation = grade.Next(0, 100);

if (evaluation > 90)
{
    Console.WriteLine($"You have A with {evaluation}");
}
else if (evaluation > 80)
{
    Console.WriteLine($"You have B with {evaluation}");
}
else if (evaluation > 70)
{
    Console.WriteLine($"You have C with {evaluation}");
}
else if (evaluation > 60)
{
    Console.WriteLine($"You have D with {evaluation}");
}
else
{
    Console.WriteLine($"You have E with {evaluation}");
}