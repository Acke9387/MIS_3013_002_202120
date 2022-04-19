Toy t1 = new Toy();
t1.Manufacturer = "Hasbro";
t1.Name = "Life";
t1.Price = 14.99;
t1.AddNote("Fun for all ages!");

Toy t2 = new Toy("Ruins friendships");
t2.Manufacturer = "Hasbro";
t2.Name = "Monopoly";
t2.Price = 19.99;

List<Toy> toys = new List<Toy>();

toys.Add(t1);
toys.Add(t2);

foreach (Toy toy in toys)
{
    Console.WriteLine(toy);
}