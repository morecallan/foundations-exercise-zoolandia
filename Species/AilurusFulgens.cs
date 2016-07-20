using System;
using Zoolandia;

namespace Zoolandia.Species
{
    public class AilurusFulgens : Animal 
    {
        public AilurusFulgens(string name) : base(name)
        {
            this.Diet = "carnivorous";
            this.Reproduction = "Swinger";
            this.Cute = true;
            this.Nocturnal = true;
            this.Species = "Ailurus Fulgens";
        }

        //Grooming: occurs while in a tree and shortly after awakening or eating
        private string Grooming() {
            return "Check it out! " + this.Name + " is using this opporunity to groom in a cat-like, sitting posture. Tongue is applied to legs, chest, flanks, tail, and genitals with a downward motion";
        }

        public override string Eat(int numberOfFoods) {
            return base.Eat(numberOfFoods) + " " + this.Grooming();
        }
    }
}