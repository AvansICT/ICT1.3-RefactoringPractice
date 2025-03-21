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
*/

public class UserRepository
{
    private readonly List<User> users = new List<User>();
    private int nextId;

    /// <summary>
    /// Initializes a new instance of the UserRepository class. It creates a list of users with predefined IDs.
    /// </summary>
    public UserRepository()
    {
        users = new () { 
            new User { Id = 1 }, 
            new User { Id = 2 }, 
            new User { Id = 3 }, 
        };
    }

    /// <summary>
    /// Retrieves a user from the storage based on a unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier used to find the specific user in the storage.</param>
    /// <returns>Returns the user object if found, otherwise returns null.</returns>
    public User? GetUserById(int id)
    {
        // Logica om gebruiker op te halen uit database
        return users.SingleOrDefault(u => u.Id == id);
    }

    /// <summary>
    /// Saves a user to the storage after validating their information.
    /// </summary>
    /// <param name="user">An object representing the user to be saved.</param>
    /// <returns>Returns true if the user is successfully saved, otherwise false.</returns>
    public bool SaveUser(User user)
    {
        user.Id = users.Select(u => u.Id).Max() + 1;
        if (ValidateUserBeforeSave(user))
        {
            // Logica om gebruiker op te slaan in database
            users.Add(user);
            return true;
        }

        return false;
    }

    /// <summary>
    /// Deletes the user with the specified id from the storage
    /// </summary>
    /// <param name="id">The unique identifier used to find the specific user in the storage.</param>
    public void DeleteUser(int id)
    {
        // Logica om gebruiker te verwijderen uit database
        User? user = users.SingleOrDefault(u => u.Id == id);
        if (user is not null)
        { 
            users.Remove(user); 
        }
    }

    /// <summary>
    /// Validates a user before saving to ensure they are not already present and have a valid ID.
    /// </summary>
    /// <param name="user">Checks if the user is already in the system and if their ID is set correctly.</param>
    /// <returns>Returns true if the user is valid for saving, otherwise false.</returns>
    private bool ValidateUserBeforeSave(User user)
    {
        // Logica om gebruiker te valideren voordat deze wordt opgeslagen
        if (users.Contains(user) && user.Id == default || user.Id != default)
        {
            return false;
        }

        return true;
    }
}
