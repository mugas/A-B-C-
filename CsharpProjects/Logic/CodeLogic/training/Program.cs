/*
bool flag = true;
if (flag)
{
    int value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}
here the variable doesnt exist
Console.WriteLine($"Outside the code block: {value}");


bool flag = true;
int value = 0;

if (flag)
{
    Console.WriteLine($"Inside the code block: {value}");
}

value = 10;
Console.WriteLine($"Outside the code block: {value}");

// Code sample 1
Here gives an erro because the compiler also analyzes the possibility of 
flag=false and because the value was not assigned gives an error
bool flag = true;
int value;

if (flag)
{
    value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}

Console.WriteLine($"Outside the code block: {value}");

// Code sample 2

//Here true is always true
int value;

if (true)
{
    value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}

Console.WriteLine($"Outside the code block: {value}");
*/


bool flag = true;
if (flag)
{
    Console.WriteLine(flag)
}















