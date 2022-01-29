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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
            MainPanel.BackColor = Color.FromArgb(100, 0, 0, 0);
            title.BackColor = Color.FromArgb(0);
            titlebar.BackColor = Color.FromArgb(30, 255, 255, 255);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void register_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into Student values (@RegistrationNumber, @Name, @Department, @Session, @Address)", con);
            cmd.Parameters.AddWithValue("@RegistrationNumber", stdregno.Text);
            cmd.Parameters.AddWithValue("@Name", stdfirstname.Text);
            cmd.Parameters.AddWithValue("@Department", dept.Text);
            cmd.Parameters.AddWithValue("@Session", session.Text);
            cmd.Parameters.AddWithValue("@Address", address.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully saved");
            this.Close();
        }
    }
}
