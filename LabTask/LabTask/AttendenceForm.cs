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
        private int DateChangeCount;
        private int DateRowIndexTemp;


        private bool IsAttendacneLoaded;
        private DataTable dtCourses ;
        private DataTable AttendenceTable;
        private List<DateTime> DateList;

        private List<string> StdRegTempList;
        private List<string> StdNameTempList;
        private List<bool> StdStatusTempList;
        private List<DateTime> StdDateTempList;



        // Contructor ////////////////////////////////////
        public AttendenceForm(string course)
        {
            InitializeComponent();
            DateChangeCount = 0;
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
            MessageBox.Show(AttendenceTable.Rows.Count.ToString());
            for(int i = 0; i< AttendenceTable.Rows.Count;i++)
            {
                
                
                DateTime temp = DateTime.Parse(AttendenceTable.Rows[i].ItemArray[2].ToString());
                

                string MyTempDate =  dateTimePicker1.Value.Year+":"+dateTimePicker1.Value.Month+":"+dateTimePicker1.Value.Day;
                string DatabaseTempDate = temp.Year + ":" + temp.Month + ":" + temp.Day;
               /* MessageBox.Show(MyTempDate);
                 MessageBox.Show(DatabaseTempDate);*/
               

                if (MyTempDate == DatabaseTempDate)
                {
                    DateRowIndexTemp = i;
                    MessageBox.Show("Index we get is: " + DateRowIndexTemp);
                    
                }
                DateList.Add(temp);
            }
        }

        private void InitializeListsForNewAttendance()
        {
            StdRegTempList = new List<string>();
            StdNameTempList = new List<string>();
            StdStatusTempList = new List<bool>();
            StdDateTempList = new List<DateTime>();

            for (int i = 0; i < dtCourses.Rows.Count; i++)
            {
                StdRegTempList.Add( dtCourses.Rows[i].ItemArray[0].ToString());
                StdNameTempList.Add(GetStudentName(dtCourses.Rows[i].ItemArray[0].ToString()));
                StdStatusTempList.Add(false);
                StdDateTempList.Add(dateTimePicker1.Value);
            }
            
    }

        private void InitializeTable(DateTime date)
        {
            checkNum = 0;
            LastRowIndex = 0;
            FirstRowIndex = 0;

            IsAttendacneLoaded = false;
            LoadAttendData();
            LoadDateList();

            foreach (var item in DateList)
            {
                if(item.Date ==date.Date )
                {

                    LoadDateAttendence(date.Date);
                    IsAttendacneLoaded = true;
                    break;
                }
            }
            if (!IsAttendacneLoaded)
            {
                MarkedCheck.Text = "Not Marked";
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
                    Markbtn1.Checked = false;
                    checkNum++;

                    regno2.Text = StdRegTempList[1];
                    name2.Text = StdNameTempList[1];
                    Markbtn2.Checked = false;
                    checkNum++;

                    regno3.Text = StdRegTempList[2];
                    name3.Text = StdNameTempList[2];
                    Markbtn3.Checked = false;
                    checkNum++;

                    regno4.Text = StdRegTempList[3];
                    name4.Text = StdNameTempList[3];
                    Markbtn4.Checked = false;
                    checkNum++;

                    regno5.Text = StdRegTempList[4];
                    name5.Text = StdNameTempList[4];
                    Markbtn5.Checked = false;
                    checkNum++;

                    regno6.Text = StdRegTempList[5];
                    name6.Text = StdNameTempList[5];
                    Markbtn6.Checked = false;
                    checkNum++;

                    regno7.Text = StdRegTempList[6];
                    name7.Text = StdNameTempList[6];
                    Markbtn7.Checked = false;
                    checkNum++;

                }
                catch (Exception)
                {
                }
            }
            LastRowIndex = --checkNum;
            //   MessageBox.Show(LastRowIndex.ToString());
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void LoadDateAttendence(DateTime date)
        {
            MarkedCheck.Text = "Marked";
            IsAttendacneLoaded = true;
            StdNameTempList = new List<string>();
            StdRegTempList = new List<string>();
            StdStatusTempList = new List<bool>();
            StdDateTempList = new List<DateTime>();

            for (int i = 0; i < AttendenceTable.Rows.Count; i++)
            {
                if(DateTime.Parse( AttendenceTable.Rows[i].ItemArray[2].ToString()).Date == date.Date)
                {
                    StdRegTempList.Add(AttendenceTable.Rows[i].ItemArray[0].ToString());
                    StdNameTempList.Add(GetStudentName(AttendenceTable.Rows[i].ItemArray[0].ToString()));
                    StdDateTempList.Add(DateTime.Parse(AttendenceTable.Rows[i].ItemArray[2].ToString()));
                    StdStatusTempList.Add(Boolean.Parse( AttendenceTable.Rows[i].ItemArray[3].ToString()));
                }
                
            }
            try
                {
                    regno1.Text = StdRegTempList[0];
                name1.Text = StdNameTempList[0];
                Markbtn1.Checked = StdStatusTempList[0];
                    checkNum++;

                    regno2.Text = StdRegTempList[1];
                name2.Text = StdNameTempList[1];
                Markbtn2.Checked = StdStatusTempList[1];
                checkNum++;

                    regno3.Text = StdRegTempList[2];
                name3.Text = StdNameTempList[2];
                Markbtn3.Checked = StdStatusTempList[2];
                checkNum++;

                    regno4.Text = StdRegTempList[3];
                name4.Text = StdNameTempList[3];
                Markbtn4.Checked = StdStatusTempList[3];
                checkNum++;

                    regno5.Text = StdRegTempList[4];
                name5.Text = StdNameTempList[4];
                Markbtn5.Checked = StdStatusTempList[4];
                checkNum++;

                    regno6.Text = StdRegTempList[5];
                name6.Text = StdNameTempList[5];
                Markbtn6.Checked = StdStatusTempList[5];
                checkNum++;

                    regno7.Text = StdRegTempList[6];
                name7.Text = StdNameTempList[6];
                Markbtn7.Checked = StdStatusTempList[6];
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
            if(DateChangeCount > 0)
            {
                MessageBox.Show("Date picker");
                InitializeTable(dateTimePicker1.Value);
            }
            DateChangeCount++;
            


        }

        private void Markbtn1_CheckedChanged(object sender, EventArgs e)
        {
            StdStatusTempList[FirstRowIndex + 0] = Markbtn1.Checked;
            if (Markbtn1.Checked == true)
                Markbtn1.BackColor = Color.Aqua;
            else
                Markbtn1.BackColor = Color.Honeydew;
            
        }

        private void Save1_Click(object sender, EventArgs e)
        {
            Markbtn1.Enabled = false;
        }

        private void Edit1_Click(object sender, EventArgs e)
        {
            Markbtn1.Enabled = true;
        }

        private void button40_Click(object sender, EventArgs e)
        {
             var con = Configuration.getInstance().getConnection();
            /* foreach (var item in DateList)
             {
                 if(item.Date.Equals( dateTimePicker1.Value.Date))
                 {

                 }
             }*/
            if (IsAttendacneLoaded)
            {

                for (int i = 0; i < StdRegTempList.Count; i++)
                {
                  /*  DateTime dateTemp = new DateTime();
                    dateTemp = StdDateTempList[i];
                    MessageBox.Show(dateTemp.ToString());*/
                  MessageBox.Show(AttendenceTable.Rows[DateRowIndexTemp].ItemArray[2].ToString());
                    SqlCommand cmd = new SqlCommand("Update Attendance Set [Status] = '" + StdStatusTempList[i] + "' Where TimeStamp = '" + AttendenceTable.Rows[DateRowIndexTemp].ItemArray[2] + "' And CourseName = '" + Coursetitle.Text + "' And StudentRegNo = '" + StdRegTempList[i] + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Updated");
                }
            }
            else
            {
                for (int i = 0; i < StdRegTempList.Count; i++)
                {
                    SqlCommand cmd = new SqlCommand("Insert into Attendance values (@StudentRegNo, @CourseName, @TimeStamp, @Status)", con);
                    cmd.Parameters.AddWithValue("@StudentRegNo", StdRegTempList[i]);
                    cmd.Parameters.AddWithValue("@CourseName", Coursetitle.Text);
                    cmd.Parameters.AddWithValue("@TimeStamp", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@Status", StdStatusTempList[i]);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully saved");
                }
            }
        }

    }
}
