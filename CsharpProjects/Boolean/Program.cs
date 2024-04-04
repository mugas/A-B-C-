/*Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue1 = "a";
string myValue2 = "A";
Console.WriteLine(myValue1 == "a");
Console.WriteLine(myValue1.Trim().ToLower() == myValue2.Trim().ToLower());

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));
Console.WriteLine(pangram.Contains("fox") == false);//is true == false -> false
Console.WriteLine(!pangram.Contains("fox"));//is true == false -> false

int a = 7;
int b = 6;
Console.WriteLine(a != b); // output: True
string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 != s2); // output: False
*/
//Conditional Operator//

/*Syntax
<evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>
*/
int salesAmount = 0;
int discount = 0;


salesAmount = 1999;
discount = salesAmount > 1000 ? 100 : 50;
Console.WriteLine($"{discount} {salesAmount}");

/*More clean but more difficult to read

int salesAmount=0;
Console.WriteLine($"Discount:{salesAmount>1000?100:50)}");

/*Flip the Coin*/

Random coin = new Random();
int flipCoin = coin.Next(0, 2);

string result = flipCoin == 0 ? "Heads" : "Tails";
Console.WriteLine($"You got {result} {flipCoin}");


