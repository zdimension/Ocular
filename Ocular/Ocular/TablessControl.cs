using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Ocular
{
    class TablessControl : TabControl
    {
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x1328 && !DesignMode)
            {
                m.Result = new IntPtr(1);
            }
            else
            {
                base.WndProc(ref m);
            }

            if ((m.Msg == TCM_ADJUSTRECT))
            {
                RECT rc = (RECT)m.GetLParam(typeof(RECT));
                //Adjust these values to suit, dependant upon Appearance
                rc.Left -= 3;
                rc.Right += 3;
                rc.Top -= 3;
                rc.Bottom += 3;
                Marshal.StructureToPtr(rc, m.LParam, true);
            }
            //MyBase.WndProc(m)
        }

        private const Int32 TCM_FIRST = 0x1300;
        private const Int32 TCM_ADJUSTRECT = (TCM_FIRST + 40);
        private struct RECT
        {
            public Int32 Left;
            public Int32 Top;
            public Int32 Right;
            public Int32 Bottom;
        }
    }
}
