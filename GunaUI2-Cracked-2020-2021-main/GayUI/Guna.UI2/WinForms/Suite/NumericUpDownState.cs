using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x02000096 RID: 150
	[DebuggerStepThrough]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[Description("NumericUpDownState")]
	public class NumericUpDownState
	{
		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000A75 RID: 2677 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000A76 RID: 2678 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		public NumericUpDown Parent
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

		// Token: 0x06000A77 RID: 2679 RVA: 0x00002131 File Offset: 0x00000331
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0()
		{
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000A79 RID: 2681 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000A7A RID: 2682 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "")]
		[Description("The control's ForeColor")]
		[Browsable(true)]
		[NotifyParentProperty(true)]
		[EditorBrowsable(EditorBrowsableState.Always)]
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

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000A7B RID: 2683 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000A7C RID: 2684 RVA: 0x00002134 File Offset: 0x00000334
		[NotifyParentProperty(true)]
		[Browsable(true)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Description("The control's UpDown button ForeColor")]
		[DefaultValue(typeof(Color), "")]
		public Color UpDownButtonForeColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000A7E RID: 2686 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "")]
		[Description("The control's UpDown button fill color")]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[NotifyParentProperty(true)]
		[Browsable(true)]
		public Color UpDownButtonFillColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000A7F RID: 2687 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000A80 RID: 2688 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "")]
		[Browsable(true)]
		[Description("The control's UpDown button fill color")]
		[NotifyParentProperty(true)]
		[EditorBrowsable(EditorBrowsableState.Always)]
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

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000A81 RID: 2689 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000A82 RID: 2690 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The control's UpDown button border color")]
		[DefaultValue(typeof(Color), "")]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[NotifyParentProperty(true)]
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

		// Token: 0x0400025F RID: 607
		[CompilerGenerated]
		private NumericUpDown numericUpDown_0;

		// Token: 0x04000260 RID: 608
		private Color color_0;

		// Token: 0x04000261 RID: 609
		private Color color_1;

		// Token: 0x04000262 RID: 610
		private Color color_2;

		// Token: 0x04000263 RID: 611
		private Color color_3;

		// Token: 0x04000264 RID: 612
		private Color color_4;
	}
}
