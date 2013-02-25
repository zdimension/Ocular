using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Ocular
{
    class MyToolStripRenderer : ToolStripProfessionalRenderer
    {

        MyToolStripRenderer() : base(((ToolStripProfessionalRenderer)KryptonManager.RenderOffice2010.RenderToolStrip(KryptonManager.PaletteOffice2010Blue)).ColorTable)
        {

        }

        protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
        {
           /* if (KryptonRenderer != null)
                KryptonRenderer.DrawButtonBackground(e);
            else
                base.OnRenderButtonBackground(e);*/
        } 
    } 
}
