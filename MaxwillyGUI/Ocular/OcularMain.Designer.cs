namespace Ocular
{
    partial class OcularMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OcularMain));
            this.TopBar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.MainDocControl = new MdiTabControl.TabControl();
            this.windowLabel = new System.Windows.Forms.Label();
            this.minimizeLabel = new System.Windows.Forms.Label();
            this.maximizeLabel = new System.Windows.Forms.Label();
            this.TopBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.White;
            this.TopBar.Controls.Add(this.panel1);
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(1000, 60);
            this.TopBar.TabIndex = 0;
            this.TopBar.Paint += new System.Windows.Forms.PaintEventHandler(this.TopBar_Paint);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.maximizeLabel);
            this.panel1.Controls.Add(this.minimizeLabel);
            this.panel1.Controls.Add(this.windowLabel);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 21);
            this.panel1.TabIndex = 1;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.Gray;
            this.CloseButton.Location = new System.Drawing.Point(981, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(19, 21);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // MainDocControl
            // 
            this.MainDocControl.BackColor = System.Drawing.Color.White;
            this.MainDocControl.BackHighColor = System.Drawing.Color.White;
            this.MainDocControl.BackLowColor = System.Drawing.Color.White;
            this.MainDocControl.BorderColor = System.Drawing.Color.Transparent;
            this.MainDocControl.BorderColorDisabled = System.Drawing.Color.Transparent;
            this.MainDocControl.ControlButtonBackHighColor = System.Drawing.Color.LimeGreen;
            this.MainDocControl.ControlButtonBackLowColor = System.Drawing.Color.ForestGreen;
            this.MainDocControl.ControlButtonBorderColor = System.Drawing.Color.DarkGray;
            this.MainDocControl.ControlButtonForeColor = System.Drawing.Color.Black;
            this.MainDocControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainDocControl.Location = new System.Drawing.Point(0, 60);
            this.MainDocControl.MenuRenderer = null;
            this.MainDocControl.Name = "MainDocControl";
            this.MainDocControl.Size = new System.Drawing.Size(1000, 660);
            this.MainDocControl.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.MainDocControl.TabBackHighColor = System.Drawing.Color.White;
            this.MainDocControl.TabBackHighColorDisabled = System.Drawing.Color.White;
            this.MainDocControl.TabBackLowColor = System.Drawing.Color.White;
            this.MainDocControl.TabBackLowColorDisabled = System.Drawing.Color.White;
            this.MainDocControl.TabCloseButtonBackHighColor = System.Drawing.Color.White;
            this.MainDocControl.TabCloseButtonBackHighColorDisabled = System.Drawing.Color.White;
            this.MainDocControl.TabCloseButtonBackHighColorHot = System.Drawing.Color.White;
            this.MainDocControl.TabCloseButtonBackLowColor = System.Drawing.Color.White;
            this.MainDocControl.TabCloseButtonBackLowColorDisabled = System.Drawing.Color.White;
            this.MainDocControl.TabCloseButtonBackLowColorHot = System.Drawing.Color.White;
            this.MainDocControl.TabCloseButtonBorderColor = System.Drawing.Color.White;
            this.MainDocControl.TabCloseButtonBorderColorDisabled = System.Drawing.Color.White;
            this.MainDocControl.TabCloseButtonBorderColorHot = System.Drawing.Color.White;
            this.MainDocControl.TabCloseButtonForeColor = System.Drawing.Color.DarkGray;
            this.MainDocControl.TabCloseButtonForeColorDisabled = System.Drawing.Color.DarkGray;
            this.MainDocControl.TabCloseButtonForeColorHot = System.Drawing.Color.Black;
            this.MainDocControl.TabCloseButtonImage = null;
            this.MainDocControl.TabCloseButtonImageDisabled = null;
            this.MainDocControl.TabCloseButtonImageHot = null;
            this.MainDocControl.TabIndex = 1;
            this.MainDocControl.TabMaximumWidth = 150;
            this.MainDocControl.TabMinimumWidth = 150;
            this.MainDocControl.TopSeparator = false;
            this.MainDocControl.Load += new System.EventHandler(this.MainDocControl_Load);
            this.MainDocControl.TabIndexChanged += new System.EventHandler(this.MainDocControl_TabIndexChanged);
            this.MainDocControl.Paint += new System.Windows.Forms.PaintEventHandler(this.MainDocControl_Paint);
            // 
            // windowLabel
            // 
            this.windowLabel.AutoSize = true;
            this.windowLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowLabel.ForeColor = System.Drawing.Color.Gray;
            this.windowLabel.Location = new System.Drawing.Point(3, 0);
            this.windowLabel.Name = "windowLabel";
            this.windowLabel.Size = new System.Drawing.Size(69, 21);
            this.windowLabel.TabIndex = 1;
            this.windowLabel.Text = "OCULAR";
            // 
            // minimizeLabel
            // 
            this.minimizeLabel.AutoSize = true;
            this.minimizeLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizeLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeLabel.ForeColor = System.Drawing.Color.Gray;
            this.minimizeLabel.Location = new System.Drawing.Point(964, 0);
            this.minimizeLabel.Name = "minimizeLabel";
            this.minimizeLabel.Size = new System.Drawing.Size(17, 21);
            this.minimizeLabel.TabIndex = 2;
            this.minimizeLabel.Text = "_";
            this.minimizeLabel.Click += new System.EventHandler(this.minimizeLabel_Click);
            // 
            // maximizeLabel
            // 
            this.maximizeLabel.AutoSize = true;
            this.maximizeLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.maximizeLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximizeLabel.ForeColor = System.Drawing.Color.Gray;
            this.maximizeLabel.Location = new System.Drawing.Point(942, 0);
            this.maximizeLabel.Name = "maximizeLabel";
            this.maximizeLabel.Size = new System.Drawing.Size(22, 21);
            this.maximizeLabel.TabIndex = 3;
            this.maximizeLabel.Text = "O";
            this.maximizeLabel.Click += new System.EventHandler(this.maximizeLabel_Click);
            // 
            // OcularMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1000, 720);
            this.Controls.Add(this.MainDocControl);
            this.Controls.Add(this.TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "OcularMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Ocular_Load);
            this.TopBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBar;
        private MdiTabControl.TabControl MainDocControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label windowLabel;
        private System.Windows.Forms.Label minimizeLabel;
        private System.Windows.Forms.Label maximizeLabel;
    }
}

