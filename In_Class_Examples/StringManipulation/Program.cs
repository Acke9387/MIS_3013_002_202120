//Define a variable with the variable name, 'name', of type string and assign the value of "hENRY JAMES" to it.
//

//             012345678910
string name = "hENRY JAMES";
int numberOfCharacters = name.Length;
Console.WriteLine($"Starting value: {name}.  It has {numberOfCharacters.ToString("n0")} characters.");
//Output 'name' with all lower-case letters.
//   e.g. henry james
string lowerName = name.ToLower();
Console.WriteLine($"Lower-case version of the variable {lowerName}.");
Console.WriteLine();

//Output the first letter of the first name and last name found in 'name' with a period after each letter. 
//   e.g. H.J.
char firstNameInitial = name.ToUpper()[0];
char lastNameInitial;// = name.ToUpper()[6]; // 6 works for henry james, but we want to make it work for all instances
int indexOfSpace = name.IndexOf(' ');
lastNameInitial = name.ToUpper()[indexOfSpace + 1];

Console.WriteLine($"Initials: {firstNameInitial}.{lastNameInitial}.");
Console.WriteLine();

//Output the 'name' with correct punctuation (the first letter of the first and last name should be capitilized)
//   e.g. Henry James

string firstname, lastname;

firstname = firstNameInitial + name.ToLower().Substring(1, indexOfSpace - 1);
lastname = lastNameInitial +  name.Substring(indexOfSpace+2).ToLower();

Console.WriteLine($"Full name w/ punctuation: {firstname} {lastname}");