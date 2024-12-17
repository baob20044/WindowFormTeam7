using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x0200008E RID: 142
	[DebuggerStepThrough]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[Description("DateTimePickerState")]
	public class DateTimePickerState
	{
		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000A02 RID: 2562 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000A03 RID: 2563 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		public DateTimePicker Parent
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

		// Token: 0x06000A04 RID: 2564 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0()
		{
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x00002131 File Offset: 0x00000331
		public override string ToString()
		{
			return null;
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000A07 RID: 2567 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The date picker's fill color")]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[NotifyParentProperty(true)]
		[DefaultValue(typeof(Color), "")]
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

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000A09 RID: 2569 RVA: 0x00002134 File Offset: 0x00000334
		[NotifyParentProperty(true)]
		[Browsable(true)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[DefaultValue(typeof(Color), "")]
		[Description("The date picker's ForeColor")]
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

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000A0A RID: 2570 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000A0B RID: 2571 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "")]
		[NotifyParentProperty(true)]
		[Browsable(true)]
		[Description("The date picker's border color")]
		[EditorBrowsable(EditorBrowsableState.Always)]
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

		// Token: 0x04000232 RID: 562
		[CompilerGenerated]
		private DateTimePicker dateTimePicker_0;

		// Token: 0x04000233 RID: 563
		private Color color_0;

		// Token: 0x04000234 RID: 564
		private Color color_1;

		// Token: 0x04000235 RID: 565
		private Color color_2;
	}
}
