
namespace LabTask
{
    partial class AddStudent
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
            this.register = new System.Windows.Forms.Button();
            this.address = new System.Windows.Forms.TextBox();
            this.session = new System.Windows.Forms.TextBox();
            this.dept = new System.Windows.Forms.TextBox();
            this.stdregno = new System.Windows.Forms.TextBox();
            this.stdfirstname = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.titlebar = new System.Windows.Forms.Panel();
            this.closebtn = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.titlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MainPanel.Controls.Add(this.register);
            this.MainPanel.Controls.Add(this.address);
            this.MainPanel.Controls.Add(this.session);
            this.MainPanel.Controls.Add(this.dept);
            this.MainPanel.Controls.Add(this.stdregno);
            this.MainPanel.Controls.Add(this.stdfirstname);
            this.MainPanel.Controls.Add(this.title);
            this.MainPanel.Controls.Add(this.titlebar);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(500, 500);
            this.MainPanel.TabIndex = 1;
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.register.FlatAppearance.BorderSize = 0;
            this.register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.register.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.register.Location = new System.Drawing.Point(204, 410);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(103, 40);
            this.register.TabIndex = 6;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // address
            // 
            this.address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.address.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.address.Location = new System.Drawing.Point(134, 263);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.PlaceholderText = "Address";
            this.address.Size = new System.Drawing.Size(253, 123);
            this.address.TabIndex = 5;
            this.address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // session
            // 
            this.session.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.session.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.session.Location = new System.Drawing.Point(250, 204);
            this.session.Multiline = true;
            this.session.Name = "session";
            this.session.PlaceholderText = "Session";
            this.session.Size = new System.Drawing.Size(222, 35);
            this.session.TabIndex = 4;
            this.session.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dept
            // 
            this.dept.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dept.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dept.Location = new System.Drawing.Point(12, 204);
            this.dept.Multiline = true;
            this.dept.Name = "dept";
            this.dept.PlaceholderText = "Department";
            this.dept.Size = new System.Drawing.Size(222, 35);
            this.dept.TabIndex = 3;
            this.dept.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stdregno
            // 
            this.stdregno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stdregno.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stdregno.Location = new System.Drawing.Point(250, 135);
            this.stdregno.Multiline = true;
            this.stdregno.Name = "stdregno";
            this.stdregno.PlaceholderText = "Registration No.";
            this.stdregno.Size = new System.Drawing.Size(222, 35);
            this.stdregno.TabIndex = 2;
            this.stdregno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stdfirstname
            // 
            this.stdfirstname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stdfirstname.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stdfirstname.Location = new System.Drawing.Point(12, 135);
            this.stdfirstname.Multiline = true;
            this.stdfirstname.Name = "stdfirstname";
            this.stdfirstname.PlaceholderText = "First Name";
            this.stdfirstname.Size = new System.Drawing.Size(222, 35);
            this.stdfirstname.TabIndex = 1;
            this.stdfirstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.title.Font = new System.Drawing.Font("Yu Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.title.Location = new System.Drawing.Point(134, 31);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(253, 38);
            this.title.TabIndex = 5;
            this.title.Text = "Register Student";
            // 
            // titlebar
            // 
            this.titlebar.BackColor = System.Drawing.Color.White;
            this.titlebar.Controls.Add(this.closebtn);
            this.titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebar.Location = new System.Drawing.Point(0, 0);
            this.titlebar.Name = "titlebar";
            this.titlebar.Size = new System.Drawing.Size(500, 28);
            this.titlebar.TabIndex = 4;
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
            this.closebtn.Location = new System.Drawing.Point(465, 0);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(35, 28);
            this.closebtn.TabIndex = 100;
            this.closebtn.Text = "X";
            this.closebtn.UseVisualStyleBackColor = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStudent";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.titlebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel titlebar;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox session;
        private System.Windows.Forms.TextBox dept;
        private System.Windows.Forms.TextBox stdregno;
        private System.Windows.Forms.TextBox stdfirstname;
        private System.Windows.Forms.Button register;
    }
}