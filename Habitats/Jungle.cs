using System.Collections.Generic;


namespace Zoolandia.Habitats
{
    class Jungle : Habitat
    {
        public Jungle (Animal featuredAnimal) : base(featuredAnimal)
        {
            this.PublicName = "Jungle";
        }
    }
}