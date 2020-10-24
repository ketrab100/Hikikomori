using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Your_daily_carbon
{
    class CommunicationWithFiles
    {

        public List<Vehicle> getListOfVehicles()
        {
            List<Vehicle> list = new List<Vehicle>();
            string current;
            StreamReader sr = createStreamReader(@"Vehicles.txt");

            int i = 0;
            while ((current = sr.ReadLine()) != null)
            {
                string name = "";
                double co2 = 0;
                if (i % 2 == 0)
                {
                    name = current;
                }
                if (i % 2 == 1)
                {
                    co2 = Convert.ToDouble(current);
                    Vehicle vehicle = new Vehicle(name, co2);
                    list.Add(vehicle);
                }
                i++;
            }
            sr.Close();
            return list;
        }

        public List<Product> getListOfProducts()
        {
            List<Product> list = new List<Product>();
            string current;
            StreamReader sr = createStreamReader(@"Products.txt");

            int i = 0;
            while ((current = sr.ReadLine()) != null)
            {
                string companyName = "";
                string name = "";
                double weight = 0;
                double co2 = 0;

                if (i % 4 == 0)
                {
                    name = current;
                }
                if (i % 4 == 2)
                {
                    co2 = Double.Parse(current);
                }
                if (i % 4 == 1)
                {
                    weight = Convert.ToDouble(current);
                }
                if (i % 4 == 3)
                {
                    companyName = current;
                    Product product = new Product(name, companyName, weight, co2);
                    list.Add(product);
                }
                i++;
            }
            sr.Close();
            return list;
        }

        public List<CO2emmission> getListOfCO2emmission()
        {
            List<CO2emmission> list = new List<CO2emmission>();
            string current;
            StreamReader sr = createStreamReader(@"CO2emissions.txt");

            int i = 0;
            while ((current = sr.ReadLine()) != null)
            {
                string name = "";
                string date = "";
                double co2 = 0;
                if (i % 3 == 0)
                {
                    name = current;
                }
                if (i % 3 == 1)
                {
                    date = current;
                }
                if (i % 3 == 2)
                {
                    co2 = Convert.ToDouble(current);
                    CO2emmission emission = new CO2emmission(name, date, co2);
                    list.Add(emission);
                }
                i++;
            }
            sr.Close();
            return list;
        }

        public StreamWriter createStreamWriter(string path)
        {
            ///string path = @"DailyCarbonPrint.txt";
            StreamWriter sw;

            if (!File.Exists(path))
            {
                sw = File.CreateText(path);
            }
            else
            {
                sw = new StreamWriter(path, true);
            }

            return sw;
        }

        public StreamReader createStreamReader(string path)
        {
            StreamReader sr;
            if (!File.Exists(path))
            {
                sr = File.OpenText(path);
            }
            else
            {
                sr = new StreamReader(path, true);
            }
            return sr;
        }
        public void saveVehicle(List<Vehicle> vehicles)
        {
            StreamWriter sw = createStreamWriter(@"Vehicles.txt");
            foreach (Vehicle x in vehicles)
            {
                sw.WriteLine(x.name);
                sw.WriteLine(x.co2);
            }
            sw.Close();
        }

        public void saveProducts(List<Product> product)
        {
            StreamWriter sw = createStreamWriter(@"Products.txt");
            foreach (Product x in product)
            {
                sw.WriteLine(x.name);
                sw.WriteLine(x.companyName);
                sw.WriteLine(x.weight);
                sw.WriteLine(x.co2);
            }
            sw.Close();
        }

        public void saveCO2emission(List<CO2emmission> emission)
        {
            StreamWriter sw = createStreamWriter(@"CO2emissions.txt");
            foreach (CO2emmission x in emission)
            {
                sw.WriteLine(x.name);
                sw.WriteLine(x.date);
                sw.WriteLine(x.co2);
            }
            sw.Close();
        }

    }
}