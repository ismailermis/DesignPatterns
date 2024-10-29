using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class AwayWin : ISoccer
    {
        public string Outcome(int homeScore, int awayScore)
        {
            return (awayScore > homeScore)?"Away team wins":"Away-none";
        }
    }
}