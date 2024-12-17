using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Guna.UI2.WinForms.Enums;
using Guna.UI2.WinForms.Suite;

namespace Guna.UI2.WinForms
{
	// Token: 0x02000077 RID: 119
	[ToolboxItem(true)]
	[Designer(typeof(Guna2VScrollBarDesigner))]
	[DebuggerStepThrough]
	[Description("A vertical ScrollBar Control")]
	[ToolboxBitmap(typeof(VScrollBar))]
	public class Guna2VScrollBar : Guna.UI2.WinForms.Suite.HScrollBar
	{
		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x060008ED RID: 2285 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060008EE RID: 2286 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("The border BackColor")]
		[DefaultValue(typeof(Color), "")]
		public Color BorderColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x060008EF RID: 2287 RVA: 0x000033C4 File Offset: 0x000015C4
		// (set) Token: 0x060008F0 RID: 2288 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(0)]
		[Browsable(true)]
		[Description("Sets the thumb's style in relation to the ScrollBar.")]
		public ThumbStyle ThumbStyle
		{
			get
			{
				return ThumbStyle.Default;
			}
			set
			{
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060008F2 RID: 2290 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Control), "")]
		[Description("Attaches the ScrollBar to the scroll events of any scrollable container-control or DataGridView.")]
		public Control BindingContainer
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x060008F3 RID: 2291 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060008F4 RID: 2292 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("If true, the border on the control is rounded off automatically")]
		[DefaultValue(false)]
		public bool AutoRoundedCorners
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnResize(EventArgs e)
		{
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x00002134 File Offset: 0x00000334
		private void method_5()
		{
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x00002134 File Offset: 0x00000334
		private void method_6()
		{
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x00002134 File Offset: 0x00000334
		private void method_7()
		{
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x00002136 File Offset: 0x00000336
		private int method_8(ListView listView)
		{
			return 0;
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x00002136 File Offset: 0x00000336
		public int getVerticalScrollPosition(ListView listView)
		{
			return 0;
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x00002136 File Offset: 0x00000336
		private int method_9(ListView listView)
		{
			return 0;
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x00002134 File Offset: 0x00000334
		private void method_10(object sender, EventArgs e)
		{
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x00002134 File Offset: 0x00000334
		private void method_11()
		{
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x00002134 File Offset: 0x00000334
		private void method_12()
		{
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x00002134 File Offset: 0x00000334
		private void method_13()
		{
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x00002134 File Offset: 0x00000334
		private void method_14()
		{
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x00002134 File Offset: 0x00000334
		private void method_15()
		{
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x00002134 File Offset: 0x00000334
		private void method_16(object sender, ControlEventArgs e)
		{
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x00002134 File Offset: 0x00000334
		private void method_17(object sender, ControlEventArgs e)
		{
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x00002134 File Offset: 0x00000334
		private void method_18(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x00002134 File Offset: 0x00000334
		private void method_19(object sender, ScrollEventArgs e)
		{
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x00002134 File Offset: 0x00000334
		private void method_20(object sender, DataGridViewRowEventArgs e)
		{
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x00002134 File Offset: 0x00000334
		private void method_21(object sender, DataGridViewRowsAddedEventArgs e)
		{
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x00002134 File Offset: 0x00000334
		private void method_22(object sender, DataGridViewRowsRemovedEventArgs e)
		{
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x00002134 File Offset: 0x00000334
		private void method_23(Control control)
		{
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x0600090A RID: 2314 RVA: 0x00002131 File Offset: 0x00000331
		[Description("The properties that will be applied when the cursor is over the control")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(true)]
		public ScrollBarState HoverState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x0600090B RID: 2315 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(true)]
		[Description("The properties that will be applied when the control is in pressed state")]
		public ScrollBarState PressedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x000033DC File Offset: 0x000015DC
		// (set) Token: 0x0600090D RID: 2317 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The control's padding property")]
		public new Padding Padding
		{
			[CompilerGenerated]
			get
			{
				return default(Padding);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x0600090E RID: 2318 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x0600090F RID: 2319 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The control's font")]
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new Font Font
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000910 RID: 2320 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000911 RID: 2321 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The control's text")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public new string Text
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000912 RID: 2322 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000913 RID: 2323 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		[Description("The control's ForeColor")]
		public new Color ForeColor
		{
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000914 RID: 2324 RVA: 0x00002145 File Offset: 0x00000345
		// (set) Token: 0x06000915 RID: 2325 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("The control's thumb size")]
		[DefaultValue(10f)]
		public float ThumbSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000916 RID: 2326 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000917 RID: 2327 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(0)]
		[Browsable(true)]
		[Description("The curve angle of the control on all angles")]
		public int BorderRadius
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000918 RID: 2328 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000919 RID: 2329 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("The MouseWheel Bar Partitions when using the mouse wheel")]
		public int MouseWheelBarPartitions
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x0600091A RID: 2330 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600091B RID: 2331 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The size of the scrollbar")]
		[Browsable(true)]
		public int ScrollbarSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x0600091C RID: 2332 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600091D RID: 2333 RVA: 0x00002134 File Offset: 0x00000334
		[Description("If true, the bar will be highlighted on mouse wheel")]
		[DefaultValue(false)]
		public bool HighlightOnWheel
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x0600091E RID: 2334 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600091F RID: 2335 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(0)]
		[Browsable(true)]
		[Description("The minimum scrollbar value")]
		public int Minimum
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000920 RID: 2336 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000921 RID: 2337 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(100)]
		[Description("The maximum scrollbar value")]
		public int Maximum
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000922 RID: 2338 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000923 RID: 2339 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(1)]
		[Description("The minimum scrollbar value change")]
		public int SmallChange
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000924 RID: 2340 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000925 RID: 2341 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(5)]
		[Description("The maximum scrollbar value change")]
		public int LargeChange
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000926 RID: 2342 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000927 RID: 2343 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("The scrollbar thumb color")]
		public Color ThumbColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000928 RID: 2344 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000929 RID: 2345 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The control's fill color")]
		[Browsable(true)]
		public Color FillColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00002134 File Offset: 0x00000334
		private void method_24()
		{
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x0600092B RID: 2347 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600092C RID: 2348 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The scrollbar current value")]
		[Browsable(true)]
		[DefaultValue(0)]
		public int Value
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x0600092D RID: 2349 RVA: 0x000033DC File Offset: 0x000015DC
		// (set) Token: 0x0600092E RID: 2350 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Padding), "0, 0, 0, 0")]
		[Browsable(true)]
		[Description("The bar positioning property")]
		public Padding FillOffset
		{
			get
			{
				return default(Padding);
			}
			set
			{
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x0600092F RID: 2351 RVA: 0x00002131 File Offset: 0x00000331
		protected override CreateParams CreateParams
		{
			[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
			get
			{
				return null;
			}
		}

		// Token: 0x040001D0 RID: 464
		private Control control_0;

		// Token: 0x040001D1 RID: 465
		private bool bool_0;

		// Token: 0x040001D2 RID: 466
		private Timer timer_0;

		// Token: 0x040001D3 RID: 467
		private IContainer icontainer_1;

		// Token: 0x040001D4 RID: 468
		private int int_0;

		// Token: 0x040001D5 RID: 469
		private bool bool_1;

		// Token: 0x040001D6 RID: 470
		private int int_1;

		// Token: 0x040001D7 RID: 471
		private int int_2;

		// Token: 0x040001D8 RID: 472
		private int int_3;

		// Token: 0x040001D9 RID: 473
		private int int_4;

		// Token: 0x040001DA RID: 474
		private int int_5;

		// Token: 0x040001DB RID: 475
		private VScrollBar vscrollBar_0;

		// Token: 0x040001DC RID: 476
		[CompilerGenerated]
		private Padding padding_1;

		// Token: 0x040001DD RID: 477
		[CompilerGenerated]
		private Font font_0;

		// Token: 0x040001DE RID: 478
		[CompilerGenerated]
		private string string_0;

		// Token: 0x040001DF RID: 479
		[CompilerGenerated]
		private Color color_0;

		// Token: 0x02000078 RID: 120
		// (Invoke) Token: 0x06000932 RID: 2354
		private delegate void Delegate3();
	}
}
