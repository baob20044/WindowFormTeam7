using System;
using System.Drawing;
using Guna.UI2.HtmlRenderer.Adapters;
using Guna.UI2.HtmlRenderer.Adapters.Entities;

namespace Guna.UI2.HtmlRenderer.WinForms.Adapters
{
	// Token: 0x02000109 RID: 265
	public sealed class GraphicsAdapter : RGraphics
	{
		// Token: 0x0600123F RID: 4671 RVA: 0x00003C5C File Offset: 0x00001E5C
		static GraphicsAdapter()
		{
			砍.砍_0(GraphicsAdapter.stringFormat_0, StringFormatFlags.MeasureTrailingSpaces | StringFormatFlags.NoClip);
			GraphicsAdapter.stringFormat_1 = new StringFormat(砌.砌_0());
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x00003CCC File Offset: 0x00001ECC
		public GraphicsAdapter(Graphics g, bool useGdiPlusTextRendering, bool releaseGraphics = false) : base(null, default(RRect))
		{
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x00002134 File Offset: 0x00000334
		public override void PopClip()
		{
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x00002134 File Offset: 0x00000334
		public override void PushClip(RRect rect)
		{
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x00002134 File Offset: 0x00000334
		public override void PushClipExclude(RRect rect)
		{
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x00002131 File Offset: 0x00000331
		public override object SetAntiAliasSmoothingMode()
		{
			return null;
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x00002134 File Offset: 0x00000334
		public override void ReturnPreviousSmoothingMode(object prevMode)
		{
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x00003BFC File Offset: 0x00001DFC
		public override RSize MeasureString(string str, RFont font)
		{
			return default(RSize);
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x00002134 File Offset: 0x00000334
		public override void MeasureString(string str, RFont font, double maxWidth, out int charFit, out double charFitWidth)
		{
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x00002134 File Offset: 0x00000334
		public override void DrawString(string str, RFont font, RColor color, RPoint point, RSize size, bool rtl)
		{
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x00002131 File Offset: 0x00000331
		public override RBrush GetTextureBrush(RImage image, RRect dstRect, RPoint translateTransformLocation)
		{
			return null;
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x00002131 File Offset: 0x00000331
		public override RGraphicsPath GetGraphicsPath()
		{
			return null;
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x00002134 File Offset: 0x00000334
		public override void Dispose()
		{
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x00002134 File Offset: 0x00000334
		public override void DrawLine(RPen pen, double x1, double y1, double x2, double y2)
		{
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x00002134 File Offset: 0x00000334
		public override void DrawRectangle(RPen pen, double x, double y, double width, double height)
		{
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x00002134 File Offset: 0x00000334
		public override void DrawRectangle(RBrush brush, double x, double y, double width, double height)
		{
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x00002134 File Offset: 0x00000334
		public override void DrawImage(RImage image, RRect destRect, RRect srcRect)
		{
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x00002134 File Offset: 0x00000334
		public override void DrawImage(RImage image, RRect destRect)
		{
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x00002134 File Offset: 0x00000334
		public override void DrawPath(RPen pen, RGraphicsPath path)
		{
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x00002134 File Offset: 0x00000334
		public override void DrawPath(RBrush brush, RGraphicsPath path)
		{
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x00002134 File Offset: 0x00000334
		public override void DrawPolygon(RBrush brush, RPoint[] points)
		{
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0()
		{
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x00002134 File Offset: 0x00000334
		private void method_1()
		{
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x00002134 File Offset: 0x00000334
		private void method_2(RFont font)
		{
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x00002134 File Offset: 0x00000334
		private void method_3(Color color)
		{
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x00002134 File Offset: 0x00000334
		private void method_4(bool rtl)
		{
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x00002134 File Offset: 0x00000334
		private static void smethod_0(IntPtr hdc, string str, RFont font, Point point, Size size, Color color)
		{
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x00002134 File Offset: 0x00000334
		private void method_5(bool rtl)
		{
		}

		// Token: 0x040006E6 RID: 1766
		private static readonly int[] int_0 = new int[1];

		// Token: 0x040006E7 RID: 1767
		private static readonly int[] int_1 = new int[1000];

		// Token: 0x040006E8 RID: 1768
		private static readonly CharacterRange[] characterRange_0 = new CharacterRange[1];

		// Token: 0x040006E9 RID: 1769
		private static readonly StringFormat stringFormat_0 = new StringFormat(砌.砌_0());

		// Token: 0x040006EA RID: 1770
		private static readonly StringFormat stringFormat_1;

		// Token: 0x040006EB RID: 1771
		private readonly Graphics graphics_0;

		// Token: 0x040006EC RID: 1772
		private readonly bool bool_0;

		// Token: 0x040006ED RID: 1773
		private IntPtr intptr_0;

		// Token: 0x040006EE RID: 1774
		private readonly bool bool_1;

		// Token: 0x040006EF RID: 1775
		private bool bool_2;
	}
}
