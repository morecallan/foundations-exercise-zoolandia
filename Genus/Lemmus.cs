namespace Zoolandia.Genus
{
    public class Lemmus : Animal 
    {
        public Lemmus(string name) : base(name)
        {
            
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