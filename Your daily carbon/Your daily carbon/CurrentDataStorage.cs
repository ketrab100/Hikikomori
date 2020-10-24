using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Your_daily_carbon
{
    class CurrentDataStorage
    {

        public CurrentDataStorage(List<Vehicle> listOfVehicles, List<Product> listofProducts, List<CO2emmission> listofEmmissions)
        {
            this.listOfVehicles = listOfVehicles;
            this.listofProducts = listofProducts;
            this.listofEmmissions = listofEmmissions;
        }

        internal List<Vehicle> listOfVehicles;
        internal List<Product> listofProducts;
        internal List<CO2emmission> listofEmmissions;

    }

    class Vehicle
    {

        public Vehicle(string name, double co2)
        {
            this.name = name;
            this.co2 = co2;
        }
        public string name
        {
            get;
            private set;
        }

        public double co2
        {
            get;
            private set;
        }
    }

    class Product
    {
        public Product(string name, string companyName, int weight, double co2)
        {
            this.name = name;
            this.companyName = companyName;
            this.weight = weight;
            this.co2 = co2;
        }
        public string name
        {
            get;
            private set;
        }
        public string companyName
        {
            get;
            private set;
        }
        public int weight
        {
            get;
            private set;
        }
        public int id
        {
            get;
            private set;
        }
        public double co2
        {
            get;
            private set;
        }

        public void setID(int id)
        {
            this.id = id;
        }
    }

    class CO2emmission
    {
        public CO2emmission(string name, string date, double co2)
        {
            this.name = name;
            this.co2 = co2;
            this.date = date;
        }
        public string name
        {
            get;
            private set;
        }
        public string date
        {
            get;
            private set;
        }

        public double co2
        {
            get;
            private set;
        }
    }
}
