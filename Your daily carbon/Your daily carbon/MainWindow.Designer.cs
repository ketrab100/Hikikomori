namespace Your_daily_carbon
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.FileStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.openHistoryFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FoodStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.addnewfood = new System.Windows.Forms.ToolStripMenuItem();
            this.setfoodconsuption = new System.Windows.Forms.ToolStripMenuItem();
            this.TransportStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.addVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setDistanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SummaryStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.showCo2EmitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileStripDropDownButton1,
            this.FoodStripDropDownButton4,
            this.TransportStripDropDownButton3,
            this.SummaryStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // FileStripDropDownButton1
            // 
            this.FileStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FileStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openHistoryFileToolStripMenuItem});
            this.FileStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FileStripDropDownButton1.Name = "FileStripDropDownButton1";
            this.FileStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.FileStripDropDownButton1.Text = "File";
            // 
            // openHistoryFileToolStripMenuItem
            // 
            this.openHistoryFileToolStripMenuItem.Name = "openHistoryFileToolStripMenuItem";
            this.openHistoryFileToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.openHistoryFileToolStripMenuItem.Text = "Open history file";
            // 
            // FoodStripDropDownButton4
            // 
            this.FoodStripDropDownButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FoodStripDropDownButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addnewfood,
            this.setfoodconsuption});
            this.FoodStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FoodStripDropDownButton4.Name = "FoodStripDropDownButton4";
            this.FoodStripDropDownButton4.Size = new System.Drawing.Size(47, 22);
            this.FoodStripDropDownButton4.Text = "Food";
            // 
            // addnewfood
            // 
            this.addnewfood.Name = "addnewfood";
            this.addnewfood.Size = new System.Drawing.Size(228, 22);
            this.addnewfood.Text = "Add new food to list";
            this.addnewfood.Click += new System.EventHandler(this.addFoodListToolStripMenuItem_Click);
            // 
            // setfoodconsuption
            // 
            this.setfoodconsuption.Name = "setfoodconsuption";
            this.setfoodconsuption.Size = new System.Drawing.Size(228, 22);
            this.setfoodconsuption.Text = "Set consumption of products";
            this.setfoodconsuption.Click += new System.EventHandler(this.setProductsConsumptionToolStripMenuItem_Click);
            // 
            // TransportStripDropDownButton3
            // 
            this.TransportStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TransportStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVehicleToolStripMenuItem,
            this.setDistanceToolStripMenuItem});
            this.TransportStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TransportStripDropDownButton3.Name = "TransportStripDropDownButton3";
            this.TransportStripDropDownButton3.Size = new System.Drawing.Size(69, 22);
            this.TransportStripDropDownButton3.Text = "Transport";
            this.TransportStripDropDownButton3.Click += new System.EventHandler(this.toolStripDropDownButton3_Click);
            // 
            // addVehicleToolStripMenuItem
            // 
            this.addVehicleToolStripMenuItem.Name = "addVehicleToolStripMenuItem";
            this.addVehicleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addVehicleToolStripMenuItem.Text = "Add vehicle";
            this.addVehicleToolStripMenuItem.Click += new System.EventHandler(this.addVehicleToolStripMenuItem_Click);
            // 
            // setDistanceToolStripMenuItem
            // 
            this.setDistanceToolStripMenuItem.Name = "setDistanceToolStripMenuItem";
            this.setDistanceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setDistanceToolStripMenuItem.Text = "Set distance";
            this.setDistanceToolStripMenuItem.Click += new System.EventHandler(this.setDistanceToolStripMenuItem_Click);
            // 
            // SummaryStripDropDownButton2
            // 
            this.SummaryStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SummaryStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showCo2EmitionToolStripMenuItem});
            this.SummaryStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SummaryStripDropDownButton2.Name = "SummaryStripDropDownButton2";
            this.SummaryStripDropDownButton2.Size = new System.Drawing.Size(71, 22);
            this.SummaryStripDropDownButton2.Text = "Summary";
            this.SummaryStripDropDownButton2.Click += new System.EventHandler(this.toolStripDropDownButton2_Click);
            // 
            // showCo2EmitionToolStripMenuItem
            // 
            this.showCo2EmitionToolStripMenuItem.Name = "showCo2EmitionToolStripMenuItem";
            this.showCo2EmitionToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.showCo2EmitionToolStripMenuItem.Text = "Show co2 emition";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 410);
            this.panel1.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainWindow";
            this.Text = "Your daili carbon";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton FileStripDropDownButton1;
        private System.Windows.Forms.ToolStripDropDownButton FoodStripDropDownButton4;
        private System.Windows.Forms.ToolStripDropDownButton TransportStripDropDownButton3;
        private System.Windows.Forms.ToolStripDropDownButton SummaryStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem openHistoryFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addnewfood;
        private System.Windows.Forms.ToolStripMenuItem setfoodconsuption;
        private System.Windows.Forms.ToolStripMenuItem addVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setDistanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCo2EmitionToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}

