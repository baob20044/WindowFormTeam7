using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Guna.UI2.WinForms.Suite;

namespace Guna.UI2.WinForms
{
	// Token: 0x02000066 RID: 102
	[DebuggerStepThrough]
	[Designer(typeof(Guna2PictureBoxDesigner))]
	[ToolboxBitmap(typeof(System.Windows.Forms.PictureBox))]
	[Description("A picturebox control")]
	[ToolboxItem(true)]
	public class Guna2PictureBox : Guna.UI2.WinForms.Suite.PictureBox
	{
		// Token: 0x1700030E RID: 782
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600076F RID: 1903 RVA: 0x00002134 File Offset: 0x00000334
		[Description("If true, the border on the control is rounded off automatically")]
		[Browsable(true)]
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

		// Token: 0x06000770 RID: 1904 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnResize(EventArgs e)
		{
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00002134 File Offset: 0x00000334
		private void method_2()
		{
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000773 RID: 1907 RVA: 0x00002134 File Offset: 0x00000334
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Description("Shadow property of the control to add and customize a control's shadow")]
		[Browsable(true)]
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

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000774 RID: 1908 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000775 RID: 1909 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "")]
		[Description("The BackColor that will fill the control")]
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

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000777 RID: 1911 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The curve angle of the control on all angles")]
		[Browsable(true)]
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

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000779 RID: 1913 RVA: 0x00002134 File Offset: 0x00000334
		[Description("If true, the background will allow a transparent color")]
		[DefaultValue(false)]
		[Browsable(true)]
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

		// Token: 0x0400016D RID: 365
		private bool bool_1;

		// Token: 0x0400016E RID: 366
		private int int_1;
	}
}
