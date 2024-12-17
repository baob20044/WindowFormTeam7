using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace ns4
{
	// Token: 0x02000100 RID: 256
	internal static class Class16
	{
		// Token: 0x06001203 RID: 4611
		[DllImport("user32.dll")]
		public static extern int SetCursor(int hCursor);

		// Token: 0x06001204 RID: 4612
		[DllImport("user32.dll")]
		public static extern int LoadCursor(int hInstance, int lpCursorName);

		// Token: 0x06001205 RID: 4613 RVA: 0x00003C44 File Offset: 0x00001E44
		public static IntPtr smethod_0(IntPtr hdc, int width, int height, out IntPtr dib)
		{
			return 0;
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x00002134 File Offset: 0x00000334
		public static void smethod_1(IntPtr memoryHdc, IntPtr dib)
		{
		}

		// Token: 0x06001207 RID: 4615
		[DllImport("user32.dll")]
		public static extern bool IsWindowVisible(IntPtr hWnd);

		// Token: 0x06001208 RID: 4616
		[DllImport("user32.dll")]
		public static extern IntPtr WindowFromDC(IntPtr hdc);

		// Token: 0x06001209 RID: 4617
		[DllImport("User32", SetLastError = true)]
		public static extern int GetWindowRect(IntPtr hWnd, out Rectangle lpRect);

		// Token: 0x0600120A RID: 4618 RVA: 0x0000343C File Offset: 0x0000163C
		public static Rectangle smethod_2(IntPtr handle)
		{
			return default(Rectangle);
		}

		// Token: 0x0600120B RID: 4619
		[DllImport("User32.dll")]
		public static extern bool MoveWindow(IntPtr handle, int x, int y, int width, int height, bool redraw);

		// Token: 0x0600120C RID: 4620
		[DllImport("gdi32.dll")]
		public static extern int SetTextAlign(IntPtr hdc, uint fMode);

		// Token: 0x0600120D RID: 4621
		[DllImport("gdi32.dll")]
		public static extern int SetBkMode(IntPtr hdc, int mode);

		// Token: 0x0600120E RID: 4622
		[DllImport("gdi32.dll")]
		public static extern IntPtr SelectObject(IntPtr hdc, IntPtr hgdiObj);

		// Token: 0x0600120F RID: 4623
		[DllImport("gdi32.dll")]
		public static extern uint SetTextColor(IntPtr hdc, int color);

		// Token: 0x06001210 RID: 4624
		[DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
		public static extern bool GetTextMetrics(IntPtr hdc, out Struct2 lptm);

		// Token: 0x06001211 RID: 4625
		[DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
		public static extern int GetTextExtentPoint32W(IntPtr hdc, [MarshalAs(UnmanagedType.LPWStr)] string str, int len, ref Size size);

		// Token: 0x06001212 RID: 4626
		[DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
		public static extern bool GetTextExtentExPointW(IntPtr hDc, [MarshalAs(UnmanagedType.LPWStr)] string str, int nLength, int nMaxExtent, int[] lpnFit, int[] alpDx, ref Size size);

		// Token: 0x06001213 RID: 4627
		[DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
		public static extern bool TextOutW(IntPtr hdc, int x, int y, [MarshalAs(UnmanagedType.LPWStr)] string str, int len);

		// Token: 0x06001214 RID: 4628
		[DllImport("gdi32.dll")]
		public static extern IntPtr CreateRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);

		// Token: 0x06001215 RID: 4629
		[DllImport("gdi32.dll")]
		public static extern int GetClipBox(IntPtr hdc, out Rectangle lprc);

		// Token: 0x06001216 RID: 4630
		[DllImport("gdi32.dll")]
		public static extern int SelectClipRgn(IntPtr hdc, IntPtr hrgn);

		// Token: 0x06001217 RID: 4631
		[DllImport("gdi32.dll")]
		public static extern bool DeleteObject(IntPtr hObject);

		// Token: 0x06001218 RID: 4632
		[DllImport("gdi32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool BitBlt(IntPtr hdc, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, uint dwRop);

		// Token: 0x06001219 RID: 4633
		[DllImport("gdi32.dll")]
		public static extern bool GdiAlphaBlend(IntPtr hdcDest, int nXOriginDest, int nYOriginDest, int nWidthDest, int nHeightDest, IntPtr hdcSrc, int nXOriginSrc, int nYOriginSrc, int nWidthSrc, int nHeightSrc, Struct0 blendFunction);

		// Token: 0x0600121A RID: 4634
		[DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern bool DeleteDC(IntPtr hdc);

		// Token: 0x0600121B RID: 4635
		[DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr CreateCompatibleDC(IntPtr hdc);

		// Token: 0x0600121C RID: 4636
		[DllImport("gdi32.dll")]
		public static extern IntPtr CreateDIBSection(IntPtr hdc, [In] ref Struct1 pbmi, uint iUsage, out IntPtr ppvBits, IntPtr hSection, uint dwOffset);

		// Token: 0x040006AA RID: 1706
		public const int int_0 = 8388608;

		// Token: 0x040006AB RID: 1707
		public const int int_1 = 512;

		// Token: 0x040006AC RID: 1708
		public const int int_2 = 13369376;

		// Token: 0x040006AD RID: 1709
		public const int int_3 = 15597702;

		// Token: 0x040006AE RID: 1710
		public const int int_4 = 32;

		// Token: 0x040006AF RID: 1711
		public const int int_5 = 32649;

		// Token: 0x040006B0 RID: 1712
		public const int int_6 = 0;

		// Token: 0x040006B1 RID: 1713
		public const int int_7 = 256;

		// Token: 0x040006B2 RID: 1714
		public const int int_8 = 24;

		// Token: 0x040006B3 RID: 1715
		public const int int_9 = 280;
	}
}
