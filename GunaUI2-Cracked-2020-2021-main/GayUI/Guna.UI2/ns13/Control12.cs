using System;
using System.ComponentModel;
using System.Windows.Forms;
using Guna.UI2.AnimatorNS;

namespace ns13
{
	// Token: 0x02000191 RID: 401
	[ToolboxItem(false)]
	internal class Control12 : TabControl
	{
		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06001843 RID: 6211 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06001844 RID: 6212 RVA: 0x00002134 File Offset: 0x00000334
		[TypeConverter(typeof(ExpandableObjectConverter))]
		public Animation Animation_0
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x06001845 RID: 6213 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnSelecting(TabControlCancelEventArgs e)
		{
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x00002134 File Offset: 0x00000334
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0()
		{
		}

		// Token: 0x04000A70 RID: 2672
		private Animator animator_0;

		// Token: 0x04000A71 RID: 2673
		private IContainer icontainer_0;
	}
}
