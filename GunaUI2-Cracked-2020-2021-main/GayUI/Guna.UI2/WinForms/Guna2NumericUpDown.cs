using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Guna.UI2.WinForms.Suite;

namespace Guna.UI2.WinForms
{
	// Token: 0x02000064 RID: 100
	[Description("A numeric UpDown control")]
	[ToolboxItem(true)]
	[ToolboxBitmap(typeof(System.Windows.Forms.NumericUpDown))]
	[Designer(typeof(Guna2NumericUpDownDesigner))]
	[DebuggerStepThrough]
	public class Guna2NumericUpDown : Guna.UI2.WinForms.Suite.NumericUpDown
	{
		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000738 RID: 1848 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000739 RID: 1849 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(false)]
		[Description("If true, the border on the control is rounded off automatically")]
		[Browsable(true)]
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

		// Token: 0x0600073A RID: 1850 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnResize(EventArgs e)
		{
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x00002134 File Offset: 0x00000334
		private void method_11()
		{
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600073D RID: 1853 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(false)]
		[Browsable(false)]
		public bool IndicateFocus
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Description("The properties that will be applied when the control is in a focused state")]
		[Browsable(true)]
		public NumericUpDownState FocusedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x0600073F RID: 1855 RVA: 0x00002131 File Offset: 0x00000331
		[Browsable(true)]
		[Description("The properties that will be applied when the control is in a disabled state")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public NumericUpDownState DisabledState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000741 RID: 1857 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(true)]
		[Browsable(true)]
		[Description("If true, the UpDown button will be visible")]
		public bool UpDownButtonBorderVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000743 RID: 1859 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(typeof(Color), "94, 148, 255")]
		[Description("The UpDown button fill color")]
		public Color UpDownButtonFillColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000744 RID: 1860 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000745 RID: 1861 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The UpDown button ForeColor")]
		[DefaultValue(typeof(Color), "80, 0, 0, 0")]
		[Browsable(true)]
		public Color UpDownButtonForeColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x06000747 RID: 1863 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(DashStyle.Solid)]
		[Description("The css-like style of the border. You can customize the border to meet your design needs")]
		public new DashStyle BorderStyle
		{
			get
			{
				return DashStyle.Solid;
			}
			set
			{
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000749 RID: 1865 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("Shadow property of the control to add and customize a control's shadow")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public ShadowDecoration ShadowDecoration
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600074B RID: 1867 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The BackColor that will fill the control")]
		[Browsable(true)]
		[DefaultValue(typeof(Color), "White")]
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

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x0600074C RID: 1868 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600074D RID: 1869 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The control's border color")]
		[Browsable(true)]
		[DefaultValue(typeof(Color), "213, 218, 223")]
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

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x0600074E RID: 1870 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600074F RID: 1871 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(1)]
		[Description("The border thickness. The higher the value, the thicker the border")]
		public int BorderThickness
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000750 RID: 1872 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000751 RID: 1873 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("The curve angle of the control on all angles")]
		[DefaultValue(0)]
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

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000752 RID: 1874 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000753 RID: 1875 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("If true, the background will allow a transparent color")]
		[DefaultValue(false)]
		public bool UseTransparentBackground
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000754 RID: 1876 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x06000755 RID: 1877 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Point), "0, 0")]
		[Description("The control's text position")]
		[Browsable(true)]
		public Point TextOffset
		{
			get
			{
				return default(Point);
			}
			set
			{
			}
		}

		// Token: 0x04000169 RID: 361
		private bool bool_4;

		// Token: 0x0400016A RID: 362
		private int int_2;
	}
}
