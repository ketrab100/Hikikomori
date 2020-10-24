using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Your_daily_carbon
{
    class CoreApp
    {
        CurrentDataStorage dataStorage = new CurrentDataStorage();

        public void addTransportMethod(string name, string co2)
        {
            dataStorage.listOfVehicles.Add(new Vehicle(name, Convert.ToInt32(co2)));
        }

        public string showTransportMethods()
        {
            string print = "    Currently you have " + dataStorage.listOfVehicles.Count() + "means of transport added: \n";
            //wypisz linię informującą o ilości różnych środków transportu, potem je wypisuje po kolei ze spalaniem na g/km
            print += "    Vehicle name    |   CO2emission [g/km]";

            for(int q=0; q<dataStorage.listOfVehicles.Count(); q++)
            {
                print += "    ";
                print += dataStorage.listOfVehicles(q);
            }
            return print;
        }
    }
}
