namespace Ocular.TabForms
{
    partial class File
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
            this.tx = new FastColoredTextBoxNS.FastColoredTextBox();
            this.SuspendLayout();
            // 
            // tx
            // 
            this.tx.AutoScrollMinSize = new System.Drawing.Size(25, 15);
            this.tx.BackBrush = null;
            this.tx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tx.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.tx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tx.Location = new System.Drawing.Point(0, 0);
            this.tx.Name = "tx";
            this.tx.Paddings = new System.Windows.Forms.Padding(0);
            this.tx.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.tx.Size = new System.Drawing.Size(421, 338);
            this.tx.TabIndex = 2;
            // 
            // File
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 338);
            this.Controls.Add(this.tx);
            this.Name = "File";
            this.Text = "File";
            this.Load += new System.EventHandler(this.File_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox tx;
    }
}