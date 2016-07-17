using System;
using Zoolandia;

namespace Zoolandia.Species
{
    public class CricetulusGriseus : Animal 
    {
        public CricetulusGriseus(string name) : base(name)
        {
            this.Diet = "omnivorous";
            this.Reproduction = "cannibals";
            this.Cute = true;
            this.Nocturnal = true;
        }
    }
}