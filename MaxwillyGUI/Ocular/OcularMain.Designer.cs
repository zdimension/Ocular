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
            this.TopBar = new System.Windows.Forms.Panel();
            this.MainDocControl = new MdiTabControl.TabControl();
            this.SuspendLayout();
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.White;
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(1000, 50);
            this.TopBar.TabIndex = 0;
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
            this.MainDocControl.Location = new System.Drawing.Point(0, 50);
            this.MainDocControl.MenuRenderer = null;
            this.MainDocControl.Name = "MainDocControl";
            this.MainDocControl.Size = new System.Drawing.Size(1000, 750);
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
            this.MainDocControl.TabIndexChanged += new System.EventHandler(this.MainDocControl_TabIndexChanged);
            // 
            // Ocular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.MainDocControl);
            this.Controls.Add(this.TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Ocular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Ocular_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBar;
        private MdiTabControl.TabControl MainDocControl;
    }
}

