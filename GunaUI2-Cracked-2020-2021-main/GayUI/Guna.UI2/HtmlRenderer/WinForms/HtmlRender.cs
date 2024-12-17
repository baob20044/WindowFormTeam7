using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using Guna.UI2.HtmlRenderer.Core;
using Guna.UI2.HtmlRenderer.Core.Entities;

namespace Guna.UI2.HtmlRenderer.WinForms
{
	// Token: 0x020000FC RID: 252
	public static class HtmlRender
	{
		// Token: 0x060011D6 RID: 4566 RVA: 0x00002134 File Offset: 0x00000334
		public static void AddFontFamily(FontFamily fontFamily)
		{
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x00002134 File Offset: 0x00000334
		public static void AddFontFamilyMapping(string fromFamily, string toFamily)
		{
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x00002131 File Offset: 0x00000331
		public static CssData ParseStyleSheet(string stylesheet, bool combineWithDefault = true)
		{
			return null;
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x00003BCC File Offset: 0x00001DCC
		public static SizeF Measure(Graphics g, string html, float maxWidth = 0f, CssData cssData = null, EventHandler<HtmlStylesheetLoadEventArgs> stylesheetLoad = null, EventHandler<HtmlImageLoadEventArgs> imageLoad = null)
		{
			return default(SizeF);
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x00003BCC File Offset: 0x00001DCC
		public static SizeF MeasureGdiPlus(Graphics g, string html, float maxWidth = 0f, CssData cssData = null, EventHandler<HtmlStylesheetLoadEventArgs> stylesheetLoad = null, EventHandler<HtmlImageLoadEventArgs> imageLoad = null)
		{
			return default(SizeF);
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x00003BCC File Offset: 0x00001DCC
		public static SizeF Render(Graphics g, string html, float left = 0f, float top = 0f, float maxWidth = 0f, CssData cssData = null, EventHandler<HtmlStylesheetLoadEventArgs> stylesheetLoad = null, EventHandler<HtmlImageLoadEventArgs> imageLoad = null)
		{
			return default(SizeF);
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x00003BCC File Offset: 0x00001DCC
		public static SizeF Render(Graphics g, string html, PointF location, SizeF maxSize, CssData cssData = null, EventHandler<HtmlStylesheetLoadEventArgs> stylesheetLoad = null, EventHandler<HtmlImageLoadEventArgs> imageLoad = null)
		{
			return default(SizeF);
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x00003BCC File Offset: 0x00001DCC
		public static SizeF RenderGdiPlus(Graphics g, string html, float left = 0f, float top = 0f, float maxWidth = 0f, CssData cssData = null, EventHandler<HtmlStylesheetLoadEventArgs> stylesheetLoad = null, EventHandler<HtmlImageLoadEventArgs> imageLoad = null)
		{
			return default(SizeF);
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x00003BCC File Offset: 0x00001DCC
		public static SizeF RenderGdiPlus(Graphics g, string html, PointF location, SizeF maxSize, CssData cssData = null, EventHandler<HtmlStylesheetLoadEventArgs> stylesheetLoad = null, EventHandler<HtmlImageLoadEventArgs> imageLoad = null)
		{
			return default(SizeF);
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x00002131 File Offset: 0x00000331
		public static Metafile RenderToMetafile(string html, float left = 0f, float top = 0f, float maxWidth = 0f, CssData cssData = null, EventHandler<HtmlStylesheetLoadEventArgs> stylesheetLoad = null, EventHandler<HtmlImageLoadEventArgs> imageLoad = null)
		{
			return null;
		}

		// Token: 0x060011E0 RID: 4576 RVA: 0x00002134 File Offset: 0x00000334
		public static void RenderToImage(Image image, string html, PointF location = default(PointF), CssData cssData = null, EventHandler<HtmlStylesheetLoadEventArgs> stylesheetLoad = null, EventHandler<HtmlImageLoadEventArgs> imageLoad = null)
		{
		}

		// Token: 0x060011E1 RID: 4577 RVA: 0x00002134 File Offset: 0x00000334
		public static void RenderToImage(Image image, string html, PointF location, SizeF maxSize, CssData cssData = null, EventHandler<HtmlStylesheetLoadEventArgs> stylesheetLoad = null, EventHandler<HtmlImageLoadEventArgs> imageLoad = null)
		{
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x00002131 File Offset: 0x00000331
		public static Image RenderToImage(string html, Size size, Color backgroundColor = default(Color), CssData cssData = null, EventHandler<HtmlStylesheetLoadEventArgs> stylesheetLoad = null, EventHandler<HtmlImageLoadEventArgs> imageLoad = null)
		{
			return null;
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x00002131 File Offset: 0x00000331
		public static Image RenderToImage(string html, int maxWidth = 0, int maxHeight = 0, Color backgroundColor = default(Color), CssData cssData = null, EventHandler<HtmlStylesheetLoadEventArgs> stylesheetLoad = null, EventHandler<HtmlImageLoadEventArgs> imageLoad = null)
		{
			return null;
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x00002131 File Offset: 0x00000331
		public static Image RenderToImage(string html, Size minSize, Size maxSize, Color backgroundColor = default(Color), CssData cssData = null, EventHandler<HtmlStylesheetLoadEventArgs> stylesheetLoad = null, EventHandler<HtmlImageLoadEventArgs> imageLoad = null)
		{
			return null;
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x00002131 File Offset: 0x00000331
		public static Image RenderToImageGdiPlus(string html, Size size, TextRenderingHint textRenderingHint = TextRenderingHint.AntiAlias, CssData cssData = null, EventHandler<HtmlStylesheetLoadEventArgs> stylesheetLoad = null, EventHandler<HtmlImageLoadEventArgs> imageLoad = null)
		{
			return null;
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x00002131 File Offset: 0x00000331
		public static Image RenderToImageGdiPlus(string html, int maxWidth = 0, int maxHeight = 0, TextRenderingHint textRenderingHint = TextRenderingHint.AntiAlias, CssData cssData = null, EventHandler<HtmlStylesheetLoadEventArgs> stylesheetLoad = null, EventHandler<HtmlImageLoadEventArgs> imageLoad = null)
		{
			return null;
		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x00002131 File Offset: 0x00000331
		public static Image RenderToImageGdiPlus(string html, Size minSize, Size maxSize, TextRenderingHint textRenderingHint = TextRenderingHint.AntiAlias, CssData cssData = null, EventHandler<HtmlStylesheetLoadEventArgs> stylesheetLoad = null, EventHandler<HtmlImageLoadEventArgs> imageLoad = null)
		{
			return null;
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x00003BCC File Offset: 0x00001DCC
		private static SizeF smethod_0(Graphics g, string html, float maxWidth, CssData cssData, bool useGdiPlusTextRendering, EventHandler<HtmlStylesheetLoadEventArgs> stylesheetLoad, EventHandler<HtmlImageLoadEventArgs> imageLoad)
		{
			return default(SizeF);
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x00003364 File Offset: 0x00001564
		private static Size smethod_1(HtmlContainer htmlContainer, Size minSize, Size maxSize)
		{
			return default(Size);
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x00003BCC File Offset: 0x00001DCC
		private static SizeF smethod_2(Graphics g, string html, PointF location, SizeF maxSize, CssData cssData, bool useGdiPlusTextRendering, EventHandler<HtmlStylesheetLoadEventArgs> stylesheetLoad, EventHandler<HtmlImageLoadEventArgs> imageLoad)
		{
			return default(SizeF);
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x00003BCC File Offset: 0x00001DCC
		private static SizeF smethod_3(Graphics g, string html, PointF location, SizeF maxSize, CssData cssData, bool useGdiPlusTextRendering, EventHandler<HtmlStylesheetLoadEventArgs> stylesheetLoad, EventHandler<HtmlImageLoadEventArgs> imageLoad)
		{
			return default(SizeF);
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x00002134 File Offset: 0x00000334
		private static void smethod_4(IntPtr memoryHdc, Image image)
		{
		}
	}
}
