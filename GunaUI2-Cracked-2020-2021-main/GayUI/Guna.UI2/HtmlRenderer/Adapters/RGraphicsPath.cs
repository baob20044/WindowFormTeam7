using System;

namespace Guna.UI2.HtmlRenderer.Adapters
{
	// Token: 0x02000157 RID: 343
	public abstract class RGraphicsPath : IDisposable
	{
		// Token: 0x06001641 RID: 5697
		public abstract void Start(double x, double y);

		// Token: 0x06001642 RID: 5698
		public abstract void LineTo(double x, double y);

		// Token: 0x06001643 RID: 5699
		public abstract void ArcTo(double x, double y, double size, RGraphicsPath.Corner corner);

		// Token: 0x06001644 RID: 5700
		public abstract void Dispose();

		// Token: 0x02000158 RID: 344
		public enum Corner
		{
			// Token: 0x040008EE RID: 2286
			TopLeft,
			// Token: 0x040008EF RID: 2287
			TopRight,
			// Token: 0x040008F0 RID: 2288
			BottomLeft,
			// Token: 0x040008F1 RID: 2289
			BottomRight
		}
	}
}
