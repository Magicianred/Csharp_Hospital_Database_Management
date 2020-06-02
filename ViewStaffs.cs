using System;
using System.Windows.Forms;

namespace Hospital_dbms
{
    public partial class ViewStaffsForm : Form
    {
        STAFFS staffs = new STAFFS();
        public ViewStaffsForm()
        {
            InitializeComponent();
        }

        private void ViewStaffs_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = staffs.getStaffs();
        }

       
    }
}
