using System;
using Guna.UI2.HtmlRenderer.Adapters.Entities;

namespace Guna.UI2.HtmlRenderer.Adapters
{
	// Token: 0x02000153 RID: 339
	public abstract class RControl
	{
		// Token: 0x06001614 RID: 5652 RVA: 0x00002167 File Offset: 0x00000367
		protected RControl(RAdapter adapter)
		{
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x06001615 RID: 5653 RVA: 0x00002131 File Offset: 0x00000331
		public RAdapter Adapter
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x06001616 RID: 5654
		public abstract bool LeftMouseButton { get; }

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x06001617 RID: 5655
		public abstract bool RightMouseButton { get; }

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06001618 RID: 5656
		public abstract RPoint MouseLocation { get; }

		// Token: 0x06001619 RID: 5657
		public abstract void SetCursorDefault();

		// Token: 0x0600161A RID: 5658
		public abstract void SetCursorHand();

		// Token: 0x0600161B RID: 5659
		public abstract void SetCursorIBeam();

		// Token: 0x0600161C RID: 5660
		public abstract void DoDragDropCopy(object dragDropData);

		// Token: 0x0600161D RID: 5661
		public abstract void MeasureString(string str, RFont font, double maxWidth, out int charFit, out double charFitWidth);

		// Token: 0x0600161E RID: 5662
		public abstract void Invalidate();

		// Token: 0x040008E9 RID: 2281
		private readonly RAdapter radapter_0;
	}
}
