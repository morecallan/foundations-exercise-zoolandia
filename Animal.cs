using System;
using Zoolandia.Species;

namespace Zoolandia
{
    public class Animal
    {
        public Animal(string name)
        {
            this.Name = name;
        }

        public string Name {get; set;}
        public string Diet{get; set;}
        public string Reproduction{get; set;}
        public bool Cute{get; set;}
        public bool Nocturnal{get; set;}
        public string Species{get; set;}
        

        private string Chew() {
            return "nom nom nom";
        }

        public virtual string Eat(int numberOfFoods)
        {
            if (numberOfFoods <= 0)
            {
                return this.Name + " says: YOU BASTARD. FEED ME.";
            } else {
                return this.Name + " says: " + this.Chew() + " YUM!";
            }
        }

        private string Sleeptime() {
            if (this.Nocturnal) {
                return "daytime";

            } else {
                return "nighttime";
            }
        }

        public virtual string Sleep()
        {
            return "Oh, hey look, its " + this.Sleeptime() + ". " + this.Name +  " is fast asleep.";
        }

        private string CuteLine() {
            if (this.Cute == true) {
                return "is effin adorable.";
            } else {
                return "is a hideous monster.";
            }
        }

        public string Bio()
        {
            return "Behold! A glorious " + this.Species + " in it's natural habitat. Our friend, " + this.Name + " " + CuteLine() + " What type of sexy is " + this.Name + "? " + this.Reproduction + ". " + this.Sleep() + " Let's try feeding our new friend, " + this.Name + ".";
        }
    }
}


//Species to create:
//Bushbaby - Otolemur garnettii.
//Chinese hamster - Cricetulus griseus.
//Mouse Lemur - Microcebus murinus