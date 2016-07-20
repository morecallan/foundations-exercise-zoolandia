using System;
using System.Globalization;
using Zoolandia;

namespace Zoolandia.Species
{
    public class CondyluraCristata : Animal 
    {
        public CondyluraCristata(string name) : base(name)
        {
            this.Diet = "omnivorous";
            this.Reproduction = "Prude";
            this.Cute = false;
            this.Nocturnal = true;
            this.Species = "Condylura Cristata";
        }

        public override string Eat(int numberOfFoods) {
            return base.Eat(numberOfFoods) + " Thanks for the " + numberOfFoods + " worms, dude.";
        }

    }
}