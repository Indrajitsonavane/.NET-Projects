using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Collage_mgt_system
{
    public partial class View_student_Detils : Form
    {
        public View_student_Detils()
        {
            InitializeComponent();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_login obj = new frm_login();
            obj.Show();
            this.Hide();
        }

        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
           Add_Student_Details obj = new Add_Student_Details();
            obj.Show();
            this.Hide();
        }

        private void View_student_Detils_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'add_Student_Detils_DBDataSet1.Student_Detils' table. You can move, or remove it, as needed.
            this.student_DetilsTableAdapter1.Fill(this.add_Student_Detils_DBDataSet1.Student_Detils);
            // TODO: This line of code loads data into the 'collage_MGT_System_DBDataSet.Student_detils' table. You can move, or remove it, as needed.
            this.student_detilsTableAdapter.Fill(this.collage_MGT_System_DBDataSet.Student_detils);

        }
    }
}
