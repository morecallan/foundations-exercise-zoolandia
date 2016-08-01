using Zoolandia.Genus;

namespace Zoolandia.Species
{
    public class GorillaGorillaDiehli : Gorilla 
    {
        public GorillaGorillaDiehli(string name) : base(name)
        {
            this.Name = name;
            this.Species = "Gorilla Gorilla Diehli";
            this.CommonName = "Cross River Gorilla";
        }
    }
}