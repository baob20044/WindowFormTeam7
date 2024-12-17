using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x0200009C RID: 156
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[Description("TrackBarState")]
	[DebuggerStepThrough]
	public class TrackBarState
	{
		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000ACC RID: 2764 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000ACD RID: 2765 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		public TrackBar Parent
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

		// Token: 0x06000ACE RID: 2766 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0()
		{
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x00002131 File Offset: 0x00000331
		public override string ToString()
		{
			return null;
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000AD0 RID: 2768 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000AD1 RID: 2769 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "")]
		[Description("The control's fill color")]
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

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000AD2 RID: 2770 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000AD3 RID: 2771 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "")]
		[Description("The control's thumb color")]
		[Browsable(true)]
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

		// Token: 0x04000283 RID: 643
		[CompilerGenerated]
		private TrackBar trackBar_0;

		// Token: 0x04000284 RID: 644
		private Color color_0;

		// Token: 0x04000285 RID: 645
		private Color color_1;
	}
}
