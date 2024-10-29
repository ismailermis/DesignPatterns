using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Draw : ISoccer
    {
        public string Outcome(int homeScore, int awayScore)
        {
            return (homeScore == awayScore)?"Draw":"Draw-none";
        }
    }
}