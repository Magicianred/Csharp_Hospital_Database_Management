using System;
using System.Windows.Forms;

namespace Hospital_dbms
{
    public partial class ManagePatientForm : Form
    {
        PATIENT patient = new PATIENT();
        public ManagePatientForm()
        {
            InitializeComponent();
        }
       private void ManagePatientForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = patient.getPatients();
        }
        private void buttonClearAllFields_Click(object sender, EventArgs e)
        {
            textBoxPatientid.Text = "";
            textBoxPatientName.Text = "";
            textBoxContactNumber.Text = "";
            textBoxResidentialAddress.Text = "";
            textBoxSex.Text = "";
            textBoxBloodGroup.Text = "";
            textBoxAge.Text = "";
            textBoxTestsDone.Text = "";
            textBoxTestsResults.Text = "";
            textBoxDateOfBirth.Text = "";
            textBoxMedicationHistory.Text = "";
            textBoxReasonOfAssessment.Text = "";
            textBoxAllergies.Text = "";
            textBoxPhysician_id.Text = "";
            textBoxDateOfVisit.Text = "";
            textBoxWardNumber.Text = "";
            textBoxTime.Text = "";
        }
        private void buttonAddNewPatient_Click(object sender, EventArgs e)
        {
            {
                String id = textBoxPatientid.Text;
                String name = textBoxPatientName.Text;
                String age = textBoxAge.Text;
                String sex = textBoxSex.Text;
                String number = textBoxContactNumber.Text;
                String address = textBoxResidentialAddress.Text;
                String testsdone = textBoxTestsDone.Text;
                String testres = textBoxTestsResults.Text;
                String medicalhist = textBoxMedicationHistory.Text;
                String reasonofassess = textBoxReasonOfAssessment.Text;
                String allergies = textBoxAllergies.Text;
                String dob = textBoxDateOfBirth.Text;
                String bloodgroup = textBoxBloodGroup.Text;
                String physician_id = textBoxPhysician_id.Text;
                String date = textBoxDateOfVisit.Text;
                String ward_num = textBoxWardNumber.Text;
                String time = textBoxTime.Text;

                if (id.Trim().Equals("") || name.Trim().Equals("") || age.Trim().Equals("") || sex.Trim().Equals("") || number.Trim().Equals("") || address.Trim().Equals("") || testsdone.Trim().Equals("") || testres.Trim().Equals("") || medicalhist.Trim().Equals("") || reasonofassess.Trim().Equals("") || allergies.Trim().Equals("") || dob.Trim().Equals("") || bloodgroup.Trim().Equals("") || physician_id.Trim().Equals("") || date.Trim().Equals(""))
                {
                    MessageBox.Show("Some fiels empty", "Enter all the fields", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    Boolean insertPatient = patient.insertPatient(id, name, age, sex, number, address, testsdone, testres, medicalhist, reasonofassess, allergies, dob, bloodgroup, physician_id, date,ward_num,time);
                    if (insertPatient)
                    {
                        dataGridView1.DataSource = patient.getPatients();
                        MessageBox.Show("Patient Details Saved Successfully ", "Add Patient ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("ERROR-Paitent Details Not Inserted", " Add Patient", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void buttonEditPatient_Click(object sender, EventArgs e)
        {
            //int id=Convert.ToInt32(textBoxPatientid.Text);
            //String id = textBoxPatientid.Text;
            String name = textBoxPatientName.Text;
            String age = textBoxAge.Text;
            String sex = textBoxSex.Text;
            String number = textBoxContactNumber.Text;
            String address = textBoxResidentialAddress.Text;
            String testsdone = textBoxTestsDone.Text;
            String testres = textBoxTestsResults.Text;
            String medicalhist = textBoxMedicationHistory.Text;
            String reasonofassess = textBoxReasonOfAssessment.Text;
            String allergies = textBoxAllergies.Text;
            String dob = textBoxDateOfBirth.Text;
            String bloodgroup = textBoxBloodGroup.Text;
            String physician_id = textBoxPhysician_id.Text;
            String date = textBoxDateOfVisit.Text;
            String ward_num = textBoxWardNumber.Text; 
            String time = textBoxTime.Text;

            try
            {
                int id=Convert.ToInt32(textBoxPatientid.Text);
                if (name.Trim().Equals("") || age.Trim().Equals("") || sex.Trim().Equals("") || number.Trim().Equals("") || address.Trim().Equals("") || testsdone.Trim().Equals("") || testres.Trim().Equals("") || medicalhist.Trim().Equals("") || reasonofassess.Trim().Equals("") || allergies.Trim().Equals("") || dob.Trim().Equals("") || bloodgroup.Trim().Equals("") || physician_id.Trim().Equals("") || date.Trim().Equals("") || ward_num.Trim().Equals(""))
                {
                    MessageBox.Show("Some fiels empty", "Enter all the fields", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    Boolean editPatient = patient.editPatient(id, name, age, sex, number, address, testsdone, testres, medicalhist, reasonofassess, allergies, dob, bloodgroup, physician_id, date,ward_num,time);
                    if (editPatient)
                    {
                        dataGridView1.DataSource = patient.getPatients();
                        MessageBox.Show("Patient Details Updated Successfully ", "Edit Patient ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("ERROR-Paitent Details Not Updated", " Edit Patient", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Input string was not in a correct format", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxPatientid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxPatientName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxAge.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxSex.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxContactNumber.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxResidentialAddress.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBoxTestsDone.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBoxTestsResults.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBoxMedicationHistory.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBoxReasonOfAssessment.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textBoxAllergies.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            textBoxDateOfBirth.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            textBoxBloodGroup.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            textBoxPhysician_id.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            textBoxDateOfVisit.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            textBoxWardNumber.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            textBoxTime.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
        }
        private void buttonDeletePatient_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxPatientid.Text);
                if(patient.removePatient(id))
                {
                    dataGridView1.DataSource = patient.getPatients();
                    MessageBox.Show("Patient Details Deleted Successfully ", "Delete Patient ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonClearAllFields.PerformClick();
                }
                else
                {
                    MessageBox.Show("ERROR-Paitent Details Not Deleted", "Delete Patient", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Input string was not in a correct format", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

}
