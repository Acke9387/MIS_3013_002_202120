string name = "Instructor Ackerman";
DeveloperInformation(name, "MIS-3013", "4/12/2022");

string response;
double answer = 0;
bool shouldIAskTheUserForTheFirstValueOrNot = true;

do
{
    Console.WriteLine("What type of calculation do you wish to perform (Add, Subtract, Multiply, Divide)? <<");
    string function = Console.ReadLine();
    double first;
    if (shouldIAskTheUserForTheFirstValueOrNot)
    {
        Console.WriteLine("What is your first value? <<");
        first = Convert.ToDouble(Console.ReadLine());
    }
    else
    {
        first = answer;
    }

    Console.WriteLine("What is your second value? <<");
    double second = Convert.ToDouble(Console.ReadLine());

    switch (function.ToLower())
    {
        case "add":
            answer = Add(first, second);
            Console.WriteLine($"{first} + {second} = {answer}");
            break;
        case "subtract":
            answer = Subtract(first, second);
            Console.WriteLine($"{first} - {second} = {answer}");
            break;
        case "multiply":
            answer = Multiply(first, second);
            Console.WriteLine($"{first} * {second} = {answer}");
            break;
        case "divide":
            answer = Divide(first, second);
            Console.WriteLine($"{first} / {second} = {answer}");
            break;

        default:
            answer = 0;
            break;
    }

    Console.WriteLine("Would you like to perform another calculation? yes or no >>");
    response = Console.ReadLine().ToLower();
    if (response == "yes")
    {
        Console.WriteLine($"Would you like to use {answer} as the first value? yes or no >>");
        if (Console.ReadLine().ToLower() == "yes")
        {
            shouldIAskTheUserForTheFirstValueOrNot = false;
        }
        else
        {
            shouldIAskTheUserForTheFirstValueOrNot = true;
        }
    }

} while (response.ToLower() == "yes");


static double Add(double lh, double rh)
{
    double result = 0;

    result = lh + rh;

    return result;
}

static double Subtract(double lh, double rh)
{
    return lh - rh;
}

static double Multiply(double lh, double rh)
{
    return lh * rh;
}

static double Divide(double lh, double rh)
{
    if (rh == 0)
    {
        return 0;
    }
    else
    {
        return lh / rh;
    }
}

static void DeveloperInformation(string devName, string className, string date)
{
    Console.WriteLine($"{devName} wrote this application for {className} on {date}");
}
