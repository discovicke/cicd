var kalle = new Duck { Name = "Kalle" };
Console.WriteLine(kalle.Quack());
var kalle2 = new Duck { Name = "Kalle2" };
public class Duck
{
    public required string Name { get; init; }

    public string Quack() => $"{Name} quacks!";
}