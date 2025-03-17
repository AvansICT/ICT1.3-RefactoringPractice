namespace ICT1._3_Refactoring.ExtractInterface;
/**
 ## Oefening: Extract Interface in C#

**Opdracht:**

De volgende C# code bevat een `UserRepository` klasse die de data access logica voor gebruikers beheert. Refactor de code om een interface te extraheren die het contract voor de `UserRepository` klasse definieert.

**Instructies:**

1. Creëer een nieuwe interface genaamd `IUserRepository`.
2. Voeg method signatures toe aan de `IUserRepository` interface voor de `GetUserById`, `SaveUser` en `DeleteUser` methoden van de `UserRepository` klasse.
3. Laat de `UserRepository` klasse de `IUserRepository` interface implementeren.
4. Pas de code in de `UserRepository` klasse aan om de interface te implementeren.

**Tips:**

* De interface moet alleen de publieke methoden van de `UserRepository` klasse bevatten die deel uitmaken van het contract dat je wilt definiëren.
* De interface moet een beschrijvende naam hebben die de functionaliteit die hij vertegenwoordigt duidelijk weergeeft.

**Code:**
 
 */

public class UserRepository
{
    private readonly List<User> users = new List<User>();
    private int nextId = 1;

    public User GetUserById(int id)
    {
        // Logica om gebruiker op te halen uit database
        return null; // Vervang dit door de daadwerkelijke implementatie
    }

    public void SaveUser(User user)
    {
        // Logica om gebruiker op te slaan in database
    }

    public void DeleteUser(int id)
    {
        // Logica om gebruiker te verwijderen uit database
    }

    private bool ValidateUserBeforeSave(User user)
    {
        // Logica om gebruiker te valideren voordat deze wordt opgeslagen
        return true;
    }
}
