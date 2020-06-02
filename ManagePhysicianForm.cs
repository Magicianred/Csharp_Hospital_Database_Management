using System;
using System.Windows.Forms;

namespace Hospital_dbms
{
    public partial class ManagePhysicianForm : Form
    {
        PHYSICIAN physician = new PHYSICIAN();
        public ManagePhysicianForm()
        {
            InitializeComponent();
           
        }
        private void buttonAddNewPhysician_Click(object sender, EventArgs e)
        {
            {
                String id = textBoxPhysician_id.Text;
                String name = textBoxPhysician_name.Text;
                String speciality = textBoxSpeciality.Text;
                String wrkhrs = textBoxWorkingHours.Text;
                String wrkdays = textBoxWorkingDays.Text;
                String number  = textBoxContactNumber.Text;
              
                if (id.Trim().Equals("") || name.Trim().Equals("") || speciality.Trim().Equals("") || wrkhrs.Trim().Equals("") || wrkdays.Trim().Equals("") || number.Trim().Equals(""))
                {
                    MessageBox.Show("Some fiels empty", "Enter all the fields", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    Boolean insertPhysician = physician.insertPhysician(id, name,speciality,wrkhrs,wrkdays,number);
                    if (insertPhysician)
                    {
                        dataGridView1.DataSource = physician.getPhysician();
                        MessageBox.Show("Physician Details Saved Successfully ", "Add Patient ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("ERROR-Physician Details Not Inserted", " Add Patient", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    private void buttonUpdateDetails_Click(object sender, EventArgs e)
        {
           
           // String id = textBoxPhysician_id.Text;
            String name = textBoxPhysician_name.Text;
            String speciality = textBoxSpeciality.Text;
            String wrkhrs = textBoxWorkingHours.Text;
            String wrkdays = textBoxWorkingDays.Text;
            String number = textBoxContactNumber.Text;

            try
            {
                int id = Convert.ToInt32(textBoxPhysician_id.Text);
                if ( name.Trim().Equals("") || speciality.Trim().Equals("") || wrkhrs.Trim().Equals("") || wrkdays.Trim().Equals("") || number.Trim().Equals(""))
                {
                    MessageBox.Show("Some fiels empty", "Enter all the fields", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    Boolean editPhysician = physician.editPhysician(id, name, speciality, wrkhrs, wrkdays, number);
                    if (editPhysician)
                    {
                        dataGridView1.DataSource = physician.getPhysician();
                        MessageBox.Show("Physician Details Saved Successfully ", "Add Patient ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("ERROR-Physician Details Not Inserted", " Add Patient", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Input string was not in a correct format", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ManagePhysicianForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = physician.getPhysician();
        }
        private void buttonClearAllFields_Click(object sender, EventArgs e)
        {
            textBoxPhysician_id.Text = "";
            textBoxPhysician_name.Text = "";
            textBoxSpeciality.Text = "";
            textBoxWorkingHours.Text = "";
            textBoxWorkingDays.Text = "";
            textBoxContactNumber.Text = "";
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxPhysician_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxPhysician_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxSpeciality.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxWorkingHours.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxWorkingDays.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxContactNumber.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
    
        }
    }
}
