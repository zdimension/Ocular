﻿namespace Ocular
{
    partial class NewProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProject));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.MinFootprint = new System.Windows.Forms.Timer(this.components);
            this.NewProjectLabel = new System.Windows.Forms.Label();
            this.ProjectNameField = new System.Windows.Forms.TextBox();
            this.ProjectDirectory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            // MinFootprint
            // 
            this.MinFootprint.Enabled = true;
            this.MinFootprint.Tick += new System.EventHandler(this.MinFootprint_Tick);
            // 
            // NewProjectLabel
            // 
            this.NewProjectLabel.AutoSize = true;
            this.NewProjectLabel.BackColor = System.Drawing.Color.Transparent;
            this.NewProjectLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewProjectLabel.ForeColor = System.Drawing.Color.Gray;
            this.NewProjectLabel.Location = new System.Drawing.Point(352, 32);
            this.NewProjectLabel.Name = "NewProjectLabel";
            this.NewProjectLabel.Size = new System.Drawing.Size(224, 45);
            this.NewProjectLabel.TabIndex = 5;
            this.NewProjectLabel.Text = "NEW PROJECT";
            // 
            // ProjectNameField
            // 
            this.ProjectNameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProjectNameField.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectNameField.Location = new System.Drawing.Point(12, 111);
            this.ProjectNameField.Name = "ProjectNameField";
            this.ProjectNameField.Size = new System.Drawing.Size(576, 43);
            this.ProjectNameField.TabIndex = 6;
            this.ProjectNameField.Text = "Project Name";
            // 
            // ProjectDirectory
            // 
            this.ProjectDirectory.AutoSize = true;
            this.ProjectDirectory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectDirectory.ForeColor = System.Drawing.Color.Gray;
            this.ProjectDirectory.Location = new System.Drawing.Point(23, 151);
            this.ProjectDirectory.Name = "ProjectDirectory";
            this.ProjectDirectory.Size = new System.Drawing.Size(390, 21);
            this.ProjectDirectory.TabIndex = 7;
            this.ProjectDirectory.Text = "C:\\Users\\Me\\Documents\\Ocular\\Projects\\ProjectName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Will add more to this tomorrow.";
            // 
            // NewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProjectNameField);
            this.Controls.Add(this.NewProjectLabel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LogoBox);
            this.Controls.Add(this.ProjectDirectory);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewProject";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Project";
            this.Load += new System.EventHandler(this.NewProject_Load);
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
        private System.Windows.Forms.Timer MinFootprint;
        private System.Windows.Forms.Label NewProjectLabel;
        private System.Windows.Forms.TextBox ProjectNameField;
        private System.Windows.Forms.Label ProjectDirectory;
        private System.Windows.Forms.Label label1;
    }
}