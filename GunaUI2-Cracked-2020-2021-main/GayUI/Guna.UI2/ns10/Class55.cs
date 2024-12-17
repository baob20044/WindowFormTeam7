using System;
using System.IO;
using Guna.UI2.HtmlRenderer.Adapters;
using Guna.UI2.HtmlRenderer.Adapters.Entities;

namespace ns10
{
	// Token: 0x0200010D RID: 269
	internal sealed class Class55 : RAdapter
	{
		// Token: 0x0600126C RID: 4716 RVA: 0x00002427 File Offset: 0x00000627
		private Class55()
		{
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x0600126D RID: 4717 RVA: 0x00002131 File Offset: 0x00000331
		public static Class55 Class55_0
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x00003C2C File Offset: 0x00001E2C
		protected override RColor GetColorInt(string colorName)
		{
			return default(RColor);
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x00002131 File Offset: 0x00000331
		protected override RPen CreatePen(RColor color)
		{
			return null;
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x00002131 File Offset: 0x00000331
		protected override RBrush CreateSolidBrush(RColor color)
		{
			return null;
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x00002131 File Offset: 0x00000331
		protected override RBrush CreateLinearGradientBrush(RRect rect, RColor color1, RColor color2, double angle)
		{
			return null;
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x00002131 File Offset: 0x00000331
		protected override RImage ConvertImageInt(object image)
		{
			return null;
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x00002131 File Offset: 0x00000331
		protected override RImage ImageFromStreamInt(Stream memoryStream)
		{
			return null;
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x00002131 File Offset: 0x00000331
		protected override RFont CreateFontInt(string family, double size, RFontStyle style)
		{
			return null;
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x00002131 File Offset: 0x00000331
		protected override RFont CreateFontInt(RFontFamily family, double size, RFontStyle style)
		{
			return null;
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x00002131 File Offset: 0x00000331
		protected override object GetClipboardDataObjectInt(string html, string plainText)
		{
			return null;
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x00002134 File Offset: 0x00000334
		protected override void SetToClipboardInt(string text)
		{
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x00002134 File Offset: 0x00000334
		protected override void SetToClipboardInt(string html, string plainText)
		{
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x00002134 File Offset: 0x00000334
		protected override void SetToClipboardInt(RImage image)
		{
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x00002131 File Offset: 0x00000331
		protected override RContextMenu CreateContextMenuInt()
		{
			return null;
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x00002134 File Offset: 0x00000334
		protected override void SaveToFileInt(RImage image, string name, string extension, RControl control = null)
		{
		}

		// Token: 0x040006F4 RID: 1780
		private static readonly Class55 class55_0 = new Class55();
	}
}
