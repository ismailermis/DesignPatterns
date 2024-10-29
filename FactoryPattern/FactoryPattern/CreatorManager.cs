using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public enum VehicleTypes
    {
        LicensesA,
        LicensesB,
        LicensesC,
    }
    public class CreatorManager
    {
        public TrafficLicenses FactoryMethod(VehicleTypes vehicleType)
        {
            TrafficLicenses licenses = null;
            switch (vehicleType)
            {
                case VehicleTypes.LicensesA:
                    licenses = new LicensesA();
                    break;
                case VehicleTypes.LicensesB:
                    licenses = new LicensesB();
                    break;
                case VehicleTypes.LicensesC:
                    licenses = new LicensesC();
                    break;
            }
            return licenses;
        }
    }
}