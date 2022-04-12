
string[] names = { "John", "Jane", "Marry", "Herman", "Kylie" };
List<Student> students = new List<Student>();

for (int i = 0; i < names.Length; i++)
{
    Student x = new Student();
    x.Name = names[i];
    x.Id = i + 1;
    x.Grades = CreateRandomSizedListWithRandomValues();

    students.Add(x);
}


foreach (Student student in students)
{
    //student.StudentInformation();

    Console.WriteLine(student);
}



Student s = new Student(); ;
s.Id = 2;


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