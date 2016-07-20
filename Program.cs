﻿using System;
using Zoolandia.Species;
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
            MicrocebusMurinus grayMouseLemur = new MicrocebusMurinus("Lem", 10);

            Console.WriteLine(grayMouseLemur.Age);

            

            while (keepGoing)
            {
               Console.WriteLine("Which do you want to learn more about? (Type the number in your command line.)");

                List<Animal> myZoo = new List<Animal>();

                //Adding items to a list is really easy
                myZoo.Add(redPanda);
                myZoo.Add(starNosedMole);
                myZoo.Add(chineseHamster);
                myZoo.Add(grayMouseLemur);

                for (int i = 0; i < myZoo.Count; i++)
                {
                    Console.WriteLine(i + ": " + myZoo[i].Species);
                }

                Console.Write(prompt);
                int userWantsToKnowMoreAbout = Int32.Parse(Console.ReadLine());
                if (userWantsToKnowMoreAbout <= myZoo.Count && userWantsToKnowMoreAbout >=0) {
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
                    Console.WriteLine("You effing idiot. How hard is it to type in a dang number. It is literally written RIGHT THERE above the prompt line. HOW MUCH MORE EASY DO I HAVE TO MAKE THIS FOR YOU TURDS?! You know what, fuck this. I'm leaving."); 
                    keepGoing = false;
                }
                
            }
        }
    }
}


//Create a class Animal
    // Simple properties and methods - general to all animals
    // Use a mix of native C# types for properties
    // Choose one of the general methods that you created in the Animal class and make it virtual.
    // Add a new, overloaded constructor method to your animal that takes a single string as an argument.
    // Add another overloaded constructor method that will set the value of one of the int typed properties of your animal. Define an integer as an argument and then create another instance of your animal and pass it an integer.
//Create 3 species classes
    // Create a constructor function for each of your animals. The constructor function should, at the very least, set the initial name of all animals of that type to a name of your choosing.
    // Derive properties and methods from Animal
    // Create some properties that apply only to that species
    // Use a mix of native C# types for properties
    // Override that method in all of your species classes, giving each a more specialized implementation.
// Create some instances of your species.
    //Assign values to the properties of each.
// Use Console.WriteLine(); to output the property values of your animals to the console.
