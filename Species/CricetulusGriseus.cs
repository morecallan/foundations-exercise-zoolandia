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
            this.CommonName = "Chinese Hamster";
        }

        public override string Sleep() {
            DateTime now = DateTime.Now;
            int currentMonth = now.Month;
            string hibernationResponse;
            if (currentMonth > 3 && currentMonth < 11) {
                hibernationResponse = "When it gets cold enough, " + this.Name + " will hibernate!";
            } else {
                hibernationResponse = "Brrrrr, it's cold outside. " + this.Name + "is hibernating.";
            }
            return base.Sleep() + " " + hibernationResponse;
        }
    }
}