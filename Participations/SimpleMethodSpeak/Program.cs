Console.WriteLine("Please enter an animal name >>");
string answer = Console.ReadLine();
string result = "";
result = Speak(answer);
Console.WriteLine($"{answer} makes the sound {result}");

static string Speak(string animal)
{
    string result = "";

    switch (animal)
    {
        case "Dog":
            result = "Ruff";
            break;
        case "Monkey":
            result = "ooo ooo ahhh ahhh";
            break;
        case "Goat":
            result = "human scream";
            break;
        default:
            result = "Grrr";
            break;
    }

    if (animal == "Dog")
    {
        result = "Ruff";
    }
    else if (animal == "Monkey")
    {
        result = "ooo ooo ahhh ahhh";
    }
    else if (animal == "Goat")
    {
        result = "human scream";
    }
    else
    {
        result = "Grrr";
    }
        return result;
}