using CRUD_Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LabTask.User_Controls
{
    public partial class CourseControl : UserControl
    {
        private int checkNum = 0;
        private int LastRowIndex = 0;
        private int FirstRowIndex = 1;
        private int TableSize = 0;
        private DataTable dtCourses = new DataTable();
        public CourseControl()
        {
            InitializeComponent();
            InitializeTable();
        }
        private void InitializeTable()
        {


            /*row2.Width = 0;
            row1.Width = 0;
            row3.Width = 0;
            row4.Width = 0;
            row5.Width = 0;
            row6.Width = 0;
            row7.Width = 0;*/
            upbtn.Width = 0;
            downBtn.Width = 0;
            checkNum = 0;
            LastRowIndex = 0;
            FirstRowIndex = 0;
            dtCourses = new DataTable();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Course", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtCourses);

            TableSize = dtCourses.Rows.Count;
            try
            {
                name1.Text = dtCourses.Rows[0].ItemArray[0].ToString();
                course1.Text = dtCourses.Rows[0].ItemArray[1].ToString();
                checkNum++;

                name2.Text = dtCourses.Rows[1].ItemArray[0].ToString();
                course2.Text = dtCourses.Rows[1].ItemArray[1].ToString();
                checkNum++;

                name3.Text = dtCourses.Rows[2].ItemArray[0].ToString();
                course3.Text = dtCourses.Rows[2].ItemArray[1].ToString();
                checkNum++;

                name4.Text = dtCourses.Rows[3].ItemArray[0].ToString();
                course4.Text = dtCourses.Rows[3].ItemArray[1].ToString();
                checkNum++;

                name5.Text = dtCourses.Rows[4].ItemArray[0].ToString();
                course5.Text = dtCourses.Rows[4].ItemArray[1].ToString();
                checkNum++;

                name6.Text = dtCourses.Rows[5].ItemArray[0].ToString();
                course6.Text = dtCourses.Rows[5].ItemArray[1].ToString();
                checkNum++;

                name7.Text = dtCourses.Rows[6].ItemArray[0].ToString();
                course7.Text = dtCourses.Rows[6].ItemArray[1].ToString();
                checkNum++;

            }
            catch (Exception)
            {
            }
            LastRowIndex = checkNum;
            //   MessageBox.Show(LastRowIndex.ToString());
            MessageBox.Show(FirstRowIndex + "");
           // timer1.Enabled = true;

        }


        private void button7_Click(object sender, EventArgs e)
        {
            AddCourseForm addCrs = new AddCourseForm();
            addCrs.ShowDialog();
            InitializeTable();
        }
        private void upBtn_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(FirstRowIndex+"");
            if (FirstRowIndex >= 1)
            {
                upbtn.Width = 406;
                name1.Text = dtCourses.Rows[FirstRowIndex - 1].ItemArray[0].ToString();
                course1.Text = dtCourses.Rows[FirstRowIndex - 1].ItemArray[1].ToString();

                name2.Text = dtCourses.Rows[(FirstRowIndex + 1) - 1].ItemArray[0].ToString();
                course2.Text = dtCourses.Rows[(FirstRowIndex + 1) - 1].ItemArray[1].ToString();

                name3.Text = dtCourses.Rows[FirstRowIndex + 2 - 1].ItemArray[0].ToString();
                course3.Text = dtCourses.Rows[FirstRowIndex + 2 - 1].ItemArray[1].ToString();

                name4.Text = dtCourses.Rows[FirstRowIndex + 3 - 1].ItemArray[0].ToString();
                course4.Text = dtCourses.Rows[FirstRowIndex + 3 - 1].ItemArray[1].ToString();

                name5.Text = dtCourses.Rows[FirstRowIndex + 4 - 1].ItemArray[0].ToString();
                course5.Text = dtCourses.Rows[FirstRowIndex + 4 - 1].ItemArray[1].ToString();

                name6.Text = dtCourses.Rows[FirstRowIndex + 5 - 1].ItemArray[0].ToString();
                course6.Text = dtCourses.Rows[FirstRowIndex + 5 - 1].ItemArray[1].ToString();

                name7.Text = dtCourses.Rows[FirstRowIndex + 6 - 1].ItemArray[0].ToString();
                course7.Text = dtCourses.Rows[FirstRowIndex + 6 - 1].ItemArray[1].ToString();
                FirstRowIndex--;
                LastRowIndex--;
                if (FirstRowIndex == 0)
                {
                    upbtn.Width = 0;
                }
            }
        }

        private void downBtn_Click(object sender, EventArgs e)
        {

            if (LastRowIndex >= 7 && LastRowIndex < dtCourses.Rows.Count)
            {
                FirstRowIndex++;
                upbtn.Width = 406;
                LastRowIndex++;
                name1.Text = dtCourses.Rows[(LastRowIndex) - 7].ItemArray[0].ToString();
                course1.Text = dtCourses.Rows[LastRowIndex - 7].ItemArray[1].ToString();

                name2.Text = dtCourses.Rows[LastRowIndex - 6].ItemArray[0].ToString();
                course2.Text = dtCourses.Rows[LastRowIndex - 6].ItemArray[1].ToString();

                name3.Text = dtCourses.Rows[LastRowIndex - 5].ItemArray[0].ToString();
                course3.Text = dtCourses.Rows[LastRowIndex - 5].ItemArray[1].ToString();

                name4.Text = dtCourses.Rows[LastRowIndex - 4].ItemArray[0].ToString();
                course4.Text = dtCourses.Rows[LastRowIndex - 4].ItemArray[1].ToString();

                name5.Text = dtCourses.Rows[LastRowIndex - 3].ItemArray[0].ToString();
                course5.Text = dtCourses.Rows[LastRowIndex - 3].ItemArray[1].ToString();

                name6.Text = dtCourses.Rows[LastRowIndex - 2].ItemArray[0].ToString();
                course6.Text = dtCourses.Rows[LastRowIndex - 2].ItemArray[1].ToString();

                name7.Text = dtCourses.Rows[LastRowIndex - 1].ItemArray[0].ToString();
                course7.Text = dtCourses.Rows[LastRowIndex - 1].ItemArray[1].ToString();
            }
        }

    }
}
