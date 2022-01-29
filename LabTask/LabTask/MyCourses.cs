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
    public partial class MyCourses : Form
    {
        private List<string> coursesList;
        private string RegNo;
        public MyCourses(string regNo)
        {
            InitializeComponent();
            coursesList = new List<string>();
            RegNo = regNo;


            // Registered Courses 
            DataTable dtCourses = new DataTable();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Enrollments Where StudentRegNo = '" + regNo + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtCourses);
            comboBox2.Items.Add("Select Course");
            comboBox2.SelectedIndex = 0;
            for (int i = 0; i < dtCourses.Rows.Count; i++)
            {
                comboBox2.Items.Add(dtCourses.Rows[i].ItemArray[1].ToString());
                coursesList.Add(dtCourses.Rows[i].ItemArray[1].ToString());
            }

            // Update Registered Courses Numbers
            regCourses.Text = dtCourses.Rows.Count.ToString();




             dtCourses = new DataTable();
             con = Configuration.getInstance().getConnection();
             cmd = new SqlCommand("Select Name from Course ", con);
             da = new SqlDataAdapter(cmd);
            da.Fill(dtCourses);
            comboBox1.Items.Add("Select Course");
            comboBox1.SelectedIndex = 0;
            for (int i = 0; i < dtCourses.Rows.Count; i++)
            {
                string courseTemp = dtCourses.Rows[i].ItemArray[0].ToString();
                if (!coursesList.Contains(courseTemp))
                {
                    comboBox1.Items.Add(courseTemp);
                }

            }


            // Update Total Courses
            totalcourses.Text = dtCourses.Rows.Count.ToString();



            
            availablcourses.Text = (Int32.Parse(totalcourses.Text) - Int32.Parse(regCourses.Text)).ToString();

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void register_Click(object sender, EventArgs e)
        {
            string course = comboBox1.SelectedItem.ToString();
            if(coursesList.Contains(course))
            {
                MessageBox.Show("Already Registered");
            }
            else
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Insert into Enrollments values (@StudentRegNo, @CourseName)", con);
                cmd.Parameters.AddWithValue("@StudentRegNo", RegNo);
                cmd.Parameters.AddWithValue("@CourseName", course);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully saved");
                comboBox2.Items.Add(course);
                comboBox1.Items.Remove(course);
                coursesList.Add(course);
                regCourses.Text = (Int32.Parse(regCourses.Text)+1).ToString();
                availablcourses.Text = (Int32.Parse(availablcourses.Text)-1).ToString();
            }

       


        }

        private void unregister_Click(object sender, EventArgs e)
        {
            string course = comboBox2.SelectedItem.ToString();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Delete From Enrollments Where CourseName = '"+course+"'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Deleted");
            comboBox2.Items.Remove(course);
            comboBox1.Items.Add(course);
            coursesList.Remove(course);
            regCourses.Text = (Int32.Parse(regCourses.Text) - 1).ToString();
            availablcourses.Text = (Int32.Parse(availablcourses.Text) - 1).ToString();


        }

    }
}
