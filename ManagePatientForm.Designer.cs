namespace Hospital_dbms
{
    partial class ManagePatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagePatientForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonClearAllFields = new System.Windows.Forms.Button();
            this.buttonDeletePatient = new System.Windows.Forms.Button();
            this.buttonEditPatient = new System.Windows.Forms.Button();
            this.buttonAddNewPatient = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxAllergies = new System.Windows.Forms.TextBox();
            this.textBoxReasonOfAssessment = new System.Windows.Forms.TextBox();
            this.textBoxMedicationHistory = new System.Windows.Forms.TextBox();
            this.textBoxTestsResults = new System.Windows.Forms.TextBox();
            this.textBoxTestsDone = new System.Windows.Forms.TextBox();
            this.textBoxPatientName = new System.Windows.Forms.TextBox();
            this.textBoxSex = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxResidentialAddress = new System.Windows.Forms.TextBox();
            this.textBoxPatientid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxDateOfBirth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBloodGroup = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxContactNumber = new System.Windows.Forms.TextBox();
            this.textBoxPhysician_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDateOfVisit = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxWardNumber = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(270, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(749, 95);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE PATIENTS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(36, 599);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 28);
            this.label5.TabIndex = 115;
            this.label5.Text = "Date Of Birth";
            // 
            // buttonClearAllFields
            // 
            this.buttonClearAllFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonClearAllFields.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearAllFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearAllFields.Location = new System.Drawing.Point(574, 685);
            this.buttonClearAllFields.Name = "buttonClearAllFields";
            this.buttonClearAllFields.Size = new System.Drawing.Size(142, 57);
            this.buttonClearAllFields.TabIndex = 114;
            this.buttonClearAllFields.Text = "Clear All Fields";
            this.buttonClearAllFields.UseVisualStyleBackColor = false;
            this.buttonClearAllFields.Click += new System.EventHandler(this.buttonClearAllFields_Click);
            // 
            // buttonDeletePatient
            // 
            this.buttonDeletePatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonDeletePatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeletePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeletePatient.Location = new System.Drawing.Point(414, 685);
            this.buttonDeletePatient.Name = "buttonDeletePatient";
            this.buttonDeletePatient.Size = new System.Drawing.Size(142, 57);
            this.buttonDeletePatient.TabIndex = 113;
            this.buttonDeletePatient.Text = "Delete Patient";
            this.buttonDeletePatient.UseVisualStyleBackColor = false;
            this.buttonDeletePatient.Click += new System.EventHandler(this.buttonDeletePatient_Click);
            // 
            // buttonEditPatient
            // 
            this.buttonEditPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonEditPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditPatient.Location = new System.Drawing.Point(260, 685);
            this.buttonEditPatient.Name = "buttonEditPatient";
            this.buttonEditPatient.Size = new System.Drawing.Size(136, 57);
            this.buttonEditPatient.TabIndex = 112;
            this.buttonEditPatient.Text = "Edit Patient";
            this.buttonEditPatient.UseVisualStyleBackColor = false;
            this.buttonEditPatient.Click += new System.EventHandler(this.buttonEditPatient_Click);
            // 
            // buttonAddNewPatient
            // 
            this.buttonAddNewPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonAddNewPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddNewPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewPatient.Location = new System.Drawing.Point(92, 685);
            this.buttonAddNewPatient.Name = "buttonAddNewPatient";
            this.buttonAddNewPatient.Size = new System.Drawing.Size(153, 57);
            this.buttonAddNewPatient.TabIndex = 111;
            this.buttonAddNewPatient.Text = "Add New Patient";
            this.buttonAddNewPatient.UseVisualStyleBackColor = false;
            this.buttonAddNewPatient.Click += new System.EventHandler(this.buttonAddNewPatient_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(729, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1123, 493);
            this.dataGridView1.TabIndex = 110;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBoxAllergies
            // 
            this.textBoxAllergies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAllergies.Location = new System.Drawing.Point(337, 549);
            this.textBoxAllergies.Name = "textBoxAllergies";
            this.textBoxAllergies.Size = new System.Drawing.Size(268, 27);
            this.textBoxAllergies.TabIndex = 109;
            // 
            // textBoxReasonOfAssessment
            // 
            this.textBoxReasonOfAssessment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReasonOfAssessment.Location = new System.Drawing.Point(337, 508);
            this.textBoxReasonOfAssessment.Name = "textBoxReasonOfAssessment";
            this.textBoxReasonOfAssessment.Size = new System.Drawing.Size(368, 27);
            this.textBoxReasonOfAssessment.TabIndex = 108;
            // 
            // textBoxMedicationHistory
            // 
            this.textBoxMedicationHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMedicationHistory.Location = new System.Drawing.Point(337, 460);
            this.textBoxMedicationHistory.Name = "textBoxMedicationHistory";
            this.textBoxMedicationHistory.Size = new System.Drawing.Size(368, 27);
            this.textBoxMedicationHistory.TabIndex = 107;
            // 
            // textBoxTestsResults
            // 
            this.textBoxTestsResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTestsResults.Location = new System.Drawing.Point(337, 422);
            this.textBoxTestsResults.Name = "textBoxTestsResults";
            this.textBoxTestsResults.Size = new System.Drawing.Size(368, 28);
            this.textBoxTestsResults.TabIndex = 106;
            // 
            // textBoxTestsDone
            // 
            this.textBoxTestsDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTestsDone.Location = new System.Drawing.Point(337, 373);
            this.textBoxTestsDone.Name = "textBoxTestsDone";
            this.textBoxTestsDone.Size = new System.Drawing.Size(368, 28);
            this.textBoxTestsDone.TabIndex = 105;
            // 
            // textBoxPatientName
            // 
            this.textBoxPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPatientName.Location = new System.Drawing.Point(337, 179);
            this.textBoxPatientName.Name = "textBoxPatientName";
            this.textBoxPatientName.Size = new System.Drawing.Size(232, 28);
            this.textBoxPatientName.TabIndex = 104;
            // 
            // textBoxSex
            // 
            this.textBoxSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSex.Location = new System.Drawing.Point(337, 222);
            this.textBoxSex.Name = "textBoxSex";
            this.textBoxSex.Size = new System.Drawing.Size(232, 28);
            this.textBoxSex.TabIndex = 103;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAge.Location = new System.Drawing.Point(337, 255);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(232, 28);
            this.textBoxAge.TabIndex = 102;
            // 
            // textBoxResidentialAddress
            // 
            this.textBoxResidentialAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResidentialAddress.Location = new System.Drawing.Point(337, 331);
            this.textBoxResidentialAddress.Name = "textBoxResidentialAddress";
            this.textBoxResidentialAddress.Size = new System.Drawing.Size(368, 28);
            this.textBoxResidentialAddress.TabIndex = 100;
            // 
            // textBoxPatientid
            // 
            this.textBoxPatientid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPatientid.Location = new System.Drawing.Point(337, 135);
            this.textBoxPatientid.Name = "textBoxPatientid";
            this.textBoxPatientid.Size = new System.Drawing.Size(232, 27);
            this.textBoxPatientid.TabIndex = 99;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(36, 548);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 28);
            this.label12.TabIndex = 98;
            this.label12.Text = "Allergies";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(33, 507);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 28);
            this.label6.TabIndex = 97;
            this.label6.Text = "Reason of Assessment";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(33, 460);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 28);
            this.label7.TabIndex = 96;
            this.label7.Text = "Medication History";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(33, 422);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 28);
            this.label8.TabIndex = 95;
            this.label8.Text = "Test Results";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(33, 373);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 28);
            this.label9.TabIndex = 94;
            this.label9.Text = "Tests done";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(33, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(225, 28);
            this.label10.TabIndex = 93;
            this.label10.Text = "Residential Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(36, 293);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(183, 28);
            this.label11.TabIndex = 92;
            this.label11.Text = "Contact Number";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(33, 255);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 28);
            this.label13.TabIndex = 91;
            this.label13.Text = "Age";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(33, 216);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 28);
            this.label14.TabIndex = 90;
            this.label14.Text = "Sex";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(36, 179);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(155, 28);
            this.label15.TabIndex = 89;
            this.label15.Text = "Patient Name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(33, 134);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 28);
            this.label16.TabIndex = 88;
            this.label16.Text = "Patient_id";
            // 
            // textBoxDateOfBirth
            // 
            this.textBoxDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDateOfBirth.Location = new System.Drawing.Point(337, 599);
            this.textBoxDateOfBirth.Name = "textBoxDateOfBirth";
            this.textBoxDateOfBirth.Size = new System.Drawing.Size(232, 28);
            this.textBoxDateOfBirth.TabIndex = 116;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(33, 642);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 28);
            this.label2.TabIndex = 117;
            this.label2.Text = "Blood Group";
            // 
            // textBoxBloodGroup
            // 
            this.textBoxBloodGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBloodGroup.Location = new System.Drawing.Point(337, 642);
            this.textBoxBloodGroup.Name = "textBoxBloodGroup";
            this.textBoxBloodGroup.Size = new System.Drawing.Size(232, 28);
            this.textBoxBloodGroup.TabIndex = 118;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(735, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 28);
            this.label3.TabIndex = 119;
            this.label3.Text = "Physician_id";
            // 
            // textBoxContactNumber
            // 
            this.textBoxContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContactNumber.Location = new System.Drawing.Point(337, 293);
            this.textBoxContactNumber.Name = "textBoxContactNumber";
            this.textBoxContactNumber.Size = new System.Drawing.Size(232, 28);
            this.textBoxContactNumber.TabIndex = 101;
            // 
            // textBoxPhysician_id
            // 
            this.textBoxPhysician_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhysician_id.Location = new System.Drawing.Point(998, 127);
            this.textBoxPhysician_id.Name = "textBoxPhysician_id";
            this.textBoxPhysician_id.Size = new System.Drawing.Size(232, 28);
            this.textBoxPhysician_id.TabIndex = 120;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(735, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 28);
            this.label4.TabIndex = 121;
            this.label4.Text = "Date of Visit";
            // 
            // textBoxDateOfVisit
            // 
            this.textBoxDateOfVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDateOfVisit.Location = new System.Drawing.Point(998, 179);
            this.textBoxDateOfVisit.Name = "textBoxDateOfVisit";
            this.textBoxDateOfVisit.Size = new System.Drawing.Size(232, 28);
            this.textBoxDateOfVisit.TabIndex = 122;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(736, 222);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(241, 28);
            this.label17.TabIndex = 123;
            this.label17.Text = "Ward No.(if Admiited)";
            // 
            // textBoxWardNumber
            // 
            this.textBoxWardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWardNumber.Location = new System.Drawing.Point(998, 222);
            this.textBoxWardNumber.Name = "textBoxWardNumber";
            this.textBoxWardNumber.Size = new System.Drawing.Size(81, 28);
            this.textBoxWardNumber.TabIndex = 124;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(1158, 222);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 28);
            this.label18.TabIndex = 125;
            this.label18.Text = "Time";
            // 
            // textBoxTime
            // 
            this.textBoxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTime.Location = new System.Drawing.Point(1238, 222);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(122, 28);
            this.textBoxTime.TabIndex = 126;
            // 
            // ManagePatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1838, 777);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBoxWardNumber);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBoxDateOfVisit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPhysician_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxBloodGroup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDateOfBirth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonClearAllFields);
            this.Controls.Add(this.buttonDeletePatient);
            this.Controls.Add(this.buttonEditPatient);
            this.Controls.Add(this.buttonAddNewPatient);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxAllergies);
            this.Controls.Add(this.textBoxReasonOfAssessment);
            this.Controls.Add(this.textBoxMedicationHistory);
            this.Controls.Add(this.textBoxTestsResults);
            this.Controls.Add(this.textBoxTestsDone);
            this.Controls.Add(this.textBoxPatientName);
            this.Controls.Add(this.textBoxSex);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxContactNumber);
            this.Controls.Add(this.textBoxResidentialAddress);
            this.Controls.Add(this.textBoxPatientid);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "ManagePatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagePatientForm";
            this.Load += new System.EventHandler(this.ManagePatientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonClearAllFields;
        private System.Windows.Forms.Button buttonDeletePatient;
        private System.Windows.Forms.Button buttonEditPatient;
        private System.Windows.Forms.Button buttonAddNewPatient;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxAllergies;
        private System.Windows.Forms.TextBox textBoxReasonOfAssessment;
        private System.Windows.Forms.TextBox textBoxMedicationHistory;
        private System.Windows.Forms.TextBox textBoxTestsResults;
        private System.Windows.Forms.TextBox textBoxTestsDone;
        private System.Windows.Forms.TextBox textBoxPatientName;
        private System.Windows.Forms.TextBox textBoxSex;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxResidentialAddress;
        private System.Windows.Forms.TextBox textBoxPatientid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxDateOfBirth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBloodGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxContactNumber;
        private System.Windows.Forms.TextBox textBoxPhysician_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDateOfVisit;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxWardNumber;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxTime;
    }
}