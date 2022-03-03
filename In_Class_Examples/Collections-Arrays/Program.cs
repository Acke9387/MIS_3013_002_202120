/*
 * Create two parallel arrays.  
 * The first will hold student id’s and the second will hold their overall GPA.  
 * Ask the user for one of the id’s that they want to see the GPA for and then output it.
 * 
 * 
 */
//                  0  1  2
int[] studentIds = {1, 2, 3};
studentIds[0] = 10;

double gpa = 5;
double[] studentGpas = new double[studentIds.Length];
studentGpas[0] = 3.2;
studentGpas[1] = 4.0;
studentGpas[2] = 2.7;

Console.WriteLine("Here are all the id's of the students :\t");

for (int i = 0; i < studentIds.Length; i++)
{
    Console.Write(studentIds[i] + "\t");
}
Console.WriteLine();
Console.WriteLine("Which student do you want to see the gpa of? >>");
int id = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < studentIds.Length; i++)
{
    int studentId = studentIds[i];

    if (studentId == id)
    {
        Console.WriteLine($"{id} has a gpa of {studentGpas[i]}");
        break;
    }
}