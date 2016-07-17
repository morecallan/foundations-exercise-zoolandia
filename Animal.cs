using System;

namespace Zoolandia
{
    public class Animal
    {
        public Animal(string name)
        {
            this.Name = name;
        }

        public string Name {get; set;}

        public virtual string Eat(int numberOfFoods)
        {
            return "YUM!";
        }
    }
}


//Species to create:
//Bushbaby - Otolemur garnettii.
//Chinese hamster - Cricetulus griseus.
//Mouse Lemur - Microcebus murinus