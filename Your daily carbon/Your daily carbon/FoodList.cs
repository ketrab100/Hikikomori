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
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ListViewItem lvi = new ListViewItem(textBox1.Text);
            lvi.SubItems.Add(textBox2.Text);
            lvi.SubItems.Add(textBox3.Text);
            listView1.Items.Add(lvi);
        }
    }
}
