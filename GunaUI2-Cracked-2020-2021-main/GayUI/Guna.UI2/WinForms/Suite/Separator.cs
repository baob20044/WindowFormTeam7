using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Guna.UI2.WinForms.Interfaces;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x020000BA RID: 186
	[ToolboxItem(false)]
	public class Separator : Control, IControl
	{
		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06000F85 RID: 3973 RVA: 0x00002136 File Offset: 0x00000336
		[Browsable(false)]
		[Description("Gets a value that indicates whether the Component is currently in design mode.")]
		public bool IsDesignMode
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x00002134 File Offset: 0x00000334
		protected void SetOrientation(Orientation orientation)
		{
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06000F88 RID: 3976 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000F89 RID: 3977 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06000F8A RID: 3978 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000F8B RID: 3979 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected int DefaultFillThickness
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06000F8C RID: 3980 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x06000F8D RID: 3981 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected DashStyle DefaultFillStyle
		{
			get
			{
				return DashStyle.Solid;
			}
			set
			{
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06000F8E RID: 3982 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000F8F RID: 3983 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06000F90 RID: 3984 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0(Graphics G)
		{
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaintBackground(PaintEventArgs e)
		{
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnResize(EventArgs e)
		{
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x04000431 RID: 1073
		private Color color_0;

		// Token: 0x04000432 RID: 1074
		private int int_0;

		// Token: 0x04000433 RID: 1075
		private DashStyle dashStyle_0;

		// Token: 0x04000434 RID: 1076
		private bool bool_0;

		// Token: 0x04000435 RID: 1077
		private Orientation orientation_0;
	}
}
