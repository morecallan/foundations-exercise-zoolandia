using System.Collections.Generic;


namespace Zoolandia.Habitats
{
    class ArcticTundra : Habitat
    {
        public ArcticTundra (Animal featuredAnimal) : base(featuredAnimal)
        {
            this.PublicName = "Arcitc Tundra";
            this.FeaturedAnimal = featuredAnimal;
        }
    }
}