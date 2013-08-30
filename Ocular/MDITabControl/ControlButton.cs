using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Diagnostics;

namespace MdiTabControl
{
    partial class ControlButton : System.Windows.Forms.Control
    {

        public ControlButton()
        {
            MouseLeave += MdiTab_MouseLeave;
            MouseEnter += MdiTab_MouseEnter;
            // This call is required by the Windows Form Designer.
            InitializeComponent();
            // Add any initialization after the InitializeComponent() call.
            this.SuspendLayout();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            base.BackColor = Color.Transparent;
            ResetBackHighColor();
            ResetBackLowColor();
            ResetBorderColor();
            this.ResumeLayout();
        }

        public enum ButtonStyle
        {
            Close,
            Drop
        }

        private bool m_hot = false;
        private Color m_BackHighColor;
        private Color m_BackLowColor;
        private Color m_BorderColor;
        private ButtonStyle m_style;

        private ToolStripRenderMode m_RenderMode;
        private readonly Color defaultBackHighColor = SystemColors.ControlLightLight;
        private readonly Color defaultBackLowColor = SystemColors.ControlDark;

        private readonly Color defaultBorderColor = SystemColors.ControlDarkDark;
        internal ToolStripRenderMode RenderMode
        {
            get { return m_RenderMode; }
            set
            {
                m_RenderMode = value;
                Invalidate();
            }
        }

        public ButtonStyle Style
        {
            get { return m_style; }
            set { m_style = value; }
        }

        [Browsable(true), Category("Appearance")]
        public System.Drawing.Color BackHighColor
        {
            get { return m_BackHighColor; }
            set { m_BackHighColor = value; }
        }

        public bool ShouldSerializeBackHighColor()
        {
            return m_BackHighColor != this.defaultBackHighColor;
        }

        public void ResetBackHighColor()
        {
            m_BackHighColor = this.defaultBackHighColor;
        }

        [Browsable(true), Category("Appearance")]
        public Color BackLowColor
        {
            get { return m_BackLowColor; }
            set { m_BackLowColor = value; }
        }

        public bool ShouldSerializeBackLowColor()
        {
            return m_BackLowColor != this.defaultBackLowColor;
        }

        public void ResetBackLowColor()
        {
            m_BackLowColor = this.defaultBackLowColor;
        }

        [Browsable(true), Category("Appearance")]
        public Color BorderColor
        {
            get { return m_BorderColor; }
            set { m_BorderColor = value; }
        }

        public bool ShouldSerializeBorderColor()
        {
            return m_BorderColor != this.defaultBorderColor;
        }

        public void ResetBorderColor()
        {
            m_BorderColor = this.defaultBorderColor;
        }

        [DebuggerStepThrough()]
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            System.Drawing.Point[] DropPoints = {
			new Point(0, 0),
			new Point(11, 0),
			new Point(5, 6)
		};
            System.Drawing.Point[] ClosePoints = {
			new Point(0, 0),
			new Point(2, 0),
			new Point(5, 3),
			new Point(8, 0),
			new Point(10, 0),
			new Point(6, 4),
			new Point(10, 8),
			new Point(8, 8),
			new Point(5, 5),
			new Point(2, 8),
			new Point(0, 8),
			new Point(4, 4)
		};
            Rectangle rec = new Rectangle();
            rec.Size = new Size(this.Width - 1, this.Height - 1);
            if (m_hot)
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.FillRectangle(new LinearGradientBrush(new Point(0, 0), new Point(0, this.Height), Helper.RenderColors.ControlButtonBackHighColor(m_RenderMode, m_BackHighColor), Helper.RenderColors.ControlButtonBackLowColor(m_RenderMode, m_BackLowColor)), rec);
                e.Graphics.DrawRectangle(new Pen(Helper.RenderColors.ControlButtonBorderColor(m_RenderMode, m_BorderColor)), rec);
                e.Graphics.SmoothingMode = SmoothingMode.Default;
            }
            GraphicsPath g = new GraphicsPath();
            Matrix m = new Matrix();
            int x = (this.Width - 11) / 2;
            int y = (this.Height - 11) / 2 + 1;
            if (m_style == ButtonStyle.Drop)
            {
                e.Graphics.FillRectangle(new SolidBrush(ForeColor), x, y, 11, 2);
                g.AddPolygon(DropPoints);
                m.Translate(x, y + 3);
                g.Transform(m);
                e.Graphics.FillPolygon(new SolidBrush(ForeColor), g.PathPoints);
            }
            else
            {
                g.AddPolygon(ClosePoints);
                m.Translate(x, y);
                g.Transform(m);
                e.Graphics.DrawPolygon(new Pen(ForeColor), g.PathPoints);
                e.Graphics.FillPolygon(new SolidBrush(ForeColor), g.PathPoints);
            }
            g.Dispose();
            m.Dispose();
        }

        private void MdiTab_MouseEnter(object sender, System.EventArgs e)
        {
            m_hot = true;
            Invalidate();
        }

        private void MdiTab_MouseLeave(object sender, System.EventArgs e)
        {
            m_hot = false;
            Invalidate();
        }

    }
}
