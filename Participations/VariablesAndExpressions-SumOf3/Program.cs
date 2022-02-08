Console.WriteLine("Please input your first number >>");
string answer1 = Console.ReadLine();
double val1 = Convert.ToDouble(answer1);

Console.WriteLine("Please input your second number >>");
string answer2 = Console.ReadLine();
double val2 = Convert.ToDouble(answer2);

Console.WriteLine("Please input your third number >>");
string answer3 = Console.ReadLine();
double val3 = Convert.ToDouble(answer3);

double sum = val1 + val1 + val3;


Console.WriteLine($"{val1.ToString("N3")} + {val2.ToString("N3")} + {val3.ToString("N3")} = {sum.ToString("N3")}");

const double MAGIC_NUMBER = 7.777;
double newTotal = sum * MAGIC_NUMBER;

Console.WriteLine($"{sum.ToString("N3")} * {MAGIC_NUMBER.ToString("N3")} = {newTotal.ToString("N3")}");