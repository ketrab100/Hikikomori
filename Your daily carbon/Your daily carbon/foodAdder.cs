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
    public partial class foodAdder : Form
    {
        public foodAdder()
        {
            InitializeComponent();
            
            foreach(var p in CoreApp.dataStorage.listofProducts)
            {
                ListViewItem lvi = new ListViewItem(textBox1.Text);
                lvi.SubItems.Add(textBox2.Text);
                listView1.Items.Add(lvi);
            }
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CoreApp.addProduct(textBox1.Text,"dsda" , textBox2.Text);
            ListViewItem lvi = new ListViewItem(textBox1.Text);
            lvi.SubItems.Add(textBox2.Text);
            listView1.Items.Add(lvi);
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
