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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void checkToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkCarbonPrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1() {Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
            frm.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(frm);
            frm.Show();
        }
    }
}
