using Zoolandia.Genus;

namespace Zoolandia.Species
{
    public class GorillaGorillaGorilla : Gorilla 
    {
        public GorillaGorillaGorilla() : base()
        {
            this.CommonName = "Western Lowland Gorilla";
        }


        public GorillaGorillaGorilla(string name) : base(name)
        {
            this.CommonName = "Western Lowland Gorilla";
            this.Species = "Gorilla Gorilla Gorilla";
            this.Name = name;
        }
    }
}