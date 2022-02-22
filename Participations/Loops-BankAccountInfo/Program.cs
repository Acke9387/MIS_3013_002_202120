Console.WriteLine("How many bank accounts do you have? >>");
string answer = Console.ReadLine();

int numberOfBankAccounts;

bool isValid = int.TryParse(answer, out numberOfBankAccounts);

while (isValid == false)
{
    Console.WriteLine("Sorry you must enter a valid number, please tell me how many bank accounts do you have? >>");
    answer = Console.ReadLine();
    isValid = int.TryParse(answer, out numberOfBankAccounts);
}

double total = 0;

for (int i = 0; i < numberOfBankAccounts; i++)
{
    double input;// Convert.ToDouble(Console.ReadLine());

    do
    {
        Console.WriteLine($"What is the balance for account {(i + 1).ToString("N0")}? >>");
        answer = Console.ReadLine();
    } while (double.TryParse(answer, out input) == false);

    //total = total + input;
    total += input; //shorthand notation
}

Console.WriteLine($"The total of your {numberOfBankAccounts.ToString("N0")} accounts is {total.ToString("C")}.");

double average = total / numberOfBankAccounts;
Console.Write($"The average of your accounts is ");
if (average > 5000)
{
    Console.BackgroundColor = ConsoleColor.Green;
}
Console.WriteLine(average.ToString("C"));
