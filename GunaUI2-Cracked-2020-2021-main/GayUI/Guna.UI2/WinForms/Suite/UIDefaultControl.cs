using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Guna.UI2.WinForms.Enums;
using Guna.UI2.WinForms.Interfaces;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x020000C3 RID: 195
	[ToolboxItem(false)]
	public class UIDefaultControl : Control, IControl
	{
		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x060010BF RID: 4287 RVA: 0x00002136 File Offset: 0x00000336
		[Browsable(false)]
		[Description("Gets a value that indicates whether the Component is currently in design mode.")]
		public bool IsDesignMode
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x060010C1 RID: 4289 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060010C2 RID: 4290 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x060010C3 RID: 4291 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x060010C4 RID: 4292 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x060010C5 RID: 4293 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060010C6 RID: 4294 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x060010C7 RID: 4295 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060010C8 RID: 4296 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x060010C9 RID: 4297 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060010CA RID: 4298 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
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

		// Token: 0x060010CB RID: 4299 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseDown(MouseEventArgs e)
		{
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseUp(MouseEventArgs e)
		{
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseEnter(EventArgs e)
		{
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseLeave(EventArgs e)
		{
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnLostFocus(EventArgs e)
		{
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x060010D0 RID: 4304 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060010D1 RID: 4305 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x060010D2 RID: 4306 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0(Graphics G)
		{
		}

		// Token: 0x060010D3 RID: 4307 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaintBackground(PaintEventArgs e)
		{
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnResize(EventArgs e)
		{
		}

		// Token: 0x040004AA RID: 1194
		private int int_0;

		// Token: 0x040004AB RID: 1195
		private DashStyle dashStyle_0;

		// Token: 0x040004AC RID: 1196
		private Color color_0;

		// Token: 0x040004AD RID: 1197
		private int int_1;

		// Token: 0x040004AE RID: 1198
		private ShadowDecoration shadowDecoration_0;

		// Token: 0x040004AF RID: 1199
		internal bool bool_0;

		// Token: 0x040004B0 RID: 1200
		private bool bool_1;

		// Token: 0x040004B1 RID: 1201
		internal bool bool_2;

		// Token: 0x040004B2 RID: 1202
		internal bool bool_3;

		// Token: 0x040004B3 RID: 1203
		protected MouseState MouseState;

		// Token: 0x040004B4 RID: 1204
		private bool bool_4;
	}
}
