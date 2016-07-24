namespace Zoolandia.Genus
{
    public class Spheniscus : Animal 
    {
        public Spheniscus() : base()
        {
            this.Reproduction = "monogomous";
        }

        public bool Aerodynamic = true;

        public virtual string MatingRitual()
        {
            return "male makes a glorious nest to woo his fabulous mate";
        }
    }
}