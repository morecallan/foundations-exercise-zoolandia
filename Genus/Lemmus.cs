namespace Zoolandia.Genus
{
    public class Lemmus : Animal 
    {
        public Lemmus(string name) : base(name)
        {
            this.Cute = true;
            this.Reproduction = "wild and fast";
        }

        public bool migrationMishap(int numberOfLemmingsInZoo)
        {
            bool mishap;
            if (numberOfLemmingsInZoo > 20) {
                mishap = true;
            } else {
                mishap = false;
            }

            return mishap;
        }

    }
}