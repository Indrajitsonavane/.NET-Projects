namespace Collage_mgt_system
{
    partial class View_student_Detils
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
            this.components = new System.ComponentModel.Container();
            this.lbl_View_Student_Ditels = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addStudentDetilsDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.add_Student_Detils_DBDataSet = new Collage_mgt_system.Add_Student_Detils_DBDataSet();
            this.btn_Add_New_Student = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.collage_MGT_System_DBDataSet = new Collage_mgt_system.Collage_MGT_System_DBDataSet();
            this.studentdetilsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_detilsTableAdapter = new Collage_mgt_system.Collage_MGT_System_DBDataSetTableAdapters.Student_detilsTableAdapter();
            this.add_Student_Detils_DBDataSet1 = new Collage_mgt_system.Add_Student_Detils_DBDataSet1();
            this.studentDetilsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.student_DetilsTableAdapter1 = new Collage_mgt_system.Add_Student_Detils_DBDataSet1TableAdapters.Student_DetilsTableAdapter();
            this.rollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addStudentDetilsDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_Student_Detils_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collage_MGT_System_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentdetilsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_Student_Detils_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetilsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_View_Student_Ditels
            // 
            this.lbl_View_Student_Ditels.AutoSize = true;
            this.lbl_View_Student_Ditels.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Student_Ditels.Location = new System.Drawing.Point(124, 14);
            this.lbl_View_Student_Ditels.Name = "lbl_View_Student_Ditels";
            this.lbl_View_Student_Ditels.Size = new System.Drawing.Size(313, 39);
            this.lbl_View_Student_Ditels.TabIndex = 2;
            this.lbl_View_Student_Ditels.Text = "View Student Ditels";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentDetilsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(7, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(553, 322);
            this.dataGridView1.TabIndex = 3;
            // 
            // addStudentDetilsDBDataSetBindingSource
            // 
            this.addStudentDetilsDBDataSetBindingSource.DataSource = this.add_Student_Detils_DBDataSet;
            this.addStudentDetilsDBDataSetBindingSource.Position = 0;
            // 
            // add_Student_Detils_DBDataSet
            // 
            this.add_Student_Detils_DBDataSet.DataSetName = "Add_Student_Detils_DBDataSet";
            this.add_Student_Detils_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Add_New_Student
            // 
            this.btn_Add_New_Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Student.Location = new System.Drawing.Point(177, 404);
            this.btn_Add_New_Student.Name = "btn_Add_New_Student";
            this.btn_Add_New_Student.Size = new System.Drawing.Size(188, 36);
            this.btn_Add_New_Student.TabIndex = 5;
            this.btn_Add_New_Student.Text = "Add New Student";
            this.btn_Add_New_Student.UseVisualStyleBackColor = true;
            this.btn_Add_New_Student.Click += new System.EventHandler(this.btn_Add_New_Student_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Logout.Location = new System.Drawing.Point(473, 12);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(87, 30);
            this.btn_Logout.TabIndex = 5;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // collage_MGT_System_DBDataSet
            // 
            this.collage_MGT_System_DBDataSet.DataSetName = "Collage_MGT_System_DBDataSet";
            this.collage_MGT_System_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentdetilsBindingSource
            // 
            this.studentdetilsBindingSource.DataMember = "Student_detils";
            this.studentdetilsBindingSource.DataSource = this.collage_MGT_System_DBDataSet;
            // 
            // student_detilsTableAdapter
            // 
            this.student_detilsTableAdapter.ClearBeforeFill = true;
            // 
            // add_Student_Detils_DBDataSet1
            // 
            this.add_Student_Detils_DBDataSet1.DataSetName = "Add_Student_Detils_DBDataSet1";
            this.add_Student_Detils_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDetilsBindingSource1
            // 
            this.studentDetilsBindingSource1.DataMember = "Student_Detils";
            this.studentDetilsBindingSource1.DataSource = this.add_Student_Detils_DBDataSet1;
            // 
            // student_DetilsTableAdapter1
            // 
            this.student_DetilsTableAdapter1.ClearBeforeFill = true;
            // 
            // rollNoDataGridViewTextBoxColumn
            // 
            this.rollNoDataGridViewTextBoxColumn.DataPropertyName = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.HeaderText = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.Name = "rollNoDataGridViewTextBoxColumn";
            this.rollNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "D_O_B";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "D_O_B";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            this.mobileNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // View_student_Detils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 452);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_Add_New_Student);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_View_Student_Ditels);
            this.Name = "View_student_Detils";
            this.Text = "View student Detils";
            this.Load += new System.EventHandler(this.View_student_Detils_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addStudentDetilsDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_Student_Detils_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collage_MGT_System_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentdetilsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_Student_Detils_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetilsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_View_Student_Ditels;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Add_New_Student;
        private System.Windows.Forms.Button btn_Logout;
        private Collage_MGT_System_DBDataSet collage_MGT_System_DBDataSet;
        private System.Windows.Forms.BindingSource studentdetilsBindingSource;
        private Collage_MGT_System_DBDataSetTableAdapters.Student_detilsTableAdapter student_detilsTableAdapter;
        private System.Windows.Forms.BindingSource addStudentDetilsDBDataSetBindingSource;
        private Add_Student_Detils_DBDataSet add_Student_Detils_DBDataSet;
        private Add_Student_Detils_DBDataSet1 add_Student_Detils_DBDataSet1;
        private System.Windows.Forms.BindingSource studentDetilsBindingSource1;
        private Add_Student_Detils_DBDataSet1TableAdapters.Student_DetilsTableAdapter student_DetilsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
    }
}