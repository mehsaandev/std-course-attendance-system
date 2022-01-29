
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
            this.titlebar = new System.Windows.Forms.Panel();
            this.closebtn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.titlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MainPanel.Controls.Add(this.title);
            this.MainPanel.Controls.Add(this.titlebar);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(500, 500);
            this.MainPanel.TabIndex = 1;
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
            this.title.Location = new System.Drawing.Point(134, 31);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(253, 38);
            this.title.TabIndex = 5;
            this.title.Text = "Register Student";
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
    }
}