using Zoolandia.Genus;

namespace Zoolandia.Species
{
    public class SpheniscusHumboldti : Spheniscus 
    {
        public SpheniscusHumboldti(string name) : base(name)
        {
            this.CommonName = "Humboldt Penguin";
            this.Name = name;
        }
    }
}