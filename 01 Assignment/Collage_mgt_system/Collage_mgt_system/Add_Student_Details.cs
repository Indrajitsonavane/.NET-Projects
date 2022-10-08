using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Collage_mgt_system
{
    public partial class Add_Student_Details : Form
    {
        public Add_Student_Details()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Add_Student_Detils_DB;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }
        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }

        void Clear_Controls()
        {
            tb_Roll_No.Text = "";
            tb_Name.Text = "";
            tb_Mobile_No.Text = "";
            cmb_Course.Text = "";
            dtp_D_O_B.Text = "";
        }

        private void btn_View_Student_Ditels_Click(object sender, EventArgs e)
        {
            View_student_Detils obj = new View_student_Detils();
            obj.Show();
            this.Hide();
        }
        private void btn_Logout_Click(object sender, EventArgs e)
        {

            frm_login obj = new frm_login();
            obj.Show();
            this.Hide();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            Con_Open();

            if (tb_Roll_No.Text != "" && tb_Name.Text != "" && tb_Mobile_No.Text != "" && cmb_Course.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();


                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into Student_Detils (Roll_No, Name, D_O_B, Mobile_No, Course) Values(@RNo, @Nm, @D_O_B, @MNo, @Course)";

                Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;
                Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("D_O_B", SqlDbType.Date).Value = dtp_D_O_B.Text;
                Cmd.Parameters.Add("MNo", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

                Cmd.ExecuteNonQuery();


                MessageBox.Show("Record Insert Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Fill All Fildes", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

