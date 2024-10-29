using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class HomeWin : ISoccer
    {
        public string Outcome(int homeScore, int awayScore)
        {
           return (homeScore > awayScore)?"Home team wins":"home-none";
        }
    }
}