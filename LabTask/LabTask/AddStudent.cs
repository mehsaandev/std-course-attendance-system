using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
