## Oefening: Replace Data Value with Object in C#

**Opdracht:**

De volgende C# code gebruikt een string-veld om het telefoonnummer van een klant op te slaan. Refactor de code om de telefoonnummer string property te vervangen door een `PhoneNumber` object.

**Instructies:**
0. Maak een aantal unit tests om de huidige functionaliteit te testen.
    0.1 Deze kun je toevoegen onder 04_ReplaceDataValueWithObject/CustomerTests.cs in het test project.
1. Creëer een nieuwe klasse genaamd `PhoneNumber`.
2. Voeg een string property `Number` toe aan de `PhoneNumber` klasse om het telefoonnummer op te slaan.
3. Verplaats de `IsValidPhoneNumber` en `GetFormattedPhoneNumber` methoden van de `Customer` klasse naar de `PhoneNumber` klasse. 
4. Pas de methoden in de `PhoneNumber` klasse aan zodat ze werken met de `Number` property.
5. Vervang de `string PhoneNumber` property in de `Customer` klasse door een `PhoneNumber PhoneNumber` property.
6. Pas de code in de `Customer` klasse aan om de nieuwe `PhoneNumber` object te gebruiken.
7. Maak nieuwe unit tests zodat de nieuwe klasse en methodes getest worden.

**Tips:**

* De `PhoneNumber` klasse moet goed geëncapsuleerd zijn en de interne details van het telefoonnummer verbergen.
* De `PhoneNumber` klasse kan extra functionaliteit bevatten, zoals het valideren van het telefoonnummer formaat of het opsplitsen van het telefoonnummer in landcode, netnummer en abonneenummer.
