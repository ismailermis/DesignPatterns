namespace AbstructFactory
{
    public class Ankara : ICapitalCity
    {
        public int GetPopulation()
        {
            return 20;
        }

        public List<string> ListOfTopAttractions()
        {
            return new List<string>{"Ankara kulesi", "Anıtkabir", "güvercinlik"};
        }
    }
}