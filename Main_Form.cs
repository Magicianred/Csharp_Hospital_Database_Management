using System;
using System.Windows.Forms;

namespace Hospital_dbms
{
    public partial class Main_Form : Form
   {
        public Main_Form()
        {
            InitializeComponent();
        }
        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void managePatientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagePatientForm managePF = new ManagePatientForm();
            managePF.ShowDialog();
        }
        private void viewStaffsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStaffsForm viewSF = new ViewStaffsForm();
            viewSF.ShowDialog();
        }
        private void aboutHospitalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutHospitalForm aboutHF = new AboutHospitalForm();
            aboutHF.ShowDialog();
        }
        private void ManagePhysicianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagePhysicianForm managePF = new ManagePhysicianForm();
            managePF.ShowDialog();
        }
    }
}
