using System.ComponentModel;
using System.Drawing;
using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing.Drawing2D;
namespace MdiTabControl
{
    public partial class TabControl : System.Windows.Forms.UserControl
{

	#region " Class GetTabRegionEventArgs "

	[Description("Provides data for the MdiTabControl.TabControl.GetTabRegion event.")]
	public class GetTabRegionEventArgs : System.EventArgs
	{

		private Point[] m_Points;
		private int m_TabWidth;
		private int m_TabHeight;

		private bool m_Selected;
		private GetTabRegionEventArgs()
		{
		}

		[Description("Initializes a new instance of the MdiTabControl.TabControl.GetTabRegionEventArgs class.")]
		public GetTabRegionEventArgs(Point[] Points, int Width, int Height, bool Selected) : base()
		{
			m_Points = Points;
			m_TabWidth = Width;
			m_TabHeight = Height;
			m_Selected = Selected;
		}

		[Description("Returns whether the tab is selected or not.")]
		public int Selected {
			get { return Convert.ToInt32(m_Selected); }
		}

		[Description("Returns the tab width.")]
		public int TabWidth {
			get { return m_TabWidth; }
		}

		[Description("Returns the tab height.")]
		public int TabHeight {
			get { return m_TabHeight; }
		}

		[Description("Gets or sets an array of System.Drawing.Point structures that represents the points through which the tab path is constructed.")]
		public Point[] Points {
			get { return m_Points; }
			set { m_Points = value; }
		}

	}

	#endregion

	#region " Class TabPaintEventArgs "

	[Description("Provides data for the MdiTabControl.TabControl.TabPaint event.")]
	public class TabPaintEventArgs : PaintEventArgs
	{

		private bool m_Handled = false;
		private bool m_Selected = false;
		private bool m_Hot = false;
		private System.Drawing.Drawing2D.GraphicsPath m_GraphicPath;
		private int m_TabWidth;

		private int m_TabHeight;
		[Description("Initializes a new instance of the MdiTabControl.TabControl.GetTabRegionEventArgs class.")]
		public TabPaintEventArgs(Graphics graphics, Rectangle clipRect, bool Selected, bool Hot, System.Drawing.Drawing2D.GraphicsPath GraphicPath, int Width, int Height) : base(graphics, clipRect)
		{
			m_Selected = Selected;
			m_Hot = Hot;
			m_GraphicPath = GraphicPath;
			m_TabWidth = Width;
			m_TabHeight = Height;
		}

		[Description("Returns the tab's hot state.")]
		public bool Hot {
			get { return m_Hot; }
		}

		[Description("Returns whether the tab is selected or not.")]
		public bool Selected {
			get { return m_Selected; }
		}

		[Description("Gets or sets a value that indicates whether the event handler has completely handled the paint or whether the system should continue its own processing.")]
		public bool Handled {
			get { return m_Handled; }
			set { m_Handled = value; }
		}

		[Description("Returns the tab width.")]
		public int TabWidth {
			get { return m_TabWidth; }
		}

		[Description("Returns the tab height.")]
		public int TabHeight {
			get { return m_TabHeight; }
		}

		[Description("Represents a series of connected lines and curves which the tab path is constructed.")]
		public System.Drawing.Drawing2D.GraphicsPath GraphicPath {
			get { return m_GraphicPath; }
		}

	}

	#endregion

	#region " Class TabPageCollection "

	[Description("Contains a collection of MdiTabControl.TabPage objects.")]
	public class TabPageCollection : CollectionBase
	{

		private TabControl TabControl;

		private bool IsReorder = false;
		internal event GetTabRegionEventHandler GetTabRegion;
		internal delegate void GetTabRegionEventHandler(object sender, TabControl.GetTabRegionEventArgs e);
		[Description("Occurs when the Tab Background has been painted.")]
		internal event TabPaintBackgroundEventHandler TabPaintBackground;
		internal delegate void TabPaintBackgroundEventHandler(object sender, TabControl.TabPaintEventArgs e);
		[Description("Occurs when the Tab Border has been painted.")]
		internal event TabPaintBorderEventHandler TabPaintBorder;
		internal delegate void TabPaintBorderEventHandler(object sender, TabControl.TabPaintEventArgs e);
		internal event EventHandler SelectedChanged;

		internal TabPageCollection(TabControl Owner)
		{
			TabControl = Owner;
		}

		[Description("Create a new TabPage and adds it to the collection whit the Form associated and returns the created TabPage.")]
		public TabPage Add(Form Form)
		{
			TabPage TabPage = new TabPage(Form);
			TabPage.SuspendLayout();
			TabControl.SuspendLayout();

			// Initialize all the tabpage defaults values 
			TabControl.AddingPage = true;
			TabPage.BackHighColor = TabControl.TabBackHighColor;
			TabPage.BackHighColorDisabled = TabControl.TabBackHighColorDisabled;
			TabPage.BackLowColor = TabControl.TabBackLowColor;
			TabPage.BackLowColorDisabled = TabControl.TabBackLowColorDisabled;
			TabPage.BorderColor = TabControl.BorderColor;
			TabPage.BorderColorDisabled = TabControl.BorderColorDisabled;
			TabPage.ForeColor = TabControl.ForeColor;
			TabPage.ForeColorDisabled = TabControl.ForeColorDisabled;
			TabPage.MaximumWidth = TabControl.TabMaximumWidth;
			TabPage.MinimumWidth = TabControl.TabMinimumWidth;
			TabPage.PadLeft = TabControl.TabPadLeft;
			TabPage.PadRight = TabControl.TabPadRight;
			TabPage.CloseButtonVisible = TabControl.TabCloseButtonVisible;
			TabPage.CloseButtonImage = TabControl.TabCloseButtonImage;
			TabPage.CloseButtonImageHot = TabControl.TabCloseButtonImageHot;
			TabPage.CloseButtonImageDisabled = TabControl.TabCloseButtonImageDisabled;
			TabPage.CloseButtonSize = TabControl.TabCloseButtonSize;
			TabPage.CloseButtonBackHighColor = TabControl.TabCloseButtonBackHighColor;
			TabPage.CloseButtonBackLowColor = TabControl.TabCloseButtonBackLowColor;
			TabPage.CloseButtonBorderColor = TabControl.TabCloseButtonBorderColor;
			TabPage.CloseButtonForeColor = TabControl.TabCloseButtonForeColor;
			TabPage.CloseButtonBackHighColorDisabled = TabControl.TabCloseButtonBackHighColorDisabled;
			TabPage.CloseButtonBackLowColorDisabled = TabControl.TabCloseButtonBackLowColorDisabled;
			TabPage.CloseButtonBorderColorDisabled = TabControl.TabCloseButtonBorderColorDisabled;
			TabPage.CloseButtonForeColorDisabled = TabControl.TabCloseButtonForeColorDisabled;
			TabPage.CloseButtonBackHighColorHot = TabControl.TabCloseButtonBackHighColorHot;
			TabPage.CloseButtonBackLowColorHot = TabControl.TabCloseButtonBackLowColorHot;
			TabPage.CloseButtonBorderColorHot = TabControl.TabCloseButtonBorderColorHot;
			TabPage.CloseButtonForeColorHot = TabControl.TabCloseButtonForeColorHot;
			TabPage.HotTrack = TabControl.HotTrack;
			TabPage.Font = TabControl.Font;
			TabPage.FontBoldOnSelect = TabControl.FontBoldOnSelect;
			TabPage.IconSize = TabControl.TabIconSize;
			TabPage.SmoothingMode = TabControl.SmoothingMode;
			TabPage.Alignment = TabControl.Alignment;
			TabPage.GlassGradient = TabControl.TabGlassGradient;
			TabPage.BorderEnhanced = TabControl.m_TabBorderEnhanced;
			TabPage.RenderMode = TabControl.RenderMode;
			TabPage.BorderEnhanceWeight = TabControl.TabBorderEnhanceWeight;

			TabPage.Top = 0;
			TabPage.Left = TabControl.LeftOffset;
			TabPage.Height = TabControl.TabHeight;

			TabControl.TabToolTip.SetToolTip(TabPage, TabPage.m_Form.Text);

			// Create the event handles 
			TabPage.Click += TabPage_Clicked;
			TabPage.Close += TabPage_Closed;
			TabPage.GetTabRegion += TabPage_GetTabRegion;
			TabPage.TabPaintBackground += TabPage_TabPaintBackground;
			TabPage.TabPaintBorder += TabPage_TabPaintBorder;
			TabPage.SizeChanged += TabPage_SizeChanged;
			TabPage.Dragging += TabPage_Dragging;
			TabPage.EndDrag += TabPage_EndDrag;
			TabPage.EnterForm += TabPage_Enter;
			TabPage.LeaveForm += TabPage_Leave;

			// Insert the tabpage in the collection
			List.Add(TabPage);
			TabControl.ResumeLayout();
			TabPage.ResumeLayout();
			return TabPage;
		}

		[Description("Removes a TabPage from the collection.")]
		public void Remove(TabPage TabPage)
		{
			try {
				TabControl.IsDelete = true;
				if (TabControl.pnlBottom.Controls.Count > 1) {
					// brings the next top tab
					// first dock the form in the body then display it
					TabControl.pnlBottom.Controls[1].Dock = DockStyle.Fill;
					TabControl.pnlBottom.Controls[1].Visible = true;
				}
				List.Remove(TabPage);
			} catch (Exception ex) {
			}
		}

		public Form TearOff(TabPage TabPage)
		{
			Form f = TabPage.m_Form;
			TabControl.pnlBottom.Controls.Remove(f);
			TabPage.m_Form = new Form();
			Remove(TabPage);
			f.TopLevel = true;
			f.Dock = DockStyle.None;
			f.FormBorderStyle = FormBorderStyle.Sizable;
			return f;
		}

		[Description("Gets a TabPage in the position Index from the collection.")]
		public TabPage this[int Index] {
			get { return (TabPage)List[Index]; }
		}

		[Description("Gets a TabPage associated with the Form from the collection.")]
		public TabPage this[Form Form] {
			get {
				int x = IndexOf(Form);
				if (x == -1) {
					return null;
				} else {
					return (TabPage)List[x];
				}
			}
		}

		/*[Description("Returns the index of the specified TabPage in the collection.")]
		public int IndexOf {
			get { return List.IndexOf(TabPage); }
			set {
				IsReorder = true;
				List.Remove(TabPage);
				List.Insert(value, TabPage);
				TabControl.ArrangeItems();
				IsReorder = false;
			}
		}*/

        [Description("Returns the index of the specified TabPage in the collection.")]
        public int IndexOf(TabPage t)
        {
            return List.IndexOf(t);
        }

        [Description("Sets the TabPage of the specified index in the collection.")]
        public void IndexOfSet(TabPage t, int pos)
        {
            IsReorder = true;
				List.Remove(t);
				List.Insert(pos, t);
				TabControl.ArrangeItems();
				IsReorder = false;
        }

        [Description("Returns the index of the specified TabPage associated with the Form in the collection.")]
        public int IndexOf(Form f)
        {
            int ret = -1;
				for (int i = 0; i <= List.Count - 1; i++) {
					if (((TabPage)List[i]).m_Form.Equals(f)) {
						ret = i;
						break; // TODO: might not be correct. Was : Exit For
					}
				}
				return ret;
        }

		/*[Description("Returns the index of the specified TabPage associated with the Form in the collection.")]
		public int IndexOf {
			get {
				int ret = -1;
				for (int i = 0; i <= List.Count - 1; i++) {
					if (((TabPage)List(i)).m_Form.Equals(Form)) {
						ret = i;
						break; // TODO: might not be correct. Was : Exit For
					}
				}
				return ret;
			}
		}*/

		protected override void OnInsertComplete(int index, object value)
		{
			base.OnInsertComplete(index, value);
			if (IsReorder)
				return;
			// insert the controls in the respective containers
			TabControl.pnlBottom.Controls.Add(((TabPage)value).m_Form);
			TabControl.pnlTabs.Controls.Add((TabPage)value);
			// select the inserted tabpage
			((TabPage)value).Select();
			TabControl.AddingPage = false;
			TabControl.ArrangeItems();
			TabControl.Background.Visible = false;
		}

		protected override void OnRemoveComplete(int index, object value)
		{
			base.OnRemoveComplete(index, value);
			if (IsReorder)
				return;
			if (List.Count == 0)
				TabControl.Background.Visible = true;
			TabControl.ArrangeItems();
			TabControl.pnlBottom.Controls.Remove(((TabPage)value).m_Form);
			((TabPage)value).m_Form.Dispose();
			TabControl.pnlTabs.Controls.Remove((TabPage)value);
			((TabPage)value).Dispose();
			TabControl.SelectItem(null);
		}

		protected override void OnClear()
		{
			base.OnClear();
			TabControl.Background.Visible = true;
		}

		protected override void OnClearComplete()
		{
			base.OnClearComplete();
			TabControl.pnlBottom.Controls.Clear();
			TabControl.pnlTabs.Controls.Clear();
		}

		[Description("Returns the selected TabPage.")]
		public TabPage SelectedTab()
		{
			foreach (TabPage T in List) {
				if (T.IsSelected)
					return T;
			}
			return null;
		}

		[Description("Returns the index of the selected TabPage.")]
		public int SelectedIndex()
		{
			foreach (TabPage T in List) {
                if (T.IsSelected)
                    return List.IndexOf(T);
			}
            return 0;
		}

		private void TabPage_Clicked(object sender, EventArgs e)
		{
			TabControl.SelectItem((TabPage)sender);
			if (SelectedChanged != null) {
				SelectedChanged(sender, e);
			}
		}

		private void TabPage_Closed(object sender, EventArgs e)
		{
			Remove((TabPage)sender);
		}

		private void TabPage_GetTabRegion(object sender, TabControl.GetTabRegionEventArgs e)
		{
			if (GetTabRegion != null) {
				GetTabRegion(sender, e);
			}
		}

		private void TabPage_TabPaintBackground(object sender, TabControl.TabPaintEventArgs e)
		{
			if (TabPaintBackground != null) {
				TabPaintBackground(sender, e);
			}
		}

		private void TabPage_TabPaintBorder(object sender, TabControl.TabPaintEventArgs e)
		{
			if (TabPaintBorder != null) {
				TabPaintBorder(sender, e);
			}
		}

		private void TabPage_SizeChanged(object sender, EventArgs e)
		{
			TabControl.ArrangeItems();
		}


		private TabPage CurrentTab = null;
		private void TabPage_Dragging(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (TabControl.AllowTabReorder && e.Button == MouseButtons.Left) {
				TabPage t = GetTabPage((TabPage)sender, e.X, e.Y);
				if (t == null) {
					CurrentTab = null;
				} else if (!object.ReferenceEquals(t, CurrentTab)) {
					// swap the tabpages
					IndexOfSet(t, IndexOf((TabPage)sender));
					CurrentTab = t;
				}
			}
		}

		private void TabPage_EndDrag(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			CurrentTab = null;
		}

		private TabPage GetTabPage(TabPage TabPage, int x, int y)
		{
			for (int i = 0; i <= List.Count - 1; i++) {
				if (!object.ReferenceEquals((TabPage)List[i], TabPage) && ((TabPage)List[i]).TabVisible) {
					if (((TabPage)List[i]).RectangleToScreen(((TabPage)List[i]).ClientRectangle).Contains(TabPage.PointToScreen(new Point(x, y)))) {
						return (TabPage)List[i];
					}
				}
			}
			return null;
		}

		public void TabPage_Enter(object sender, EventArgs e)
		{
			if (!TabControl.m_Focused) {
				TabControl.SetFocus = true;
			}
		}

		public void TabPage_Leave(object sender, EventArgs e)
		{
			if (TabControl.m_Focused) {
				TabControl.SetFocus = false;
			}
		}

	}

	#endregion

	[Description("Gets or sets the specified alignment for the control.")]
	public enum TabAlignment
	{
		Top = 0,
		Bottom = 1
	}

	[Description("Gets or sets the specified direction for the control.")]
	public enum FlowDirection
	{
		LeftToRight = 0,
		RightToLeft = 2
	}

	public enum Weight
	{
		Soft = 2,
		Medium = 3,
		Strong = 4,
		Strongest = 5
	}

	private bool AddingPage = false;
	private int LeftOffset = 3;
	private bool IsDelete = false;
	private System.Windows.Forms.Panel Background = new System.Windows.Forms.Panel();
    private TabPageCollection withEventsField_Items;
	private TabPageCollection Items {
		get { return withEventsField_Items; }
		set {
			if (withEventsField_Items != null) {
				withEventsField_Items.GetTabRegion -= Items_GetTabRegion;
				withEventsField_Items.SelectedChanged -= Items_SelectedChanged;
				withEventsField_Items.TabPaintBackground -= Items_TabPaintBackground;
				withEventsField_Items.TabPaintBorder -= Items_TabPaintBorder;
			}
			withEventsField_Items = value;
			if (withEventsField_Items != null) {
				withEventsField_Items.GetTabRegion += Items_GetTabRegion;
				withEventsField_Items.SelectedChanged += Items_SelectedChanged;
				withEventsField_Items.TabPaintBackground += Items_TabPaintBackground;
				withEventsField_Items.TabPaintBorder += Items_TabPaintBorder;
			}
		}
	}
	private FlowDirection m_TabsDirection = FlowDirection.LeftToRight;
	private int m_TabMaximumWidth = 200;
	private int m_tabMinimumWidth = 100;
	private Color m_BackLowColor;
	private Color m_BackHighColor;
	private Color m_BorderColor;
	private Color m_TabBackHighColor;
	private Color m_TabBackLowColor;
	private Color m_TabBackHighColorDisabled;
	private Color m_TabBackLowColorDisabled;
	private Color m_BorderColorDisabled;
	private Color m_ForeColorDisabled;
	private bool m_TopSeparator = true;
	private int m_TabTop = 3;
	private int m_TabHeight = 28;
	private int m_TabOffset = 3;
	private int m_TabPadLeft = 5;
	private int m_TabPadRight = 5;
	private SmoothingMode m_TabSmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
	private Size m_TabIconSize = new Size(16, 16);
	private TabAlignment m_Alignment = TabAlignment.Top;
	private bool m_FontBoldOnSelect = true;
	private bool m_HotTrack = true;
	private Size m_TabCloseButtonSize = new Size(17, 17);
	private bool m_TabCloseButtonVisible = true;
	private Image m_TabCloseButtonImage;
	private Image m_TabCloseButtonImageHot;
	private Image m_TabCloseButtonImageDisabled;
	private Color m_TabCloseButtonBackHighColor;
	private Color m_TabCloseButtonBackLowColor;
	private Color m_TabCloseButtonBorderColor;
	private Color m_TabCloseButtonForeColor;
	private Color m_TabCloseButtonBackHighColorDisabled;
	private Color m_TabCloseButtonBackLowColorDisabled;
	private Color m_TabCloseButtonBorderColorDisabled;
	private Color m_TabCloseButtonForeColorDisabled;
	private Color m_TabCloseButtonBackHighColorHot;
	private Color m_TabCloseButtonBackLowColorHot;
	private Color m_TabCloseButtonBorderColorHot;
	private Color m_TabCloseButtonForeColorHot;
	private bool m_AllowTabReorder = true;
	private bool m_TabGlassGradient = false;
	private bool m_TabBorderEnhanced = false;
	private ToolStripRenderMode m_RenderMode;
	private ToolStripRenderer m_ContextMenuRenderer;
	private Weight m_TabBorderEnhanceWeight = Weight.Medium;

	private bool m_Focused;
	internal new readonly Padding defaultPadding = new Padding(0, 0, 0, 0);
	internal readonly Color defaultBackLowColor = SystemColors.ControlLightLight;
	internal readonly Color defaultBackHighColor = SystemColors.Control;
	internal readonly Color defaultBorderColor = SystemColors.ControlDarkDark;
	internal readonly Color defaultTabBackHighColor = SystemColors.Window;
	internal readonly Color defaultTabBackLowColor = SystemColors.Control;
	internal readonly Color defaultTabBackHighColorDisabled = SystemColors.Control;
	internal readonly Color defaultTabBackLowColorDisabled = SystemColors.ControlDark;
	internal readonly Color defaultBorderColorDisabled = SystemColors.ControlDark;
	internal readonly Color defaultForeColorDisabled = SystemColors.ControlText;
	internal readonly Color defaultControlButtonBackHighColor = SystemColors.GradientInactiveCaption;
	internal readonly Color defaultControlButtonBackLowColor = SystemColors.GradientInactiveCaption;
	internal readonly Color defaultControlButtonBorderColor = SystemColors.HotTrack;
	internal readonly Color defaultControlButtonForeColor = SystemColors.ControlText;
	internal readonly Size defaultTabCloseButtonSize = new Size(17, 17);
	internal readonly Size defaultTabIconSize = new Size(16, 16);
	internal readonly Color defaultTabCloseButtonBackHighColor = System.Drawing.Color.IndianRed;
	internal readonly Color defaultTabCloseButtonBackHighColorDisabled = System.Drawing.Color.LightGray;
	internal readonly Color defaultTabCloseButtonBackHighColorHot = System.Drawing.Color.LightCoral;
	internal readonly Color defaultTabCloseButtonBackLowColor = System.Drawing.Color.Firebrick;
	internal readonly Color defaultTabCloseButtonBackLowColorDisabled = System.Drawing.Color.DarkGray;
	internal readonly Color defaultTabCloseButtonBackLowColorHot = System.Drawing.Color.IndianRed;
	internal readonly Color defaultTabCloseButtonBorderColor = System.Drawing.Color.DarkRed;
	internal readonly Color defaultTabCloseButtonBorderColorDisabled = System.Drawing.Color.Gray;
	internal readonly Color defaultTabCloseButtonBorderColorHot = System.Drawing.Color.Firebrick;
	internal readonly Color defaultTabCloseButtonForeColor = System.Drawing.Color.White;
	internal readonly Color defaultTabCloseButtonForeColorDisabled = System.Drawing.Color.White;
	internal readonly Color defaultTabCloseButtonForeColorHot = System.Drawing.Color.White;

	internal readonly ToolStripRenderMode defaultRenderMode = ToolStripRenderMode.ManagerRenderMode;
	[Description("Occurs when the Tab Page requests the tab region.")]
	public event GetTabRegionEventHandler GetTabRegion;
	public delegate void GetTabRegionEventHandler(object sender, GetTabRegionEventArgs e);
	[Description("Occurs when the Tab Background has been painted.")]
	public event TabPaintBackgroundEventHandler TabPaintBackground;
	public delegate void TabPaintBackgroundEventHandler(object sender, TabPaintEventArgs e);
	[Description("Occurs when the Tab Border has been painted.")]
	public event TabPaintBorderEventHandler TabPaintBorder;
	public delegate void TabPaintBorderEventHandler(object sender, TabPaintEventArgs e);
	[Description("Occurs when the TabControl Focus changes.")]
	public event EventHandler FocusedChanged;
	public event EventHandler SelectedTabChanged;

	public TabControl()
	{
		Load += TabControl_Load;
		Resize += TabControl_Resize;
		Paint += TabControl_Paint;
		ForeColorChanged += TabControl_ForeColorChanged;
		FontChanged += TabControl_FontChanged;
		// This call is required by the Windows Form Designer.
		InitializeComponent();
		// Add any initialization after the InitializeComponent() call.
		this.SuspendLayout();
		//Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
		//Me.SetStyle(ControlStyles.UserPaint, True)
		this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
		Background.BackColor = SystemColors.AppWorkspace;
		Background.BorderStyle = BorderStyle.Fixed3D;
		Background.Dock = DockStyle.Fill;
		this.Controls.Add(Background);
		Background.BringToFront();
		ResetBackLowColor();
		ResetBackHighColor();
		ResetBorderColor();
		ResetTabBackHighColor();
		ResetTabBackLowColor();
		ResetTabBackHighColorDisabled();
		ResetTabBackLowColorDisabled();
		ResetBorderColorDisabled();
		ResetForeColorDisabled();
		ResetControlButtonBackHighColor();
		ResetControlButtonBackLowColor();
		ResetControlButtonBorderColor();
		ResetControlButtonForeColor();
		ResetTabCloseButtonBackHighColor();
		ResetTabCloseButtonBackLowColor();
		ResetTabCloseButtonBorderColor();
		ResetTabCloseButtonForeColor();
		ResetTabCloseButtonBackHighColorDisabled();
		ResetTabCloseButtonBackLowColorDisabled();
		ResetTabCloseButtonBorderColorDisabled();
		ResetTabCloseButtonForeColorDisabled();
		ResetTabCloseButtonBackHighColorHot();
		ResetTabCloseButtonBackLowColorHot();
		ResetTabCloseButtonBorderColorHot();
		ResetTabCloseButtonForeColorHot();
		ResetPadding();
		ResetTabCloseButtonSize();
		ResetTabIconSize();
		ResetRenderMode();
		AdjustHeight();
		DropButton.RenderMode = this.RenderMode;
		CloseButton.RenderMode = this.RenderMode;
        withEventsField_Items = new TabPageCollection(this);
		this.ResumeLayout();
	}

	[Browsable(false)]
	public override bool Focused {
		get { return m_Focused; }
	}

	internal bool SetFocus {
		set {
			m_Focused = value;
			if (FocusedChanged != null) {
				FocusedChanged(this, new EventArgs());
			}
		}
	}

	[Browsable(false)]
	public object SelectedForm {
		get {
			if (pnlBottom.Controls.Count > 0) {
				return pnlBottom.Controls[0];
			} else {
				return null;
			}
		}
	}

	[Browsable(true), Category("Layout"), DefaultValue(FlowDirection.LeftToRight), Description("Gets or sets the the direction which the tabs are drawn.")]
	public FlowDirection TabsDirection {
		get { return m_TabsDirection; }
		set {
			m_TabsDirection = value;
			SelectItem(null);
		}
	}

	[Browsable(true), Category("Appearance"), DefaultValue(false), Description("Gets or sets if the tab background will paint with glass style.")]
	public bool TabGlassGradient {
		get { return m_TabGlassGradient; }
		set {
			m_TabGlassGradient = value;
			foreach (TabPage t in TabPages) {
				t.GlassGradient = value;
			}
		}
	}

	[Browsable(true), Category("Appearance"), DefaultValue(false), Description("Gets or sets if the tab border will paint with enhanced style.")]
	public bool TabBorderEnhanced {
		get { return m_TabBorderEnhanced; }
		set {
			m_TabBorderEnhanced = value;
			foreach (TabPage t in TabPages) {
				t.BorderEnhanced = value;
			}
		}
	}

	[Browsable(true), Category("Appearance"), Description("Gets or sets the System.Drawing.Color structure that represents the starting color of the Background linear gradient for the tab close button.")]
	public System.Drawing.Color TabCloseButtonBackHighColor {
		get { return m_TabCloseButtonBackHighColor; }
		set { m_TabCloseButtonBackHighColor = value; }
	}

	internal bool ShouldSerializeTabCloseButtonBackHighColor()
	{
		return m_TabCloseButtonBackHighColor != this.defaultTabCloseButtonBackHighColor;
	}

	internal void ResetTabCloseButtonBackHighColor()
	{
		m_TabCloseButtonBackHighColor = this.defaultTabCloseButtonBackHighColor;
	}

	[Browsable(true), Category("Appearance"), Description("Gets or sets the System.Drawing.Color structure that represents the ending color of the Background linear gradient for the tab close button.")]
	public System.Drawing.Color TabCloseButtonBackLowColor {
		get { return m_TabCloseButtonBackLowColor; }
		set { m_TabCloseButtonBackLowColor = value; }
	}

	internal bool ShouldSerializeTabCloseButtonBackLowColor()
	{
		return m_TabCloseButtonBackLowColor != this.defaultTabCloseButtonBackLowColor;
	}

	internal void ResetTabCloseButtonBackLowColor()
	{
		m_TabCloseButtonBackLowColor = this.defaultTabCloseButtonBackLowColor;
	}

	[Browsable(true), Category("Appearance"), Description("Gets or sets the System.Drawing.Color structure that represents the border color for the tab close button.")]
	public System.Drawing.Color TabCloseButtonBorderColor {
		get { return m_TabCloseButtonBorderColor; }
		set { m_TabCloseButtonBorderColor = value; }
	}

	internal bool ShouldSerializeTabCloseButtonBorderColor()
	{
		return m_TabCloseButtonBorderColor != this.defaultTabCloseButtonBorderColor;
	}

	internal void ResetTabCloseButtonBorderColor()
	{
		m_TabCloseButtonBorderColor = this.defaultTabCloseButtonBorderColor;
	}

	[Browsable(true), Category("Appearance"), Description("Gets or sets the System.Drawing.Color structure that represents the fore color for the tab close button.")]
	public System.Drawing.Color TabCloseButtonForeColor {
		get { return m_TabCloseButtonForeColor; }
		set { m_TabCloseButtonForeColor = value; }
	}

	internal bool ShouldSerializeTabCloseButtonForeColor()
	{
		return m_TabCloseButtonForeColor != this.defaultTabCloseButtonForeColor;
	}

	internal void ResetTabCloseButtonForeColor()
	{
		m_TabCloseButtonForeColor = this.defaultTabCloseButtonForeColor;
	}

	[Browsable(true), Category("Appearance"), Description("Gets or sets the System.Drawing.Color structure that represents the starting color of the Background linear gradient for the disabled tab close button.")]
	public System.Drawing.Color TabCloseButtonBackHighColorDisabled {
		get { return m_TabCloseButtonBackHighColorDisabled; }
		set { m_TabCloseButtonBackHighColorDisabled = value; }
	}

	internal bool ShouldSerializeTabCloseButtonBackHighColorDisabled()
	{
		return m_TabCloseButtonBackHighColorDisabled != this.defaultTabCloseButtonBackHighColorDisabled;
	}

	internal void ResetTabCloseButtonBackHighColorDisabled()
	{
		m_TabCloseButtonBackHighColorDisabled = this.defaultTabCloseButtonBackHighColorDisabled;
	}

	[Browsable(true), Category("Appearance"), Description("Gets or sets the System.Drawing.Color structure that represents the ending color of the Background linear gradient for the disabled tab close button.")]
	public System.Drawing.Color TabCloseButtonBackLowColorDisabled {
		get { return m_TabCloseButtonBackLowColorDisabled; }
		set { m_TabCloseButtonBackLowColorDisabled = value; }
	}

	internal bool ShouldSerializeTabCloseButtonBackLowColorDisabled()
	{
		return m_TabCloseButtonBackLowColorDisabled != this.defaultTabCloseButtonBackLowColorDisabled;
	}

	internal void ResetTabCloseButtonBackLowColorDisabled()
	{
		m_TabCloseButtonBackLowColorDisabled = this.defaultTabCloseButtonBackLowColorDisabled;
	}

	[Browsable(true), Category("Appearance"), Description("Gets or sets the System.Drawing.Color structure that represents the border color for the disabled tab close button.")]
	public System.Drawing.Color TabCloseButtonBorderColorDisabled {
		get { return m_TabCloseButtonBorderColorDisabled; }
		set { m_TabCloseButtonBorderColorDisabled = value; }
	}

	internal bool ShouldSerializeTabCloseButtonBorderColorDisabled()
	{
		return m_TabCloseButtonBorderColorDisabled != this.defaultTabCloseButtonBorderColorDisabled;
	}

	internal void ResetTabCloseButtonBorderColorDisabled()
	{
		m_TabCloseButtonBorderColorDisabled = this.defaultTabCloseButtonBorderColorDisabled;
	}

	[Browsable(true), Category("Appearance"), Description("Gets or sets the System.Drawing.Color structure that represents the disabled fore color for the tab close button.")]
	public System.Drawing.Color TabCloseButtonForeColorDisabled {
		get { return m_TabCloseButtonForeColorDisabled; }
		set { m_TabCloseButtonForeColorDisabled = value; }
	}

	internal bool ShouldSerializeTabCloseButtonForeColorDisabled()
	{
		return m_TabCloseButtonForeColorDisabled != this.defaultTabCloseButtonForeColorDisabled;
	}

	internal void ResetTabCloseButtonForeColorDisabled()
	{
		m_TabCloseButtonForeColorDisabled = this.defaultTabCloseButtonForeColorDisabled;
	}

	[Browsable(true), Category("Appearance"), Description("Gets or sets the System.Drawing.Color structure that represents the starting color of the Background linear gradient for the Hot tab close button.")]
	public System.Drawing.Color TabCloseButtonBackHighColorHot {
		get { return m_TabCloseButtonBackHighColorHot; }
		set { m_TabCloseButtonBackHighColorHot = value; }
	}

	internal bool ShouldSerializeTabCloseButtonBackHighColorHot()
	{
		return m_TabCloseButtonBackHighColorHot != this.defaultTabCloseButtonBackHighColorHot;
	}

	internal void ResetTabCloseButtonBackHighColorHot()
	{
		m_TabCloseButtonBackHighColorHot = this.defaultTabCloseButtonBackHighColorHot;
	}

	[Browsable(true), Category("Appearance"), Description("Gets or sets the System.Drawing.Color structure that represents the ending color of the Background linear gradient for the Hot tab close button.")]
	public System.Drawing.Color TabCloseButtonBackLowColorHot {
		get { return m_TabCloseButtonBackLowColorHot; }
		set { m_TabCloseButtonBackLowColorHot = value; }
	}

	internal bool ShouldSerializeTabCloseButtonBackLowColorHot()
	{
		return m_TabCloseButtonBackLowColorHot != this.defaultTabCloseButtonBackLowColorHot;
	}

	internal void ResetTabCloseButtonBackLowColorHot()
	{
		m_TabCloseButtonBackLowColorHot = this.defaultTabCloseButtonBackLowColorHot;
	}

	[Browsable(true), Category("Appearance"), Description("Gets or sets the System.Drawing.Color structure that represents the border color for the Hot tab close button.")]
	public System.Drawing.Color TabCloseButtonBorderColorHot {
		get { return m_TabCloseButtonBorderColorHot; }
		set { m_TabCloseButtonBorderColorHot = value; }
	}

	internal bool ShouldSerializeTabCloseButtonBorderColorHot()
	{
		return m_TabCloseButtonBorderColorHot != this.defaultTabCloseButtonBorderColorHot;
	}

	internal void ResetTabCloseButtonBorderColorHot()
	{
		m_TabCloseButtonBorderColorHot = this.defaultTabCloseButtonBorderColorHot;
	}

	[Browsable(true), Category("Appearance"), Description("Gets or sets the System.Drawing.Color structure that represents the Hot fore color for the tab close button.")]
	public System.Drawing.Color TabCloseButtonForeColorHot {
		get { return m_TabCloseButtonForeColorHot; }
		set { m_TabCloseButtonForeColorHot = value; }
	}

	internal bool ShouldSerializeTabCloseButtonForeColorHot()
	{
		return m_TabCloseButtonForeColorHot != this.defaultTabCloseButtonForeColorHot;
	}

	internal void ResetTabCloseButtonForeColorHot()
	{
		m_TabCloseButtonForeColorHot = this.defaultTabCloseButtonForeColorHot;
	}

	[Browsable(true), Category("Appearance"), Description("Gets or sets the tab close button image.")]
	public Image TabCloseButtonImage {
		get { return m_TabCloseButtonImage; }
		set {
			m_TabCloseButtonImage = value;
			foreach (TabPage t in TabPages) {
				t.CloseButtonImage = value;
			}
		}
	}

	[Browsable(true), Category("Appearance"), Description("Gets or sets the tab close button image in hot state.")]
	public Image TabCloseButtonImageHot {
		get { return m_TabCloseButtonImageHot; }
		set {
			m_TabCloseButtonImageHot = value;
			foreach (TabPage t in TabPages) {
				t.CloseButtonImageHot = value;
			}
		}
	}

	[Browsable(true), Category("Appearance"), Description("Gets or sets the tab close button image in disabled state.")]
	public Image TabCloseButtonImageDisabled {
		get { return m_TabCloseButtonImageDisabled; }
		set {
			m_TabCloseButtonImageDisabled = value;
			foreach (TabPage t in TabPages) {
				t.CloseButtonImageDisabled = value;
			}
		}
	}

	[Browsable(true), Category("Layout"), DefaultValue(true), Description("Gets or sets whether the tab close button is visble or not.")]
	public bool TabCloseButtonVisible {
		get { return m_TabCloseButtonVisible; }
		set {
			m_TabCloseButtonVisible = value;
			foreach (TabPage t in TabPages) {
				t.CloseButtonVisible = value;
			}
		}
	}

	[Browsable(true), Category("Appearance"), Description("Gets or sets the size of the icon displayed at the tab.")]
	public Size TabIconSize {
		get { return m_TabIconSize; }
		set {
			m_TabIconSize = value;
			foreach (TabPage t in TabPages) {
				t.IconSize = value;
			}
		}
	}

	internal bool ShouldSerializeTabIconSize()
	{
		return m_TabIconSize != this.defaultTabIconSize;
	}

	internal void ResetTabIconSize()
	{
		m_TabIconSize = this.defaultTabIconSize;
	}

	[Browsable(true), Category("Appearance"), Description("Gets or sets the size of the close button displayed at the tab.")]
	public Size TabCloseButtonSize {
		get { return m_TabCloseButtonSize; }
		set {
			m_TabCloseButtonSize = value;
			foreach (TabPage t in TabPages) {
				t.CloseButtonSize = value;
			}
		}
	}

	internal bool ShouldSerializeTabCloseButtonSize()
	{
		return m_TabCloseButtonSize != this.defaultTabCloseButtonSize;
	}

	internal void ResetTabCloseButtonSize()
	{
		m_TabCloseButtonSize = this.defaultTabCloseButtonSize;
	}

	[Browsable(true), Category("Appearance"), DefaultValue(System.Drawing.Drawing2D.SmoothingMode.None), Description("Specifies whether smoothing (antialiasing) is applied to lines and curves and the edges of filled areas.")]
	public System.Drawing.Drawing2D.SmoothingMode SmoothingMode {
		get { return m_TabSmoothingMode; }
		set {
			m_TabSmoothingMode = value;
			foreach (TabPage t in TabPages) {
				t.SmoothingMode = value;
			}
		}
	}

	[Browsable(true), Category("Layout"), DefaultValue(5), Description("Gets or sets the amount of space on the right side of the tab.")]
	public int TabPadRight {
		get { return m_TabPadRight; }
		set {
			m_TabPadRight = value;
			foreach (TabPage t in TabPages) {
				t.PadRight = value;
			}
		}
	}

	[Browsable(true), Category("Layout"), DefaultValue(5), Description("Gets or sets the amount of space on the left side of the tab.")]
	public int TabPadLeft {
		get { return m_TabPadLeft; }
		set {
			m_TabPadLeft = value;
			foreach (TabPage t in TabPages) {
				t.PadLeft = value;
			}
		}
	}

	[Browsable(true), Category("Layout"), DefaultValue(3), Description("Gets or sets the amount of space between the tabs.")]
	public int TabOffset {
		get { return m_TabOffset; }
		set {
			m_TabOffset = value;
			ArrangeItems();
		}
	}

	[Browsable(true), Category("Layout"), DefaultValue(28), Description("Gets or sets the height of the tab.")]
	public int TabHeight {
		get { return m_TabHeight; }
		set {
			if (m_TabHeight != value) {
				m_TabHeight = value;
				pnlTabs.Height = m_TabHeight;
				pnlTabs.Top = pnlTop.Height - pnlTabs.Height;
				AdjustHeight();
				foreach (TabPage t in TabPages) {
					t.Height = value;
				}
			}
		}
	}

	[Browsable(true), Category("Layout"), DefaultValue(3), Description("Gets or sets the distance between the top of the control and the top of the tab.")]
	public int TabTop {
		get { return m_TabTop; }
		set {
			m_TabTop = value;
			AdjustHeight();
		}
	}

	[Browsable(true), Category("Appearance"), Description("Gets or sets the System.Drawing.Color structure that represents the starting color of the Background linear gradient.")]
	public System.Drawing.Color TabBackHighColor {
		get { return m_TabBackHighColor; }
		set {
			m_TabBackHighColor = value;
			foreach (TabPage t in TabPages) {
				t.BackHighColor = value;
			}
		}
	}

	internal bool ShouldSerializeTabBackHighColor()
	{
		return m_TabBackHighColor != this.defaultTabBackHighColor;
	}

	internal void ResetTabBackHighColor()
	{
		m_TabBackHighColor = this.defaultTabBackHighColor;
	}

	[Browsable(true), Category("Appearance"), Description("Gets or sets the System.Drawing.Color structure that represents the ending color of the Background linear gradient.")]
	public Color TabBackLowColor {
		get { return m_TabBackLowColor; }
		set {
			m_TabBackLowColor = value;
			foreach (TabPage t in TabPages) {
				t.BackLowColor = value;
			}
		}
	}

	internal bool ShouldSerializeTabBackLowColor()
	{
		return m_TabBackLowColor != this.defaultTabBackLowColor;
	}

	internal void ResetTabBackLowColor()
	{
		m_TabBackLowColor = this.defaultTabBackLowColor;
	}

	[Browsable(true), Category("Appearance"), Description("Gets or sets the System.Drawing.Color structure that represents the starting color of the Background linear gradient for a non selected tab.")]
	public System.Drawing.Color TabBackHighColorDisabled {
		get { return m_TabBackHighColorDisabled; }
		set {
			m_TabBackHighColorDisabled = value;
			foreach (TabPage t in TabPages) {
				t.BackHighColorDisabled = value;
			}
		}
	}

	internal bool ShouldSerializeTabBackHighColorDisabled()
	{
		return m_TabBackHighColorDisabled != this.defaultTabBackHighColorDisabled;
	}

	internal void ResetTabBackHighColorDisabled()
	{
		m_TabBackHighColorDisabled = this.defaultTabBackHighColorDisabled;
	}

	[Browsable(true), Category("Appearance"), Description("Gets or sets the System.Drawing.Color structure that represents the ending color of the Background linear gradient for a non selected tab.")]
	public Color TabBackLowColorDisabled {
		get { return m_TabBackLowColorDisabled; }
		set {
			m_TabBackLowColorDisabled = value;
			foreach (TabPage t in TabPages) {
				t.BackLowColorDisabled = value;
			}
		}
	}

	internal bool ShouldSerializeTabBackLowColorDisabled()
	{
		return m_TabBackLowColorDisabled != this.defaultTabBackLowColorDisabled;
	}

	internal void ResetTabBackLowColorDisabled()
	{
		m_TabBackLowColorDisabled = this.defaultTabBackLowColorDisabled;
	}

	[Browsable(true), Category("Appearance"), Description("Gets or sets the System.Drawing.Color structure that represents the border color of the tab when not selected.")]
	public Color BorderColorDisabled {
		get { return m_BorderColorDisabled; }
		set {
			m_BorderColorDisabled = value;
			foreach (TabPage t in TabPages) {
				t.BorderColorDisabled = value;
			}
		}
	}

	internal bool ShouldSerializeBorderColorDisabled()
	{
		return m_BorderColorDisabled != this.defaultBorderColorDisabled;
	}

	internal void ResetBorderColorDisabled()
	{
		m_BorderColorDisabled = this.defaultBorderColorDisabled;
	}

	[Browsable(true), Category("Appearance"), Description("Gets or sets the System.Drawing.Color structure that represents the fore color of the tab when not selected.")]
	public Color ForeColorDisabled {
		get { return m_ForeColorDisabled; }
		set {
			m_ForeColorDisabled = value;
			foreach (TabPage t in TabPages) {
				t.ForeColorDisabled = value;
			}
		}
	}

	internal bool ShouldSerializeForeColorDisabled()
	{
		return m_ForeColorDisabled != this.defaultForeColorDisabled;
	}

	internal void ResetForeColorDisabled()
	{
		m_ForeColorDisabled = this.defaultForeColorDisabled;
	}

	[Browsable(true), Category("Layout"), DefaultValue(100), Description("Gets or sets the minimum width for the tab.")]
	public int TabMinimumWidth {
		get { return m_tabMinimumWidth; }
		set {
			m_tabMinimumWidth = value;
			foreach (TabPage t in TabPages) {
				t.MinimumWidth = value;
			}
		}
	}

	[Browsable(true), Category("Layout"), DefaultValue(200), Description("Gets or sets the maximum width for the tab.")]
	public int TabMaximumWidth {
		get { return m_TabMaximumWidth; }
		set {
			m_TabMaximumWidth = value;
			foreach (TabPage t in TabPages) {
				t.MaximumWidth = value;
			}
		}
	}

	[Browsable(true), Category("Appearance"), DefaultValue(true), Description("Gets or sets whether the font on the selected tab is displayed in bold.")]
	public bool FontBoldOnSelect {
		get { return m_FontBoldOnSelect; }
		set {
			m_FontBoldOnSelect = value;
			foreach (TabPage t in TabPages) {
				t.FontBoldOnSelect = value;
			}
		}
	}

	[Browsable(true), Category("Behavior"), DefaultValue(true), Description("Gets or sets a value indicating whether the control's tabs change in appearance when the mouse passes over them.")]
	public bool HotTrack {
		get { return m_HotTrack; }
		set {
			m_HotTrack = value;
			foreach (TabPage t in TabPages) {
				t.HotTrack = value;
			}
		}
	}

	[Browsable(true), Category("Behavior"), DefaultValue(true), Description("Gets or sets a value indicating whether the user can reorder tabs draging.")]
	public bool AllowTabReorder {
		get { return m_AllowTabReorder; }
		set { m_AllowTabReorder = value; }
	}

	[Browsable(true), Category("Layout"), DefaultValue(false), Description("Gets or sets a value indicating whether the close button is displayed or not.")]
	public bool CloseButtonVisible {
		get { return CloseButton.Visible; }
		set {
			if (CloseButton.Visible != value) {
				CloseButton.Visible = value;
				SetControlsSizeLocation();
			}
		}
	}

	[Browsable(true), Category("Layout"), DefaultValue(true), Description("Gets or sets a value indicating whether the drop button is displayed or not.")]
	public bool DropButtonVisible {
		get { return DropButton.Visible; }
		set {
			if (DropButton.Visible != value) {
				DropButton.Visible = value;
				SetControlsSizeLocation();
			}
		}
	}

	[Browsable(true), Category("Appearance"), DefaultValue(true), Description("Gets or sets a value indicating whether a double line separator is displayed at the top of the control.")]
	public bool TopSeparator {
		get { return m_TopSeparator; }
		set {
			m_TopSeparator = value;
			AdjustHeight();
		}
	}

	[Browsable(true), Category("Behavior"), DefaultValue(TabAlignment.Top), Description("Gets or sets the area of the control (for example, along the top) where the tabs are aligned.")]
	public TabAlignment Alignment {
		get { return m_Alignment; }
		set {
			m_Alignment = value;
			AdjustHeight();
			PositionButtons();
			foreach (TabPage t in TabPages) {
				t.Alignment = value;
			}
		}
	}

	[Browsable(true), Category("Layout"), Description("Gets or sets the amount of space around the form on the control's tab pages.")]
	public new Padding Padding {
		get { return pnlBottom.Padding; }
		set { pnlBottom.Padding = value; }
	}

	internal bool ShouldSerializePadding()
	{
		return pnlBottom.Padding != defaultPadding;
	}

	internal void ResetPadding()
	{
		pnlBottom.Padding = defaultPadding;
	}

	[Browsable(true), Category("Appearance"), Description("Gets or sets the System.Drawing.Color structure that represents the starting color of the Background linear gradient for the control button.")]
	public System.Drawing.Color ControlButtonBackHighColor {
		get { return DropButton.BackHighColor; }
		set {
			DropButton.BackHighColor = value;
			CloseButton.BackHighColor = value;
		}
	}

	internal bool ShouldSerializeControlButtonBackHighColor()
	{
		return DropButton.BackHighColor != this.defaultControlButtonBackHighColor;
	}

	internal void ResetControlButtonBackHighColor()
	{
		DropButton.BackHighColor = this.defaultControlButtonBackHighColor;
		CloseButton.BackHighColor = this.defaultControlButtonBackHighColor;
	}

	[Browsable(true), Category("Appearance"), Description("Gets or sets the System.Drawing.Color structure that represents the ending color of the Background linear gradient for the control button.")]
	public Color ControlButtonBackLowColor {
		get { return DropButton.BackLowColor; }
		set {
			DropButton.BackLowColor = value;
			CloseButton.BackLowColor = value;
		}
	}

	internal bool ShouldSerializeControlButtonBackLowColor()
	{
		return DropButton.BackLowColor != this.defaultControlButtonBackLowColor;
	}

	internal void ResetControlButtonBackLowColor()
	{
		DropButton.BackLowColor = this.defaultControlButtonBackLowColor;
		CloseButton.BackLowColor = this.defaultControlButtonBackLowColor;
	}

	[Browsable(true), Category("Appearance"), Description("Gets or sets the System.Drawing.Color structure that represents the border color for the control button.")]
	public Color ControlButtonBorderColor {
		get { return DropButton.BorderColor; }
		set {
			DropButton.BorderColor = value;
			CloseButton.BorderColor = value;
		}
	}

	internal bool ShouldSerializeControlButtonBorderColor()
	{
		return DropButton.BorderColor != this.defaultControlButtonBorderColor;
	}

	internal void ResetControlButtonBorderColor()
	{
		DropButton.BorderColor = this.defaultControlButtonBorderColor;
		CloseButton.BorderColor = this.defaultControlButtonBorderColor;
	}

	[Browsable(true), Category("Appearance"), Description("Gets or sets the System.Drawing.Color structure that represents the ForeColor for the control button.")]
	public Color ControlButtonForeColor {
		get { return DropButton.ForeColor; }
		set {
			DropButton.ForeColor = value;
			CloseButton.ForeColor = value;
		}
	}

	internal bool ShouldSerializeControlButtonForeColor()
	{
		return DropButton.ForeColor != this.defaultControlButtonForeColor;
	}

	internal void ResetControlButtonForeColor()
	{
		DropButton.ForeColor = this.defaultControlButtonForeColor;
		CloseButton.ForeColor = this.defaultControlButtonForeColor;
	}

	[Browsable(true), Category("Appearance"), Description("Gets or sets the System.Drawing.Color structure that represents the ending color of the Background linear gradient for the tabs region.")]
	public System.Drawing.Color BackLowColor {
		get { return m_BackLowColor; }
		set {
			m_BackLowColor = value;
			Invalidate();
		}
	}

	internal bool ShouldSerializeBackLowColor()
	{
		return m_BackLowColor != this.defaultBackLowColor;
	}

	internal void ResetBackLowColor()
	{
		m_BackLowColor = this.defaultBackLowColor;
	}

	[Browsable(true), Category("Appearance"), Description("Gets or sets the System.Drawing.Color structure that represents the starting color of the Background linear gradient for the tabs region.")]
	public Color BackHighColor {
		get { return m_BackHighColor; }
		set {
			m_BackHighColor = value;
			Invalidate();
		}
	}

	internal bool ShouldSerializeBackHighColor()
	{
		return m_BackHighColor != this.defaultBackHighColor;
	}

	internal void ResetBackHighColor()
	{
		m_BackHighColor = this.defaultBackHighColor;
	}

	[Browsable(true), Category("Appearance"), Description("Gets or sets the System.Drawing.Color structure that represents the border color.")]
	public Color BorderColor {
		get { return m_BorderColor; }
		set {
			m_BorderColor = value;
			foreach (TabPage t in TabPages) {
				t.BorderColor = value;
			}
			pnlTabs.Invalidate();
			pnlTop.Invalidate();
		}
	}

	internal bool ShouldSerializeBorderColor()
	{
		return m_BorderColor != this.defaultBorderColor;
	}

	internal void ResetBorderColor()
	{
		m_BorderColor = this.defaultBorderColor;
	}

	[Browsable(false), Description("Gets the collection of tab pages in this tab control.")]
	public TabPageCollection TabPages {
		get { return Items; }
	}

	[Browsable(true), Category("Appearance"), Description("The painting style applied to the control.")]
	public ToolStripRenderMode RenderMode {
		get { return m_RenderMode; }
		set {
			m_RenderMode = value;
			DropButton.RenderMode = value;
			CloseButton.RenderMode = value;
			WinMenu.RenderMode = value;
			foreach (TabPage t in TabPages) {
				t.RenderMode = value;
			}
		}
	}

	[Browsable(false)]
	public ToolStripRenderer MenuRenderer {
		get { return m_ContextMenuRenderer; }
		set {
			m_ContextMenuRenderer = value;
			WinMenu.Renderer = m_ContextMenuRenderer;
		}
	}

	[Browsable(true), Category("Appearance"), DefaultValue(Weight.Medium), Description("The weight of the border.")]
	public Weight TabBorderEnhanceWeight {
		get { return m_TabBorderEnhanceWeight; }
		set {
			m_TabBorderEnhanceWeight = value;
			foreach (TabPage t in TabPages) {
				t.BorderEnhanceWeight = value;
			}
		}
	}

	internal bool ShouldSerializeRenderMode()
	{
		return m_RenderMode != this.defaultRenderMode;
	}

	internal void ResetRenderMode()
	{
		m_RenderMode = this.defaultRenderMode;
	}

	private void SetControlsSizeLocation()
	{
		if (DropButton.Visible & CloseButton.Visible) {
			pnlControls.Width = 43;
		} else if (DropButton.Visible | CloseButton.Visible) {
			pnlControls.Width = 25;
		} else {
			pnlControls.Width = 3;
		}
		pnlControls.Left = this.Width - pnlControls.Width;
		CheckVisibility();
	}

	private void AdjustHeight()
	{
		if (Alignment == TabAlignment.Top) {
			pnlTop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			pnlTop.Height = pnlTabs.Height + m_TabTop;
			pnlTop.Top = (m_TopSeparator ? 2 : 0);
			pnlTabs.Top = m_TabTop;
			pnlBottom.Height = this.Height - (pnlTop.Height + (m_TopSeparator ? 2 : 0));
			pnlBottom.Top = this.Height - pnlBottom.Height;
		} else {
			pnlTop.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pnlTop.Height = pnlTabs.Height + m_TabTop;
			pnlTop.Top = this.Height - pnlTop.Height;
			pnlTabs.Top = 0;
			pnlBottom.Height = this.Height - (pnlTop.Height + (m_TopSeparator ? 2 : 0));
			pnlBottom.Top = (m_TopSeparator ? 2 : 0);
		}
		pnlTop.Invalidate();
	}

	private void ArrangeItems()
	{
		pnlTabs.SuspendLayout();
		if (Items.Count == 0)
			return;
		int x = LeftOffset;
		for (int i = 0; i <= Items.Count - 1; i++) {
			Items[i].TabVisible = x + Items[i].Width < pnlControls.Left;
			if (Items[i].IsSelected & !Items[i].TabVisible) {
				SelectItem(Items[i]);
				return;
			}
			Items[i].TabLeft = x;
			x += Items[i].Width + m_TabOffset - 1;
		}
		if (!AddingPage) {
			if (IsDelete) {
				for (int i = Items.Count - 1; i >= 0; i += -1) {
					ShowTab(i);
				}
				IsDelete = false;
			} else {
				for (int i = 0; i <= Items.Count - 1; i++) {
					ShowTab(i);
				}
			}
		}
		pnlTabs.ResumeLayout();
	}

	private void CheckVisibility()
	{
		if (Items == null)
			return;
		int x = LeftOffset;
		for (int i = 0; i <= Items.Count - 1; i++) {
			if (Items[i].TabVisible != (x + Items[i].Width < pnlControls.Left)) {
				if (Items[i].TabVisible) {
					Items[i].TabVisible = false;
					if (Items[i].IsSelected) {
						SelectItem(Items[i]);
						return;
					} else {
						ShowTab(i);
						return;
					}
				} else {
					Items[i].TabVisible = true;
					Items[i].TabLeft = x;
					ShowTab(i);
				}
			} else if (!Items[i].TabVisible) {
				return;
			}
			x += Items[i].Width + m_TabOffset - 1;
			if (x > pnlControls.Left)
				return;
		}
	}

	private void ShowTab(int i)
	{
		Items[i].Visible = Items[i].TabVisible;
		if (Items[0].Width != 1)
			Items[i].Left = Items[i].TabLeft;
	}

	private void SelectItem(TabPage TabPage)
	{
		foreach (TabPage T in TabPages) {
			T.IsSelected = false;
		}
		if (TabPage != null) {
			foreach (TabPage t in TabPages) {
				if (m_TabsDirection == FlowDirection.LeftToRight)
					t.SendToBack();
				else
					t.BringToFront();
			}
			// only the visible tab container has style doc.fill - when resize don't resize all tab containers
			TabPage.m_Form.Dock = DockStyle.Fill;
			TabPage.m_Form.Visible = true;
			TabPage.BringToFront();
			TabPage.m_Form.BringToFront();
			TabPage.m_Form.Focus();
			if (pnlBottom.Controls.Count > 1) {
				pnlBottom.Controls[1].Visible = false;
				pnlBottom.Controls[1].Dock = DockStyle.None;
			}
			TabPage.IsSelected = true;
			if (!TabPage.TabVisible & TabPages.IndexOf(TabPage) != 0) {
				TabPages.IndexOfSet(TabPage, 0);
			}
		} else if (pnlTabs.Controls.Count > 0) {
			foreach (TabPage t in Items) {
				if (t.m_Form.Equals(pnlBottom.Controls[0])) {
					t.Select();
					break; // TODO: might not be correct. Was : Exit For
				}
			}
		}
	}

	private void TabControl_FontChanged(object sender, System.EventArgs e)
	{
		foreach (TabPage t in TabPages) {
			t.Font = Font;
		}
	}

	private void TabControl_ForeColorChanged(object sender, System.EventArgs e)
	{
		foreach (TabPage t in TabPages) {
			t.ForeColor = ForeColor;
		}
	}

	private void TabControl_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
	{
		if (m_TopSeparator) {
			ControlPaint.DrawBorder3D(e.Graphics, new Rectangle(-2, 0, this.Width + 4, -2));
		}
	}

	private void TabControl_Resize(object sender, System.EventArgs e)
	{
		CheckVisibility();
	}

	private void pnlTop_SizeChanged(object sender, System.EventArgs e)
	{
		PositionButtons();
	}

	private void PositionButtons()
	{
		DropButton.Top = int.Parse(Math.Ceiling((decimal)(((pnlTop.Height - DropButton.Height) / 2) + (Alignment == TabAlignment.Top & TopSeparator ? -1 : 0))) + "");
		CloseButton.Top = DropButton.Top;
	}

	private void pnlTop_Paint(System.Object sender, System.Windows.Forms.PaintEventArgs e)
	{
		System.Drawing.Drawing2D.LinearGradientBrush Brush = new System.Drawing.Drawing2D.LinearGradientBrush(new Point(0, 0), new Point(0, pnlTop.Height), Helper.RenderColors.BackHighColor(m_RenderMode, BackHighColor), Helper.RenderColors.BackLowColor(m_RenderMode, BackLowColor));
		e.Graphics.FillRectangle(Brush, new Rectangle(0, 0, pnlTop.Width, pnlTop.Height));
		Pen Pen = new Pen(Helper.RenderColors.BorderColor(m_RenderMode, BorderColor));
		if (Alignment == TabAlignment.Top) {
            e.Graphics.DrawLine(Pen, 0, ((Control)sender).Height - 1, ((Control)sender).Width + 1, ((Control)sender).Height - 1);
		} else {
            e.Graphics.DrawLine(Pen, 0, 0, ((Control)sender).Width + 1, 0);
		}
		Pen.Dispose();
		Brush.Dispose();
	}

	private void DropButton_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
	{
		WinMenu.Items.Clear();
		for (int i = 0; i <= Items.Count - 1; i++) {
			WinMenu.Items.Add(Items[i].MenuItem);
			Items[i].MenuItem.Click += MenuClick;
		}
		WinMenu.Show(pnlTop, pnlTop.Width - WinMenu.Width, pnlTop.Height - 1);
	}

	private void MenuClick(object sender, EventArgs e)
	{
		Control g = (Control)sender;
        Control h = (Control)(g.Tag);
        h.Select();
	}

	private void CloseButton_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
	{
		Items.SelectedTab().m_Form.Close();
	}

	private void Items_GetTabRegion(object sender, GetTabRegionEventArgs e)
	{
		if (GetTabRegion != null) {
			GetTabRegion(sender, e);
		}
	}

	private void Items_SelectedChanged(object sender, System.EventArgs e)
	{
		if (SelectedTabChanged != null) {
			SelectedTabChanged(sender, e);
		}
	}

	private void Items_TabPaintBackground(object sender, TabPaintEventArgs e)
	{
		if (TabPaintBackground != null) {
			TabPaintBackground(sender, e);
		}
	}

	private void Items_TabPaintBorder(object sender, TabPaintEventArgs e)
	{
		if (TabPaintBorder != null) {
			TabPaintBorder(sender, e);
		}
	}

	public void SetColors(ProfessionalColorTable ColorTable)
	{
		BackHighColor = ColorTable.ToolStripGradientEnd;
		BackLowColor = ColorTable.ToolStripGradientBegin;
		BorderColor = ColorTable.GripDark;
		BorderColorDisabled = ColorTable.SeparatorDark;
		ControlButtonBackHighColor = ColorTable.ButtonSelectedGradientBegin;
		ControlButtonBackLowColor = ColorTable.ButtonSelectedGradientEnd;
		ControlButtonBorderColor = ColorTable.ButtonPressedBorder;
		TabBackHighColor = ColorTable.MenuItemPressedGradientBegin;
		TabBackLowColor = ColorTable.MenuItemPressedGradientEnd;
		TabBackHighColorDisabled = ColorTable.ToolStripDropDownBackground;
		TabBackLowColorDisabled = ColorTable.ToolStripGradientMiddle;
		TabCloseButtonBackHighColor = Color.Transparent;
		TabCloseButtonBackHighColorDisabled = Color.Transparent;
		TabCloseButtonBackHighColorHot = Color.WhiteSmoke;
		TabCloseButtonBackLowColor = Color.Transparent;
		TabCloseButtonBackLowColorDisabled = Color.Transparent;
		TabCloseButtonBackLowColorHot = Color.LightGray;
		TabCloseButtonBorderColor = Color.Transparent;
		TabCloseButtonBorderColorDisabled = Color.Transparent;
		TabCloseButtonBorderColorHot = Color.Gray;
		TabCloseButtonForeColor = Color.Gray;
		TabCloseButtonForeColorDisabled = Color.Gray;
		TabCloseButtonForeColorHot = Color.Firebrick;
	}

	#region "Keyboard Handler"

	private void TabControl_Load(object sender, System.EventArgs e)
	{
		this.ParentForm.KeyPreview = true;
		this.ParentForm.KeyDown += Owner_KeyDown;
	}

	private bool m_KeyCloseEnabled = true;

	private bool m_KeyTabEnabled = true;
	[Browsable(true), Category("Behavior"), DefaultValue(true), Description("Gets or sets if the CTRL+TAB/CTRL+SHIFT+TAB will select the next/previous tab.")]
	public bool KeyTabEnabled {
		get { return m_KeyTabEnabled; }
		set { m_KeyTabEnabled = value; }
	}

	[Browsable(true), Category("Behavior"), DefaultValue(true), Description("Gets or sets if the CTRL+F4 will close the selected tab.")]
	public bool KeyCloseEnabled {
		get { return m_KeyCloseEnabled; }
		set { m_KeyCloseEnabled = value; }
	}

	public class KeyHandledEventArgs : HandledEventArgs
	{
		public int Index;
		public bool Shift = false;
	}

	public event TabPressedEventHandler TabPressed;
	public delegate void TabPressedEventHandler(object sender, KeyHandledEventArgs e);
	public event F4PressedEventHandler F4Pressed;
	public delegate void F4PressedEventHandler(object sender, KeyHandledEventArgs e);

	private void Owner_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
	{
		if (TabPages.Count == 0)
			return;
		KeyHandledEventArgs ke = new KeyHandledEventArgs();
		int Index = 0;
		if (KeyTabEnabled & e.KeyCode == Keys.Tab & e.Control & !e.Alt) {
			if (e.Shift) {
				Index = TabPages.SelectedIndex() - 1;
				if (Index < 0)
					Index = TabPages.Count - 1;
				ke.Shift = true;
			} else {
				Index = TabPages.SelectedIndex() + 1;
				if (Index > TabPages.Count - 1)
					Index = 0;
			}
			ke.Index = Index;
			ke.Handled = false;
			if (TabPressed != null) {
				TabPressed(this, ke);
			}
			if (!ke.Handled)
				TabPages[Index].Select();
		} else if (KeyCloseEnabled & e.KeyCode == Keys.F4 & e.Control & !e.Shift & !e.Alt) {
			ke.Index = TabPages.SelectedIndex();
			ke.Handled = false;
			if (F4Pressed != null) {
				F4Pressed(this, ke);
			}
			if (!ke.Handled)
				TabPages.SelectedTab().m_Form.Close();
		}
	}

	#endregion

	#region " Obsolete properties "

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Browsable(false), Category("Appearance"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new BorderStyle BorderStyle;

	#endregion

}

static internal class Helper
{

	static internal System.Drawing.Drawing2D.LinearGradientBrush CreateGlassGradientBrush(Rectangle Rectangle, Color Color1, Color Color2)
	{
		System.Drawing.Drawing2D.LinearGradientBrush b = new System.Drawing.Drawing2D.LinearGradientBrush(Rectangle, Color1, Color2, System.Drawing.Drawing2D.LinearGradientMode.Vertical);
		Bitmap x = new Bitmap(1, Rectangle.Height);
		Graphics g = Graphics.FromImage(x);
		g.FillRectangle(b, new Rectangle(0, 0, 1, Rectangle.Height));
		System.Drawing.Drawing2D.ColorBlend c = new System.Drawing.Drawing2D.ColorBlend(4);
		c.Colors[0] = x.GetPixel(0, 0);
		c.Colors[1] = x.GetPixel(0, x.Height / 3);
		c.Colors[2] = x.GetPixel(0, x.Height - 1);
		c.Colors[3] = x.GetPixel(0, x.Height / 3);
		c.Positions[0] = 0;
		c.Positions[1] = 0.335F;
		c.Positions[2] = 0.335F;
		c.Positions[3] = 1;
		b.InterpolationColors = c;
		g.Dispose();
		x.Dispose();
		return b;
	}

	internal class Colors
	{

		public Color BackHighColor(ToolStripRenderMode RenderMode, Color ManagedColor)
		{
			if (RenderMode == ToolStripRenderMode.System) {
				return Color.Transparent;
			} else if (RenderMode == ToolStripRenderMode.Professional) {
				return ProfessionalColors.ToolStripGradientEnd;
			} else {
				return ManagedColor;
			}
		}

		public Color BackLowColor(ToolStripRenderMode RenderMode, Color ManagedColor)
		{
			if (RenderMode == ToolStripRenderMode.System) {
				return Color.Transparent;
			} else if (RenderMode == ToolStripRenderMode.Professional) {
				return ProfessionalColors.ToolStripGradientBegin;
			} else {
				return ManagedColor;
			}
		}

		public Color BorderColor(ToolStripRenderMode RenderMode, Color ManagedColor)
		{
			if (RenderMode == ToolStripRenderMode.System) {
				return SystemColors.ControlDarkDark;
			} else if (RenderMode == ToolStripRenderMode.Professional) {
				return ProfessionalColors.GripDark;
			} else {
				return ManagedColor;
			}
		}

		public Color BorderColorDisabled(ToolStripRenderMode RenderMode, Color ManagedColor)
		{
			if (RenderMode == ToolStripRenderMode.System) {
				return SystemColors.ControlDark;
			} else if (RenderMode == ToolStripRenderMode.Professional) {
				return ProfessionalColors.SeparatorDark;
			} else {
				return ManagedColor;
			}
		}

		public Color ControlButtonBackHighColor(ToolStripRenderMode RenderMode, Color ManagedColor)
		{
			if (RenderMode == ToolStripRenderMode.System) {
				return SystemColors.ButtonHighlight;
			} else if (RenderMode == ToolStripRenderMode.Professional) {
				return ProfessionalColors.ButtonSelectedGradientBegin;
			} else {
				return ManagedColor;
			}
		}

		public Color ControlButtonBackLowColor(ToolStripRenderMode RenderMode, Color ManagedColor)
		{
			if (RenderMode == ToolStripRenderMode.System) {
				return SystemColors.ButtonHighlight;
			} else if (RenderMode == ToolStripRenderMode.Professional) {
				return ProfessionalColors.ButtonSelectedGradientEnd;
			} else {
				return ManagedColor;
			}
		}

		public Color ControlButtonBorderColor(ToolStripRenderMode RenderMode, Color ManagedColor)
		{
			if (RenderMode == ToolStripRenderMode.System) {
				return SystemColors.HotTrack;
			} else if (RenderMode == ToolStripRenderMode.Professional) {
				return ProfessionalColors.ButtonPressedBorder;
			} else {
				return ManagedColor;
			}
		}

		public Color TabBackHighColor(ToolStripRenderMode RenderMode, Color ManagedColor)
		{
			if (RenderMode == ToolStripRenderMode.System) {
				return SystemColors.Control;
			} else if (RenderMode == ToolStripRenderMode.Professional) {
				return ProfessionalColors.MenuItemPressedGradientBegin;
			} else {
				return ManagedColor;
			}
		}

		public Color TabBackLowColor(ToolStripRenderMode RenderMode, Color ManagedColor)
		{
			if (RenderMode == ToolStripRenderMode.System) {
				return SystemColors.Control;
			} else if (RenderMode == ToolStripRenderMode.Professional) {
				return ProfessionalColors.MenuItemPressedGradientEnd;
			} else {
				return ManagedColor;
			}
		}

		public Color TabBackHighColorDisabled(ToolStripRenderMode RenderMode, Color ManagedColor)
		{
			if (RenderMode == ToolStripRenderMode.System) {
				return SystemColors.Control;
			} else if (RenderMode == ToolStripRenderMode.Professional) {
				return ProfessionalColors.ToolStripDropDownBackground;
			} else {
				return ManagedColor;
			}
		}

		public Color TabBackLowColorDisabled(ToolStripRenderMode RenderMode, Color ManagedColor)
		{
			if (RenderMode == ToolStripRenderMode.System) {
				return SystemColors.Control;
			} else if (RenderMode == ToolStripRenderMode.Professional) {
				return ProfessionalColors.ToolStripGradientMiddle;
			} else {
				return ManagedColor;
			}
		}

		public Color TabCloseButtonBackHighColor(ToolStripRenderMode RenderMode, Color ManagedColor)
		{
			if (RenderMode == ToolStripRenderMode.System) {
				return Color.Transparent;
			} else if (RenderMode == ToolStripRenderMode.Professional) {
				return Color.Transparent;
			} else {
				return ManagedColor;
			}
		}

		public Color TabCloseButtonBackHighColorDisabled(ToolStripRenderMode RenderMode, Color ManagedColor)
		{
			if (RenderMode == ToolStripRenderMode.System) {
				return Color.Transparent;
			} else if (RenderMode == ToolStripRenderMode.Professional) {
				return Color.Transparent;
			} else {
				return ManagedColor;
			}
		}

		public Color TabCloseButtonBackHighColorHot(ToolStripRenderMode RenderMode, Color ManagedColor)
		{
			if (RenderMode == ToolStripRenderMode.System) {
				return SystemColors.ButtonHighlight;
			} else if (RenderMode == ToolStripRenderMode.Professional) {
				return Color.WhiteSmoke;
			} else {
				return ManagedColor;
			}
		}

		public Color TabCloseButtonBackLowColor(ToolStripRenderMode RenderMode, Color ManagedColor)
		{
			if (RenderMode == ToolStripRenderMode.System) {
				return Color.Transparent;
			} else if (RenderMode == ToolStripRenderMode.Professional) {
				return Color.Transparent;
			} else {
				return ManagedColor;
			}
		}

		public Color TabCloseButtonBackLowColorDisabled(ToolStripRenderMode RenderMode, Color ManagedColor)
		{
			if (RenderMode == ToolStripRenderMode.System) {
				return Color.Transparent;
			} else if (RenderMode == ToolStripRenderMode.Professional) {
				return Color.Transparent;
			} else {
				return ManagedColor;
			}
		}

		public Color TabCloseButtonBackLowColorHot(ToolStripRenderMode RenderMode, Color ManagedColor)
		{
			if (RenderMode == ToolStripRenderMode.System) {
				return SystemColors.ButtonHighlight;
			} else if (RenderMode == ToolStripRenderMode.Professional) {
				return Color.LightGray;
			} else {
				return ManagedColor;
			}
		}

		public Color TabCloseButtonBorderColor(ToolStripRenderMode RenderMode, Color ManagedColor)
		{
			if (RenderMode == ToolStripRenderMode.System) {
				return SystemColors.ControlDark;
			} else if (RenderMode == ToolStripRenderMode.Professional) {
				return Color.Transparent;
			} else {
				return ManagedColor;
			}
		}

		public Color TabCloseButtonBorderColorDisabled(ToolStripRenderMode RenderMode, Color ManagedColor)
		{
			if (RenderMode == ToolStripRenderMode.System) {
				return SystemColors.GrayText;
			} else if (RenderMode == ToolStripRenderMode.Professional) {
				return Color.Transparent;
			} else {
				return ManagedColor;
			}
		}

		public Color TabCloseButtonBorderColorHot(ToolStripRenderMode RenderMode, Color ManagedColor)
		{
			if (RenderMode == ToolStripRenderMode.System) {
				return SystemColors.HotTrack;
			} else if (RenderMode == ToolStripRenderMode.Professional) {
				return Color.Gray;
			} else {
				return ManagedColor;
			}
		}

		public Color TabCloseButtonForeColor(ToolStripRenderMode RenderMode, Color ManagedColor)
		{
			if (RenderMode == ToolStripRenderMode.System) {
				return SystemColors.ControlText;
			} else if (RenderMode == ToolStripRenderMode.Professional) {
				return Color.Gray;
			} else {
				return ManagedColor;
			}
		}

		public Color TabCloseButtonForeColorDisabled(ToolStripRenderMode RenderMode, Color ManagedColor)
		{
			if (RenderMode == ToolStripRenderMode.System) {
				return SystemColors.GrayText;
			} else if (RenderMode == ToolStripRenderMode.Professional) {
				return Color.Gray;
			} else {
				return ManagedColor;
			}
		}

		public Color TabCloseButtonForeColorHot(ToolStripRenderMode RenderMode, Color ManagedColor)
		{
			if (RenderMode == ToolStripRenderMode.System) {
				return SystemColors.ControlText;
			} else if (RenderMode == ToolStripRenderMode.Professional) {
				return Color.Firebrick;
			} else {
				return ManagedColor;
			}
		}

	}


	public static Colors RenderColors = new Colors();
}
}