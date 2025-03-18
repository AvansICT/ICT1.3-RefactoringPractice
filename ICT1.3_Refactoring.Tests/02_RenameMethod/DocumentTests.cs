namespace ICT1._3_Refactoring.Tests.RenameMethod;

using ICT1._3_Refactoring.RenameMethod;

public class DocumentTests
{
    [Fact]
    public void DoIt_WithMultipleWords_PrintsCorrectWordCount()
    {
        // Arrange
        var output = new StringWriter();
        Console.SetOut(output);
        var document = new Document("The quick brown fox");

        // Act
        document.DoIt();
        var result = output.ToString().Trim();

        // Assert
        Assert.Equal("Aantal woorden: 4", result);
    }

    [Fact]
    public void DoIt_WithEmptyString_PrintsZeroWordCount()
    {
        // Arrange
        var output = new StringWriter();
        Console.SetOut(output);
        var document = new Document("");

        // Act
        document.DoIt();
        var result = output.ToString().Trim();

        // Assert
        Assert.Equal("Aantal woorden: 0", result);
    }

    [Fact]
    public void DoIt_WithSingleWord_PrintsOneWordCount()
    {
        // Arrange
        var output = new StringWriter();
        Console.SetOut(output);
        var document = new Document("Hello");

        // Act
        document.DoIt();
        var result = output.ToString().Trim();

        // Assert
        Assert.Equal("Aantal woorden: 1", result);
    }

    [Fact]
    public void DoIt_WithMultipleSpaces_HandlesSpacesCorrectly()
    {
        // Arrange
        var output = new StringWriter();
        Console.SetOut(output);
        var document = new Document("The   quick  brown   fox");

        // Act
        document.DoIt();
        var result = output.ToString().Trim();

        // Assert
        Assert.Equal("Aantal woorden: 4", result);
    }
}
