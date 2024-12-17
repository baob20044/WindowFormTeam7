using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms.Enums;
using Microsoft.VisualBasic;

namespace Guna.UI2.WinForms.Helpers
{
	// Token: 0x02000087 RID: 135
	public static class GraphicsHelper
	{
		// Token: 0x060009D7 RID: 2519 RVA: 0x00002131 File Offset: 0x00000331
		public static Image RotateImage(Image image, float rotationAngle)
		{
			return null;
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x00002131 File Offset: 0x00000331
		public static Image FlipRotateImage(Image image, FlipOrientation flipOrientation, float rotationAngle)
		{
			return null;
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x00002131 File Offset: 0x00000331
		public static Image FlipImage(Image image, FlipOrientation flipOrientation)
		{
			return null;
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x000032EC File Offset: 0x000014EC
		public static Color GetColorScale(int passentage, Color color1, Color color2)
		{
			return default(Color);
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x00002131 File Offset: 0x00000331
		public static Image ImageResizer(Image imgToResize, Rectangle maxOffset)
		{
			return null;
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x00002131 File Offset: 0x00000331
		public static Image ImageColorOverlay(Image image, Color oldColor, Color newColor)
		{
			return null;
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x00002134 File Offset: 0x00000334
		internal static void smethod_0(Graphics graphics, Image image, Rectangle dest, Color oldColor, Color newColor)
		{
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x00002134 File Offset: 0x00000334
		public static void DrawTransparent(Control control, Graphics graphics)
		{
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x00002134 File Offset: 0x00000334
		public static void DrawLineShadow(Control control, Color shadowColor, int shadowDepth, int shadowSize, VerHorAlign shadowAlign, AddOrRemove handler = AddOrRemove.Add)
		{
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x00002134 File Offset: 0x00000334
		public static void DrawLineShadow(Graphics graphics, Color shadowColor, Rectangle bounds, int shadowDepth, int shadowSize, VerHorAlign shadowAlign)
		{
		}

		// Token: 0x0400021E RID: 542
		private static Collection collection_0 = new Collection();

		// Token: 0x02000088 RID: 136
		private class Class8
		{
			// Token: 0x060009E2 RID: 2530 RVA: 0x00002134 File Offset: 0x00000334
			public void method_0()
			{
			}

			// Token: 0x060009E3 RID: 2531 RVA: 0x00002134 File Offset: 0x00000334
			public void method_1()
			{
			}

			// Token: 0x060009E4 RID: 2532 RVA: 0x00002134 File Offset: 0x00000334
			private void method_2(object sender, PaintEventArgs e)
			{
			}

			// Token: 0x0400021F RID: 543
			public Control control_0;

			// Token: 0x04000220 RID: 544
			public Color color_0;

			// Token: 0x04000221 RID: 545
			public int int_0;

			// Token: 0x04000222 RID: 546
			public int int_1;

			// Token: 0x04000223 RID: 547
			public VerHorAlign verHorAlign_0;
		}
	}
}
