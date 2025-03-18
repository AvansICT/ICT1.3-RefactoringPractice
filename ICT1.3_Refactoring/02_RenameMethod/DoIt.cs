using System.Text.RegularExpressions;

namespace ICT1._3_Refactoring.RenameMethod;

/**

## Oefening: Rename Method

**Opdracht:**

De volgende C# code bevat een methode met een onduidelijke naam. Refactor de code om de methode een meer beschrijvende naam te geven.

**Instructies:**

1. Analyseer de code in de `doIt()` methode.
2. Bedenk een meer beschrijvende naam voor de `doIt()` methode die de functionaliteit van de methode accuraat weergeeft.
3. Hernoem de methode met behulp van de refactoring tool "Rename Symbol".

**Tips:**

* Gebruik een werkwoord in de methodenaam om de actie die de methode uitvoert te beschrijven.
* Volg de C# naming conventions (PascalCase voor methoden).
* Zorg ervoor dat de nieuwe naam consistent is met de rest van de code.

**Code:**



*/

public class Document
{
    private string text;

    public Document(string text)
    {
        this.text = text;
    }

    public void DoIt()
    {
        Regex trimmer = new Regex(@"\s\s+", RegexOptions.Compiled);
        var trimmedText = trimmer.Replace(text, " ");
        string[] words = trimmedText.Split(' ');
        int wordCount = string.IsNullOrWhiteSpace(trimmedText) ? 0 : words.Length;
        
        Console.WriteLine("Aantal woorden: " + wordCount);
    }
}

public class DoIt
{
    public void Do()
    {
        Document doc = new("The quick brown fox jumps over the lazy dog 0123456789");
        doc.DoIt();
    }
}