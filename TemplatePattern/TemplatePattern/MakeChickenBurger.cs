using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplatePattern
{
    public class MakeChickenBurger : MakeBurger
    {
        public override void SelectBun()
        {
            Console.WriteLine("Hello, MakeChickenBurger!");

        }

        public override void AddPatty()
        {
            // add chicken patty
        }

        public override void AddSauces()
        {
            // add sauces
        }
    }
}
