using System;

namespace Zoolandia
{
    public class Animal
    {
        public Animal(string name, string diet, string reproduction, bool cute, bool nocturnal)
        {
            this.Name = name;
            this.Diet = diet;
            this.Reproduction = reproduction;
            this.Cute = cute;
            this.Nocturnal = nocturnal;
        }

        public string Name {get; set;}
        public string Diet{get; set;}
        public string Reproduction{get; set;}
        public bool Cute{get; set;}
        public bool Nocturnal{get;set;}
        

        private string Chew() {
            return "nom nom nom";
        }

        public virtual string Eat(int numberOfFoods)
        {
            if (numberOfFoods <= 0)
            {
                return "YOU BASTARD. FEED ME.";
            } else {
                return this.Chew() + "YUM!";
            }
        }

        private string Sleeptime() {
            if (this.Nocturnal) {
                return "daytime";
            } else {
                return "nighttime";
            }
        }

        public virtual string Sleep(int numberOfFoods)
        {
            return "Oh, hey look, its" + this.Sleeptime() + " this animal is fast asleep.";
        }
    }
}


//Species to create:
//Bushbaby - Otolemur garnettii.
//Chinese hamster - Cricetulus griseus.
//Mouse Lemur - Microcebus murinus