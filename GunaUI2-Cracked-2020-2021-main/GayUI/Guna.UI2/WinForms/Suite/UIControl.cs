using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Guna.UI2.WinForms.Enums;
using Guna.UI2.WinForms.Interfaces;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x020000C2 RID: 194
	[ToolboxItem(false)]
	public class UIControl : Control, IControl
	{
		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x060010A9 RID: 4265 RVA: 0x00002136 File Offset: 0x00000336
		[Browsable(false)]
		[Description("Gets a value that indicates whether the Component is currently in design mode.")]
		public bool IsDesignMode
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x060010AB RID: 4267 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060010AC RID: 4268 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x060010AD RID: 4269 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x060010AE RID: 4270 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(DashStyle.Solid)]
		public DashStyle BorderStyle
		{
			get
			{
				return DashStyle.Solid;
			}
			set
			{
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x060010AF RID: 4271 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060010B0 RID: 4272 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(typeof(Color), "Black")]
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

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x060010B1 RID: 4273 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060010B2 RID: 4274 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x060010B3 RID: 4275 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060010B4 RID: 4276 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
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

		// Token: 0x060010B5 RID: 4277 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseDown(MouseEventArgs e)
		{
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseUp(MouseEventArgs e)
		{
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseEnter(EventArgs e)
		{
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseLeave(EventArgs e)
		{
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnLostFocus(EventArgs e)
		{
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x060010BA RID: 4282 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060010BB RID: 4283 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("Set the use of transfarant backgroud on this control.")]
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

		// Token: 0x060010BC RID: 4284 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0(Graphics G)
		{
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaintBackground(PaintEventArgs e)
		{
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnResize(EventArgs e)
		{
		}

		// Token: 0x040004A0 RID: 1184
		private int int_0;

		// Token: 0x040004A1 RID: 1185
		private DashStyle dashStyle_0;

		// Token: 0x040004A2 RID: 1186
		private Color color_0;

		// Token: 0x040004A3 RID: 1187
		private int int_1;

		// Token: 0x040004A4 RID: 1188
		private ShadowDecoration shadowDecoration_0;

		// Token: 0x040004A5 RID: 1189
		private bool bool_0;

		// Token: 0x040004A6 RID: 1190
		internal bool bool_1;

		// Token: 0x040004A7 RID: 1191
		internal bool bool_2;

		// Token: 0x040004A8 RID: 1192
		internal MouseState mouseState_0;

		// Token: 0x040004A9 RID: 1193
		private bool bool_3;
	}
}
