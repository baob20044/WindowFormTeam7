using System;
using Guna.UI2.HtmlRenderer.Adapters.Entities;

namespace Guna.UI2.HtmlRenderer.Adapters
{
	// Token: 0x0200015A RID: 346
	public abstract class RPen
	{
		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x0600164A RID: 5706
		// (set) Token: 0x0600164B RID: 5707
		public abstract double Width { get; set; }

		// Token: 0x17000747 RID: 1863
		// (set) Token: 0x0600164C RID: 5708
		public abstract RDashStyle DashStyle { set; }
	}
}
