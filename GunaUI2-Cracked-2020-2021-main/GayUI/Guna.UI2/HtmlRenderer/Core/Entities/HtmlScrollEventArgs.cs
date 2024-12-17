using System;
using Guna.UI2.HtmlRenderer.Adapters.Entities;

namespace Guna.UI2.HtmlRenderer.Core.Entities
{
	// Token: 0x0200013A RID: 314
	public sealed class HtmlScrollEventArgs : EventArgs
	{
		// Token: 0x06001425 RID: 5157 RVA: 0x00002337 File Offset: 0x00000537
		public HtmlScrollEventArgs(RPoint location)
		{
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06001426 RID: 5158 RVA: 0x00002154 File Offset: 0x00000354
		public double X
		{
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06001427 RID: 5159 RVA: 0x00002154 File Offset: 0x00000354
		public double Y
		{
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x00002131 File Offset: 0x00000331
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000823 RID: 2083
		private readonly RPoint rpoint_0;
	}
}
