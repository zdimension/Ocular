namespace Ocular
{
    partial class PlainButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PlainButtonText = new System.Windows.Forms.Label();
            this.PlainButtonImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PlainButtonImage)).BeginInit();
            this.SuspendLayout();
            // 
            // PlainButtonText
            // 
            this.PlainButtonText.Font = new System.Drawing.Font("Segoe UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlainButtonText.ForeColor = System.Drawing.Color.DarkGray;
            this.PlainButtonText.Location = new System.Drawing.Point(53, 3);
            this.PlainButtonText.Name = "PlainButtonText";
            this.PlainButtonText.Size = new System.Drawing.Size(264, 44);
            this.PlainButtonText.TabIndex = 1;
            this.PlainButtonText.Text = "PlainButton Text";
            this.PlainButtonText.Click += new System.EventHandler(this.PlainButtonText_Click);
            this.PlainButtonText.MouseEnter += new System.EventHandler(this.PlainButtonText_MouseEnter);
            this.PlainButtonText.MouseLeave += new System.EventHandler(this.PlainButtonText_MouseLeave);
            // 
            // PlainButtonImage
            // 
            this.PlainButtonImage.Location = new System.Drawing.Point(3, 3);
            this.PlainButtonImage.Name = "PlainButtonImage";
            this.PlainButtonImage.Size = new System.Drawing.Size(44, 44);
            this.PlainButtonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlainButtonImage.TabIndex = 0;
            this.PlainButtonImage.TabStop = false;
            this.PlainButtonImage.Click += new System.EventHandler(this.PlainButtonImage_Click);
            this.PlainButtonImage.MouseEnter += new System.EventHandler(this.PlainButtonImage_MouseEnter);
            this.PlainButtonImage.MouseLeave += new System.EventHandler(this.PlainButtonImage_MouseLeave);
            // 
            // PlainButton
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.PlainButtonText);
            this.Controls.Add(this.PlainButtonImage);
            this.Name = "PlainButton";
            this.Size = new System.Drawing.Size(320, 50);
            this.Load += new System.EventHandler(this.PlainButton_Load);
            this.Click += new System.EventHandler(this.PlainButton_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PlainButton_Paint);
            this.MouseEnter += new System.EventHandler(this.PlainButton_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.PlainButton_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.PlainButtonImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PlainButtonImage;
        private System.Windows.Forms.Label PlainButtonText;
    }
}
