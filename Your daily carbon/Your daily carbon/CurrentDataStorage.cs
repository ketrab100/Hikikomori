using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Your_daily_carbon
{
    class CurrentDataStorage
    {

        internal List<Vehicle> listOfVehicles = new List<Vehicle>();

        Vehicle xd = new Vehicle("as", 200);

        string test = xd.name;
    }

    class Vehicle
    {

        public Vehicle(string name, int co2)
        {
            this.name = name;
            this.co2 = co2;
        }
        public string name;

        private int co2;

        
    }
}
