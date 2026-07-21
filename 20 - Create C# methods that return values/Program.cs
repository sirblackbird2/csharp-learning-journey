Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
{
    PlayGame();
}

bool ShouldPlay()
{
    var playOrNot = Console.ReadLine().ToLower();
    if (playOrNot == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}

void PlayGame() 
{
    var play = true;

    while (play) 
    {
        var target = random.Next(1,6);
        var roll = random.Next(1,6);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}


string WinOrLose(int roll, int target)
{
    if (target > roll)
    {
        return "You Lose";
    }
    else
    {
        return "You Win!";
    }
}


