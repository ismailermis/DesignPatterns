using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public interface ISoccer
    {
        string Outcome(int homeScore, int awayScore);
    }
}