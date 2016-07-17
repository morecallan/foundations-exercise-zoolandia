using System;
using Zoolandia;

namespace Zoolandia.Species
{
    public class CondyluraCristata : Animal 
    {
        public CondyluraCristata(string name) : base(name)
        {
            this.Diet = "omnivorous";
            this.Reproduction = "prudes";
            this.Cute = false;
            this.Nocturnal = true;
        }
    }
}