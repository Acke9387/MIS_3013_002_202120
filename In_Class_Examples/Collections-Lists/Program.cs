/*
 * Using a List, ask the user to enter all of their favorite things.  
 * Once they are done, randomly pick a value from the list and display it.
 * 
 * 
 */

List<string> favoriteThings = new List<string>();

do
{
    Console.WriteLine("Enter one of your favorite things >>");
    string answer = Console.ReadLine();
    favoriteThings.Add(answer);

    Console.WriteLine("Do you have another favorite thing? yes or no>>");
} while (Console.ReadLine().ToLower()[0] == 'y');

Console.WriteLine("A random favorite thing from your items is :");

Random random = new Random();
int randomIndex = random.Next(0, favoriteThings.Count);

Console.WriteLine(favoriteThings[randomIndex]);

//output all favorite things
Console.WriteLine("All of your favorite things are:");

//For equivalent of foreach
//for (int i = 0; i < favoriteThings.Count; i++)
//{
//    string thing = favoriteThings[i];
//    Console.Write(thing);
//}

foreach (string thing in favoriteThings)
{
    Console.Write(thing);
}