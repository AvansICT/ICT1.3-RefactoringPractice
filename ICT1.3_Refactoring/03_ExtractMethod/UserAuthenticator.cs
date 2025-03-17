using System.Security.Cryptography;
using System.Text;

/**
## Oefening: Extract Method in C#

**Opdracht:**

De volgende C# code bevat een lange methode die meerdere taken uitvoert. Refactor de code om de leesbaarheid te verbeteren door een deel van de code te extraheren naar een nieuwe methode.


**Instructies:**

1. Identificeer een logisch blok code in de `AuthenticateUser` methode dat een specifieke taak uitvoert.
2. Selecteer het blok code dat je wilt extraheren.
3. De de refactoring handmatig of gebruik de refactoring tool "Extract Method" in Visual Studio Code om de code naar een nieuwe methode te extraheren. (VS Code refactoring werkt niet goed in notebooks...)
4. Geef de nieuwe methode een beschrijvende naam, bijvoorbeeld `CompareHashedPasswords`.
5. Pas de `AuthenticateUser` methode aan om de nieuwe methode aan te roepen.

**Tips:**

* De nieuwe methode moet alle parameters ontvangen die hij nodig heeft om de taak uit te voeren.
* De nieuwe methode moet een return waarde hebben als hij een waarde berekent die nodig is in de aanroepende methode.
* Zorg ervoor dat de nieuwe methode goed geëncapsuleerd is en geen onnodige afhankelijkheden heeft van de `UserAuthenticator` klasse.

**Code:**

*/

public abstract class UserAuthenticator
{
    List<string> users = new List<string> { "alice", "bob", "charlie" };

    // Concrete class implements this, ignore for this exercise
    public abstract string ExecuteQuery(string qry);

    public bool AuthenticateUser(string username, string password)
    {
        // 1. Check if the username exists in the database.
        bool userExists;
        if (users == null || users.Count() == 0)
            userExists = false;
        if (users.Any(u => u == username))
        {
            userExists = true;
        }
        else
        {
            userExists = false;
        }

        if (!userExists)
        {
            return false;
        }

        // 2. Retrieve the user's hashed password from the database.
        string qry = "SELECT password FROM users WHERE username = '" + username + "'";
        string storedHashedPassword = ExecuteQuery(qry);

        // 3. Hash the provided password.
        byte[] providedPwdAsBytes;
        byte[] hashedProvidedPasswordAsBytes;

        //Create a byte array from source data.
        providedPwdAsBytes = ASCIIEncoding.ASCII.GetBytes(password);

        hashedProvidedPasswordAsBytes = SHA256
            .Create()
            .ComputeHash(providedPwdAsBytes);

        StringBuilder pwdStringBuilder = new StringBuilder(hashedProvidedPasswordAsBytes.Length);

        for (int i = 0; i < hashedProvidedPasswordAsBytes.Length; i++)
        {
            pwdStringBuilder.Append(hashedProvidedPasswordAsBytes[i].ToString("X2"));
        }
        string hashedPasswordAsString = pwdStringBuilder.ToString();


        // 4. Compare the hashed passwords.
        if (storedHashedPassword == hashedPasswordAsString)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // ... other methods ...
}