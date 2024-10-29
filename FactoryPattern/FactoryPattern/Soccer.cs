using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Soccer
    {
        public ISoccer Create(string className)
        {
            if (string.IsNullOrEmpty(className)){
                throw new ArgumentNullException("ClassName cannot be null or empty");
            }else{
            return (ISoccer)Activator.CreateInstance(Type.GetType($"FactoryPattern.{className}"));

            }
        }
    }
}