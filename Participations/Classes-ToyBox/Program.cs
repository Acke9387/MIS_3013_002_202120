List<ToyBox> boxes = new List<ToyBox>();
do
{
    ToyBox tb = new ToyBox();
    Console.WriteLine("Please enter the owner's name of the ToyBox <<");
    tb.Owner = Console.ReadLine();

    Console.WriteLine("Please enter the location of the ToyBox <<");
    tb.Location = Console.ReadLine();

    tb.Toys = AskTheUserToCreateAsManyToysAsTheyWantForThisToyBox();

    boxes.Add(tb);
    Console.WriteLine("Do you want to create another Toy Box? yes or no <<");
} while (Console.ReadLine().ToLower() == "yes");

foreach (ToyBox box in boxes)
{
    Console.WriteLine($"{box.Owner}'s ToyBox located @ {box.Location} has the following toys:");
    foreach (Toy toy in box.Toys)
    {
        Console.WriteLine($"\t{toy}");
    }
}

foreach (ToyBox box1 in boxes)
{
    Console.WriteLine($"A random toy from {box1.Owner} is {box1.GetRandomToy()}");
}

static List<Toy> AskTheUserToCreateAsManyToysAsTheyWantForThisToyBox()
{
    List<Toy> toys = new List<Toy>();
    toys.Add(new Toy());
    return toys;
    do
    {
        Toy myToy = new Toy();
        string name, manufacturer, note;
        double price;

        Console.WriteLine($"Please enter the name of the toy <<");
        name = Console.ReadLine();

        Console.WriteLine($"Please enter the manufacturer of {name} <<");
        manufacturer = Console.ReadLine();

        Console.WriteLine($"Please enter the note for {name} <<");
        note = Console.ReadLine();

        Console.WriteLine($"Please enter the note for {name} <<");
        price = Convert.ToDouble(Console.ReadLine());

        myToy.AddNote(note);
        myToy.Name = name;
        myToy.Manufacturer = manufacturer;
        myToy.Price = price;

        toys.Add(myToy);

        Console.WriteLine("Do you want to create another toy? yes or no <<");
    } while (Console.ReadLine().ToLower() == "yes");

    return toys;
}