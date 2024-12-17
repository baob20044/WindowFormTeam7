using System;

namespace Guna.UI2.HtmlRenderer.Adapters
{
	// Token: 0x02000154 RID: 340
	public abstract class RFont
	{
		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x0600161F RID: 5663
		public abstract double Size { get; }

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x06001620 RID: 5664
		public abstract double Height { get; }

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x06001621 RID: 5665
		public abstract double UnderlineOffset { get; }

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x06001622 RID: 5666
		public abstract double LeftPadding { get; }

		// Token: 0x06001623 RID: 5667
		public abstract double GetWhitespaceWidth(RGraphics graphics);
	}
}
