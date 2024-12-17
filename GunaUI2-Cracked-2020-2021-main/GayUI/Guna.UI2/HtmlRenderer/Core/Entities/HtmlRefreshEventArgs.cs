using System;

namespace Guna.UI2.HtmlRenderer.Core.Entities
{
	// Token: 0x02000137 RID: 311
	public sealed class HtmlRefreshEventArgs : EventArgs
	{
		// Token: 0x0600141D RID: 5149 RVA: 0x00002337 File Offset: 0x00000537
		public HtmlRefreshEventArgs(bool layout)
		{
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x0600141E RID: 5150 RVA: 0x00002136 File Offset: 0x00000336
		public bool Layout
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600141F RID: 5151 RVA: 0x00002131 File Offset: 0x00000331
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000815 RID: 2069
		private readonly bool bool_0;
	}
}
