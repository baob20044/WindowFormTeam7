using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x02000095 RID: 149
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[DebuggerStepThrough]
	[Description("CustomRadionButtonState")]
	public class CustomRadionButtonState
	{
		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000A66 RID: 2662 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000A67 RID: 2663 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		public CustomRadioButton Parent
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

		// Token: 0x06000A68 RID: 2664 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0()
		{
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x00002131 File Offset: 0x00000331
		public override string ToString()
		{
			return null;
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000A6A RID: 2666 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000A6B RID: 2667 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("The fill color")]
		[NotifyParentProperty(true)]
		[DefaultValue(typeof(Color), "")]
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

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000A6C RID: 2668 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000A6D RID: 2669 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "")]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Description("The control's border color")]
		[Browsable(true)]
		[NotifyParentProperty(true)]
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

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000A6E RID: 2670 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000A6F RID: 2671 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(int), "")]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Description("The thickness of the border. The higher the value, the thicker the border")]
		[NotifyParentProperty(true)]
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

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000A70 RID: 2672 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000A71 RID: 2673 RVA: 0x00002134 File Offset: 0x00000334
		[NotifyParentProperty(true)]
		[Description("The inner color of the control")]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Browsable(true)]
		[DefaultValue(typeof(Color), "")]
		public Color InnerColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000A72 RID: 2674 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000A73 RID: 2675 RVA: 0x00002134 File Offset: 0x00000334
		[NotifyParentProperty(true)]
		[Description("The offset of the control")]
		[Browsable(true)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[DefaultValue(0)]
		public int InnerOffset
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x04000259 RID: 601
		[CompilerGenerated]
		private CustomRadioButton customRadioButton_0;

		// Token: 0x0400025A RID: 602
		private Color color_0;

		// Token: 0x0400025B RID: 603
		private Color color_1;

		// Token: 0x0400025C RID: 604
		private int int_0;

		// Token: 0x0400025D RID: 605
		private Color color_2;

		// Token: 0x0400025E RID: 606
		private int int_1;
	}
}
