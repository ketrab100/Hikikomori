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
    public partial class MainWindow : Form
    {
        public MainWindow()
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
            mainPanel.Controls.Clear();
            BarcodeReader frm = new BarcodeReader() {Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
            frm.FormBorderStyle = FormBorderStyle.None;
            mainPanel.Controls.Add(frm);
            frm.Show();
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            FoodList frm = new FoodList() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
            frm.FormBorderStyle = FormBorderStyle.None;
            mainPanel.Controls.Add(frm);
            frm.Show();
        }
    }
}
