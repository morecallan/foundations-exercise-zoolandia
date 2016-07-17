using System;

namespace Zoolandia.Species
{
    public class AilurusFulgens : Animal 
    {
        public AilurusFulgens(string name) : base(name)
        {
        }
        public override string Eat(int numberOfFoods)
        {
            string animalEat = base.Eat(3);
            return animalEat + " nom nom nom";
        }

        public string Eat()
        {
            return "Oh god I don't know what I ate";
        }

        public string Welcome(string name)
        {
            this.Name = name;
            return Welcome();
        }

        public string Welcome()
        {
            return  "Yo " + this.Name;
        }
    }
}