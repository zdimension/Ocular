using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ocular
{
    public partial class OcularMain : Form
    {
        public OcularMain()
        {
            InitializeComponent();
        }

        private void Ocular_Load(object sender, EventArgs e)
        {
            Form S = new DocumentWindow();
            S.Tag = MainDocControl.TabPages.Add(S);
        }

        private void MainDocControl_TabIndexChanged(object sender, EventArgs e)
        {
            if (MainDocControl.TabPages.Count == 1)
            {
                MainDocControl.CloseButtonVisible = false;
            }
            else
            {
                MainDocControl.CloseButtonVisible = true;
            }
        }

    }
}
