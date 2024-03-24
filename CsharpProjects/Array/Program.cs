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


