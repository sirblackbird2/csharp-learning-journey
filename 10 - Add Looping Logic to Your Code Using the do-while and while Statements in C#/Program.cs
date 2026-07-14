int heroHP = 10;
int monsterHP = 10;

Random random = new Random();
int attack = random.Next(1, 11);

while (heroHP > 0 && monsterHP > 0)
{
    monsterHP -= attack;
    Console.WriteLine($"Attack = {attack}, Remaining monster HP = {monsterHP}");

    if (monsterHP <= 0) 
        break;
    
    attack = random.Next(1,11);
    heroHP -= attack;
    Console.WriteLine($"Attack = {attack}, Remaining hero HP = {heroHP}");
}

if (heroHP > 0)
    Console.WriteLine("Hero Wins!");

else 
    Console.WriteLine("Monster Wins!");