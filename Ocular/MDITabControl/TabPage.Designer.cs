using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MdiTabControl
{
    partial class TabPage
    {

        //Control overrides dispose to clean up the component list.
        [System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        //Required by the Control Designer

        private System.ComponentModel.IContainer components;
        // NOTE: The following procedure is required by the Component Designer
        // It can be modified using the Component Designer.  Do not modify it
        // using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
        }

    }
}
