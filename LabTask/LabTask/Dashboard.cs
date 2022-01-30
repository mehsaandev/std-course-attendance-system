using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CRUD_Operations;
using System.Data.SqlClient;

namespace LabTask
{
    public partial class Dashboard : Form
    {
        private int checkNum = 0;
        private int LastRowIndex = 0;
        private int FirstRowIndex = 1;
        private int TableSize = 0;
        private DataTable dtCourses = new DataTable();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
    );
        public Dashboard()
        {
            InitializeComponent();
            /* CourseDashboard.Enabled = false;
             StudentDashboard.Enabled = false;*/
            InitializeDashboards();

            // Course Dashboard location : 192, 77

            // MainPanal.Size = 760, 512);

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            nav.Height = studentDashboardbn.Height;
            nav.Top = studentDashboardbn.Top;
            nav.Left = studentDashboardbn.Left;
            studentDashboardbn.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void InitializeDashboards()
        {
            CourseDashboard.Location = new System.Drawing.Point(900, 900);
            CourseDashboard.Enabled = false;
            CourseDashboard.Visible = false;
            CourseDashboard.Width = 0;
            CourseDashboard.Height = 0;

            StudentDashboard.Location = new System.Drawing.Point(900, 900);
            StudentDashboard.Visible = false;
            StudentDashboard.Enabled = false;
            StudentDashboard.Width = 0;
            StudentDashboard.Height = 0;

            AttendanceDashBoard.Location = new System.Drawing.Point(900, 900);
            AttendanceDashBoard.Visible = false;
            AttendanceDashBoard.Enabled = false;
            AttendanceDashBoard.Width = 0;
            AttendanceDashBoard.Height = 0;
        }


        private int GetStudentCount(string CourseName)
        {
            DataTable stdTable = new DataTable();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select [StudentRegNo] from Enrollments Where CourseName = '"+CourseName+"'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(stdTable);
            return stdTable.Rows.Count;
        }

        private void InitializeAttendanceTable()
        {
            AttendanceDashBoard.Location = new System.Drawing.Point(192, 77);
            AttendanceDashBoard.Enabled = true;
            AttendanceDashBoard.Visible = true;
            AttendanceDashBoard.Width = 760;
            AttendanceDashBoard.Height = 512;



            attendUpbtn.BackColor = Color.FromArgb(100, 101, 110, 118);
            attenddownbtn.BackColor = Color.FromArgb(100, 101, 110, 118);

            attendrow1.Width = 0;
            attendrow2.Width = 0;
            attendrow3.Width = 0;
            attendrow4.Width = 0;
            attendrow5.Width = 0;
            attendrow6.Width = 0;
            attendrow7.Width = 0;

            attenddownbtn.Width = 0;
            attendUpbtn.Width = 0;
            checkNum = 0;
            LastRowIndex = 0;
            FirstRowIndex = 0;

             dtCourses = new DataTable();
             var con = Configuration.getInstance().getConnection();
             SqlCommand cmd = new SqlCommand("Select [Name] from Course", con);
             SqlDataAdapter da = new SqlDataAdapter(cmd);
             da.Fill(dtCourses);
             TableSize = dtCourses.Rows.Count;
             try
             {
                attendCourseName1.Text = dtCourses.Rows[0].ItemArray[0].ToString();

                 nostdreg1.Text = GetStudentCount(attendCourseName1.Text).ToString();
                 checkNum++;

                 attendCourseName2.Text = dtCourses.Rows[1].ItemArray[0].ToString();
                nostdreg2.Text = GetStudentCount(attendCourseName2.Text).ToString();
                checkNum++;

                attendCourseName3.Text = dtCourses.Rows[2].ItemArray[0].ToString();
                nostdreg3.Text = GetStudentCount(attendCourseName3.Text).ToString();
                checkNum++;

                attendCourseName4.Text = dtCourses.Rows[3].ItemArray[0].ToString();
                nostdreg4.Text = GetStudentCount(attendCourseName4.Text).ToString();
                checkNum++;

                attendCourseName5.Text = dtCourses.Rows[4].ItemArray[0].ToString();
                nostdreg5.Text = GetStudentCount(attendCourseName5.Text).ToString();
                checkNum++;

                attendCourseName6.Text = dtCourses.Rows[5].ItemArray[0].ToString();
                nostdreg6.Text = GetStudentCount(attendCourseName6.Text).ToString();
                checkNum++;

                attendCourseName7.Text = dtCourses.Rows[6].ItemArray[0].ToString();
                nostdreg7.Text = GetStudentCount(attendCourseName7.Text).ToString();
                checkNum++;

             }
             catch (Exception)
             {
             }
            LastRowIndex = checkNum;
            //   MessageBox.Show(LastRowIndex.ToString());
            timer1.Enabled = true;
        }
        private void InitializeStudentTable()
        {
            StudentDashboard.Location = new System.Drawing.Point(192, 77);
            StudentDashboard.Enabled = true;
            StudentDashboard.Visible = true;
            StudentDashboard.Width = 760;
            StudentDashboard.Height = 512;



            stddownbtn.BackColor = Color.FromArgb(100, 101, 110, 118);
            stdUpbtn.BackColor = Color.FromArgb(100, 101, 110, 118);
            stdrow1.Width = 0;
            stdrow2.Width = 0;
            stdrow3.Width = 0;
            stdrow4.Width = 0;
            stdrow5.Width = 0;
            stdrow6.Width = 0;
            stdrow7.Width = 0;
            stdUpbtn.Width = 0;
            stddownbtn.Width = 0;
            checkNum = 0;
            LastRowIndex = 0;
            FirstRowIndex = 0;
            dtCourses = new DataTable();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select [RegistrationNumber],[Name] from Student", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtCourses);

            TableSize = dtCourses.Rows.Count;
               try
               {
                   RegNo1.Text = dtCourses.Rows[0].ItemArray[0].ToString();
                   stdName1.Text = dtCourses.Rows[0].ItemArray[1].ToString();
                   checkNum++;

                   RegNo2.Text = dtCourses.Rows[1].ItemArray[0].ToString();
                   stdName2.Text = dtCourses.Rows[1].ItemArray[1].ToString();
                   checkNum++;

                   RegNo3.Text = dtCourses.Rows[2].ItemArray[0].ToString();
                   stdName3.Text = dtCourses.Rows[2].ItemArray[1].ToString();
                   checkNum++;

                   RegNo4.Text = dtCourses.Rows[3].ItemArray[0].ToString();
                   stdName4.Text = dtCourses.Rows[3].ItemArray[1].ToString();
                   checkNum++;

                   RegNo5.Text = dtCourses.Rows[4].ItemArray[0].ToString();
                   stdName5.Text = dtCourses.Rows[4].ItemArray[1].ToString();
                   checkNum++;

                   RegNo6.Text = dtCourses.Rows[5].ItemArray[0].ToString();
                   stdName6.Text = dtCourses.Rows[5].ItemArray[1].ToString();
                   checkNum++;

                   RegNo7.Text = dtCourses.Rows[6].ItemArray[0].ToString();
                   stdName7.Text = dtCourses.Rows[6].ItemArray[1].ToString();
                   checkNum++;

               }
               catch (Exception)
               {
               }

            LastRowIndex = checkNum;
            //   MessageBox.Show(LastRowIndex.ToString());
            timer1.Enabled = true;
        }
        private void InitializeCourseTable()
        {

            CourseDashboard.Location = new System.Drawing.Point(192, 77);
            CourseDashboard.Enabled = true;
            CourseDashboard.Visible = true;
            CourseDashboard.Width = 760;
            CourseDashboard.Height = 512;

            downBtn.BackColor = Color.FromArgb(100, 101, 110, 118);
            upbtn.BackColor = Color.FromArgb(100, 101, 110, 118);
            row2.Width = 0;
            row1.Width = 0;
            row3.Width = 0;
            row4.Width = 0;
            row5.Width = 0;
            row6.Width = 0;
            row7.Width = 0;
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
            timer1.Enabled = true;

        }
        private void studentbtn(object sender, EventArgs e)
        {
            Dashboardtitle.Text = "Student Dashboard";
            Attendencedashboardbtn.BackColor = Color.FromArgb(24, 30, 54);
            coursedashboardbtn.BackColor = Color.FromArgb(24, 30, 54);
            button5.BackColor = Color.FromArgb(24, 30, 54);
            nav.Height = studentDashboardbn.Height;
            nav.Top = studentDashboardbn.Top;
            nav.Left = studentDashboardbn.Left;
            studentDashboardbn.BackColor = Color.FromArgb(46, 51, 73);

            CourseDashboard.Location = new System.Drawing.Point(900, 900);
            CourseDashboard.Enabled = false;
            CourseDashboard.Visible = false;
            CourseDashboard.Width = 0;
            CourseDashboard.Height = 0;

            AttendanceDashBoard.Location = new System.Drawing.Point(900, 900);
            AttendanceDashBoard.Visible = false;
            AttendanceDashBoard.Enabled = false;
            AttendanceDashBoard.Width = 0;
            AttendanceDashBoard.Height = 0;





            InitializeStudentTable();
        }

        private void attendencebtn(object sender, EventArgs e)
        {
            Dashboardtitle.Text = "Attendence Dashboard";
            studentDashboardbn.BackColor = Color.FromArgb(24, 30, 54);
            coursedashboardbtn.BackColor = Color.FromArgb(24, 30, 54);
            button5.BackColor = Color.FromArgb(24, 30, 54);
            nav.Height = Attendencedashboardbtn.Height;
            nav.Top = Attendencedashboardbtn.Top;
            nav.Left = Attendencedashboardbtn.Left;
            Attendencedashboardbtn.BackColor = Color.FromArgb(46, 51, 73);
           


            StudentDashboard.Location = new System.Drawing.Point(900, 900);
            StudentDashboard.Visible = false;
            StudentDashboard.Enabled = false;
            StudentDashboard.Width = 0;
            StudentDashboard.Height = 0;

            CourseDashboard.Location = new System.Drawing.Point(900, 900);
            CourseDashboard.Visible = false;
            CourseDashboard.Enabled = false;
            CourseDashboard.Width = 0;
            CourseDashboard.Height = 0;

            InitializeAttendanceTable();
        }

        private void coursebtn(object sender, EventArgs e)
        {
            Dashboardtitle.Text = "Course Dashboard";
            studentDashboardbn.BackColor = Color.FromArgb(24, 30, 54);
            Attendencedashboardbtn.BackColor = Color.FromArgb(24, 30, 54);
            button5.BackColor = Color.FromArgb(24, 30, 54);
            nav.Height = coursedashboardbtn.Height;
            nav.Top = coursedashboardbtn.Top;
            nav.Left = coursedashboardbtn.Left;
            coursedashboardbtn.BackColor = Color.FromArgb(46, 51, 73);



            StudentDashboard.Location = new System.Drawing.Point(900,900);
            StudentDashboard.Enabled = false;
            StudentDashboard.Visible = false;
            StudentDashboard.Width = 0;
            StudentDashboard.Height = 0;


            AttendanceDashBoard.Location = new System.Drawing.Point(900, 900);
            AttendanceDashBoard.Visible = false;
            AttendanceDashBoard.Enabled = false;
            AttendanceDashBoard.Width = 0;
            AttendanceDashBoard.Height = 0;

            InitializeCourseTable();
            // CourseDashboard.Location.X = 192;

            //  CourseDashboard.Location.Y = 77;

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }


        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddCourseForm addCrs = new AddCourseForm();
            addCrs.ShowDialog();
            InitializeCourseTable();
        } 
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(CourseDashboard.Location.X != 900)
            {
                if (row1.Width < 731)
                {
                    row1.Width += 50;
                }
                else
                {
                    timer1.Enabled = false;
                    if (checkNum > 1)
                    {
                        timer2.Enabled = true;
                    }
                }
            }
            else if(StudentDashboard.Location.X != 900)
            {
                if (stdrow1.Width < 731)
                {
                    stdrow1.Width += 50;
                }
                else
                {
                    timer1.Enabled = false;
                    if (checkNum > 1)
                    {
                        timer2.Enabled = true;
                    }
                }
            }
            else if (AttendanceDashBoard.Location.X != 900)
            {
                if (attendrow1.Width < 731)
                {
                    attendrow1.Width += 50;
                }
                else
                {
                    timer1.Enabled = false;
                    if (checkNum > 1)
                    {
                        timer2.Enabled = true;
                    }
                }
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(CourseDashboard.Location.X !=900)
            {
                if (row2.Width < 731)
                {
                    row2.Width += 50;
                }
                else
                {
                    timer2.Enabled = false;
                    if (checkNum > 2)
                    {
                        timer3.Enabled = true;
                    }
                }
            }
            else if (StudentDashboard.Location.X != 900)
            {
                if (stdrow2.Width < 731)
                {
                    stdrow2.Width += 50;
                }
                else
                {
                    timer2.Enabled = false;
                    if (checkNum > 2)
                    {
                        timer3.Enabled = true;
                    }
                }
            }
            else if (AttendanceDashBoard.Location.X != 900)
            {
                if (attendrow2.Width < 731)
                {
                    attendrow2.Width += 50;
                }
                else
                {
                    timer2.Enabled = false;
                    if (checkNum > 2)
                    {
                        timer3.Enabled = true;
                    }
                }
            }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (CourseDashboard.Location.X != 900)
            {
                if (row3.Width < 731)
                {
                    row3.Width += 75;
                }
                else
                {
                    timer3.Enabled = false;
                    if (checkNum > 3)
                    {
                        timer4.Enabled = true;
                    }
                }
            }
            else if (StudentDashboard.Location.X != 900)
            {
                if (stdrow3.Width < 731)
                {
                    stdrow3.Width += 75;
                }
                else
                {
                    timer3.Enabled = false;
                    if (checkNum > 3)
                    {
                        timer4.Enabled = true;
                    }
                }
            }
            else if (AttendanceDashBoard.Location.X != 900)
            {
                if (attendrow3.Width < 731)
                {
                    attendrow3.Width += 75;
                }
                else
                {
                    timer3.Enabled = false;
                    if (checkNum > 3)
                    {
                        timer4.Enabled = true;
                    }
                }
            }


        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if(CourseDashboard.Location.X != 900)
            {
                if (row4.Width < 731)
                {
                    row4.Width += 75;
                }
                else
                {
                    timer4.Enabled = false;
                    if (checkNum > 4)
                    {
                        timer5.Enabled = true;
                    }
                }
            }
            else if(StudentDashboard.Location.X != 900)
            {
                if (stdrow4.Width < 731)
                {
                    stdrow4.Width += 75;
                }
                else
                {
                    timer4.Enabled = false;
                    if (checkNum > 4)
                    {
                        timer5.Enabled = true;
                    }
                }
            }
            else if (AttendanceDashBoard.Location.X != 900)
            {
                if (attendrow4.Width < 731)
                {
                    attendrow4.Width += 75;
                }
                else
                {
                    timer4.Enabled = false;
                    if (checkNum > 4)
                    {
                        timer5.Enabled = true;
                    }
                }
            }

        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (CourseDashboard.Location.X != 900)
            {
                if (stdrow5.Width < 731)
                {
                    stdrow5.Width += 75;
                }
                else
                {
                    timer5.Enabled = false;
                    if (checkNum > 5)
                    {
                        timer6.Enabled = true;
                    }
                }
            }
            else if (StudentDashboard.Location.X != 900)
            {
                if (stdrow5.Width < 731)
                {
                    stdrow5.Width += 75;
                }
                else
                {
                    timer5.Enabled = false;
                    if (checkNum > 5)
                    {
                        timer6.Enabled = true;
                    }
                }
            }
            else if (AttendanceDashBoard.Location.X != 900)
            {
                if (attendrow5.Width < 731)
                {
                    attendrow5.Width += 75;
                }
                else
                {
                    timer5.Enabled = false;
                    if (checkNum > 5)
                    {
                        timer6.Enabled = true;
                    }
                }
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (CourseDashboard.Location.X != 900)
            {
                if (stdrow6.Width < 731)
                {
                    stdrow6.Width += 75;
                }
                else
                {
                    timer6.Enabled = false;
                    if (checkNum > 6)
                    {
                        timer7.Enabled = true;
                    }
                }
            }
            else if (StudentDashboard.Location.X != 900)
            {
                if (stdrow6.Width < 731)
                {
                    stdrow6.Width += 75;
                }
                else
                {
                    timer6.Enabled = false;
                    if (checkNum > 6)
                    {
                        timer7.Enabled = true;
                    }
                }
            }
            else if (AttendanceDashBoard.Location.X != 900)
            {
                if (attendrow6.Width < 731)
                {
                    attendrow6.Width += 75;
                }
                else
                {
                    timer6.Enabled = false;
                    if (checkNum > 6)
                    {
                        timer7.Enabled = true;
                    }
                }
            }

        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (CourseDashboard.Location.X != 900)
            {
                if (row7.Width < 731)
                {
                    row7.Width += 75;
                }
                else
                {
                    timer7.Enabled = false;
                    if (TableSize > 7)
                    {
                        downBtn.Width = 750;
                    }
                }
            }
            else if (StudentDashboard.Location.X != 900)
            {
                if (stdrow7.Width < 731)
                {
                    stdrow7.Width += 75;
                }
                else
                {
                    timer7.Enabled = false;
                    if (TableSize > 7)
                    {
                        stddownbtn.Width = 750;
                    }
                }
            }
            else if (AttendanceDashBoard.Location.X != 900)
            {
                if (attendrow7.Width < 731)
                {
                    attendrow7.Width += 75;
                }
                else
                {
                    timer7.Enabled = false;
                    if (TableSize > 7)
                    {
                        attenddownbtn.Width = 750;
                    }
                }
            }

        }
        private void AttendupBtn_Click(object sender, EventArgs e)
        {
            if (FirstRowIndex >= 1)
            {
                attendUpbtn.Width = 406;
                attendCourseName1.Text = dtCourses.Rows[FirstRowIndex - 1].ItemArray[0].ToString();
                nostdreg1.Text = GetStudentCount(attendCourseName1.Text).ToString();

                attendCourseName2.Text = dtCourses.Rows[(FirstRowIndex + 1) - 1].ItemArray[0].ToString();
                nostdreg2.Text = GetStudentCount(attendCourseName2.Text).ToString();

                attendCourseName3.Text = dtCourses.Rows[FirstRowIndex + 2 - 1].ItemArray[0].ToString();
                nostdreg3.Text = GetStudentCount(attendCourseName3.Text).ToString();

                attendCourseName4.Text = dtCourses.Rows[FirstRowIndex + 3 - 1].ItemArray[0].ToString();
                nostdreg4.Text = GetStudentCount(attendCourseName4.Text).ToString();

                attendCourseName5.Text = dtCourses.Rows[FirstRowIndex + 4 - 1].ItemArray[0].ToString();
                nostdreg5.Text = GetStudentCount(attendCourseName5.Text).ToString();

                attendCourseName6.Text = dtCourses.Rows[FirstRowIndex + 5 - 1].ItemArray[0].ToString();
                nostdreg6.Text = GetStudentCount(attendCourseName6.Text).ToString();

                attendCourseName7.Text = dtCourses.Rows[FirstRowIndex + 6 - 1].ItemArray[0].ToString();
                nostdreg7.Text = GetStudentCount(attendCourseName7.Text).ToString();

                FirstRowIndex--;
                LastRowIndex--;
                if (FirstRowIndex == 0)
                {
                    attendUpbtn.Width = 0;
                }
            }
        }
        private void AttenddownBtn_Click(object sender, EventArgs e)
        {

            if (LastRowIndex >= 7 && LastRowIndex < dtCourses.Rows.Count)
            {
                FirstRowIndex++;
                attendUpbtn.Width = 406;
                LastRowIndex++;
                attendCourseName1.Text = dtCourses.Rows[(LastRowIndex) - 7].ItemArray[0].ToString();
                nostdreg1.Text = GetStudentCount(attendCourseName1.Text).ToString();

                attendCourseName2.Text = dtCourses.Rows[LastRowIndex - 6].ItemArray[0].ToString();
                nostdreg2.Text = GetStudentCount(attendCourseName2.Text).ToString();

                attendCourseName3.Text = dtCourses.Rows[LastRowIndex - 5].ItemArray[0].ToString();
                nostdreg3.Text = GetStudentCount(attendCourseName3.Text).ToString();

                attendCourseName4.Text = dtCourses.Rows[LastRowIndex - 4].ItemArray[0].ToString();
                nostdreg4.Text = GetStudentCount(attendCourseName4.Text).ToString();

                attendCourseName5.Text = dtCourses.Rows[LastRowIndex - 3].ItemArray[0].ToString();
                nostdreg5.Text = GetStudentCount(attendCourseName5.Text).ToString();

                attendCourseName6.Text = dtCourses.Rows[LastRowIndex - 2].ItemArray[0].ToString();
                nostdreg6.Text = GetStudentCount(attendCourseName6.Text).ToString();

                attendCourseName7.Text = dtCourses.Rows[LastRowIndex - 1].ItemArray[0].ToString();
                nostdreg7.Text = GetStudentCount(attendCourseName7.Text).ToString();
            }
        }
        private void StddownBtn_Click(object sender, EventArgs e)
        {

            if (LastRowIndex >= 7 && LastRowIndex < dtCourses.Rows.Count)
            {
                FirstRowIndex++;
                stdUpbtn.Width = 406;
                LastRowIndex++;
                RegNo1.Text = dtCourses.Rows[(LastRowIndex) - 7].ItemArray[0].ToString();
                stdName1.Text = dtCourses.Rows[LastRowIndex - 7].ItemArray[1].ToString();

                RegNo2.Text = dtCourses.Rows[LastRowIndex - 6].ItemArray[0].ToString();
                stdName2.Text = dtCourses.Rows[LastRowIndex - 6].ItemArray[1].ToString();

                RegNo3.Text = dtCourses.Rows[LastRowIndex - 5].ItemArray[0].ToString();
                stdName3.Text = dtCourses.Rows[LastRowIndex - 5].ItemArray[1].ToString();

                RegNo4.Text = dtCourses.Rows[LastRowIndex - 4].ItemArray[0].ToString();
                stdName4.Text = dtCourses.Rows[LastRowIndex - 4].ItemArray[1].ToString();

                RegNo5.Text = dtCourses.Rows[LastRowIndex - 3].ItemArray[0].ToString();
                stdName5.Text = dtCourses.Rows[LastRowIndex - 3].ItemArray[1].ToString();

                RegNo6.Text = dtCourses.Rows[LastRowIndex - 2].ItemArray[0].ToString();
                stdName6.Text = dtCourses.Rows[LastRowIndex - 2].ItemArray[1].ToString();

                RegNo7.Text = dtCourses.Rows[LastRowIndex - 1].ItemArray[0].ToString();
                stdName7.Text = dtCourses.Rows[LastRowIndex - 1].ItemArray[1].ToString();
            }
        }

        private void StdupBtn_Click(object sender, EventArgs e)
        {
            if (FirstRowIndex >= 1)
            {
                stdUpbtn.Width = 406;
                RegNo1.Text = dtCourses.Rows[FirstRowIndex - 1].ItemArray[0].ToString();
                stdName1.Text = dtCourses.Rows[FirstRowIndex - 1].ItemArray[1].ToString();

                RegNo2.Text = dtCourses.Rows[(FirstRowIndex + 1) - 1].ItemArray[0].ToString();
                stdName2.Text = dtCourses.Rows[(FirstRowIndex + 1) - 1].ItemArray[1].ToString();

                RegNo3.Text = dtCourses.Rows[FirstRowIndex + 2 - 1].ItemArray[0].ToString();
                stdName3.Text = dtCourses.Rows[FirstRowIndex + 2 - 1].ItemArray[1].ToString();

                RegNo4.Text = dtCourses.Rows[FirstRowIndex + 3 - 1].ItemArray[0].ToString();
                stdName4.Text = dtCourses.Rows[FirstRowIndex + 3 - 1].ItemArray[1].ToString();

                RegNo5.Text = dtCourses.Rows[FirstRowIndex + 4 - 1].ItemArray[0].ToString();
                stdName5.Text = dtCourses.Rows[FirstRowIndex + 4 - 1].ItemArray[1].ToString();

                RegNo6.Text = dtCourses.Rows[FirstRowIndex + 5 - 1].ItemArray[0].ToString();
                stdName6.Text = dtCourses.Rows[FirstRowIndex + 5 - 1].ItemArray[1].ToString();

                RegNo7.Text = dtCourses.Rows[FirstRowIndex + 6 - 1].ItemArray[0].ToString();
                stdName7.Text = dtCourses.Rows[FirstRowIndex + 6 - 1].ItemArray[1].ToString();
                FirstRowIndex--;
                LastRowIndex--;
                if (FirstRowIndex == 0)
                {
                    stdUpbtn.Width = 0;
                }
            }
        }


        private void upBtn_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(FirstRowIndex+"");
            if (FirstRowIndex>=1)
            {
                upbtn.Width = 406;
                name1.Text = dtCourses.Rows[FirstRowIndex - 1].ItemArray[0].ToString();
                course1.Text = dtCourses.Rows[FirstRowIndex - 1].ItemArray[1].ToString();

                name2.Text = dtCourses.Rows[(FirstRowIndex+1) - 1].ItemArray[0].ToString();
                course2.Text = dtCourses.Rows[(FirstRowIndex+1) - 1].ItemArray[1].ToString();

                name3.Text = dtCourses.Rows[FirstRowIndex+2 - 1].ItemArray[0].ToString();
                course3.Text = dtCourses.Rows[FirstRowIndex+2 - 1].ItemArray[1].ToString();

                name4.Text = dtCourses.Rows[FirstRowIndex+3 - 1].ItemArray[0].ToString();
                course4.Text = dtCourses.Rows[FirstRowIndex+3 - 1].ItemArray[1].ToString();

                name5.Text = dtCourses.Rows[FirstRowIndex+4 - 1].ItemArray[0].ToString();
                course5.Text = dtCourses.Rows[FirstRowIndex+4 - 1].ItemArray[1].ToString();

                name6.Text = dtCourses.Rows[FirstRowIndex+5 - 1].ItemArray[0].ToString();
                course6.Text = dtCourses.Rows[FirstRowIndex+5 - 1].ItemArray[1].ToString();

                name7.Text = dtCourses.Rows[FirstRowIndex+6 - 1].ItemArray[0].ToString();
                course7.Text = dtCourses.Rows[FirstRowIndex+6 - 1].ItemArray[1].ToString();
                FirstRowIndex--;
                LastRowIndex--;
                if(FirstRowIndex == 0)
                {
                    upbtn.Width = 0;
                }
            }
        }

        private void downBtn_Click(object sender, EventArgs e)
        {

            if(LastRowIndex>=7 && LastRowIndex<dtCourses.Rows.Count)
            {
                FirstRowIndex++;
                upbtn.Width = 406;
                LastRowIndex++;
                name1.Text = dtCourses.Rows[(LastRowIndex)-7].ItemArray[0].ToString();
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

        private void AddStdbtn(object sender, EventArgs e)
        {
            AddStudent std = new AddStudent();
            std.ShowDialog();
            InitializeStudentTable();
        }

        private void mycourse1_Click(object sender, EventArgs e)
        {
            MyCourses mycourse1 = new MyCourses(RegNo1.Text);
            mycourse1.ShowDialog();
        }

        private void Attendencebtn1_Click(object sender, EventArgs e)
        {
            AttendenceForm attend1 = new AttendenceForm(attendCourseName1.Text);
            attend1.ShowDialog();

        }

        private void Attendencebtn2_Click(object sender, EventArgs e)
        {
            AttendenceForm attend1 = new AttendenceForm(attendCourseName2.Text);
            attend1.ShowDialog();
        }

        private void Attendencebtn3_Click(object sender, EventArgs e)
        {
            AttendenceForm attend1 = new AttendenceForm(attendCourseName3.Text);
            attend1.ShowDialog();
        }

        private void Attendencebtn4_Click(object sender, EventArgs e)
        {
            AttendenceForm attend1 = new AttendenceForm(attendCourseName4.Text);
            attend1.ShowDialog();
        }

        private void Attendencebtn5_Click(object sender, EventArgs e)
        {
            AttendenceForm attend1 = new AttendenceForm(attendCourseName5.Text);
            attend1.ShowDialog();
        }

        private void Attendencebtn6_Click(object sender, EventArgs e)
        {
            AttendenceForm attend1 = new AttendenceForm(attendCourseName6.Text);
            attend1.ShowDialog();
        }

        private void Attendencebtn7_Click(object sender, EventArgs e)
        {
            AttendenceForm attend1 = new AttendenceForm(attendCourseName7.Text);
            attend1.ShowDialog();
        }

        private void mycourse2_Click(object sender, EventArgs e)
        {
            MyCourses mycourse1 = new MyCourses(RegNo2.Text);
            mycourse1.ShowDialog();
        }

        private void mycourse3_Click(object sender, EventArgs e)
        {
            MyCourses mycourse1 = new MyCourses(RegNo3.Text);
            mycourse1.ShowDialog();
        }

        private void mycourse4_Click(object sender, EventArgs e)
        {
            MyCourses mycourse1 = new MyCourses(RegNo4.Text);
            mycourse1.ShowDialog();
        }

        private void mycourse5_Click(object sender, EventArgs e)
        {
            MyCourses mycourse1 = new MyCourses(RegNo5.Text);
            mycourse1.ShowDialog();
        }

        private void mycourse6_Click(object sender, EventArgs e)
        {
            MyCourses mycourse1 = new MyCourses(RegNo6.Text);
            mycourse1.ShowDialog();
        }

        private void mycourse7_Click(object sender, EventArgs e)
        {
            MyCourses mycourse1 = new MyCourses(RegNo7.Text);
            mycourse1.ShowDialog();
        }
    }
}
