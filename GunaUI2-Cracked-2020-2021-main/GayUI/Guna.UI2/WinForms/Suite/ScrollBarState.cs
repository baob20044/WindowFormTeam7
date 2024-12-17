using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x02000099 RID: 153
	[DebuggerStepThrough]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[Description("ScrollBarState")]
	public class ScrollBarState : ExpandableObjectConverter
	{
		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000A9E RID: 2718 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000A9F RID: 2719 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		public HScrollBar Parent
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

		// Token: 0x06000AA0 RID: 2720 RVA: 0x00002131 File Offset: 0x00000331
		public override string ToString()
		{
			return null;
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000AA2 RID: 2722 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(typeof(Color), "")]
		[Description("The scroll bar thumb color")]
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

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000AA4 RID: 2724 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The scroll bar fill color")]
		[Browsable(true)]
		[DefaultValue(typeof(Color), "")]
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

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000AA6 RID: 2726 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "")]
		[Description("The scroll bar border color")]
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

		// Token: 0x04000270 RID: 624
		[CompilerGenerated]
		private HScrollBar hscrollBar_0;

		// Token: 0x04000271 RID: 625
		private Color color_0;

		// Token: 0x04000272 RID: 626
		private Color color_1;

		// Token: 0x04000273 RID: 627
		private Color color_2;
	}
}
