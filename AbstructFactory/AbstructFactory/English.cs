using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstructFactory
{
    //Concreate Class
    public class English : ILanguage
    {
        public void Greet()
        {
            Console.WriteLine("English Hello");
        }
    }
}