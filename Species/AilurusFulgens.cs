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
    }
}