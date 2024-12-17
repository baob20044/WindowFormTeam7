using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x02000090 RID: 144
	[Description("Button State")]
	[DebuggerStepThrough]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class ButtonState
	{
		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000A1F RID: 2591 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		public CustomButtonBase Parent
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

		// Token: 0x06000A20 RID: 2592 RVA: 0x00002134 File Offset: 0x00000334
		internal void method_0()
		{
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x00002131 File Offset: 0x00000331
		public override string ToString()
		{
			return null;
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000A23 RID: 2595 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Description("The controls' fill color")]
		[DefaultValue(typeof(Color), "")]
		[NotifyParentProperty(true)]
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

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000A24 RID: 2596 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000A25 RID: 2597 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The controls' ForeColor")]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[DefaultValue(typeof(Color), "")]
		[Browsable(true)]
		[NotifyParentProperty(true)]
		public Color ForeColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000A26 RID: 2598 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000A27 RID: 2599 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Always)]
		[DefaultValue(typeof(Color), "")]
		[Browsable(true)]
		[NotifyParentProperty(true)]
		[Description("The controls' border color")]
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

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000A29 RID: 2601 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Description("The controls' custom border color")]
		[NotifyParentProperty(true)]
		[DefaultValue(typeof(Color), "")]
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

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000A2B RID: 2603 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The controls' image")]
		[NotifyParentProperty(true)]
		[DefaultValue(typeof(Image), "")]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Browsable(true)]
		public Image Image
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000A2D RID: 2605 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The controls' font style")]
		[Browsable(true)]
		[DefaultValue(typeof(Font), "")]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[NotifyParentProperty(true)]
		public Font Font
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x0400023D RID: 573
		[CompilerGenerated]
		private CustomButtonBase customButtonBase_0;

		// Token: 0x0400023E RID: 574
		private Color color_0;

		// Token: 0x0400023F RID: 575
		private Color color_1;

		// Token: 0x04000240 RID: 576
		private Color color_2;

		// Token: 0x04000241 RID: 577
		private Color color_3;

		// Token: 0x04000242 RID: 578
		private Image image_0;

		// Token: 0x04000243 RID: 579
		private Font font_0;
	}
}
