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

        private void toolStripDropDownButton3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {

        }

        private void openFoodListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FoodList foodlist = new FoodList() {Dock = DockStyle.Fill ,TopLevel = false , TopMost = false};
            foodlist.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(foodlist);
            foodlist.Show();
        }

        private void addVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            vehicleAdder vehicle = new vehicleAdder() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
            vehicle.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(vehicle);
            vehicle.Show();

        }

        private void checCarbonPrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            foodAdder foodadder = new foodAdder() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
            foodadder.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(foodadder);
            foodadder.Show();
        }

        private void setDistanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            vehicleList vehiclelist = new vehicleList() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
            vehiclelist.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(vehiclelist);
            vehiclelist.Show();
        }
    }
}
