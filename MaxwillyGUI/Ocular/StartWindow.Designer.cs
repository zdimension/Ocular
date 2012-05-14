namespace Ocular
{
    partial class StartWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BrightnessTrackBar = new System.Windows.Forms.TrackBar();
            this.BrightnessLabel = new System.Windows.Forms.Label();
            this.GetStartedGroup = new System.Windows.Forms.GroupBox();
            this.NewCSSFileButton = new Ocular.PlainButton();
            this.NewHTMLFileButton = new Ocular.PlainButton();
            this.OpenProjectButton = new Ocular.PlainButton();
            this.NewProjectButton = new Ocular.PlainButton();
            this.RecentProjectsGroup = new System.Windows.Forms.GroupBox();
            this.WhatsNewLabel = new System.Windows.Forms.Label();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessTrackBar)).BeginInit();
            this.GetStartedGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(599, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 400);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.ForestGreen;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 399);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 1);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 399);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(1, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(598, 1);
            this.panel4.TabIndex = 4;
            // 
            // BrightnessTrackBar
            // 
            this.BrightnessTrackBar.AutoSize = false;
            this.BrightnessTrackBar.Location = new System.Drawing.Point(71, 374);
            this.BrightnessTrackBar.Maximum = 255;
            this.BrightnessTrackBar.Name = "BrightnessTrackBar";
            this.BrightnessTrackBar.Size = new System.Drawing.Size(100, 23);
            this.BrightnessTrackBar.TabIndex = 5;
            this.BrightnessTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.BrightnessTrackBar.Value = 255;
            this.BrightnessTrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BrightnessTrackBar_MouseUp);
            // 
            // BrightnessLabel
            // 
            this.BrightnessLabel.AutoSize = true;
            this.BrightnessLabel.BackColor = System.Drawing.Color.Transparent;
            this.BrightnessLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrightnessLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.BrightnessLabel.Location = new System.Drawing.Point(4, 378);
            this.BrightnessLabel.Name = "BrightnessLabel";
            this.BrightnessLabel.Size = new System.Drawing.Size(71, 13);
            this.BrightnessLabel.TabIndex = 6;
            this.BrightnessLabel.Text = "BRIGHTNESS";
            // 
            // GetStartedGroup
            // 
            this.GetStartedGroup.BackColor = System.Drawing.Color.Transparent;
            this.GetStartedGroup.Controls.Add(this.NewCSSFileButton);
            this.GetStartedGroup.Controls.Add(this.NewHTMLFileButton);
            this.GetStartedGroup.Controls.Add(this.OpenProjectButton);
            this.GetStartedGroup.Controls.Add(this.NewProjectButton);
            this.GetStartedGroup.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetStartedGroup.ForeColor = System.Drawing.Color.Gray;
            this.GetStartedGroup.Location = new System.Drawing.Point(12, 111);
            this.GetStartedGroup.Name = "GetStartedGroup";
            this.GetStartedGroup.Size = new System.Drawing.Size(335, 259);
            this.GetStartedGroup.TabIndex = 7;
            this.GetStartedGroup.TabStop = false;
            this.GetStartedGroup.Text = "Get Started";
            // 
            // NewCSSFileButton
            // 
            this.NewCSSFileButton.BackColor = System.Drawing.Color.White;
            this.NewCSSFileButton.ButtonImage = global::Ocular.Properties.Resources.NewCSS;
            this.NewCSSFileButton.ButtonText = "New CSS File...";
            this.NewCSSFileButton.Location = new System.Drawing.Point(6, 197);
            this.NewCSSFileButton.Name = "NewCSSFileButton";
            this.NewCSSFileButton.Size = new System.Drawing.Size(323, 50);
            this.NewCSSFileButton.TabIndex = 3;
            // 
            // NewHTMLFileButton
            // 
            this.NewHTMLFileButton.BackColor = System.Drawing.Color.White;
            this.NewHTMLFileButton.ButtonImage = global::Ocular.Properties.Resources.NewHTML;
            this.NewHTMLFileButton.ButtonText = "New HTML File...";
            this.NewHTMLFileButton.Location = new System.Drawing.Point(6, 144);
            this.NewHTMLFileButton.Name = "NewHTMLFileButton";
            this.NewHTMLFileButton.Size = new System.Drawing.Size(323, 50);
            this.NewHTMLFileButton.TabIndex = 2;
            // 
            // OpenProjectButton
            // 
            this.OpenProjectButton.BackColor = System.Drawing.Color.White;
            this.OpenProjectButton.ButtonImage = global::Ocular.Properties.Resources.OpenProject;
            this.OpenProjectButton.ButtonText = "Open Project...";
            this.OpenProjectButton.Location = new System.Drawing.Point(6, 91);
            this.OpenProjectButton.Name = "OpenProjectButton";
            this.OpenProjectButton.Size = new System.Drawing.Size(323, 50);
            this.OpenProjectButton.TabIndex = 1;
            // 
            // NewProjectButton
            // 
            this.NewProjectButton.BackColor = System.Drawing.Color.White;
            this.NewProjectButton.ButtonImage = ((System.Drawing.Image)(resources.GetObject("NewProjectButton.ButtonImage")));
            this.NewProjectButton.ButtonText = "New Project...";
            this.NewProjectButton.Location = new System.Drawing.Point(6, 38);
            this.NewProjectButton.Name = "NewProjectButton";
            this.NewProjectButton.Size = new System.Drawing.Size(323, 50);
            this.NewProjectButton.TabIndex = 0;
            // 
            // RecentProjectsGroup
            // 
            this.RecentProjectsGroup.BackColor = System.Drawing.Color.Transparent;
            this.RecentProjectsGroup.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecentProjectsGroup.ForeColor = System.Drawing.Color.Gray;
            this.RecentProjectsGroup.Location = new System.Drawing.Point(353, 111);
            this.RecentProjectsGroup.Name = "RecentProjectsGroup";
            this.RecentProjectsGroup.Size = new System.Drawing.Size(235, 259);
            this.RecentProjectsGroup.TabIndex = 8;
            this.RecentProjectsGroup.TabStop = false;
            this.RecentProjectsGroup.Text = "Recent Projects";
            // 
            // WhatsNewLabel
            // 
            this.WhatsNewLabel.AutoSize = true;
            this.WhatsNewLabel.BackColor = System.Drawing.Color.Transparent;
            this.WhatsNewLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhatsNewLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.WhatsNewLabel.Location = new System.Drawing.Point(432, 378);
            this.WhatsNewLabel.Name = "WhatsNewLabel";
            this.WhatsNewLabel.Size = new System.Drawing.Size(165, 13);
            this.WhatsNewLabel.TabIndex = 9;
            this.WhatsNewLabel.Text = "WHAT\'S NEW IN THIS RELEASE?";
            // 
            // LogoBox
            // 
            this.LogoBox.BackColor = System.Drawing.Color.Transparent;
            this.LogoBox.Image = global::Ocular.Properties.Resources.OcularApp;
            this.LogoBox.Location = new System.Drawing.Point(5, 5);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(350, 100);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoBox.TabIndex = 0;
            this.LogoBox.TabStop = false;
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Ocular.Properties.Resources.StartWindow1;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.WhatsNewLabel);
            this.Controls.Add(this.RecentProjectsGroup);
            this.Controls.Add(this.GetStartedGroup);
            this.Controls.Add(this.BrightnessLabel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LogoBox);
            this.Controls.Add(this.BrightnessTrackBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartWindow";
            this.Load += new System.EventHandler(this.StartWindow_Load);
            this.BackColorChanged += new System.EventHandler(this.StartWindow_BackColorChanged);
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessTrackBar)).EndInit();
            this.GetStartedGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TrackBar BrightnessTrackBar;
        private System.Windows.Forms.Label BrightnessLabel;
        private System.Windows.Forms.GroupBox GetStartedGroup;
        private System.Windows.Forms.GroupBox RecentProjectsGroup;
        private PlainButton NewProjectButton;
        private System.Windows.Forms.Label WhatsNewLabel;
        private PlainButton OpenProjectButton;
        private PlainButton NewHTMLFileButton;
        private PlainButton NewCSSFileButton;
    }
}