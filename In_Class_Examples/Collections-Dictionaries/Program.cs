/*
 * Create a dictionary that the key will be the student id and the value will be their GPA.
 *  Ask the user if there is another student they want to add, make sure it doesn’t exist then add it
 *  Ask them for a student id and output their GPA
 * 
 */

Dictionary<int, double> students = new Dictionary<int, double>();

students.Add(10, 3.2);
students.Add(2, 4.0);
students.Add(3, 2.7);

Console.WriteLine("Give us a student id to add >>");
int studId = Convert.ToInt32(Console.ReadLine());

if (students.ContainsKey(studId) == false)
{
    Console.WriteLine("Give us the student's GPA >>");
    double studGpa = Convert.ToDouble(Console.ReadLine()); 
    students.Add(studId, studGpa);
}
else
{
    Console.WriteLine($"{studId} already exists so I am not doing anything ...");
}


Console.Write("Student ids: \t");
foreach (int id in students.Keys)
{
    Console.Write(id + "\t");
}

Console.WriteLine();
Console.WriteLine("Which student do you want to see the gpa of? >>");
studId = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Student with id {studId} has a gpa of {students[studId]}");