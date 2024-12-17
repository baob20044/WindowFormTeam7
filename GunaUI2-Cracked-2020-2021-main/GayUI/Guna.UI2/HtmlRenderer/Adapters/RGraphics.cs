using System;
using System.Collections.Generic;
using Guna.UI2.HtmlRenderer.Adapters.Entities;

namespace Guna.UI2.HtmlRenderer.Adapters
{
	// Token: 0x02000156 RID: 342
	public abstract class RGraphics : IDisposable
	{
		// Token: 0x06001627 RID: 5671 RVA: 0x00002167 File Offset: 0x00000367
		protected RGraphics(RAdapter adapter, RRect initialClip)
		{
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x00002131 File Offset: 0x00000331
		public RPen GetPen(RColor color)
		{
			return null;
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x00002131 File Offset: 0x00000331
		public RBrush GetSolidBrush(RColor color)
		{
			return null;
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x00002131 File Offset: 0x00000331
		public RBrush GetLinearGradientBrush(RRect rect, RColor color1, RColor color2, double angle)
		{
			return null;
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x00003C14 File Offset: 0x00001E14
		public RRect GetClip()
		{
			return default(RRect);
		}

		// Token: 0x0600162C RID: 5676
		public abstract void PopClip();

		// Token: 0x0600162D RID: 5677
		public abstract void PushClip(RRect rect);

		// Token: 0x0600162E RID: 5678
		public abstract void PushClipExclude(RRect rect);

		// Token: 0x0600162F RID: 5679 RVA: 0x00002134 File Offset: 0x00000334
		public void SuspendClipping()
		{
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x00002134 File Offset: 0x00000334
		public void ResumeClipping()
		{
		}

		// Token: 0x06001631 RID: 5681
		public abstract object SetAntiAliasSmoothingMode();

		// Token: 0x06001632 RID: 5682
		public abstract void ReturnPreviousSmoothingMode(object prevMode);

		// Token: 0x06001633 RID: 5683
		public abstract RBrush GetTextureBrush(RImage image, RRect dstRect, RPoint translateTransformLocation);

		// Token: 0x06001634 RID: 5684
		public abstract RGraphicsPath GetGraphicsPath();

		// Token: 0x06001635 RID: 5685
		public abstract RSize MeasureString(string str, RFont font);

		// Token: 0x06001636 RID: 5686
		public abstract void MeasureString(string str, RFont font, double maxWidth, out int charFit, out double charFitWidth);

		// Token: 0x06001637 RID: 5687
		public abstract void DrawString(string str, RFont font, RColor color, RPoint point, RSize size, bool rtl);

		// Token: 0x06001638 RID: 5688
		public abstract void DrawLine(RPen pen, double x1, double y1, double x2, double y2);

		// Token: 0x06001639 RID: 5689
		public abstract void DrawRectangle(RPen pen, double x, double y, double width, double height);

		// Token: 0x0600163A RID: 5690
		public abstract void DrawRectangle(RBrush brush, double x, double y, double width, double height);

		// Token: 0x0600163B RID: 5691
		public abstract void DrawImage(RImage image, RRect destRect, RRect srcRect);

		// Token: 0x0600163C RID: 5692
		public abstract void DrawImage(RImage image, RRect destRect);

		// Token: 0x0600163D RID: 5693
		public abstract void DrawPath(RPen pen, RGraphicsPath path);

		// Token: 0x0600163E RID: 5694
		public abstract void DrawPath(RBrush brush, RGraphicsPath path);

		// Token: 0x0600163F RID: 5695
		public abstract void DrawPolygon(RBrush brush, RPoint[] points);

		// Token: 0x06001640 RID: 5696
		public abstract void Dispose();

		// Token: 0x040008EA RID: 2282
		protected readonly RAdapter _adapter;

		// Token: 0x040008EB RID: 2283
		protected readonly Stack<RRect> _clipStack;

		// Token: 0x040008EC RID: 2284
		private Stack<RRect> stack_0;
	}
}
