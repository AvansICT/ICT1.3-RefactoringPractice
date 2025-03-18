namespace ICT1._3_Refactoring.ReplaceMagicNrWithConstant;

/**
## Oefening: Replace Magic Number with Symbolic Constant in C#

**Opdracht:**

De volgende C# code bevat meerdere "magic numbers" (hardcoded waardes). Refactor de code om deze magic numbers te vervangen door beschrijvende constante variabelen.

**Instructies:**

1. Identificeer alle magic numbers in de code.
2. Bedenk voor elke magic number een beschrijvende naam voor een constante variabele.
3. Declareer de constante variabelen in de `OrderProcessor` klasse.
4. Vervang de magic numbers in de code door de gedeclareerde constanten.

**Conventies:**

* Gebruik de `const` keyword voor constanten die tijdens compilatie bekend zijn.
* Gebruik PascalCase voor de namen van constante variabelen.
* Plaats de constanten op een logische plaats in de klasse.
  * Dicht bij gebruik of juist ergens bovenaan in het bestand? Of een aparte unit?


**Code:**


*/

// Werk deze code uit
public class OrderProcessor 
{
    public decimal CalculateDiscount(decimal orderAmount) 
    {
        if (orderAmount > 100) 
        {
            return orderAmount * 0.1m; 
        } 
        else 
        {
            return 0;
        }
    }

    public decimal CalculateShippingCost(decimal orderWeight) 
    {
        if (orderWeight > 5) 
        {
            return 10m;
        } 
        else 
        {
            return 5m;
        }
    }

    public int GetMaximumOrderQuantity() 
    {
        return 50;
    }
}