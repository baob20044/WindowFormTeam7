using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Guna.UI2.WinForms
{
	// Token: 0x0200006E RID: 110
	[ToolboxItem(true)]
	[ToolboxBitmap(typeof(Panel))]
	[DebuggerStepThrough]
	[Description("A ShadowPanel Control")]
	public class Guna2ShadowPanel : Panel
	{
		// Token: 0x06000835 RID: 2101 RVA: 0x00002131 File Offset: 0x00000331
		private GraphicsPath method_0(Rectangle rect, int radius)
		{
			return null;
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x00002131 File Offset: 0x00000331
		private GraphicsPath method_1(Rectangle rect, int radius, bool dropStyle)
		{
			return null;
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x00002131 File Offset: 0x00000331
		private GraphicsPath method_2(Graphics G, Brush rectBrush, Rectangle rect, int radius)
		{
			return null;
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00002131 File Offset: 0x00000331
		private GraphicsPath method_3(Graphics G, Pen pen, Rectangle rect, int radius)
		{
			return null;
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000839 RID: 2105 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600083A RID: 2106 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The begin gradient color.")]
		public Color FillColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x0600083B RID: 2107 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600083C RID: 2108 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(0)]
		[Description("The width of an edge.")]
		public int EdgeWidth
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600083E RID: 2110 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The corner round radius.")]
		[DefaultValue(0)]
		public int Radius
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000840 RID: 2112 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The shadow color.")]
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

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000841 RID: 2113 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000842 RID: 2114 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The shadow depth color.")]
		[DefaultValue(100)]
		public int ShadowDepth
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000843 RID: 2115 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000844 RID: 2116 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(5)]
		[Description("The shadow shift.")]
		public int ShadowShift
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000845 RID: 2117 RVA: 0x00003A08 File Offset: 0x00001C08
		// (set) Token: 0x06000846 RID: 2118 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Style of the shadow.")]
		[DefaultValue(1)]
		public Guna2ShadowPanel.ShadowMode ShadowStyle
		{
			get
			{
				return Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
			}
			set
			{
			}
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x00002134 File Offset: 0x00000334
		private void method_4(Graphics g, ref Rectangle edgeRect)
		{
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x00002134 File Offset: 0x00000334
		private void method_5(Graphics g, Rectangle rect)
		{
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x00002134 File Offset: 0x00000334
		private void method_6(Graphics graphics, Rectangle rect)
		{
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00002134 File Offset: 0x00000334
		private void method_7(Graphics graphics, Rectangle rect)
		{
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00002134 File Offset: 0x00000334
		private void method_8(Graphics graphics, Rectangle rect)
		{
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x00002134 File Offset: 0x00000334
		private void method_9(Graphics graphics)
		{
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x0400019D RID: 413
		private Color color_0;

		// Token: 0x0400019E RID: 414
		private int int_0;

		// Token: 0x0400019F RID: 415
		private int int_1;

		// Token: 0x040001A0 RID: 416
		private int int_2;

		// Token: 0x040001A1 RID: 417
		private Color color_1;

		// Token: 0x040001A2 RID: 418
		private const int int_3 = 10;

		// Token: 0x040001A3 RID: 419
		private int int_4;

		// Token: 0x040001A4 RID: 420
		private Color color_2;

		// Token: 0x040001A5 RID: 421
		private Guna2ShadowPanel.ShadowMode shadowMode_0;

		// Token: 0x0200006F RID: 111
		public enum ShadowMode
		{
			// Token: 0x040001A7 RID: 423
			ForwardDiagonal,
			// Token: 0x040001A8 RID: 424
			Surrounded,
			// Token: 0x040001A9 RID: 425
			Dropped
		}
	}
}
