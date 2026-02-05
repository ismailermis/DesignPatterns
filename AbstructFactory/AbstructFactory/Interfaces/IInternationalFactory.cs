using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstructFactory
{
    public interface IInternationalFactory
    {
        ILanguage CreateLanguage();
        ICapitalCity CreateCapitalCity();
    }
}