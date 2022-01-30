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
    public partial class AttendenceForm : Form
    {
        private int checkNum = 0;
        private int LastRowIndex = 0;
        private int FirstRowIndex = 1;
        private int TableSize = 0;


        private bool AttendTypeStatus;
        private DataTable dtCourses ;
        private DataTable AttendenceTable;
        private List<DateTime> DateList;

        private List<string> StdRegTempList;
        private List<string> StdNameTempList;
        private List<bool> StdStatusTempList;



        // Contructor ////////////////////////////////////
        public AttendenceForm(string course)
        {
            InitializeComponent();
            Coursetitle.Text = course;
            dateTimePicker1.Value = DateTime.Now;

            InitializeTable(dateTimePicker1.Value);
          //  LoadDateAttendence();
        }
        // Contructor End //////////////////////////////////////




        private void LoadAttendData()
        {
            AttendenceTable = new DataTable();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Attendance Where CourseName = '" + Coursetitle.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(AttendenceTable);

        }
        private string GetStudentName(string regNo)
        {
            DataTable dtCourses = new DataTable();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select [Name] from Student Where RegistrationNumber = '" + regNo + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtCourses);
            return dtCourses.Rows[0].ItemArray[0].ToString();
        }

        private void LoadDateList()
        {
            DateList = new List<DateTime>();

            foreach (var item in AttendenceTable.Rows)
            {
                DateTime temp = DateTime.Parse(item.ToString());
                DateList.Add(temp);
            }
        }

        private void InitializeListsForNewAttendance()
        {
            StdRegTempList = new List<string>();
            StdNameTempList = new List<string>();
            StdStatusTempList = new List<bool>();

            for (int i = 0; i < dtCourses.Rows.Count; i++)
            {
                StdRegTempList.Add( dtCourses.Rows[i].ItemArray[0].ToString());
                StdNameTempList.Add(GetStudentName(dtCourses.Rows[i].ItemArray[0].ToString()));
                StdStatusTempList.Add(false);
            }
            
    }

        private void InitializeTable(DateTime date)
        {
            checkNum = 0;
            LastRowIndex = 0;
            FirstRowIndex = 0;

            AttendTypeStatus = false;
            LoadAttendData();
            LoadDateList();

            foreach (var item in DateList)
            {
                if(item.Date ==date.Date )
                {
                    LoadDateAttendence(date.Date);
                    AttendTypeStatus = true;
                    break;
                }
            }
            if (!AttendTypeStatus)
            {
                dtCourses = new DataTable();
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Select [StudentRegNo] from Enrollments Where CourseName = '" + Coursetitle.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtCourses);
                InitializeListsForNewAttendance();
                try
                {
                    regno1.Text = StdRegTempList[0];
                    name1.Text = StdNameTempList[0];
                    checkNum++;

                    regno2.Text = StdRegTempList[1];
                    name2.Text = StdNameTempList[1];
                    checkNum++;

                    regno3.Text = StdRegTempList[2];
                    name3.Text = StdNameTempList[2];
                    checkNum++;

                    regno4.Text = StdRegTempList[3];
                    name4.Text = StdNameTempList[3];
                    checkNum++;

                    regno5.Text = StdRegTempList[4];
                    name5.Text = StdNameTempList[4];
                    checkNum++;

                    regno6.Text = StdRegTempList[5];
                    name6.Text = StdNameTempList[5];
                    checkNum++;

                    regno7.Text = StdRegTempList[6];
                    name7.Text = StdNameTempList[6];
                    checkNum++;

                }
                catch (Exception)
                {
                }
            }


            




           
           
            LastRowIndex = checkNum;
            //   MessageBox.Show(LastRowIndex.ToString());
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void LoadDateAttendence(DateTime date)
        {
            StdNameTempList = new List<string>();
            StdRegTempList = new List<string>();
            StdStatusTempList = new List<bool>();

            for (int i = 0; i < AttendenceTable.Rows.Count; i++)
            {
                if(DateTime.Parse( AttendenceTable.Rows[i].ItemArray[2].ToString()).Date == date.Date)
                {
                    StdRegTempList.Add(AttendenceTable.Rows[i].ItemArray[0].ToString());
                    StdNameTempList.Add(GetStudentName(AttendenceTable.Rows[i].ItemArray[0].ToString()));
                    StdStatusTempList.Add(Boolean.Parse( AttendenceTable.Rows[i].ItemArray[3].ToString()));
                }
                
            }
            try
                {
                    regno1.Text = StdRegTempList[0];
                name1.Text = StdNameTempList[0];
                    checkNum++;

                    regno2.Text = StdRegTempList[1];
                name2.Text = StdNameTempList[1];
                checkNum++;

                    regno3.Text = StdRegTempList[2];
                name3.Text = StdNameTempList[2];
                checkNum++;

                    regno4.Text = StdRegTempList[3];
                name4.Text = StdNameTempList[3];
                checkNum++;

                    regno5.Text = StdRegTempList[4];
                name5.Text = StdNameTempList[4];
                checkNum++;

                    regno6.Text = StdRegTempList[5];
                name6.Text = StdNameTempList[5];
                checkNum++;

                    regno7.Text = StdRegTempList[6];
                name7.Text = StdNameTempList[6];
                checkNum++;

                }
                catch (Exception)
                {
                }


         
            LastRowIndex = checkNum;
            //   MessageBox.Show(LastRowIndex.ToString());
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // LoadDateAttendence();
        }
    }
}
