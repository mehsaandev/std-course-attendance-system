using CRUD_Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LabTask
{
    public partial class AddCourseForm : Form
    {
        public AddCourseForm()
        {
            InitializeComponent();
            title.BackColor = Color.FromArgb(0);
            titlebar.BackColor = Color.FromArgb(30,255,255,255);

        }

        private void AddCourseForm_Load(object sender, EventArgs e)
        {
            MainPanel.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into Course values (@Name, @Code)", con);
            cmd.Parameters.AddWithValue("@Name", coursename.Text);
            cmd.Parameters.AddWithValue("@Code", coursecode.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully saved");
            this.Close();



        }
    }
}