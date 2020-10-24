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
        internal List<Product> listofProducts = new List<Product>();
        internal List<CO2emmission> listofEmmissions = new List<CO2emmission>();

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
        public double co2
        {
            get;
            private set;
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
