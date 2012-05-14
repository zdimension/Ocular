namespace Ocular
{
    partial class DocumentWindow
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
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.SourceCodeEditor = new FastColoredTextBoxNS.FastColoredTextBox();
            this.PreviewControl = new System.Windows.Forms.WebBrowser();
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusText = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            this.MainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.BackColor = System.Drawing.Color.White;
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.SourceCodeEditor);
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.PreviewControl);
            this.MainSplitContainer.Size = new System.Drawing.Size(1000, 698);
            this.MainSplitContainer.SplitterDistance = 500;
            this.MainSplitContainer.TabIndex = 0;
            // 
            // SourceCodeEditor
            // 
            this.SourceCodeEditor.AutoScrollMinSize = new System.Drawing.Size(501, 150);
            this.SourceCodeEditor.BackBrush = null;
            this.SourceCodeEditor.CommentPrefix = null;
            this.SourceCodeEditor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SourceCodeEditor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.SourceCodeEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SourceCodeEditor.Language = FastColoredTextBoxNS.Language.HTML;
            this.SourceCodeEditor.LeftBracket = '<';
            this.SourceCodeEditor.LeftBracket2 = '(';
            this.SourceCodeEditor.Location = new System.Drawing.Point(0, 0);
            this.SourceCodeEditor.Name = "SourceCodeEditor";
            this.SourceCodeEditor.Paddings = new System.Windows.Forms.Padding(0);
            this.SourceCodeEditor.RightBracket = '>';
            this.SourceCodeEditor.RightBracket2 = ')';
            this.SourceCodeEditor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.SourceCodeEditor.Size = new System.Drawing.Size(500, 698);
            this.SourceCodeEditor.TabIndex = 0;
            this.SourceCodeEditor.Text = "<!DOCTYPE HTML>\r\n<html>\r\n<head>\r\n<meta http-equiv=\"Content-Type\" content=\"text/ht" +
    "ml; charset=utf-8\">\r\n<title>Untitled Document</title>\r\n</head>\r\n<body>\r\n\r\n</body" +
    ">\r\n</html>";
            // 
            // PreviewControl
            // 
            this.PreviewControl.AllowNavigation = false;
            this.PreviewControl.AllowWebBrowserDrop = false;
            this.PreviewControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviewControl.IsWebBrowserContextMenuEnabled = false;
            this.PreviewControl.Location = new System.Drawing.Point(0, 0);
            this.PreviewControl.MinimumSize = new System.Drawing.Size(20, 20);
            this.PreviewControl.Name = "PreviewControl";
            this.PreviewControl.ScriptErrorsSuppressed = true;
            this.PreviewControl.Size = new System.Drawing.Size(496, 698);
            this.PreviewControl.TabIndex = 0;
            this.PreviewControl.Url = new System.Uri("about:blank", System.UriKind.Absolute);
            this.PreviewControl.WebBrowserShortcutsEnabled = false;
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.BackColor = System.Drawing.Color.White;
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusText});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 698);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(1000, 22);
            this.MainStatusStrip.TabIndex = 1;
            // 
            // StatusText
            // 
            this.StatusText.ForeColor = System.Drawing.Color.Gray;
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(61, 17);
            this.StatusText.Text = "StatusText";
            // 
            // DocumentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 720);
            this.Controls.Add(this.MainSplitContainer);
            this.Controls.Add(this.MainStatusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DocumentWindow";
            this.Text = "DocumentWindow";
            this.Load += new System.EventHandler(this.DocumentWindow_Load);
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer MainSplitContainer;
        public System.Windows.Forms.WebBrowser PreviewControl;
        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusText;
        private FastColoredTextBoxNS.FastColoredTextBox SourceCodeEditor;
    }
}