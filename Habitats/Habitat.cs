using System.Collections.Generic;


namespace Zoolandia.Habitats
{
    class Habitat
    {
        public Habitat(Animal featuredAnimal)
        {
            this.FeaturedAnimal = featuredAnimal;
        }
        public List<Animal> inhabitants = new List<Animal>();
        public string PublicName { get; set;}
        public Animal FeaturedAnimal{ get; set; }
    }
}


