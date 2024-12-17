using System;

namespace Guna.UI2.HtmlRenderer.Adapters
{
	// Token: 0x02000159 RID: 345
	public abstract class RImage : IDisposable
	{
		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x06001646 RID: 5702
		public abstract double Width { get; }

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x06001647 RID: 5703
		public abstract double Height { get; }

		// Token: 0x06001648 RID: 5704
		public abstract void Dispose();
	}
}
