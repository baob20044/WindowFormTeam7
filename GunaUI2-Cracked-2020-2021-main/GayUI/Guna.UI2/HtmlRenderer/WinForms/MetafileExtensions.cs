using System;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Guna.UI2.HtmlRenderer.WinForms
{
	// Token: 0x020000FD RID: 253
	public static class MetafileExtensions
	{
		// Token: 0x060011ED RID: 4589 RVA: 0x00002134 File Offset: 0x00000334
		public static void SaveAsEmf(Metafile me, string fileName)
		{
		}

		// Token: 0x060011EE RID: 4590
		[DllImport("gdi32")]
		public static extern int GetEnhMetaFileBits(int hemf, int cbBuffer, byte[] lpbBuffer);

		// Token: 0x060011EF RID: 4591
		[DllImport("gdi32")]
		public static extern bool DeleteEnhMetaFile(int hemfbitHandle);
	}
}
