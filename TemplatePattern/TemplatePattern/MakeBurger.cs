using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplatePattern
{
    public abstract class MakeBurger
    {
        public void Prepare()
        {
            SelectBun();
            AddPatty();
            AddSauces();
            Pack();
        }

        public abstract void SelectBun();
        public abstract void AddPatty();
        public abstract void AddSauces();

        public virtual void Pack()
        {
            // pack the burger
        }
    }
}
