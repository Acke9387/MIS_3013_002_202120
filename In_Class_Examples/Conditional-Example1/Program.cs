//Welcome the user to your application and prompt the user to enter their name.
//Prompt the user, while using their name, for their total monthly income
//  as well as their total monthly expenses.
//  Output the difference in green if they will have money to put in their savings account, or red if they spent more than they made.


// Step 1: Welcome user and get their name
Console.WriteLine("Welcome to my application! What can I call you? >>");
string name = Console.ReadLine();

// Step 2: Ask user (with their name) for monthly income
Console.WriteLine($"{name}, what is your total monthly income? >>");
//Console.WriteLine(name + ", what is your total monthly income? >>");
string answer = Console.ReadLine();
double income = Convert.ToDouble(answer);

// Step 3: Ask user (with their name) for monthly expenses
Console.WriteLine($"{name}, what is your total monthly expenses? >>");
answer = Console.ReadLine();
double expenses = Convert.ToDouble(answer);

// Step 4: Output the difference in green if they have savings, otherwise output in red
double savings = income - expenses;

if (savings > 0)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"You saved {savings.ToString("C")}!");
}
else if (savings == 0)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"Wow, you budgeted correctly down to the penny! You have {savings.ToString("C")} left for the month");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Oh no! You overspent by {savings.ToString("C")} :(");
}


