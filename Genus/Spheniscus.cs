namespace Zoolandia.Genus
{
    public class Spheniscus : Animal 
    {
        public Spheniscus() : base()
        {
            this.Reproduction = "monogomous";
        }

        public bool Aerodynamic = true;

        public virtual string MatingRitual(Animal animal)
        {
            if (animal.Gender == "male") {
                return "makes a glorious nest to woo his fabulous mate";
            } else {
                return "sits around and wait for a nest to get it on in";
            }
        }
    }
}