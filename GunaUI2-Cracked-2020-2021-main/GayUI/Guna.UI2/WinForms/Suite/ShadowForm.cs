using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x020000BB RID: 187
	public partial class ShadowForm : Form
	{
		// Token: 0x06000F94 RID: 3988
		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr GetDC(IntPtr hWnd);

		// Token: 0x06000F95 RID: 3989
		[DllImport("Gdi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr CreateCompatibleDC(IntPtr hDC);

		// Token: 0x06000F96 RID: 3990
		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern bool UpdateLayeredWindow(IntPtr hwnd, IntPtr hdcDst, ref Point pptDst, ref Size psize, IntPtr hdcSrc, ref Point pprSrc, int crKey, ref ShadowForm.BLENDFUNCTION pblend, int dwFlags);

		// Token: 0x06000F97 RID: 3991
		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

		// Token: 0x06000F98 RID: 3992
		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr GetForegroundWindow();

		// Token: 0x06000F99 RID: 3993
		[DllImport("Gdi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObject);

		// Token: 0x06000F9A RID: 3994
		[DllImport("Gdi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern bool DeleteObject(IntPtr hObject);

		// Token: 0x06000F9B RID: 3995
		[DllImport("Gdi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern bool DeleteDC(IntPtr hdc);

		// Token: 0x06000F9C RID: 3996
		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, ShadowForm.SetWindowPosFlags uFlags);

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06000F9D RID: 3997 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000F9E RID: 3998 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("The curve angle of the control on all angles")]
		[DefaultValue(12)]
		public int BorderRadius
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06000F9F RID: 3999 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000FA0 RID: 4000 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The shadow color")]
		[DefaultValue(typeof(Color), "Black")]
		[Browsable(true)]
		public Color ShadowColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x0000215F File Offset: 0x0000035F
		public ShadowForm(Form form)
		{
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0(object sender, FormClosedEventArgs e)
		{
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06000FA4 RID: 4004 RVA: 0x00002131 File Offset: 0x00000331
		protected override CreateParams CreateParams
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x00002134 File Offset: 0x00000334
		private void method_1()
		{
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x00002134 File Offset: 0x00000334
		private void method_2(object sender, EventArgs e)
		{
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x00002134 File Offset: 0x00000334
		private void method_3(object sender, EventArgs e)
		{
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x00002134 File Offset: 0x00000334
		private void method_4(object sender, EventArgs e)
		{
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x00002134 File Offset: 0x00000334
		private void method_5(object sender, EventArgs e)
		{
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x00002134 File Offset: 0x00000334
		private void method_7(object sender, EventArgs e)
		{
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x00002134 File Offset: 0x00000334
		private void method_8(object sender, EventArgs e)
		{
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x00002134 File Offset: 0x00000334
		private void method_9(object sender, EventArgs e)
		{
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x00002134 File Offset: 0x00000334
		private void method_10(object sender, EventArgs e)
		{
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x00002134 File Offset: 0x00000334
		private void method_11(object sender, EventArgs e)
		{
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x00002134 File Offset: 0x00000334
		private void method_12(object sender, EventArgs e)
		{
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x00002131 File Offset: 0x00000331
		private GraphicsPath method_13(Rectangle r, int radius, ShadowForm.Corners corners)
		{
			return null;
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x00002134 File Offset: 0x00000334
		private void method_14()
		{
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x00002134 File Offset: 0x00000334
		private void method_15(Bitmap bmp, int int_1)
		{
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x00002134 File Offset: 0x00000334
		private void method_16()
		{
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x00002134 File Offset: 0x00000334
		[CompilerGenerated]
		private void method_6(object object_1)
		{
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x00002134 File Offset: 0x00000334
		private void method_17(object sender, FormClosedEventArgs e)
		{
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x00002134 File Offset: 0x00000334
		private void method_18()
		{
		}

		// Token: 0x04000436 RID: 1078
		private int int_0;

		// Token: 0x04000437 RID: 1079
		private Color color_0;

		// Token: 0x04000438 RID: 1080
		private int int_1;

		// Token: 0x04000439 RID: 1081
		private bool bool_0;

		// Token: 0x0400043A RID: 1082
		private IntPtr intptr_0;

		// Token: 0x0400043B RID: 1083
		private Form form_0;

		// Token: 0x0400043C RID: 1084
		private bool bool_1;

		// Token: 0x0400043D RID: 1085
		private bool bool_2;

		// Token: 0x0400043E RID: 1086
		private bool bool_3;

		// Token: 0x0400043F RID: 1087
		private bool bool_4;

		// Token: 0x04000440 RID: 1088
		private int int_2;

		// Token: 0x04000441 RID: 1089
		private bool bool_5;

		// Token: 0x04000442 RID: 1090
		private IContainer icontainer_0;

		// Token: 0x020000BC RID: 188
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		public struct BLENDFUNCTION
		{
			// Token: 0x04000443 RID: 1091
			public byte BlendOp;

			// Token: 0x04000444 RID: 1092
			public byte BlendFlags;

			// Token: 0x04000445 RID: 1093
			public byte SourceConstantAlpha;

			// Token: 0x04000446 RID: 1094
			public byte AlphaFormat;
		}

		// Token: 0x020000BD RID: 189
		[Flags]
		public enum Corners
		{
			// Token: 0x04000448 RID: 1096
			None = 0,
			// Token: 0x04000449 RID: 1097
			TopLeft = 1,
			// Token: 0x0400044A RID: 1098
			TopRight = 2,
			// Token: 0x0400044B RID: 1099
			BottomLeft = 4,
			// Token: 0x0400044C RID: 1100
			BottomRight = 8,
			// Token: 0x0400044D RID: 1101
			All = 15
		}

		// Token: 0x020000BE RID: 190
		[Flags]
		public enum SetWindowPosFlags : uint
		{
			// Token: 0x0400044F RID: 1103
			SWP_ASYNCWINDOWPOS = 16384u,
			// Token: 0x04000450 RID: 1104
			SWP_DEFERERASE = 8192u,
			// Token: 0x04000451 RID: 1105
			SWP_DRAWFRAME = 32u,
			// Token: 0x04000452 RID: 1106
			SWP_FRAMECHANGED = 32u,
			// Token: 0x04000453 RID: 1107
			SWP_HIDEWINDOW = 128u,
			// Token: 0x04000454 RID: 1108
			SWP_NOACTIVATE = 16u,
			// Token: 0x04000455 RID: 1109
			SWP_NOCOPYBITS = 256u,
			// Token: 0x04000456 RID: 1110
			SWP_NOMOVE = 2u,
			// Token: 0x04000457 RID: 1111
			SWP_NOOWNERZORDER = 512u,
			// Token: 0x04000458 RID: 1112
			SWP_NOREDRAW = 8u,
			// Token: 0x04000459 RID: 1113
			SWP_NOREPOSITION = 512u,
			// Token: 0x0400045A RID: 1114
			SWP_NOSENDCHANGING = 1024u,
			// Token: 0x0400045B RID: 1115
			SWP_NOSIZE = 1u,
			// Token: 0x0400045C RID: 1116
			SWP_NOZORDER = 4u,
			// Token: 0x0400045D RID: 1117
			SWP_SHOWWINDOW = 64u
		}
	}
}
