using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace Your_daily_carbon
{
    public partial class BarcodeReader : Form
    {
        public BarcodeReader()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                ZXing.BarcodeReader reader = new ZXing.BarcodeReader();
                Bitmap bitmap = new Bitmap(filePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; 
                pictureBox1.Image = bitmap;
                var result = reader.Decode((Bitmap)bitmap);
                if (result != null)
                {
                    textBox1.Text = result.ToString();
                }
                
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
