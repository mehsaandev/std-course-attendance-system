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
            InitializeTable();


            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            nav.Height = button4.Height;
            nav.Top = button4.Top;
            nav.Left = button4.Left;
            button4.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void InitializeTable()
        {
            row2.Width = 0;
            row1.Width = 0;
            row3.Width = 0;
            row4.Width = 0;
            row5.Width = 0;
            row6.Width = 0;
            row7.Width = 0;
            downBtn.Width = 0;
            checkNum = 0;
            LastRowIndex = 0;
            dtCourses = new DataTable();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Course", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtCourses);
            MessageBox.Show(dtCourses.Rows[0].ItemArray[0].ToString());
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
        private void button4_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(24, 30, 54);
            button3.BackColor = Color.FromArgb(24, 30, 54);
            button5.BackColor = Color.FromArgb(24, 30, 54);
            nav.Height = button4.Height;
            nav.Top = button4.Top;
            nav.Left = button4.Left;
            button4.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(24, 30, 54);
            button3.BackColor = Color.FromArgb(24, 30, 54);
            button5.BackColor = Color.FromArgb(24, 30, 54);
            nav.Height = button1.Height;
            nav.Top = button1.Top;
            nav.Left = button1.Left;
            button1.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(24, 30, 54);
            button1.BackColor = Color.FromArgb(24, 30, 54);
            button5.BackColor = Color.FromArgb(24, 30, 54);
            nav.Height = button3.Height;
            nav.Top = button3.Top;
            nav.Left = button3.Left;
            button3.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
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
            InitializeTable();
        } 
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (row1.Width < 731)
            {
                row1.Width += 50;
            }
            else
            {
                timer1.Enabled = false;
                if(checkNum > 1)
                {
                    timer2.Enabled = true;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
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

        private void timer3_Tick(object sender, EventArgs e)
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

        private void timer4_Tick(object sender, EventArgs e)
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

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (row5.Width < 731)
            {
                row5.Width += 75;
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

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (row6.Width < 731)
            {
                row6.Width += 75;
            }
            else
            {
                timer6.Enabled = false;
                if (checkNum > 6)
                if (checkNum > 6)
                {
                    timer7.Enabled = true;
                }
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (row7.Width < 731)
            {
                row7.Width += 75;
            }
            else
            {
                timer7.Enabled = false;
                if(TableSize>7)
                {
                    downBtn.Width = 750;
                }
            }
        }

        private void downBtn_Click(object sender, EventArgs e)
        {

            if(LastRowIndex>=7 && LastRowIndex<dtCourses.Rows.Count)
            {
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
    }
}
