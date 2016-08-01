using System;
using Zoolandia.Species;
using Zoolandia.Misc;
using System.Collections.Generic;


namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string prompt = "> ";
            bool keepGoing = true;
        
            AilurusFulgens redPanda = new AilurusFulgens("Randy Panda");
            CondyluraCristata starNosedMole = new CondyluraCristata("Hector");
            CricetulusGriseus chineseHamster = new CricetulusGriseus("Wang Haw");

            MicrocebusMurinus grayMouseLemur = new MicrocebusMurinus("Lem");
            MicrocebusMurinus greyMouseLemurAged = new MicrocebusMurinus(10);
            MicrocebusMurinus greyMouseLemurNamedAndAged = new MicrocebusMurinus("Lem", 10);

            GorillaBerengeiBerengei mountainGorilla = new GorillaBerengeiBerengei("Phil");
            GorillaGorillaDiehli crossRiverGorilla = new GorillaGorillaDiehli("Mark");
            GorillaGorillaGorilla westernLowlandGorilla = new GorillaGorillaGorilla("Craig");

            LemmusAmurensis amurLemming = new LemmusAmurensis("Larry");
            LemmusPortenkoi wrangelIslandLemming = new LemmusPortenkoi("Luke");
            LemmusSibiricus brownLemming = new LemmusSibiricus("Lonny");

            SpheniscusDemersus africanPenguin = new SpheniscusDemersus("Patch");
            SpheniscusHumboldti humboldtPenguin = new SpheniscusHumboldti("Perry");
            SpheniscusMendiculus galapagosPenguin = new SpheniscusMendiculus("Pete");

            while (keepGoing)
            {
               Console.WriteLine("Which do you want to learn more about? (Type the number in your command line.)");

                List<Animal> myZoo = new List<Animal>();
                myZoo.Add(redPanda);
                myZoo.Add(starNosedMole);
                myZoo.Add(chineseHamster);
                myZoo.Add(grayMouseLemur);
                myZoo.Add(mountainGorilla);
                myZoo.Add(crossRiverGorilla);
                myZoo.Add(westernLowlandGorilla);
                myZoo.Add(amurLemming);
                myZoo.Add(wrangelIslandLemming);
                myZoo.Add(brownLemming);
                myZoo.Add(africanPenguin);
                myZoo.Add(humboldtPenguin);
                myZoo.Add(galapagosPenguin);
                

                for (int i = 0; i < myZoo.Count; i++)
                {
                    Console.WriteLine(i + ": " + myZoo[i].Species);
                }

                Console.Write(prompt);
                int userWantsToKnowMoreAbout = Int32.Parse(Console.ReadLine());
                if (userWantsToKnowMoreAbout < myZoo.Count && userWantsToKnowMoreAbout >=0) {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(myZoo[userWantsToKnowMoreAbout].Bio()); 
                    Console.WriteLine();
                    Console.WriteLine();
                    myZoo[userWantsToKnowMoreAbout].FeedingTime();
                    Console.WriteLine();
                    Console.WriteLine();
                } else {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You effing idiot. How hard is it to type in a dang number. It is literally written RIGHT THERE above the prompt line. HOW MUCH MORE EASY DO I HAVE TO MAKE THIS FOR YOU TURDS?! You know what, fuck this. I'm leaving.");
                    Console.WriteLine();
                    Console.WriteLine(); 
                    Console.ResetColor();
                    Console.WriteLine("You know what, let's feed a gorilla. Name the gorilla you want to feed.");
                    Console.Write(prompt);
                    string gorillaName = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    GorillaGorillaGorilla myGorillaTestFeed = new GorillaGorillaGorilla(gorillaName);
                    Console.WriteLine("How many foods do you want to give " + myGorillaTestFeed.Name + "?");                                    
                    Console.Write(prompt);
                    int foodsForGorilla = Int32.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Now, type of food. Hint: he likes 'leaves'.");
                    Console.Write(prompt);
                    string foodTypeForGorilla = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(myGorillaTestFeed.Eat(foodsForGorilla, foodTypeForGorilla));
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
        }
    }
}


// Create a class Animal
    // Simple properties and methods - general to all animals
    // Use a mix of native C# types for properties
    // Choose one of the general methods that you created in the Animal class and make it virtual.
    // Add a new, overloaded constructor method to your animal that takes a single string as an argument.
    // Add another overloaded constructor method that will set the value of one of the int typed properties of your animal. Define an integer as an argument and then create another instance of your animal and pass it an integer.
    // Add ONE MORE constructor method! This method will accept both an integer and a string as arguments. Set the appropriate property values with the argument values.
// Create 3 species classes
// Decide on at least 15 species that you would like to include in your zoo and create a class for each species.
    // Create a constructor function for each of your animals. The constructor function should, at the very least, set the initial name of all animals of that type to a name of your choosing.
    // Derive properties and methods from Animal
    // Create some properties that apply only to that species
    // Use a mix of native C# types for properties
    // Override that method in all of your species classes, giving each a more specialized implementation.
// Create some instances of your species.
    //Assign values to the properties of each.
// Use Console.WriteLine(); to output the property values of your animals to the console.
