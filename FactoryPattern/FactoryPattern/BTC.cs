using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class BTC : ISoccer
    {
        public string Outcome(int homeScore, int awayScore)
        {
            return (awayScore > 0 && homeScore > 0)?"Both team scored":"";
        }
    }
}