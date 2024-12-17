using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x0200009B RID: 155
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[DebuggerStepThrough]
	[Description("")]
	public class TextBoxState
	{
		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000ABF RID: 2751 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000AC0 RID: 2752 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		public TextBox Parent
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

		// Token: 0x06000AC1 RID: 2753 RVA: 0x00002131 File Offset: 0x00000331
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0()
		{
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000AC4 RID: 2756 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Description("The textbox ForeColor")]
		[NotifyParentProperty(true)]
		[DefaultValue(typeof(Color), "")]
		[Browsable(true)]
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

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000AC6 RID: 2758 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The textbox Placeholder ForeColor")]
		[NotifyParentProperty(true)]
		[Browsable(true)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[DefaultValue(typeof(Color), "")]
		public Color PlaceholderForeColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000AC7 RID: 2759 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000AC8 RID: 2760 RVA: 0x00002134 File Offset: 0x00000334
		[NotifyParentProperty(true)]
		[DefaultValue(typeof(Color), "")]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Description("The textbox fill color")]
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

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000AC9 RID: 2761 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000ACA RID: 2762 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "")]
		[Description("The textbox border color")]
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

		// Token: 0x0400027E RID: 638
		[CompilerGenerated]
		private TextBox textBox_0;

		// Token: 0x0400027F RID: 639
		private Color color_0;

		// Token: 0x04000280 RID: 640
		private Color color_1;

		// Token: 0x04000281 RID: 641
		private Color color_2;

		// Token: 0x04000282 RID: 642
		private Color color_3;
	}
}
