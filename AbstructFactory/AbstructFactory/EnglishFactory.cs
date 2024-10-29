namespace AbstructFactory
{
    public class EnglishFactory : IInternationalFactory
    {
        public ICapitalCity CreateCapitalCity()
        {
            return new London();
        }

        public ILanguage CreateLanguage()
        {
            return new English();
        }
    }
}