
public class ToyBox
{
    public List<Toy> Toys { get; set; } // Had to make it a list of string so it would work

    public string Owner { get; set; }

    public string Location { get; set; }


    public ToyBox()
    {
        Toys = new List<Toy>();
        Owner = string.Empty;
        Location = string.Empty;
    }

    public Toy GetRandomToy()
    {
        Random random = new Random();
        int index = random.Next(0, Toys.Count);

        return Toys[index];
    }

}

