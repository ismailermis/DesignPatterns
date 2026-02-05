namespace AbstructFactory
{
    public class TurkishFactory : IInternationalFactory
    {
        public ICapitalCity CreateCapitalCity()
        {
            return new Ankara();
        }

        public ILanguage CreateLanguage()
        {
            return new Turkish();
        }
    }
}