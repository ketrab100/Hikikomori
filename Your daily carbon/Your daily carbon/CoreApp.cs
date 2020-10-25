using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Your_daily_carbon
{
    class CoreApp
    {
        static CommunicationWithFiles fileExplorer = new CommunicationWithFiles();
        public static CurrentDataStorage dataStorage;

        public static void startApp()
        {
            dataStorage = new CurrentDataStorage(fileExplorer.getListOfVehicles(), fileExplorer.getListOfProducts(), fileExplorer.getListOfCO2emmission());
        }
        public static void closeApp()
            {
            fileExplorer.saveVehicle(dataStorage.listOfVehicles);
            fileExplorer.saveProducts(dataStorage.listofProducts);
            fileExplorer.saveCO2emission(dataStorage.listofEmmissions);
        }

        
        public static void addTransportMethod(string name, string co2)
        {
            dataStorage.listOfVehicles.Add(new Vehicle(name, Convert.ToDouble(co2)));
        }

        public static void addProduct(string name, string companyName, string co2)
        {
            dataStorage.listofProducts.Add(new Product(name, companyName, Convert.ToDouble(co2)));
        }

        public static double addCO2emmissionTravelling(string name, string date, string distance)
        {
            for(int q=0; q<dataStorage.listOfVehicles.Count; q++)
            {
                if(dataStorage.listOfVehicles[q].name==name)
                {
                    dataStorage.listofEmmissions.Add(new CO2emmission(name, date, dataStorage.listOfVehicles[q].co2*Convert.ToDouble(distance)));
                    return dataStorage.listOfVehicles[q].co2 * Convert.ToDouble(distance);
                }
                
            }
            return 0;
        }

        public static double addCO2emmissionEating(string name, string date, string weight)
        {
            for (int q = 0; q < dataStorage.listofProducts.Count; q++)
            {
                if (dataStorage.listofProducts[q].name == name)
                {
                    dataStorage.listofEmmissions.Add(new CO2emmission(name, date, dataStorage.listofProducts[q].co2*Convert.ToDouble(weight)));
                    return dataStorage.listofProducts[q].co2 * Convert.ToDouble(weight);
                }
            }
            return 0;
        }














        public static string showTransportMethods()
        {
            string print = "    Currently you have " + dataStorage.listOfVehicles.Count() + "means of transport added: \n";
            //wypisz linię informującą o ilości różnych środków transportu, potem je wypisuje po kolei ze spalaniem na g/km
            print += "    Vehicle name            |    CO2emission [g/km]";

            for (int q = 0; q < dataStorage.listOfVehicles.Count(); q++)
            {
                print += "    ";
                print += makeWordFit(dataStorage.listOfVehicles[q].name, 24);
                print += Convert.ToString(dataStorage.listOfVehicles[q].co2) + "\n";
            }
            return print;
        }
        public static string showProducts()
        {
            string print = "    Currently you have " + dataStorage.listofProducts.Count() + "products added: \n";
            //wypisz linię informującą o ilości różnych składników, potem je wypisuje po kolei ze spalaniem na g/km
            print += "    Product name            |    Company name            |    Weight [g]    |    CO2emission [g/km]";

            for (int q = 0; q < dataStorage.listOfVehicles.Count(); q++)
            {
                print += "    ";
                print += makeWordFit(dataStorage.listofProducts[q].name, 24);
                print += makeWordFit(dataStorage.listofProducts[q].companyName, 24);
                print += Convert.ToString(dataStorage.listofProducts[q].co2) + "\n";
            }
            return print;
        }
        public static string showCO2emmission()
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
        private static string makeWordFit(string word, int howLong)
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
