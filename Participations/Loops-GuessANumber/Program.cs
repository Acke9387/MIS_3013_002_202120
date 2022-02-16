Console.WriteLine("Welcome to guess a number!");
Console.WriteLine("What is the minimum value for the game? >>");
string answer = Console.ReadLine();
//int min = Convert.ToInt32(answer);
int min;

while (int.TryParse(answer, out min) == false)
{
    Console.WriteLine("\nSorry, the minimum must be a integer.\nWhat is the minimum value for the game? >>");
    answer = Console.ReadLine();
}

Console.WriteLine("What is the maximum value for the game? >>");
answer = Console.ReadLine();
int max;
//int max = Convert.ToInt32(answer); //Convert.ToInt32.(answer);
//max += 1;
//max++;
while (int.TryParse(answer, out max) == false)
{
    Console.WriteLine("\nSorry, the maximum must be a integer.\nWhat is the maximum value for the game? >>");
    answer = Console.ReadLine();
}

Random rand = new Random();
int numberToGuess = rand.Next(min, max + 1);

int usersGuess;
do
{
    Console.WriteLine($"Please guess a number between {min.ToString("N0")} and {max.ToString("N0")} >>");
    answer = Console.ReadLine();
    //usersGuess = Convert.ToInt32(answer);
    while (int.TryParse(answer, out usersGuess) == false)
    {
        Console.WriteLine($"\nSorry, the guess must be a integer.\nPlease guess a number between {min.ToString("N0")} and {max.ToString("N0")}");
        answer = Console.ReadLine();
    }

    if (usersGuess > numberToGuess)
    {
        Console.WriteLine($"Sorry that's wrong.  {usersGuess.ToString("N0")} is too high, try guessing lower");
    }
    else if (usersGuess < numberToGuess)
    {
        Console.WriteLine($"Sorry that's wrong.  {usersGuess.ToString("N0")} is too low, try guessing higher");
    }

} while (numberToGuess != usersGuess);

Console.WriteLine($"Congratulations, you guessed correctly!");