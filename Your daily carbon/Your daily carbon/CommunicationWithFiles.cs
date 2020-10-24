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
                    co2 = ToDouble(current);
                }

                Vehicle vehicle = new Vehicle(name, co2);
                list.Add(Vehicle);

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
        public void saveDailyCarbonPrin(string name, int carbonPrint)
        {
            DateTime today = DateTime.Today;
            string s = "" + today;
            string information = today + "your carbon foot print was:" + carbonPrint;
            StreamWriter sw = createStreamWriter();
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
