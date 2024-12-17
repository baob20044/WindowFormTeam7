using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Guna.UI2.WinForms.Interfaces;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x020000B5 RID: 181
	[ToolboxItem(false)]
	public class Panel : Panel, IControl
	{
		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06000EC7 RID: 3783 RVA: 0x00002136 File Offset: 0x00000336
		[Description("Gets a value that indicates whether the Component is currently in design mode.")]
		[Browsable(false)]
		public bool IsDesignMode
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06000EC8 RID: 3784 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000EC9 RID: 3785 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Style the control's border sides.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(true)]
		public CustomizableEdges CustomizableEdges
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06000ECB RID: 3787 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x06000ECC RID: 3788 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected DashStyle DefaultBorderStyle
		{
			get
			{
				return DashStyle.Solid;
			}
			set
			{
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06000ECD RID: 3789 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000ECE RID: 3790 RVA: 0x00002134 File Offset: 0x00000334
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(false)]
		protected ShadowDecoration DefaultShadowDecoration
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06000ECF RID: 3791 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000ED0 RID: 3792 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Color DefaultFillColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06000ED1 RID: 3793 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000ED2 RID: 3794 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Color DefaultBorderColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06000ED3 RID: 3795 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000ED4 RID: 3796 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected int DefaultBorderThickness
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06000ED5 RID: 3797 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000ED6 RID: 3798 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Color DefaultCustomBorderColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06000ED7 RID: 3799 RVA: 0x000033DC File Offset: 0x000015DC
		// (set) Token: 0x06000ED8 RID: 3800 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Padding DefaultCustomBorderThickness
		{
			get
			{
				return default(Padding);
			}
			set
			{
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06000ED9 RID: 3801 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000EDA RID: 3802 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected int DefaultBorderRadius
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06000EDB RID: 3803 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000EDC RID: 3804 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected bool DefaultUseTransparentBackground
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0(Graphics G)
		{
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaintBackground(PaintEventArgs e)
		{
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnResize(EventArgs e)
		{
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x00002134 File Offset: 0x00000334
		public void DefWndProc(Message m)
		{
		}

		// Token: 0x040003DD RID: 989
		private CustomizableEdges customizableEdges_0;

		// Token: 0x040003DE RID: 990
		private DashStyle dashStyle_0;

		// Token: 0x040003DF RID: 991
		private ShadowDecoration shadowDecoration_0;

		// Token: 0x040003E0 RID: 992
		private Color color_0;

		// Token: 0x040003E1 RID: 993
		private Color color_1;

		// Token: 0x040003E2 RID: 994
		private int int_0;

		// Token: 0x040003E3 RID: 995
		private Color color_2;

		// Token: 0x040003E4 RID: 996
		private Padding padding_0;

		// Token: 0x040003E5 RID: 997
		private int int_1;

		// Token: 0x040003E6 RID: 998
		private bool bool_0;
	}
}
