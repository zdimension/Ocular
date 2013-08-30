using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MdiTabControl
{
    partial class TabControl
    {

        //UserControl overrides dispose to clean up the component list.
        [System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        //Required by the Windows Form Designer

        private System.ComponentModel.IContainer components;
        //NOTE: The following procedure is required by the Windows Form Designer
        //It can be modified using the Windows Form Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.DropButton = new MdiTabControl.ControlButton();
            this.CloseButton = new MdiTabControl.ControlButton();
            this.pnlTabs = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.WinMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TabToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlTop.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            //
            //pnlTop
            //
            this.pnlTop.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
            this.pnlTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlTop.Controls.Add(this.pnlControls);
            this.pnlTop.Controls.Add(this.pnlTabs);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(200, 31);
            this.pnlTop.TabIndex = 6;
            //
            //pnlControls
            //
            this.pnlControls.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right);
            this.pnlControls.Controls.Add(this.DropButton);
            this.pnlControls.Controls.Add(this.CloseButton);
            this.pnlControls.Location = new System.Drawing.Point(175, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(25, 30);
            this.pnlControls.TabIndex = 1;
            //
            //DropButton
            //
            this.DropButton.BackColor = System.Drawing.Color.Transparent;
            this.DropButton.Location = new System.Drawing.Point(4, 8);
            this.DropButton.Name = "DropButton";
            this.DropButton.Size = new System.Drawing.Size(17, 15);
            this.DropButton.Style = ControlButton.ButtonStyle.Drop;
            this.DropButton.TabIndex = 0;
            //
            //CloseButton
            //
            this.CloseButton.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.Location = new System.Drawing.Point(4, 8);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(17, 15);
            this.CloseButton.Style = ControlButton.ButtonStyle.Close;
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Visible = false;
            //
            //pnlTabs
            //
            this.pnlTabs.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
            this.pnlTabs.BackColor = System.Drawing.Color.Transparent;
            this.pnlTabs.Location = new System.Drawing.Point(0, 3);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Size = new System.Drawing.Size(200, 28);
            this.pnlTabs.TabIndex = 0;
            //
            //pnlBottom
            //
            this.pnlBottom.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
            this.pnlBottom.Location = new System.Drawing.Point(0, 31);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(200, 99);
            this.pnlBottom.TabIndex = 7;
            //
            //WinMenu
            //
            this.WinMenu.Name = "WinMenu";
            this.WinMenu.Size = new System.Drawing.Size(153, 26);
            //
            //TabControl
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBottom);
            this.Name = "TabControl";
            this.Size = new System.Drawing.Size(200, 130);
            this.pnlTop.ResumeLayout(false);
            this.pnlControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        internal System.Windows.Forms.Panel pnlTop;
        internal System.Windows.Forms.Panel pnlTabs;
        internal System.Windows.Forms.Panel pnlBottom;
        internal System.Windows.Forms.ContextMenuStrip WinMenu;
        internal MdiTabControl.ControlButton DropButton;
        internal System.Windows.Forms.ToolTip TabToolTip;
        internal MdiTabControl.ControlButton CloseButton;

        internal System.Windows.Forms.Panel pnlControls;
    }
}
