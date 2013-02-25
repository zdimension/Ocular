namespace Ocular.Dialogs
{
    partial class WhatsNew
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WhatsNew));
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CreditsLabel = new System.Windows.Forms.Label();
            this.DoneButton = new OcButton.OcButton();
            this.CodePlexButton = new OcButton.OcButton();
            this.CloseTimer = new System.Windows.Forms.Timer(this.components);
            this.UITeamLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SeeOurCodePlexLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(1, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(498, 1);
            this.panel4.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 313);
            this.panel3.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.ForestGreen;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 313);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(499, 1);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(499, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 314);
            this.panel1.TabIndex = 5;
            // 
            // CreditsLabel
            // 
            this.CreditsLabel.AutoSize = true;
            this.CreditsLabel.BackColor = System.Drawing.Color.Transparent;
            this.CreditsLabel.Font = new System.Drawing.Font("Segoe UI Light", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditsLabel.ForeColor = System.Drawing.Color.Gray;
            this.CreditsLabel.Location = new System.Drawing.Point(1, 1);
            this.CreditsLabel.Name = "CreditsLabel";
            this.CreditsLabel.Size = new System.Drawing.Size(237, 59);
            this.CreditsLabel.TabIndex = 9;
            this.CreditsLabel.Text = "What\'s New";
            // 
            // DoneButton
            // 
            this.DoneButton.BackColor = System.Drawing.Color.White;
            this.DoneButton.ButtonText = "DONE";
            this.DoneButton.ForceUppercase = true;
            this.DoneButton.ForeColor = System.Drawing.Color.Gray;
            this.DoneButton.Location = new System.Drawing.Point(408, 277);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(80, 25);
            this.DoneButton.TabIndex = 10;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // CodePlexButton
            // 
            this.CodePlexButton.BackColor = System.Drawing.Color.White;
            this.CodePlexButton.ButtonText = "CODEPLEX";
            this.CodePlexButton.ForceUppercase = true;
            this.CodePlexButton.ForeColor = System.Drawing.Color.Gray;
            this.CodePlexButton.Location = new System.Drawing.Point(12, 277);
            this.CodePlexButton.Name = "CodePlexButton";
            this.CodePlexButton.Size = new System.Drawing.Size(80, 25);
            this.CodePlexButton.TabIndex = 11;
            this.CodePlexButton.Click += new System.EventHandler(this.CodePlexButton_Click);
            // 
            // CloseTimer
            // 
            this.CloseTimer.Interval = 1;
            this.CloseTimer.Tick += new System.EventHandler(this.CloseTimer_Tick);
            // 
            // UITeamLabel
            // 
            this.UITeamLabel.AutoSize = true;
            this.UITeamLabel.BackColor = System.Drawing.Color.Transparent;
            this.UITeamLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UITeamLabel.ForeColor = System.Drawing.Color.Gray;
            this.UITeamLabel.Location = new System.Drawing.Point(7, 76);
            this.UITeamLabel.Name = "UITeamLabel";
            this.UITeamLabel.Size = new System.Drawing.Size(303, 25);
            this.UITeamLabel.TabIndex = 0;
            this.UITeamLabel.Text = "New in This Commit Version (0.2A)";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(20, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(468, 173);
            this.label2.TabIndex = 13;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SeeOurCodePlexLabel
            // 
            this.SeeOurCodePlexLabel.AutoSize = true;
            this.SeeOurCodePlexLabel.BackColor = System.Drawing.Color.Transparent;
            this.SeeOurCodePlexLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeeOurCodePlexLabel.ForeColor = System.Drawing.Color.Gray;
            this.SeeOurCodePlexLabel.Location = new System.Drawing.Point(98, 289);
            this.SeeOurCodePlexLabel.Name = "SeeOurCodePlexLabel";
            this.SeeOurCodePlexLabel.Size = new System.Drawing.Size(266, 13);
            this.SeeOurCodePlexLabel.TabIndex = 32;
            this.SeeOurCodePlexLabel.Text = "WANT TO HELP? CHECK OUT OUR CODEPLEX PAGE!";
            // 
            // WhatsNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Ocular.Properties.Resources.StartWindow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 314);
            this.Controls.Add(this.SeeOurCodePlexLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UITeamLabel);
            this.Controls.Add(this.CodePlexButton);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.CreditsLabel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WhatsNew";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credits";
            this.Load += new System.EventHandler(this.Credits_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CreditsLabel;
        private OcButton.OcButton DoneButton;
        private OcButton.OcButton CodePlexButton;
        private System.Windows.Forms.Timer CloseTimer;
        private System.Windows.Forms.Label UITeamLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SeeOurCodePlexLabel;
    }
}