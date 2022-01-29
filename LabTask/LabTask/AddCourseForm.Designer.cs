
namespace LabTask
{
    partial class AddCourseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.titlebar = new System.Windows.Forms.Panel();
            this.closebtn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.coursename = new System.Windows.Forms.TextBox();
            this.coursecode = new System.Windows.Forms.TextBox();
            this.MainPanel.SuspendLayout();
            this.titlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MainPanel.Controls.Add(this.titlebar);
            this.MainPanel.Controls.Add(this.title);
            this.MainPanel.Controls.Add(this.addbtn);
            this.MainPanel.Controls.Add(this.coursename);
            this.MainPanel.Controls.Add(this.coursecode);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(412, 435);
            this.MainPanel.TabIndex = 0;
            // 
            // titlebar
            // 
            this.titlebar.BackColor = System.Drawing.Color.White;
            this.titlebar.Controls.Add(this.closebtn);
            this.titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebar.Location = new System.Drawing.Point(0, 0);
            this.titlebar.Name = "titlebar";
            this.titlebar.Size = new System.Drawing.Size(412, 28);
            this.titlebar.TabIndex = 3;
            // 
            // closebtn
            // 
            this.closebtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.closebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closebtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closebtn.FlatAppearance.BorderSize = 0;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closebtn.ForeColor = System.Drawing.Color.Black;
            this.closebtn.Location = new System.Drawing.Point(377, 0);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(35, 28);
            this.closebtn.TabIndex = 0;
            this.closebtn.Text = "X";
            this.closebtn.UseVisualStyleBackColor = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.title.Font = new System.Drawing.Font("Yu Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.title.Location = new System.Drawing.Point(79, 31);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(252, 38);
            this.title.TabIndex = 2;
            this.title.Text = "Add New Course";
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.addbtn.FlatAppearance.BorderSize = 0;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addbtn.Location = new System.Drawing.Point(142, 322);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(103, 40);
            this.addbtn.TabIndex = 1;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // coursename
            // 
            this.coursename.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.coursename.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coursename.Location = new System.Drawing.Point(89, 150);
            this.coursename.Multiline = true;
            this.coursename.Name = "coursename";
            this.coursename.PlaceholderText = "Course Name";
            this.coursename.Size = new System.Drawing.Size(222, 35);
            this.coursename.TabIndex = 0;
            this.coursename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // coursecode
            // 
            this.coursecode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.coursecode.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coursecode.Location = new System.Drawing.Point(89, 212);
            this.coursecode.Multiline = true;
            this.coursecode.Name = "coursecode";
            this.coursecode.PlaceholderText = "Course Code";
            this.coursecode.Size = new System.Drawing.Size(222, 35);
            this.coursecode.TabIndex = 0;
            this.coursecode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(412, 435);
            this.Controls.Add(this.MainPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCourseForm";
            this.Load += new System.EventHandler(this.AddCourseForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.titlebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.TextBox coursename;
        private System.Windows.Forms.TextBox coursecode;
        private System.Windows.Forms.Panel titlebar;
        private System.Windows.Forms.Button closebtn;
    }
}