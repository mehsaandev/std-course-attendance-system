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
            title.Text = "Register Student";
            MainPanel.BackColor = Color.FromArgb(100, 0, 0, 0);
            title.BackColor = Color.FromArgb(0);
            titlebar.BackColor = Color.FromArgb(30, 255, 255, 255);
            register.Text = "Register";
        }
        public AddStudent(string RegNo)
        {
            InitializeComponent();
            title.Text = "Update Student";
            MainPanel.BackColor = Color.FromArgb(100, 0, 0, 0);
            title.BackColor = Color.FromArgb(0);
            titlebar.BackColor = Color.FromArgb(30, 255, 255, 255);
            stdregno.Enabled = false;
            register.Text = "Update";
            InitializeStudentData(RegNo);

        }
        private void InitializeStudentData(string regNo)
        {
            DataTable dtCourses = new DataTable();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Student Where RegistrationNumber = '"+regNo+"'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtCourses);
            stdregno.Text = dtCourses.Rows[0].ItemArray[0].ToString();
            stdfirstname.Text = dtCourses.Rows[0].ItemArray[1].ToString();
            dept.Text = dtCourses.Rows[0].ItemArray[2].ToString();
            session.Text = dtCourses.Rows[0].ItemArray[3].ToString();
            address.Text = dtCourses.Rows[0].ItemArray[4].ToString();
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
            if(register.Text == "Register")
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
            else if (register.Text == "Update")
            {

               /* SqlCommand cmd = new SqlCommand("Update Attendance Set [Status] = '" + StdStatusTempList[i] + "' Where TimeStamp = '" + AttendenceTable.Rows[DateRowIndexTemp].ItemArray[2] + "' And CourseName = '" + Coursetitle.Text + "' And StudentRegNo = '" + StdRegTempList[i] + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Updated");
*/

                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Update Student Set [Name] = '"+stdfirstname.Text+"', [Department] = '"+dept.Text+"', [Session] = '"+session.Text+"', [Address] = '"+address.Text+ "' Where RegistrationNumber = '"+stdregno.Text+"'", con);
              /*  cmd.Parameters.AddWithValue("@RegistrationNumber", stdregno.Text);
                cmd.Parameters.AddWithValue("@Name", stdfirstname.Text);
                cmd.Parameters.AddWithValue("@Department", dept.Text);
                cmd.Parameters.AddWithValue("@Session", session.Text);
                cmd.Parameters.AddWithValue("@Address", address.Text);*/
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Updated");
                this.Close();
            }
           
        }

    }
}
