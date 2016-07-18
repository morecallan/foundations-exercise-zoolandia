using System;
using Zoolandia.Species;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AilurusFulgens redPanda = new AilurusFulgens("Randy Panda");
            Console.WriteLine(redPanda.Bio());
            CondyluraCristata starNosedMole = new CondyluraCristata("Hector");
            Console.WriteLine(starNosedMole.Bio());
            CricetulusGriseus chineseHamster = new CricetulusGriseus("Wang Haw");
            Console.WriteLine(chineseHamster.Bio());
            MicrocebusMurinus grayMouseLemur = new MicrocebusMurinus("Lem");
            Console.WriteLine(grayMouseLemur.Bio());
        }
    }
}


//Create a class Animal
    // Simple properties and methods - general to all animals
    // Use a mix of native C# types for properties
//Create 3 species classes
    // Derive properties and methods from Animal
    // Create some properties that apply only to that species
    // Use a mix of native C# types for properties
// Create some instances of your species.
    //Assign values to the properties of each.
// Use Console.WriteLine(); to output the property values of your animals to the console.
