using Zoolandia.Genus;

namespace Zoolandia.Species
{
    public class LemmusSibiricus : Lemmus 
    {
        public LemmusSibiricus(string name) : base(name)
        {
            this.CommonName = "Brown Lemming";
            this.Species = "Lemmus Sibiricus";
            this.Name = name;
        }
    }
}