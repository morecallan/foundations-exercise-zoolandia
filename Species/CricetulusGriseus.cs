using System;
using Zoolandia;

namespace Zoolandia.Species
{
    public class CricetulusGriseus : Animal 
    {
        public CricetulusGriseus(string name) : base(name)
        {
            this.Diet = "omnivorous";
            this.Reproduction = "Cannibal";
            this.Cute = true;
            this.Nocturnal = true;
            this.Species = "Cricetulus Griseus";
        }

        public override string Sleep() {
            return base.Sleep() + " When it gets cold enough, " + this.Name + " will hibernate!";
        }
    }
}