using Zoolandia.Genus;

namespace Zoolandia.Species
{
    public class LemmusAmurensis : Lemmus 
    {
        public LemmusAmurensis(string name) : base(name)
        {
            this.CommonName = "Amur Lemming";
            this.Species = "Lemmus Amurensis";
            this.Name = name;
        }
    }
}