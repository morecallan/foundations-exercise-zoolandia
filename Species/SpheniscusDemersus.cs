using Zoolandia.Genus;

namespace Zoolandia.Species
{
    public class SpheniscusDemersus : Spheniscus 
    {
        public SpheniscusDemersus(string name) : base(name)
        {
            this.CommonName = "African Penguin";
            this.Species = "Spheniscus Demersus";
            this.Name = name;
        }
    }
}