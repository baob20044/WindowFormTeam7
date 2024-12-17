using System;
using Guna.UI2.HtmlRenderer.Adapters.Entities;

namespace Guna.UI2.HtmlRenderer.Adapters
{
	// Token: 0x02000152 RID: 338
	public abstract class RContextMenu : IDisposable
	{
		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x0600160D RID: 5645
		public abstract int ItemsCount { get; }

		// Token: 0x0600160E RID: 5646
		public abstract void AddDivider();

		// Token: 0x0600160F RID: 5647
		public abstract void AddItem(string text, bool enabled, EventHandler onClick);

		// Token: 0x06001610 RID: 5648
		public abstract void RemoveLastDivider();

		// Token: 0x06001611 RID: 5649
		public abstract void Show(RControl parent, RPoint location);

		// Token: 0x06001612 RID: 5650
		public abstract void Dispose();
	}
}
