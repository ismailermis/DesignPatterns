using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public abstract class Ehliyet
    {
        public abstract void Sür();
    }
    public class ASınıfı : Ehliyet
    {
        public override void Sür()
        {
            Console.WriteLine("Bu ehliyet sınıfında motorsiklet kullanabilirsiniz.");
        }
    }
    public class BSınıfı : Ehliyet
    {
        public override void Sür()
        {
            Console.WriteLine("Bu ehliyet sınıfında otomobil kullanabilirsiniz.");
        }
    }
    public class ESınıfı : Ehliyet
    {
        public override void Sür()
        {
            Console.WriteLine("Bu ehliyet sınıfında otobüs kullanabilirsiniz.");
        }
    }
    public abstract class TrafficLicenses
    {
        public abstract void Run();
    }
    public class LicensesA : TrafficLicenses
    {
        public override void Run()
        {
            Console.WriteLine("You can just drive for motorbike");
        }
    }
    public class LicensesB : TrafficLicenses
    {
        public override void Run()
        {
            Console.WriteLine("You can just drive for Otomobile");
        }
    }
    public class LicensesC : TrafficLicenses
    {
        public override void Run()
        {
            Console.WriteLine("You can just drive for Truck");
        }
    }

}