namespace Hospital_dbms
{
    partial class Main_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.managePatientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManagePhysicianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStaffsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutHospitalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managePatientsToolStripMenuItem,
            this.ManagePhysicianToolStripMenuItem,
            this.viewStaffsToolStripMenuItem,
            this.aboutHospitalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(829, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // managePatientsToolStripMenuItem
            // 
            this.managePatientsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.managePatientsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managePatientsToolStripMenuItem.Name = "managePatientsToolStripMenuItem";
            this.managePatientsToolStripMenuItem.Size = new System.Drawing.Size(185, 32);
            this.managePatientsToolStripMenuItem.Text = "Manage Patients";
            this.managePatientsToolStripMenuItem.Click += new System.EventHandler(this.managePatientsToolStripMenuItem_Click);
            // 
            // ManagePhysicianToolStripMenuItem
            // 
            this.ManagePhysicianToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ManagePhysicianToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagePhysicianToolStripMenuItem.Name = "ManagePhysicianToolStripMenuItem";
            this.ManagePhysicianToolStripMenuItem.Size = new System.Drawing.Size(206, 32);
            this.ManagePhysicianToolStripMenuItem.Text = "Manage Physicians";
            this.ManagePhysicianToolStripMenuItem.Click += new System.EventHandler(this.ManagePhysicianToolStripMenuItem_Click);
            // 
            // viewStaffsToolStripMenuItem
            // 
            this.viewStaffsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.viewStaffsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewStaffsToolStripMenuItem.Name = "viewStaffsToolStripMenuItem";
            this.viewStaffsToolStripMenuItem.Size = new System.Drawing.Size(133, 32);
            this.viewStaffsToolStripMenuItem.Text = "View Staffs";
            this.viewStaffsToolStripMenuItem.Click += new System.EventHandler(this.viewStaffsToolStripMenuItem_Click);
            // 
            // aboutHospitalToolStripMenuItem
            // 
            this.aboutHospitalToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.aboutHospitalToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutHospitalToolStripMenuItem.Name = "aboutHospitalToolStripMenuItem";
            this.aboutHospitalToolStripMenuItem.Size = new System.Drawing.Size(169, 32);
            this.aboutHospitalToolStripMenuItem.Text = "About Hospital";
            this.aboutHospitalToolStripMenuItem.Click += new System.EventHandler(this.aboutHospitalToolStripMenuItem_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(829, 516);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Form";
            this.Text = "Main_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Form_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem managePatientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManagePhysicianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStaffsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutHospitalToolStripMenuItem;
    }
}