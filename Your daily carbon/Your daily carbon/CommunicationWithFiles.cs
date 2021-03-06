﻿using System;
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
            string name= "";
            StreamReader sr = createStreamReader(@"Vehicles.txt");

            int i = 0;
            while ((current = sr.ReadLine()) != null)
            {
                double co2 = 0;
                if (i == 0)
                {
                    name = current;
                }
                if (i == 1)
                {
                    co2 = Convert.ToDouble(current);
                    Vehicle vehicle = new Vehicle(name, co2);
                    list.Add(vehicle);
                    i = -1;
                }
                i++;
            }
            sr.Close();

            //MessageBox.Show("wypisz " + Convert.ToString(list.Count));
            return list;
        }

        public List<Product> getListOfProducts()
        {
            List<Product> list = new List<Product>();
            string current;
            string companyName = "";
            string name = "";
            StreamReader sr = createStreamReader(@"Products.txt");

            int i = 0;
            while ((current = sr.ReadLine()) != null)
            {
                //double weight = 0;
                double co2 = 0;

                if (i == 0)
                {
                    name = current;
                }
                if (i == 1)
                {
                    companyName = current;
                }
                /*if (i == 3)
                {
                    weight = Double.Parse(current);
                }*/
                if (i == 2)
                {
                    co2 = Convert.ToDouble(current);
                    Product product = new Product(name, companyName, co2);
                    list.Add(product);
                    i = -1;
                }
                i++;
            }
            sr.Close();

            //MessageBox.Show("wypisz " + Convert.ToString(list.Count));
            return list;
        }

        public List<CO2emmission> getListOfCO2emmission()
        {
            List<CO2emmission> list = new List<CO2emmission>();
            string current;
            string name = "";
            string date = "";
            StreamReader sr = createStreamReader(@"CO2emissions.txt");

            int i = 0;
            while ((current = sr.ReadLine()) != null)
            {
                double co2 = 0;
                if (i == 0)
                {
                    name = current;
                }
                if (i == 1)
                {
                    date = current;
                }
                if (i == 2)
                {
                    co2 = Convert.ToDouble(current);
                    CO2emmission emission = new CO2emmission(name, date, co2);
                    list.Add(emission);
                    i = -1;
                }
                i++;
            }
            sr.Close();

            //MessageBox.Show("wypisz " + Convert.ToString(list.Count));
            return list;
        }

        public StreamWriter createStreamWriter(string path)
        {
            StreamWriter sw;

            if (!File.Exists(path))
            {
                sw = File.CreateText(path);
            }
            else
            {
                sw = new StreamWriter(path);
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