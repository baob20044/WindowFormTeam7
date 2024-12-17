using System;
using System.Collections.Generic;
using System.IO;
using Guna.UI2.HtmlRenderer.Adapters.Entities;
using Guna.UI2.HtmlRenderer.Core;
using ns8;

namespace Guna.UI2.HtmlRenderer.Adapters
{
	// Token: 0x02000150 RID: 336
	public abstract class RAdapter
	{
		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x060015E8 RID: 5608 RVA: 0x00002131 File Offset: 0x00000331
		public CssData DefaultCssData
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x00003C2C File Offset: 0x00001E2C
		public RColor GetColor(string colorName)
		{
			return default(RColor);
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x00002131 File Offset: 0x00000331
		public RPen GetPen(RColor color)
		{
			return null;
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x00002131 File Offset: 0x00000331
		public RBrush GetSolidBrush(RColor color)
		{
			return null;
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x00002131 File Offset: 0x00000331
		public RBrush GetLinearGradientBrush(RRect rect, RColor color1, RColor color2, double angle)
		{
			return null;
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x00002131 File Offset: 0x00000331
		public RImage ConvertImage(object image)
		{
			return null;
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x00002131 File Offset: 0x00000331
		public RImage ImageFromStream(Stream memoryStream)
		{
			return null;
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x00002136 File Offset: 0x00000336
		public bool IsFontExists(string font)
		{
			return false;
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x00002134 File Offset: 0x00000334
		public void AddFontFamily(RFontFamily fontFamily)
		{
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x00002134 File Offset: 0x00000334
		public void AddFontFamilyMapping(string fromFamily, string toFamily)
		{
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x00002131 File Offset: 0x00000331
		public RFont GetFont(string family, double size, RFontStyle style)
		{
			return null;
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x00002131 File Offset: 0x00000331
		public RImage GetLoadingImage()
		{
			return null;
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x00002131 File Offset: 0x00000331
		public RImage GetLoadingFailedImage()
		{
			return null;
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x00002131 File Offset: 0x00000331
		public object GetClipboardDataObject(string html, string plainText)
		{
			return null;
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x00002134 File Offset: 0x00000334
		public void SetToClipboard(string text)
		{
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x00002134 File Offset: 0x00000334
		public void SetToClipboard(string html, string plainText)
		{
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x00002134 File Offset: 0x00000334
		public void SetToClipboard(RImage image)
		{
		}

		// Token: 0x060015F9 RID: 5625 RVA: 0x00002131 File Offset: 0x00000331
		public RContextMenu GetContextMenu()
		{
			return null;
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x00002134 File Offset: 0x00000334
		public void SaveToFile(RImage image, string name, string extension, RControl control = null)
		{
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x00002131 File Offset: 0x00000331
		internal RFont method_0(string family, double size, RFontStyle style)
		{
			return null;
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x00002131 File Offset: 0x00000331
		internal RFont method_1(RFontFamily family, double size, RFontStyle style)
		{
			return null;
		}

		// Token: 0x060015FD RID: 5629
		protected abstract RColor GetColorInt(string colorName);

		// Token: 0x060015FE RID: 5630
		protected abstract RPen CreatePen(RColor color);

		// Token: 0x060015FF RID: 5631
		protected abstract RBrush CreateSolidBrush(RColor color);

		// Token: 0x06001600 RID: 5632
		protected abstract RBrush CreateLinearGradientBrush(RRect rect, RColor color1, RColor color2, double angle);

		// Token: 0x06001601 RID: 5633
		protected abstract RImage ConvertImageInt(object image);

		// Token: 0x06001602 RID: 5634
		protected abstract RImage ImageFromStreamInt(Stream memoryStream);

		// Token: 0x06001603 RID: 5635
		protected abstract RFont CreateFontInt(string family, double size, RFontStyle style);

		// Token: 0x06001604 RID: 5636
		protected abstract RFont CreateFontInt(RFontFamily family, double size, RFontStyle style);

		// Token: 0x06001605 RID: 5637 RVA: 0x00002131 File Offset: 0x00000331
		protected virtual object GetClipboardDataObjectInt(string html, string plainText)
		{
			return null;
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x00002131 File Offset: 0x00000331
		protected virtual void SetToClipboardInt(string text)
		{
			null;
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x00002131 File Offset: 0x00000331
		protected virtual void SetToClipboardInt(string html, string plainText)
		{
			null;
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x00002131 File Offset: 0x00000331
		protected virtual void SetToClipboardInt(RImage image)
		{
			null;
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x00002131 File Offset: 0x00000331
		protected virtual RContextMenu CreateContextMenuInt()
		{
			return null;
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x00002131 File Offset: 0x00000331
		protected virtual void SaveToFileInt(RImage image, string name, string extension, RControl control = null)
		{
			null;
		}

		// Token: 0x040008E3 RID: 2275
		private readonly Dictionary<RColor, RBrush> dictionary_0;

		// Token: 0x040008E4 RID: 2276
		private readonly Dictionary<RColor, RPen> dictionary_1;

		// Token: 0x040008E5 RID: 2277
		private readonly Class34 class34_0;

		// Token: 0x040008E6 RID: 2278
		private CssData cssData_0;

		// Token: 0x040008E7 RID: 2279
		private RImage rimage_0;

		// Token: 0x040008E8 RID: 2280
		private RImage rimage_1;
	}
}
