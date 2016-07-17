using System;
using Zoolandia;

namespace Zoolandia.Species
{
    public class MicrocebusMurinus : Animal 
    {
        public MicrocebusMurinus(string name) : base(name)
        {
            this.Diet = "herbivorous";
            this.Reproduction = "swingers";
            this.Cute = true;
            this.Nocturnal = true;
        }
    }
}