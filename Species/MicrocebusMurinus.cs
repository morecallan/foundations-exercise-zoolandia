using System;
using Zoolandia;

namespace Zoolandia.Species
{
    public class MicrocebusMurinus : Animal 
    {
        public MicrocebusMurinus(string name) : base(name)
        {
            this.Diet = "herbivorous";
            this.Reproduction = "Swinger";
            this.Cute = true;
            this.Nocturnal = true;
            this.Species = "Microcebus Murinus";
            this.CommonName = "Gray Mouse Lemur";
        }

        public MicrocebusMurinus(int age) : base(age)
        {
            this.Diet = "herbivorous";
            this.Reproduction = "Swinger";
            this.Cute = true;
            this.Nocturnal = true;
            this.Species = "Microcebus Murinus";
        }

        public MicrocebusMurinus(string name, int age) : base(name, age)
        {
            this.Diet = "herbivorous";
            this.Reproduction = "Swinger";
            this.Cute = true;
            this.Nocturnal = true;
            this.Species = "Microcebus Murinus";
        }
    }
}