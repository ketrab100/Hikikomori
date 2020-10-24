using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Your_daily_carbon
{
    class CoreApp
    {
        public CurrentDataStorage dataStorage = new CurrentDataStorage();

        
        public void addCO2emmission(string name, string date, double co2)
        {
            dataStorage.listofEmmissions.Add(new CO2emmission(name, date, co2));
        }
        public string showCO2emmission()
        {
            string print = "    Currently you have " + dataStorage.listofEmmissions.Count() + "CO2 emmissions added: \n";
            //wypisz linię informującą o ilości różnych składników, potem je wypisuje po kolei ze spalaniem na g/km
            print += "    Description            |    Date            |    CO2emission [g/km]";

            for (int q = 0; q < dataStorage.listofEmmissions.Count(); q++)
            {
                print += "    ";
                print += makeWordFit(dataStorage.listofEmmissions[q].name, 23);
                print += makeWordFit(dataStorage.listofEmmissions[q].date, 16);
                print += Convert.ToString(dataStorage.listofEmmissions[q].co2) + "\n";
            }
            return print;
        }
        public void addTransportMethod(string name, string co2)
        {
            dataStorage.listOfVehicles.Add(new Vehicle(name, Convert.ToDouble(co2)));
        }

        public string showTransportMethods()
        {
            string print = "    Currently you have " + dataStorage.listOfVehicles.Count() + "means of transport added: \n";
            //wypisz linię informującą o ilości różnych środków transportu, potem je wypisuje po kolei ze spalaniem na g/km
            print += "    Vehicle name            |    CO2emission [g/km]";

            for(int q=0; q<dataStorage.listOfVehicles.Count(); q++)
            {
                print += "    ";
                print += makeWordFit(dataStorage.listOfVehicles[q].name, 24);
                print += Convert.ToString(dataStorage.listOfVehicles[q].co2) + "\n";
            }
            return print;
        }

        public void addProduct(string name, string companyName, string weight, string co2)
        {
            dataStorage.listofProducts.Add(new Product(name, companyName, Convert.ToInt32(weight), Convert.ToDouble(co2)));
        }

        public string showProducts()
        {
            string print = "    Currently you have " + dataStorage.listofProducts.Count() + "products added: \n";
            //wypisz linię informującą o ilości różnych składników, potem je wypisuje po kolei ze spalaniem na g/km
            print += "    Product name            |    Company name            |    Weight [g]    |    CO2emission [g/km]";

            for (int q = 0; q < dataStorage.listOfVehicles.Count(); q++)
            {
                print += "    ";
                print+=makeWordFit(dataStorage.listofProducts[q].name, 24);
                print += makeWordFit(dataStorage.listofProducts[q].companyName, 24);
                print += makeWordFit(Convert.ToString(dataStorage.listofProducts[q].weight), 14);
                print += Convert.ToString(dataStorage.listofProducts[q].co2) + "\n";
            }
            return print;
        }

        private string makeWordFit(string word, int howLong)
        {
            while(word.Length!=howLong)
            {
                word += " ";
            }
            word += "|    ";
            return word;
        }
    }
}
