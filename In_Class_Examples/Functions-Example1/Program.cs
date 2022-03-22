Console.WriteLine("Please enter your accounting grade (e.g. .70, .95) >>");
string answer = Console.ReadLine();
double accountingGrade = VerifyGradeInput(answer, "accounting");

string acctLetterGrade = ConvertGradeToLetterGrade(accountingGrade);


Console.WriteLine($"{accountingGrade.ToString("P")} = {acctLetterGrade}");
Console.WriteLine("Please enter your marketing grade (e.g. .70, .95) >>");

double marketingGrade = VerifyGradeInput(Console.ReadLine(), "marketing");
Console.WriteLine($"{marketingGrade.ToString("P")} = {ConvertGradeToLetterGrade(marketingGrade)}");


static double VerifyGradeInput(string answer, string subject)
{
    double grade = -1;

    while (double.TryParse(answer, out grade) == false || (grade < 0 || grade > 1))
    {
        Console.WriteLine($"{answer} is not valid. Please enter your {subject} grade >>");
        answer = Console.ReadLine(); 
    }


    return grade;
}

static string ConvertGradeToLetterGrade(double grade) // Function/Method Signature
{
    string letter = "";

    if (grade >= .90)
    {
        letter = "A";
    }
    else if (grade >= .80)
    {
        letter = "B";
    }
    else if (grade >= .70)
    {
        letter = "C";
    }
    else if (grade >= .60)
    {
        letter = "D";
    }
    else
    {
        letter = "F";
    }

    return letter;
}