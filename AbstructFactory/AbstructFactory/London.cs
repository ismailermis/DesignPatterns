namespace AbstructFactory
{
    public class London : ICapitalCity
    {
        public int GetPopulation()
        {
            return 10;
        }

        public List<string> ListOfTopAttractions()
        {
            return new List<string>{"Big ben", "London Tower", "Buckingham palace"};
        }
    }
}