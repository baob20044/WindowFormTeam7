using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Guna.UI2.WinForms.Suite;

namespace Guna.UI2.WinForms
{
	// Token: 0x0200005C RID: 92
	[ToolboxBitmap(typeof(System.Windows.Forms.Panel))]
	[Description("A gradient panel control")]
	[ToolboxItem(true)]
	[DebuggerStepThrough]
	public class Guna2GradientPanel : GradientPanel
	{
		// Token: 0x1700029A RID: 666
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600066E RID: 1646 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(false)]
		[Browsable(true)]
		[Description("If true, the border on the control is rounded off automatically")]
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

		// Token: 0x0600066F RID: 1647 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnResize(EventArgs e)
		{
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00002134 File Offset: 0x00000334
		private void method_1()
		{
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000671 RID: 1649 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000672 RID: 1650 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Shadow property of the control to add and customize a control's shadow")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
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

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000673 RID: 1651 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000674 RID: 1652 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "")]
		[Browsable(true)]
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

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000675 RID: 1653 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000676 RID: 1654 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "")]
		[Browsable(true)]
		[Description("The second BackColor that will fill the control in a gradient mode")]
		public Color FillColor2
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000677 RID: 1655 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000678 RID: 1656 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("The control's border color")]
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

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600067A RID: 1658 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(0)]
		[Description("The border thickness. The higher the value, the thicker the border")]
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

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x0600067B RID: 1659 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600067C RID: 1660 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "")]
		[Description("The control's custom border color")]
		[Browsable(true)]
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

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x0600067D RID: 1661 RVA: 0x000033DC File Offset: 0x000015DC
		// (set) Token: 0x0600067E RID: 1662 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Padding), "0, 0, 0, 0")]
		[Browsable(true)]
		[Description("The control's custom border thickness")]
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

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x0600067F RID: 1663 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000680 RID: 1664 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000681 RID: 1665 RVA: 0x0000331C File Offset: 0x0000151C
		// (set) Token: 0x06000682 RID: 1666 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(0)]
		[Description("The control's gradient mode")]
		[Browsable(true)]
		public LinearGradientMode GradientMode
		{
			get
			{
				return LinearGradientMode.Horizontal;
			}
			set
			{
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000684 RID: 1668 RVA: 0x00002134 File Offset: 0x00000334
		[Description("If true, the background will allow a transparent color")]
		[Browsable(true)]
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

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x06000686 RID: 1670 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(DashStyle.Solid)]
		[Browsable(true)]
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

		// Token: 0x0400014E RID: 334
		private bool bool_1;

		// Token: 0x0400014F RID: 335
		private int int_2;
	}
}
