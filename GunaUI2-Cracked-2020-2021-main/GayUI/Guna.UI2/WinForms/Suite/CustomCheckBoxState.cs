using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x02000094 RID: 148
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[Description("An abstract class used to define various states within Guna CheckBox.")]
	[DebuggerStepThrough]
	public class CustomCheckBoxState
	{
		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000A59 RID: 2649 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000A5A RID: 2650 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		public CustomCheckBox Parent
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

		// Token: 0x06000A5B RID: 2651 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0()
		{
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x00002131 File Offset: 0x00000331
		public override string ToString()
		{
			return null;
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000A5D RID: 2653 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000A5E RID: 2654 RVA: 0x00002134 File Offset: 0x00000334
		[NotifyParentProperty(true)]
		[Browsable(true)]
		[Description("Allows you to apply fill color of your checkbox by setting the color value.")]
		[EditorBrowsable(EditorBrowsableState.Always)]
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

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000A5F RID: 2655 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000A60 RID: 2656 RVA: 0x00002134 File Offset: 0x00000334
		[NotifyParentProperty(true)]
		[Browsable(true)]
		[DefaultValue(typeof(Color), "")]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Description("Allows you to set the checkbox border color.")]
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

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000A61 RID: 2657 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000A62 RID: 2658 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(int), "")]
		[Description("Allows you to set the border radius of your checkbox hence defines the roundness of your checkbox.")]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[NotifyParentProperty(true)]
		[Browsable(true)]
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

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000A63 RID: 2659 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000A64 RID: 2660 RVA: 0x00002134 File Offset: 0x00000334
		[NotifyParentProperty(true)]
		[Browsable(true)]
		[Description("Allows you to set the border thickness of your checkbox.")]
		[DefaultValue(typeof(int), "")]
		[EditorBrowsable(EditorBrowsableState.Always)]
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

		// Token: 0x04000254 RID: 596
		[CompilerGenerated]
		private CustomCheckBox customCheckBox_0;

		// Token: 0x04000255 RID: 597
		private Color color_0;

		// Token: 0x04000256 RID: 598
		private Color color_1;

		// Token: 0x04000257 RID: 599
		private int int_0;

		// Token: 0x04000258 RID: 600
		private int int_1;
	}
}
