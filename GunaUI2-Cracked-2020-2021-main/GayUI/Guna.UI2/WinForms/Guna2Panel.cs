using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Guna.UI2.WinForms.Suite;

namespace Guna.UI2.WinForms
{
	// Token: 0x02000065 RID: 101
	[DebuggerStepThrough]
	[Description("An advanced panel control")]
	[ToolboxItem(true)]
	[ToolboxBitmap(typeof(System.Windows.Forms.Panel))]
	public class Guna2Panel : Guna.UI2.WinForms.Suite.Panel
	{
		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000757 RID: 1879 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000758 RID: 1880 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06000759 RID: 1881 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnResize(EventArgs e)
		{
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00002134 File Offset: 0x00000334
		private void method_1()
		{
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x0600075B RID: 1883 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x0600075C RID: 1884 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x0600075D RID: 1885 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x0600075E RID: 1886 RVA: 0x00002134 File Offset: 0x00000334
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(true)]
		[Description("Shadow property of the control to add and customize a control's shadow")]
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

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x0600075F RID: 1887 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000760 RID: 1888 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(typeof(Color), "")]
		[Description("The BackColor that will fill the control")]
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

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000761 RID: 1889 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000762 RID: 1890 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The control's border color")]
		[DefaultValue(typeof(Color), "")]
		[Browsable(true)]
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

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000763 RID: 1891 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000764 RID: 1892 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The border thickness. The higher the value, the thicker the border")]
		[DefaultValue(0)]
		[Browsable(true)]
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

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000765 RID: 1893 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000766 RID: 1894 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("The custom border color of the control")]
		[DefaultValue(typeof(Color), "")]
		public Color CustomBorderColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000767 RID: 1895 RVA: 0x000033DC File Offset: 0x000015DC
		// (set) Token: 0x06000768 RID: 1896 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Padding), "0, 0, 0, 0")]
		[Description("The custom border thickness. The higher the value, the thicker the border")]
		[Browsable(true)]
		public Padding CustomBorderThickness
		{
			get
			{
				return default(Padding);
			}
			set
			{
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000769 RID: 1897 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600076A RID: 1898 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The curve angle of the control on all angles")]
		[DefaultValue(0)]
		[Browsable(true)]
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

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x0600076B RID: 1899 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600076C RID: 1900 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(false)]
		[Browsable(true)]
		[Description("If true, the background will allow a transparent color")]
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

		// Token: 0x0400016B RID: 363
		private bool bool_1;

		// Token: 0x0400016C RID: 364
		private int int_2;
	}
}
