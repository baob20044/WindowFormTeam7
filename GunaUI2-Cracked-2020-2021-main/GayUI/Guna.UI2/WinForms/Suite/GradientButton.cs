using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x020000A0 RID: 160
	public class GradientButton : CustomButtonBase
	{
		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06000B2F RID: 2863 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000B30 RID: 2864 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Description("Style the control's border sides.")]
		public CustomizableEdges CustomizableEdges
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06000B31 RID: 2865 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000B32 RID: 2866 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Allows animated GIF Image.")]
		[DefaultValue(false)]
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

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000B33 RID: 2867 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000B34 RID: 2868 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000B35 RID: 2869 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected ButtonImages DefaultCustomImages
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000B36 RID: 2870 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected GradientButtonState DefaultHoverState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000B37 RID: 2871 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected GradientButtonState DefaultCheckedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x0000331C File Offset: 0x0000151C
		// (set) Token: 0x06000B39 RID: 2873 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected LinearGradientMode DefaultGradientMode
		{
			get
			{
				return LinearGradientMode.Horizontal;
			}
			set
			{
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06000B3A RID: 2874 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000B3B RID: 2875 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Color DefaultFillColor2
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_7()
		{
			return default(Color);
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_8()
		{
			return default(Color);
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_9()
		{
			return default(Color);
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_10()
		{
			return default(Color);
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_11()
		{
			return default(Color);
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_12()
		{
			return default(Color);
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_13()
		{
			return default(Color);
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x00002131 File Offset: 0x00000331
		private Font method_14()
		{
			return null;
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x00002131 File Offset: 0x00000331
		private Image method_15()
		{
			return null;
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_16()
		{
			return default(Color);
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_17()
		{
			return default(Color);
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_18()
		{
			return default(Color);
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x00002131 File Offset: 0x00000331
		private Font method_19()
		{
			return null;
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x00002131 File Offset: 0x00000331
		private Image method_20()
		{
			return null;
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x00002131 File Offset: 0x00000331
		private Image method_21()
		{
			return null;
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x00002131 File Offset: 0x00000331
		private Image method_22()
		{
			return null;
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x00002131 File Offset: 0x00000331
		private Bitmap method_23()
		{
			return null;
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x00002134 File Offset: 0x00000334
		private void method_24(Graphics g)
		{
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x00002134 File Offset: 0x00000334
		private void method_25(Graphics G)
		{
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x040002A0 RID: 672
		private int int_3;

		// Token: 0x040002A1 RID: 673
		private GraphicsPath graphicsPath_0;

		// Token: 0x040002A2 RID: 674
		private CustomizableEdges customizableEdges_0;

		// Token: 0x040002A3 RID: 675
		private bool bool_6;

		// Token: 0x040002A4 RID: 676
		private bool bool_7;

		// Token: 0x040002A5 RID: 677
		private ButtonImages buttonImages_0;

		// Token: 0x040002A6 RID: 678
		private GradientButtonState gradientButtonState_0;

		// Token: 0x040002A7 RID: 679
		private GradientButtonState gradientButtonState_1;

		// Token: 0x040002A8 RID: 680
		private LinearGradientMode linearGradientMode_0;

		// Token: 0x040002A9 RID: 681
		private Color color_5;
	}
}
