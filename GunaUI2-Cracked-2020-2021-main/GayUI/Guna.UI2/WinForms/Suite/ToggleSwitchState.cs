using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x0200009A RID: 154
	[DebuggerStepThrough]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[Description("ToggleSwitchState")]
	public class ToggleSwitchState
	{
		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000AA8 RID: 2728 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000AA9 RID: 2729 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		public ToggleSwitch Parent
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

		// Token: 0x06000AAA RID: 2730 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0()
		{
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x00002131 File Offset: 0x00000331
		public override string ToString()
		{
			return null;
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000AAC RID: 2732 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000AAD RID: 2733 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Description("The toggle switch fill color")]
		[DefaultValue(typeof(Color), "")]
		[NotifyParentProperty(true)]
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

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000AAE RID: 2734 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000AAF RID: 2735 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(typeof(Color), "")]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Description("The toggle switch border color")]
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

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000AB0 RID: 2736 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000AB1 RID: 2737 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "")]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Description("The toggle switch inner color")]
		[Browsable(true)]
		[NotifyParentProperty(true)]
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

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000AB2 RID: 2738 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000AB3 RID: 2739 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "")]
		[Description("The toggle switch inner border color")]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Browsable(true)]
		[NotifyParentProperty(true)]
		public Color InnerBorderColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000AB5 RID: 2741 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The toggle switch border radius")]
		[DefaultValue(9)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Browsable(true)]
		[NotifyParentProperty(true)]
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

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000AB6 RID: 2742 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000AB7 RID: 2743 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Description("The toggle switch border thickness")]
		[NotifyParentProperty(true)]
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

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000AB8 RID: 2744 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000AB9 RID: 2745 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The toggle switch innder border radius")]
		[Browsable(true)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[NotifyParentProperty(true)]
		[DefaultValue(5)]
		public int InnerBorderRadius
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000ABA RID: 2746 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000ABB RID: 2747 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(0)]
		[Description("The toggle switch innder border thickness")]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[NotifyParentProperty(true)]
		[Browsable(true)]
		public int InnerBorderThickness
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000ABD RID: 2749 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(0)]
		[NotifyParentProperty(true)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Browsable(true)]
		[Description("The toggle switch inner offset")]
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

		// Token: 0x04000274 RID: 628
		[CompilerGenerated]
		private ToggleSwitch toggleSwitch_0;

		// Token: 0x04000275 RID: 629
		private Color color_0;

		// Token: 0x04000276 RID: 630
		private Color color_1;

		// Token: 0x04000277 RID: 631
		private Color color_2;

		// Token: 0x04000278 RID: 632
		private Color color_3;

		// Token: 0x04000279 RID: 633
		private int int_0;

		// Token: 0x0400027A RID: 634
		private int int_1;

		// Token: 0x0400027B RID: 635
		private int int_2;

		// Token: 0x0400027C RID: 636
		private int int_3;

		// Token: 0x0400027D RID: 637
		private int int_4;
	}
}
