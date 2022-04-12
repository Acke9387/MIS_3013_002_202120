
public class Student
{
    public string Name { get; set; }

    public int Id { get; set; }

    public List<double> Grades { get; set; }

    public Student()
    {
        Name = String.Empty;
        Id = 0;
        Grades = new List<double>();
    }

    public override string ToString()
    {
        double sum = 0, avg = 0;

        foreach (double grade in Grades)
        {
            sum += grade;
        }
        //sum = studGrades.Sum();
        //avg = studGrades.Average();

        avg = sum / Grades.Count;

        return $"{Name} ({Id}) has {Grades.Count.ToString("N")} # of grades with an average of {avg.ToString("P")}!";

    }

    public void StudentInformation()
    {
        double sum = 0, avg = 0;

        foreach (double grade in Grades)
        {
            sum += grade;
        }
        //sum = studGrades.Sum();
        //avg = studGrades.Average();

        avg = sum / Grades.Count;

        Console.WriteLine($"{Name} ({Id}) has {Grades.Count.ToString("N")} # of grades with an average of {avg.ToString("P")}!");

    }


}

