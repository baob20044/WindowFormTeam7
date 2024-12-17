using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x02000098 RID: 152
	[Description("You can choose which edges will be included when styling the border radius")]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[DebuggerStepThrough]
	public class CustomizableEdges
	{
		// Token: 0x06000A93 RID: 2707 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0()
		{
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x00002131 File Offset: 0x00000331
		public override string ToString()
		{
			return null;
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000A96 RID: 2710 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(true)]
		public bool TopLeft
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000A98 RID: 2712 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(true)]
		public bool TopRight
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000A9A RID: 2714 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(true)]
		public bool BottomLeft
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000A9C RID: 2716 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(true)]
		public bool BottomRight
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x0400026B RID: 619
		internal Control control_0;

		// Token: 0x0400026C RID: 620
		private bool bool_0;

		// Token: 0x0400026D RID: 621
		private bool bool_1;

		// Token: 0x0400026E RID: 622
		private bool bool_2;

		// Token: 0x0400026F RID: 623
		private bool bool_3;
	}
}
