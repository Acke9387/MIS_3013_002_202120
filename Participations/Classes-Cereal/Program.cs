string[] linesOfFile = File.ReadAllLines("Cereal_Data.txt");

List<Cereal> allCereals = new List<Cereal>();

//linesOfFile[0] : name | manufacturer | calories | cups
//linesOfFile[1] : 100 % Bran | Nabisco | 70 | 0.33

//Cereal c = new Cereal();
//c.Name = "100 % Bran";
//c.Manufacturer = "Nabisco";
//c.Cups = 0.33;
//c.Calories = 70;
//allCereals.Add(c);

for (int i = 1; i < linesOfFile.Length; i++)
{
    string currentLineOfFile = linesOfFile[i];
    //currentLineOfFile: "100 % Bran | Nabisco | 70 | 0.33"
    string[] piecesOfFile = currentLineOfFile.Split('|');

    //piecesOfFile[0] : "100 % Bran"
    //piecesOfFile[1] : "Nabisco" 
    //piecesOfFile[2] : "70"
    //piecesOfFile[3] : "0.33"
    Cereal temp = new Cereal();
    temp.Name = piecesOfFile[0];
    temp.Manufacturer = piecesOfFile[1];
    temp.Calories = Convert.ToDouble(piecesOfFile[2]);
    temp.Cups = Convert.ToDouble(piecesOfFile[3]);

    allCereals.Add(temp);
}

//The application should output all of the Cereal information that have a serving size that is 1 cup or more.

Console.WriteLine("Cereals with a serving size of 1 cup or more are:");
foreach (Cereal c in allCereals)
{
    if (c.Cups >= 1)
    {
        Console.WriteLine("\t" + c);
    }
}

//After you output all those cereals, we also need to inform them which Cereals have 100 calories or less per serving.
Console.WriteLine("Cereals with 100 calories or less are:");
OutputCerealsWithCalorieConstraint(allCereals, 100);

static void OutputCerealsWithCalorieConstraint(List<Cereal> temp, double calorieThreshold)
{
    foreach (Cereal c in temp)
    {
        if (c.Calories <= calorieThreshold)
        {
            Console.WriteLine("\t" + c);
        }
    }
}