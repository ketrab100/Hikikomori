using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Your_daily_carbon
{
    public partial class vehicleList : Form
    {
        public vehicleList()
        {
            
            InitializeComponent();
            /*
            foreach (var t in CoreApp.dataStorage.listOfVehicles)
            {
                comboBox1.Items.Add(t.name);
            }
            */
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(comboBox1.Text);
            lvi.SubItems.Add(textBox1.Text);
            listView1.Items.Add(lvi);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
