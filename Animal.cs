using System;
using Zoolandia.Species;

namespace Zoolandia
{
    public class Animal
    {
        public Animal()
        {

        }
        //Constructor is what you want to know before you interact with them
        public Animal(string name)
        {
            this.Name = name;
        }

         public Animal(int age) 
        {
            this.Age = age;
        }

        public Animal(string name, int age) 
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name {get; set;}
        public string Diet{get; set;}
        public string Reproduction{get; set;}
        public bool Cute{get; set;}
        public bool Nocturnal{get; set;}
        public string Species{get; set;}
        public int Age{get; set;}
        public string CommonName{get; set;}
        public string Gender {get; set;}
        

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
            DateTime now = DateTime.Now;
            int currentHour = now.Hour;
            
            bool dayTime;
            string stringTime;
            if (currentHour > 4 && currentHour < 17) {
                dayTime = true;
                stringTime = "daytime";
            } else {
                dayTime = false;
                stringTime = "nighttime";
            }

            string sleepingResponse;            
            if (dayTime == this.Nocturnal) {
                sleepingResponse = "Oh, hey look, its " + stringTime + ". " + this.Name +  " is fast asleep.";
            } else {
                sleepingResponse = "Oh, hey look, its " + stringTime + ". " + this.Name +  " is wide awake! " + this.Name + " sleeps during the " + this.Sleeptime() + ".";                
            }
            return sleepingResponse;
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

        public void FeedingTime()
        {
            Console.WriteLine("How many foods to you want to feed " + this.Name + " ?");
            Console.Write("> ");
            int numOfFoodsInput = Int32.Parse(Console.ReadLine());
            Console.WriteLine(this.Eat(numOfFoodsInput));
        }
    }
}


//Species to create:
//Bushbaby - Otolemur garnettii.
//Chinese hamster - Cricetulus griseus
//Mouse Lemur - Microcebus murinus

//Gorilla (Gorilla)
        //eat
        //sleep
        //
//Cross River Gorilla - Gorilla Gorilla Diehli
//Mountain Gorilla - Gorilla Berengei Berengei
//Western Lowland Gorilla - Gorilla Gorilla Gorilla

//Lemming (Lemmus)
//Wrangel Island Lemming - Lemmus Portenkoi
//Siberian Brown Lemming - Lemmus Sibiricus
//Amur Lemming - Lemmus Amurensis

//Penguin (Spheniscus) 
//African Penguin - Spheniscus Demersus
//Humbolt Penguin - Spheniscus Humboldti
//Galapagos Penguin - Spheniscus Mendiculus