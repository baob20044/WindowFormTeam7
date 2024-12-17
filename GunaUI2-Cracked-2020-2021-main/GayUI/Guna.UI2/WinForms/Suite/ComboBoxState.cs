using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Runtime.CompilerServices;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x02000092 RID: 146
	[DebuggerStepThrough]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[Description("ComboBoxState")]
	public class ComboBoxState
	{
		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000A40 RID: 2624 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000A41 RID: 2625 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06000A42 RID: 2626 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0()
		{
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x00002131 File Offset: 0x00000331
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x00002134 File Offset: 0x00000334
		internal void method_1(PaintValueEventArgs e)
		{
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000A45 RID: 2629 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000A46 RID: 2630 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The fill color")]
		[NotifyParentProperty(true)]
		[EditorBrowsable(EditorBrowsableState.Always)]
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

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000A47 RID: 2631 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000A48 RID: 2632 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(typeof(Color), "")]
		[Description("The forecolor")]
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

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000A49 RID: 2633 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000A4A RID: 2634 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "")]
		[Browsable(true)]
		[NotifyParentProperty(true)]
		[Description("The color of the border")]
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

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000A4B RID: 2635 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000A4C RID: 2636 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The font style")]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[DefaultValue(typeof(Font), "")]
		[Browsable(true)]
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

		// Token: 0x0400024B RID: 587
		[CompilerGenerated]
		private ComboBox comboBox_0;

		// Token: 0x0400024C RID: 588
		private Color color_0;

		// Token: 0x0400024D RID: 589
		private Color color_1;

		// Token: 0x0400024E RID: 590
		private Color color_2;

		// Token: 0x0400024F RID: 591
		private Font font_0;
	}
}
