namespace Zoolandia.Genus
{
    public abstract class Gorilla : Animal 
    {
        public Gorilla() : base()
        {

        }

        public Gorilla(string name) : base(name) 
        {
            this.Name = name;
        }

        public string Eat(int numberOfFoods, string typeOfFood)
        {
            string eatingMessage;
            if (typeOfFood == "leaves" && numberOfFoods > 0) {
                eatingMessage = "yo you dat tits for feeding me " + numberOfFoods + " " + typeOfFood + ".";
            } else if (typeOfFood != "leaves" && numberOfFoods > 0) {
                eatingMessage = "thanks but no thanks. i aint gonna eat no " + typeOfFood + ".";
            } else {
                eatingMessage = "YOU ARE THE WORST.";
            }
            return this.Name + " says: " + eatingMessage;
        }

        public string Play() 
        {
            return "hug each other, bite, hit or wrestle till one is pulled down on the ground.";
        }
    }
}