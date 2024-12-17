using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x02000093 RID: 147
	[Description("ControlBoxState")]
	[DebuggerStepThrough]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class ControlBoxState
	{
		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000A4E RID: 2638 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000A4F RID: 2639 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		public ControlBox Parent
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

		// Token: 0x06000A50 RID: 2640 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0()
		{
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x00002131 File Offset: 0x00000331
		public override string ToString()
		{
			return null;
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000A52 RID: 2642 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000A53 RID: 2643 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(typeof(Color), "")]
		[NotifyParentProperty(true)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Description("The fill color")]
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

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000A54 RID: 2644 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000A55 RID: 2645 RVA: 0x00002134 File Offset: 0x00000334
		[NotifyParentProperty(true)]
		[Browsable(true)]
		[Description("The icon color")]
		[DefaultValue(typeof(Color), "")]
		[EditorBrowsable(EditorBrowsableState.Always)]
		public Color IconColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000A56 RID: 2646 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000A57 RID: 2647 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Always)]
		[DefaultValue(typeof(Color), "")]
		[Description("The color of the border")]
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

		// Token: 0x04000250 RID: 592
		[CompilerGenerated]
		private ControlBox controlBox_0;

		// Token: 0x04000251 RID: 593
		private Color color_0;

		// Token: 0x04000252 RID: 594
		private Color color_1;

		// Token: 0x04000253 RID: 595
		private Color color_2;
	}
}
