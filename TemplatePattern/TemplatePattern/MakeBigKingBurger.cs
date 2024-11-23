using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplatePattern
{
    public class MakeBigKingBurger : MakeBurger
    {
        public override void SelectBun()
        {
            Console.WriteLine("Hello, MakeBigKingBurger!");
        }

        public override void AddPatty()
        {
            // add potato patty
        }

        public override void AddSauces()
        {
            // add sauces
        }
    }
}
