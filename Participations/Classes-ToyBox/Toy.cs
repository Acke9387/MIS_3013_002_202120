
public  class Toy
{
    public string Manufacturer { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    private string Notes;

    public Toy()
    {
        Manufacturer = string.Empty;
        Name = string.Empty;
        Price = 0;
        Notes = string.Empty;
    }

    public Toy(string note)
    {
        Manufacturer = string.Empty;
        Name = string.Empty;
        Price = 0;
        Notes = note;
    }

    public void AddNote(string note)
    {
        Notes = note;
    }

    public override string ToString()
    {
        return $"{Name} is made by {Manufacturer} and costs {Price.ToString("C")}.  You can find it on aisle {GetAisle()}.\n\t{Notes}";
    }

    public string GetAisle()
    {
        string aisle;
        int aisleNbr;

        Random r = new Random();
        aisleNbr = r.Next(1, 25);

        aisle = Manufacturer[0].ToString().ToUpper() + aisleNbr.ToString();

        return aisle;
    }

}
