Random random = new Random();

//int current = random.Next(1, 11);

/*Do while
//int current = 0;
 
 do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
 */

/*While
while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}

Console.WriteLine($"Last Number: {current}");


//With Continue
do
{
    current = random.Next(1, 11);
    if (current >= 8) continue;
    Console.WriteLine(current);
} while (current != 7);
*/



int monster = 10;
int hero = 10;
int hero_dice = random.Next(1, 10);
int monster_dice = random.Next(1, 10);


do
{
    hero_dice = random.Next(1, 10);
    monster_dice = random.Next(1, 10);

    monster = monster - monster_dice;
    Console.WriteLine($"Monster was damaged and lost {monster_dice} health and now has {monster} health");

    if (monster < 0) continue;
    hero = hero - hero_dice;
    Console.WriteLine($"hero was damaged and lost {hero_dice} health and now has {hero} health");

} while (monster > 0 && hero > 0);

if (monster <= 0)
{
    Console.WriteLine($"Hero wins with {hero} and Monster looses with {monster}");
}

if (hero <= 0)
{
    Console.WriteLine($"Monster wins with {monster} and Hero looses with {hero}");
}

/*Microsoft way
int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");

*/

