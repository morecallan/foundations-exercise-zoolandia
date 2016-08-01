using System.Collections.Generic;


namespace Zoolandia.Habitats
{
    class VIP : Habitat
    {
        public VIP (Animal featuredAnimal) : base(featuredAnimal)
        {
            this.PublicName = "VIP";
        }
    }
}