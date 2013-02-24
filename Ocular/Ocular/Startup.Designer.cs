namespace Ocular
{
    partial class Startup
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
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lkblSkip = new System.Windows.Forms.Label();
            this.chkNotShow = new System.Windows.Forms.CheckBox();
            this.btnNewProject = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.Transparent;
            this.pnlTitle.Controls.Add(this.pictureBox1);
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(640, 31);
            this.pnlTitle.TabIndex = 0;
            this.pnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ocular.Properties.Resources.closebtn_normal;
            this.pictureBox1.Location = new System.Drawing.Point(612, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 21);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // lkblSkip
            // 
            this.lkblSkip.AutoSize = true;
            this.lkblSkip.BackColor = System.Drawing.Color.Transparent;
            this.lkblSkip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lkblSkip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkblSkip.ForeColor = System.Drawing.Color.Blue;
            this.lkblSkip.Location = new System.Drawing.Point(569, 453);
            this.lkblSkip.Name = "lkblSkip";
            this.lkblSkip.Size = new System.Drawing.Size(56, 15);
            this.lkblSkip.TabIndex = 1;
            this.lkblSkip.Text = "Skip >>>";
            this.lkblSkip.Click += new System.EventHandler(this.lkblSkip_Click);
            // 
            // chkNotShow
            // 
            this.chkNotShow.AutoSize = true;
            this.chkNotShow.BackColor = System.Drawing.Color.Transparent;
            this.chkNotShow.Checked = global::Ocular.Properties.Settings.Default.DontShowStartupWindow;
            this.chkNotShow.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Ocular.Properties.Settings.Default, "DontShowStartupWindow", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkNotShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.chkNotShow.Location = new System.Drawing.Point(12, 452);
            this.chkNotShow.Name = "chkNotShow";
            this.chkNotShow.Size = new System.Drawing.Size(169, 19);
            this.chkNotShow.TabIndex = 2;
            this.chkNotShow.Text = "Don\'t show this page again";
            this.chkNotShow.UseVisualStyleBackColor = false;
            // 
            // btnNewProject
            // 
            this.btnNewProject.BackColor = System.Drawing.Color.Transparent;
            this.btnNewProject.FlatAppearance.BorderSize = 0;
            this.btnNewProject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnNewProject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnNewProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnNewProject.Image = global::Ocular.Properties.Resources.project;
            this.btnNewProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewProject.Location = new System.Drawing.Point(209, 184);
            this.btnNewProject.Name = "btnNewProject";
            this.btnNewProject.Size = new System.Drawing.Size(213, 23);
            this.btnNewProject.TabIndex = 3;
            this.btnNewProject.Text = "      Project";
            this.btnNewProject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewProject.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.button1.Image = global::Ocular.Properties.Resources.file;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(209, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "      HTML";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.button2.Image = global::Ocular.Properties.Resources.file;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(209, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "      CSS";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.button3.Image = global::Ocular.Properties.Resources.file;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(209, 271);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(213, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "      XML";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Magenta;
            this.BackgroundImage = global::Ocular.Properties.Resources.ocular_startpage;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNewProject);
            this.Controls.Add(this.chkNotShow);
            this.Controls.Add(this.lkblSkip);
            this.Controls.Add(this.pnlTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Startup";
            this.Text = "Startup";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.pnlTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lkblSkip;
        private System.Windows.Forms.CheckBox chkNotShow;
        private System.Windows.Forms.Button btnNewProject;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}