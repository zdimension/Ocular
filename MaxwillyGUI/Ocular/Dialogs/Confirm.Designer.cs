namespace Ocular.Dialogs
{
    partial class Confirm
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
            this.MessageLabel = new System.Windows.Forms.Label();
            this.CancelButton = new OcButton.OcButton();
            this.OkButton = new OcButton.OcButton();
            this.NoButton = new OcButton.OcButton();
            this.SuspendLayout();
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.BackColor = System.Drawing.Color.Transparent;
            this.MessageLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.ForeColor = System.Drawing.Color.Gray;
            this.MessageLabel.Location = new System.Drawing.Point(-5, -2);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(327, 74);
            this.MessageLabel.TabIndex = 0;
            this.MessageLabel.Text = "Oops, an error has occured.\r\nSorry!";
            this.MessageLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.White;
            this.CancelButton.ButtonText = "CANCEL";
            this.CancelButton.ForceUppercase = true;
            this.CancelButton.ForeColor = System.Drawing.Color.Gray;
            this.CancelButton.Location = new System.Drawing.Point(160, 113);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(80, 25);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Load += new System.EventHandler(this.CancelButton_Load);
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.Color.White;
            this.OkButton.ButtonText = "YES";
            this.OkButton.ForceUppercase = true;
            this.OkButton.ForeColor = System.Drawing.Color.Gray;
            this.OkButton.Location = new System.Drawing.Point(308, 113);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(80, 25);
            this.OkButton.TabIndex = 2;
            this.OkButton.Load += new System.EventHandler(this.OkButton_Load);
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // NoButton
            // 
            this.NoButton.BackColor = System.Drawing.Color.White;
            this.NoButton.ButtonText = "NO";
            this.NoButton.ForceUppercase = true;
            this.NoButton.ForeColor = System.Drawing.Color.Gray;
            this.NoButton.Location = new System.Drawing.Point(12, 113);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(80, 25);
            this.NoButton.TabIndex = 3;
            this.NoButton.Load += new System.EventHandler(this.NoButton_Load);
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // Confirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Ocular.Properties.Resources.StartWindow;
            this.ClientSize = new System.Drawing.Size(400, 152);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.MessageLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Confirm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirm";
            this.Load += new System.EventHandler(this.Confirm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MessageLabel;
        private OcButton.OcButton CancelButton;
        private OcButton.OcButton OkButton;
        private OcButton.OcButton NoButton;
    }
}