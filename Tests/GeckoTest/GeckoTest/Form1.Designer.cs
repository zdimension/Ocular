namespace GeckoTest
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.EditPage = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EditPage
            // 
            this.EditPage.Location = new System.Drawing.Point(0, 0);
            this.EditPage.Multiline = true;
            this.EditPage.Name = "EditPage";
            this.EditPage.Size = new System.Drawing.Size(285, 738);
            this.EditPage.TabIndex = 0;
            this.EditPage.Text = resources.GetString("EditPage.Text");
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(4, 743);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(281, 23);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 789);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.EditPage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EditPage;
        private System.Windows.Forms.Button btnView;
    }
}

