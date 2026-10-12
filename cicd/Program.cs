var kalle = new Duck { Name = "Kalle" };
Console.WriteLine(kalle.Quack());
public class Duck
{
    public required string Name { get; init; }

    public string Quack() => $"{Name} quacks!";
}