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
    public partial class vehicleAdder : Form
    {
        public vehicleAdder()
        {
            InitializeComponent();
            foreach(var t in CoreApp.dataStorage.listOfVehicles)
            {
                ListViewItem lvi = new ListViewItem(textBox1.Text);
                lvi.SubItems.Add(textBox2.Text);
                listView1.Items.Add(lvi);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CoreApp.addTransportMethod(textBox1.Text, textBox2.Text);
        }
    }
}
