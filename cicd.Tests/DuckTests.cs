namespace cicd.Tests;

public class DuckTests
{
    [Theory]
    [InlineData("Kalle")]
    [InlineData("Donald")]
    [InlineData("Daisy")]
    [InlineData("")]
    [InlineData("A very long duck name 123")]
    public void Quack_ReturnsCorrectText_RegardlessOfName(string name)
    {
        // Arrange
        var duck = new Duck { Name = name };

        // Act
        var result = duck.Quack();

        // Assert
        Assert.Equal($"{name} quacks!", result);
    }
}
