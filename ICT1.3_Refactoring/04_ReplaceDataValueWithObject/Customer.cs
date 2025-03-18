
using System.Text.RegularExpressions;

namespace ICT1._3_Refactoring.ReplaceDataValueWithObject;

/**
 ## Oefening: Replace Data Value with Object in C#

**Opdracht:**

De volgende C# code gebruikt een string-veld om het telefoonnummer van een klant op te slaan. Refactor de code om de telefoonnummer string property te vervangen door een `PhoneNumber` object.

**Instructies:**

1. Creëer een nieuwe klasse genaamd `PhoneNumber`.
2. Voeg een string property `Number` toe aan de `PhoneNumber` klasse om het telefoonnummer op te slaan.
3. Verplaats de `IsValidPhoneNumber` en `GetFormattedPhoneNumber` methoden van de `Customer` klasse naar de `PhoneNumber` klasse. 
4. Pas de methoden in de `PhoneNumber` klasse aan zodat ze werken met de `Number` property.
5. Vervang de `string PhoneNumber` property in de `Customer` klasse door een `PhoneNumber PhoneNumber` property.
6. Pas de code in de `Customer` klasse aan om de nieuwe `PhoneNumber` object te gebruiken.

**Tips:**

* De `PhoneNumber` klasse moet goed geëncapsuleerd zijn en de interne details van het telefoonnummer verbergen.
* De `PhoneNumber` klasse kan extra functionaliteit bevatten, zoals het valideren van het telefoonnummer formaat of het opsplitsen van het telefoonnummer in landcode, netnummer en abonneenummer.

**Code:**
 
 */

public class Customer
{
    public required string Name { get; set; }
    public required string PhoneNumber { get; set; }

    public bool IsValidPhoneNumber()
    {
        // Accepteert nummers met +31, 06, 0031 etc.
        // TODO: misschien vervangen door library LibPhoneNumber-csharp?
        string pattern = @"^(?:(?:\+|00)31|0)\s*[1-9](?:\d{8}|\d{2}\s*\d{6}|\d{3}\s*\d{5})$";

        return Regex.IsMatch(PhoneNumber, pattern, RegexOptions.Compiled);
    }

    public string GetFormattedPhoneNumber()
    {
        // Logica om telefoonnummer te formatteren
        
        // TODO: PhoneNumber is nu een string, erg lastig om fatsoenlijk te formatteren.
        //          Maak PhoneNumber een eigen klasse met b.v.
        //          CountryCode, AreaCode, SubscriberNumber properties
        return PhoneNumber; // Vervang dit door de daadwerkelijke formatteerlogica
    }
}