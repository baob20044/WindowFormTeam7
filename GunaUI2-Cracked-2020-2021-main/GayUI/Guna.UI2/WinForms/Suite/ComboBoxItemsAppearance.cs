using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x02000091 RID: 145
	[Description("ComboBoxItemsAppearance")]
	[DebuggerStepThrough]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class ComboBoxItemsAppearance
	{
		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000A30 RID: 2608 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		public ComboBox Parent
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

		// Token: 0x06000A31 RID: 2609 RVA: 0x00002131 File Offset: 0x00000331
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0()
		{
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000A33 RID: 2611 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000A34 RID: 2612 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Always)]
		[NotifyParentProperty(true)]
		[DefaultValue(typeof(Font), "")]
		[Description("The font style")]
		[Browsable(true)]
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

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000A36 RID: 2614 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The ForeColor")]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Browsable(true)]
		[DefaultValue(typeof(Color), "")]
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

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000A38 RID: 2616 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Description("The BackColor")]
		[Browsable(true)]
		[NotifyParentProperty(true)]
		[DefaultValue(typeof(Color), "")]
		public Color BackColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000A3A RID: 2618 RVA: 0x00002134 File Offset: 0x00000334
		[NotifyParentProperty(true)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Browsable(true)]
		[Description("The font style of a selected item")]
		[DefaultValue(typeof(Font), "")]
		public Font SelectedFont
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000A3B RID: 2619 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000A3C RID: 2620 RVA: 0x00002134 File Offset: 0x00000334
		[NotifyParentProperty(true)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[DefaultValue(typeof(Color), "")]
		[Description("The ForeColor of a selected item")]
		[Browsable(true)]
		public Color SelectedForeColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000A3E RID: 2622 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "")]
		[Description("The BackColor of a selected item")]
		[NotifyParentProperty(true)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Browsable(true)]
		public Color SelectedBackColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x04000244 RID: 580
		[CompilerGenerated]
		private ComboBox comboBox_0;

		// Token: 0x04000245 RID: 581
		private Font font_0;

		// Token: 0x04000246 RID: 582
		private Color color_0;

		// Token: 0x04000247 RID: 583
		private Color color_1;

		// Token: 0x04000248 RID: 584
		private Font font_1;

		// Token: 0x04000249 RID: 585
		private Color color_2;

		// Token: 0x0400024A RID: 586
		private Color color_3;
	}
}
