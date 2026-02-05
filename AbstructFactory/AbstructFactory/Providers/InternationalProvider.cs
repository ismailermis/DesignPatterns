using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstructFactory
{
    public class InternationalProvider
    {
        public static ILanguage CreateLanguage(Country country)
        {
            switch (country)
            {
                case Country.ENGLAND:
                    return new English();
                case Country.TURK:
                    return new Turkish();
                default:
                throw new InvalidOperationException($"Country Incalid {country}!");
            }
        }
        public static ICapitalCity CreateCapital(Country country)
        {
            switch (country)
            {
                case Country.ENGLAND:
                    return new London();
                case Country.TURK:
                    return new Ankara();
                default:
                throw new InvalidOperationException($"Country Incalid {country}!");
            }
        }
    }
}