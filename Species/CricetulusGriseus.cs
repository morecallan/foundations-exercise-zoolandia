using System;
using Zoolandia.Interfaces;

namespace Zoolandia.Species
{
    public class CricetulusGriseus : Animal, IHibernate
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

        public string PrepareForWinter()
        {
            return this.Name + " gathers adequate food and woodchips to prepare for the vicious winter in HoarderZoo";
        }

        public string WakeFromLongNap()
        {
            return this.Name + " awakens and is excited that they woke up just in time for Game of Thrones to premier";
        }

        public override string Sleep() 
        {
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