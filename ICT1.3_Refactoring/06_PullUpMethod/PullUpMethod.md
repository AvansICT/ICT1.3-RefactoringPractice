## Oefening: Pull Up Method in C#

**Opdracht:**

De volgende C# code bevat twee subklassen, `Dog` en `Cat`, die beide een methode `MakeSound()` hebben met gelijkaardige functionaliteit. Refactor de code om de `MakeSound()` methode naar de gemeenschappelijke superklasse `Animal` te verplaatsen.

**Instructies:**

1. Creëer een nieuwe methode `MakeSound()` in de `Animal` klasse.
2. Maak de `MakeSound()` methode in de `Animal` klasse `virtual` zodat deze door overervende klasses opnieuw geimplementeerd kan worden.
3. Verplaats de implementatie van de `MakeSound()` methode van de `Dog` en `Cat` klassen naar de `Animal` klasse.
4. Overschrijf de `MakeSound()` methode in de `Dog` en `Cat` klassen om het specifieke gedrag voor elke subklasse te implementeren.
5. Verwijder het casten (`((Cat)aCat)`).
6. Experimenteer met verschillende manieren van aanmaken:
    Animal animal = new Animal(); animal.MakeSound();
    Animal aCat = new Cat(); aDog.MakeSound();
    Cat aCat2 = new Cat(); aCat2.MakeSound();
    Cat aCat3 = new Animal(); aCat3.MakeSound();

**Tips:**

* De `MakeSound()` methode in de `Animal` klasse kan een standaard implementatie bevatten die door de subklassen kan worden overschreven.
* Je kunt de `override` keyword gebruiken om aan te geven dat een methode in een subklasse een methode in de superklasse overschrijft.

**Code:**