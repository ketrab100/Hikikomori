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

        public List<> getListOfVehicles()
        {
            List<int> list = new List<int>;
            string current;
            StreamReader sr = createStreamReader(@"Vehicles.txt");

            int i = 0;
            while ((current = sr.ReadLine()) != null)
            {
                string name;
                double co2;
                if (i % 2 == 0)
                {
                    name = current;
                }
                else
                {
                    co2 = Convert.ToDouble(current);
                }

                Vehicle vehicle = new Vehicle(name, co2);
                list.Add(Vehicle);
                i++;
            }
            
        }
        
        public List<> getListOfProducts()
        {
            List<int> list = new List<int>;
            string current;
            StreamReader sr = createStreamReader(@"Products.txt");

            int i = 1;
            while ((current = sr.ReadLine()) != null)
            {
                string companyName;
                string name;
                int weight;
                double co2;
                
                if(i%5==0)
                {
                    companyName=current;
                }
                if(i%3==0)
                {
                    weight=int.Parse(current);
                }
                if(i%4==0)
                {
                    co2=Double.Parse(current);
                }
                if (i % 2 == 0)
                {
                    name = current;
                }
               

                Product product = new Product(name,companyName,weight,co2);
                list.Add(product);
                i++;
            }
            
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
        public void saveDailyCarbonPrint(string name, int carbonPrint)
        {
            DateTime today = DateTime.Today;
            string s = "" + today;
            string information = today + "your carbon foot print was:" + carbonPrint;
            StreamWriter sw = createStreamWriter(@"CarbonPrint.txt");
            sw.WriteLine();
        }

        public CommunicationWithFiles()
        {
            DateTime today = DateTime.Today;
            string s = "";
            s = s + today;
        }
    }
}
