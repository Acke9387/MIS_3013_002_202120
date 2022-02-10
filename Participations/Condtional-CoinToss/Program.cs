const string DEVELOPER_INFORMATION = "Professor Ackerman";
const int HEADS = 1;
const int TAILS = 2;

Random rand = new Random();

int randomNumber = rand.Next(1, 3);

//  Added for testing purposes
//Console.WriteLine(randomNumber);

Console.WriteLine("Heads or Tails? >>");
string usersChoice = Console.ReadLine();
int usersGuess = -1;

if (usersChoice == "Heads")
{
    usersGuess = HEADS;
}
else if (usersChoice == "Tails")
{
    usersGuess = TAILS;
}
else
{
    //usersGuess = -1;
    Console.WriteLine("Invalid input.");
    Environment.Exit(usersGuess);
}

if (randomNumber == HEADS)
{
    Console.WriteLine("The coin landed heads up");
}
else
{
    Console.WriteLine("The coin landed tails up");
}

if (usersGuess == randomNumber)
{
    Console.WriteLine("Congratulations, you guessed correctly! =D");
}
else
{
    Console.WriteLine("Sorry, better luck next time. =(");
}



Console.WriteLine($"Developed by {DEVELOPER_INFORMATION}");

