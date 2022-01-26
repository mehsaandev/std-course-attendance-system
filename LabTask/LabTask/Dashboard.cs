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

namespace LabTask
{
    public partial class Dashboard : Form
    {
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
            


            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            nav.Height = button4.Height;
            nav.Top = button4.Top;
            nav.Left = button4.Left;
            button4.BackColor = Color.FromArgb(46, 51, 73);
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
            AddStudent std = new AddStudent();
            std.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 734 
            
        }
    }
}
