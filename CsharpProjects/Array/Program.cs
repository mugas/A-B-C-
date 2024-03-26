/*
//Declaring a enw carray that can hold 3 elements
string[] fradulentOrderIds = new string[3];
fradulentOrderIds[0] = "A123";
fradulentOrderIds[1] = "B456";
fradulentOrderIds[2] = "C789";
//fradulentOrderIds[3] = "D000"; This is out of the bounds of the array

Console.WriteLine($"First {fradulentOrderIds[0]}");

// You Can reassign new values to the array
fradulentOrderIds[0] = "A1A1";
Console.WriteLine($"Reassign {fradulentOrderIds[0]}");
//Initialize an array with values

string[] newOrderId = { "B123", "C234", "D345" };

Console.WriteLine(newOrderId[0]);
Console.WriteLine(newOrderId[1]);
Console.WriteLine(newOrderId[2]);

//To know the length of the array
Console.WriteLine(newOrderId.Length);

//Foreach


string[] names = { "Rowenta", "Robon", "Bao" };
foreach (int name in names)
{
    Console.WriteLine(name);

}


int[] inventory = { 200, 450, 700, 175, 250 };

int sum = 0;
//If you were to declare the variable sum inside the foreach loop, 
//it would be reinitialized to 0 on each iteration of the loop. 
//This means that you would lose the accumulated value from the previous iterations, 
//and sum would only contain the value from the current iteration.
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin}= {items} items(Running total:{sum})");
}
Console.WriteLine($"We have {sum} items in inventoty");
*/


//Your team has found a pattern. Orders that start with the letter "B" encounter
//fraud at a rate 25 times greater than the normal rate. 
//You write new code that outputs the Order ID of new orders where the Order ID starts
//with the letter "B". This will be used by the fraud team to investigate further.

string[] orders = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
foreach (string order in orders)
{
    if (order.StartsWith("B"))//new method
    {
        Console.WriteLine(order);
    }

}