using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x0200009F RID: 159
	public class CircleButton : CustomButtonBase
	{
		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000B13 RID: 2835 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000B14 RID: 2836 RVA: 0x00002134 File Offset: 0x00000334
		protected bool DefaultIndicateFocus
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000B16 RID: 2838 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(false)]
		[Description("Allows animated GIF Image.")]
		public bool AnimatedGIF
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected ButtonImages DefaultCustomImages
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000B18 RID: 2840 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected ButtonState DefaultHoverState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000B19 RID: 2841 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected ButtonState DefaultCheckedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_7()
		{
			return default(Color);
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_8()
		{
			return default(Color);
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_9()
		{
			return default(Color);
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_10()
		{
			return default(Color);
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x00002131 File Offset: 0x00000331
		private Font method_11()
		{
			return null;
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x00002131 File Offset: 0x00000331
		private Image method_12()
		{
			return null;
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_13()
		{
			return default(Color);
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_14()
		{
			return default(Color);
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_15()
		{
			return default(Color);
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_16()
		{
			return default(Color);
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x00002131 File Offset: 0x00000331
		private Font method_17()
		{
			return null;
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x00002131 File Offset: 0x00000331
		private Image method_18()
		{
			return null;
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x00002131 File Offset: 0x00000331
		private Image method_19()
		{
			return null;
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x00002131 File Offset: 0x00000331
		private Image method_20()
		{
			return null;
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x00002131 File Offset: 0x00000331
		private Bitmap method_21()
		{
			return null;
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x00002134 File Offset: 0x00000334
		private void method_22(Graphics g)
		{
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x00002134 File Offset: 0x00000334
		private void method_23(Graphics G)
		{
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x0400029A RID: 666
		private GraphicsPath graphicsPath_0;

		// Token: 0x0400029B RID: 667
		private bool bool_6;

		// Token: 0x0400029C RID: 668
		private bool bool_7;

		// Token: 0x0400029D RID: 669
		private ButtonImages buttonImages_0;

		// Token: 0x0400029E RID: 670
		private ButtonState buttonState_0;

		// Token: 0x0400029F RID: 671
		private ButtonState buttonState_1;
	}
}
