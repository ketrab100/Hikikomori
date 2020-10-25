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
    public partial class FoodList : Form
    {
        public FoodList()
        {
            
            InitializeComponent();
            /*
            foreach (var p in CoreApp.dataStorage.listofProducts)
            {
                comboBox1.Items.Add(p.name);
            }
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(comboBox1.Text);
            lvi.SubItems.Add(textBox2.Text);
            listView1.Items.Add(lvi);
            CoreApp.addProduct("asd", "asdas", "asd");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
