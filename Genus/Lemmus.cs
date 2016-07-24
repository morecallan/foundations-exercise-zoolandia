namespace Zoolandia.Genus
{
    public class Lemmus : Animal 
    {
        public Lemmus() : base()
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