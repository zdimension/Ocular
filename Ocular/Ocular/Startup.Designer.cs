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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Startup));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lkblSkip = new System.Windows.Forms.Label();
            this.chkNotShow = new System.Windows.Forms.CheckBox();
            this.btnNewProject = new System.Windows.Forms.Button();
            this.btnNewHTML = new System.Windows.Forms.Button();
            this.btnNewCSS = new System.Windows.Forms.Button();
            this.btnNewXML = new System.Windows.Forms.Button();
            this.btnNewJS = new System.Windows.Forms.Button();
            this.btnNewCF = new System.Windows.Forms.Button();
            this.btnNewMore = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            // btnNewHTML
            // 
            this.btnNewHTML.BackColor = System.Drawing.Color.Transparent;
            this.btnNewHTML.FlatAppearance.BorderSize = 0;
            this.btnNewHTML.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnNewHTML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnNewHTML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewHTML.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnNewHTML.Image = ((System.Drawing.Image)(resources.GetObject("btnNewHTML.Image")));
            this.btnNewHTML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewHTML.Location = new System.Drawing.Point(209, 213);
            this.btnNewHTML.Name = "btnNewHTML";
            this.btnNewHTML.Size = new System.Drawing.Size(213, 23);
            this.btnNewHTML.TabIndex = 4;
            this.btnNewHTML.Text = "      HTML";
            this.btnNewHTML.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewHTML.UseVisualStyleBackColor = false;
            // 
            // btnNewCSS
            // 
            this.btnNewCSS.BackColor = System.Drawing.Color.Transparent;
            this.btnNewCSS.FlatAppearance.BorderSize = 0;
            this.btnNewCSS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnNewCSS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnNewCSS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewCSS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnNewCSS.Image = ((System.Drawing.Image)(resources.GetObject("btnNewCSS.Image")));
            this.btnNewCSS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewCSS.Location = new System.Drawing.Point(209, 242);
            this.btnNewCSS.Name = "btnNewCSS";
            this.btnNewCSS.Size = new System.Drawing.Size(213, 23);
            this.btnNewCSS.TabIndex = 5;
            this.btnNewCSS.Text = "      CSS";
            this.btnNewCSS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewCSS.UseVisualStyleBackColor = false;
            // 
            // btnNewXML
            // 
            this.btnNewXML.BackColor = System.Drawing.Color.Transparent;
            this.btnNewXML.FlatAppearance.BorderSize = 0;
            this.btnNewXML.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnNewXML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnNewXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewXML.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnNewXML.Image = ((System.Drawing.Image)(resources.GetObject("btnNewXML.Image")));
            this.btnNewXML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewXML.Location = new System.Drawing.Point(209, 271);
            this.btnNewXML.Name = "btnNewXML";
            this.btnNewXML.Size = new System.Drawing.Size(213, 23);
            this.btnNewXML.TabIndex = 6;
            this.btnNewXML.Text = "      XML";
            this.btnNewXML.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewXML.UseVisualStyleBackColor = false;
            // 
            // btnNewJS
            // 
            this.btnNewJS.BackColor = System.Drawing.Color.Transparent;
            this.btnNewJS.FlatAppearance.BorderSize = 0;
            this.btnNewJS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnNewJS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnNewJS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewJS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnNewJS.Image = ((System.Drawing.Image)(resources.GetObject("btnNewJS.Image")));
            this.btnNewJS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewJS.Location = new System.Drawing.Point(209, 300);
            this.btnNewJS.Name = "btnNewJS";
            this.btnNewJS.Size = new System.Drawing.Size(213, 23);
            this.btnNewJS.TabIndex = 7;
            this.btnNewJS.Text = "      JavaScript";
            this.btnNewJS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewJS.UseVisualStyleBackColor = false;
            // 
            // btnNewCF
            // 
            this.btnNewCF.BackColor = System.Drawing.Color.Transparent;
            this.btnNewCF.FlatAppearance.BorderSize = 0;
            this.btnNewCF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnNewCF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnNewCF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewCF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnNewCF.Image = ((System.Drawing.Image)(resources.GetObject("btnNewCF.Image")));
            this.btnNewCF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewCF.Location = new System.Drawing.Point(209, 329);
            this.btnNewCF.Name = "btnNewCF";
            this.btnNewCF.Size = new System.Drawing.Size(213, 23);
            this.btnNewCF.TabIndex = 8;
            this.btnNewCF.Text = "      ColdFusion";
            this.btnNewCF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewCF.UseVisualStyleBackColor = false;
            // 
            // btnNewMore
            // 
            this.btnNewMore.BackColor = System.Drawing.Color.Transparent;
            this.btnNewMore.FlatAppearance.BorderSize = 0;
            this.btnNewMore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnNewMore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnNewMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewMore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnNewMore.Image = global::Ocular.Properties.Resources.folder;
            this.btnNewMore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewMore.Location = new System.Drawing.Point(209, 358);
            this.btnNewMore.Name = "btnNewMore";
            this.btnNewMore.Size = new System.Drawing.Size(213, 23);
            this.btnNewMore.TabIndex = 9;
            this.btnNewMore.Text = "      More...";
            this.btnNewMore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewMore.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.button1.Image = global::Ocular.Properties.Resources.open;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(16, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "      Open file...";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Magenta;
            this.BackgroundImage = global::Ocular.Properties.Resources.ocular_startpage;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNewMore);
            this.Controls.Add(this.btnNewCF);
            this.Controls.Add(this.btnNewJS);
            this.Controls.Add(this.btnNewXML);
            this.Controls.Add(this.btnNewCSS);
            this.Controls.Add(this.btnNewHTML);
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
        private System.Windows.Forms.Button btnNewHTML;
        private System.Windows.Forms.Button btnNewCSS;
        private System.Windows.Forms.Button btnNewXML;
        private System.Windows.Forms.Button btnNewJS;
        private System.Windows.Forms.Button btnNewCF;
        private System.Windows.Forms.Button btnNewMore;
        private System.Windows.Forms.Button button1;
    }
}