
string[] names = { "John", "Jane", "Marry", "Herman", "Kylie" };
int[] ids = { 1, 2, 3, 4, 5 };
List<List<double>> grades = new List<List<double>>();
//grades.Add(new List<double>());
//grades[0].Add(.53);
//grades[0].Add(.73);
//grades[0].Add(.83);
//grades[0].Add(.93);
grades.Add(CreateRandomSizedListWithRandomValues());
grades.Add(CreateRandomSizedListWithRandomValues());
grades.Add(CreateRandomSizedListWithRandomValues());
grades.Add(CreateRandomSizedListWithRandomValues());
grades.Add(CreateRandomSizedListWithRandomValues());

//StudentInformation(names[0], ids[0], grades[0]);
//StudentInformation(names[1], ids[1], grades[1]);

for (int i = 0; i < names.Length; i++)
{
    StudentInformation(names[i], ids[i], grades[i]);
}


static void StudentInformation(string studName, int studId, List<double> studGrades)
{
    double sum =0, avg = 0;

    foreach (double grade in studGrades)
    {
        sum += grade;
    }
    //sum = studGrades.Sum();
    //avg = studGrades.Average();

    avg = sum / studGrades.Count;

    Console.WriteLine($"{studName} ({studId}) has {studGrades.Count.ToString("N")} # of grades with an average of {avg.ToString("P")}!");

}

static List<double> CreateRandomSizedListWithRandomValues()
{
    List<double> randoGrades = new List<double>();
    Random rand = new Random();
    int numberOfGrades = rand.Next(3, 8);

    for (int i = 0; i < numberOfGrades; i++)
    {
        double grade = rand.NextDouble();
        randoGrades.Add(grade);
    }

    return randoGrades;
}