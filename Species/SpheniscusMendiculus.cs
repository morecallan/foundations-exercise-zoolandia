using Zoolandia.Genus;

namespace Zoolandia.Species
{
    public class SpheniscusMendiculus : Spheniscus 
    {
        public SpheniscusMendiculus(string name) : base(name)
        {
            this.CommonName = "Galapagos Penguin";
            this.Species = "Spheniscus Mendiculus";          
            this.Name = name;
        }
    }
}