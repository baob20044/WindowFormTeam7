using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x020000A2 RID: 162
	[ToolboxItem(false)]
	public class GradientCircleButton : CustomButtonBase
	{
		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06000B56 RID: 2902 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000B57 RID: 2903 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06000B58 RID: 2904 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000B59 RID: 2905 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06000B5A RID: 2906 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected ButtonImages DefaultCustomImages
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06000B5B RID: 2907 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected GradientButtonState DefaultHoverState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000B5C RID: 2908 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected GradientButtonState DefaultCheckedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000B5D RID: 2909 RVA: 0x0000331C File Offset: 0x0000151C
		// (set) Token: 0x06000B5E RID: 2910 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06000B5F RID: 2911 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000B60 RID: 2912 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06000B61 RID: 2913 RVA: 0x00003A94 File Offset: 0x00001C94
		private StringAlignment method_7(HorizontalAlignment e)
		{
			return StringAlignment.Near;
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_8()
		{
			return default(Color);
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_9()
		{
			return default(Color);
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_10()
		{
			return default(Color);
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_11()
		{
			return default(Color);
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_12()
		{
			return default(Color);
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_13()
		{
			return default(Color);
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_14()
		{
			return default(Color);
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x00002131 File Offset: 0x00000331
		private Font method_15()
		{
			return null;
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x00002131 File Offset: 0x00000331
		private Image method_16()
		{
			return null;
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_17()
		{
			return default(Color);
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_18()
		{
			return default(Color);
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_19()
		{
			return default(Color);
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x00002131 File Offset: 0x00000331
		private Font method_20()
		{
			return null;
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x00002131 File Offset: 0x00000331
		private Image method_21()
		{
			return null;
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x00002131 File Offset: 0x00000331
		private Image method_22()
		{
			return null;
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x00002131 File Offset: 0x00000331
		private Image method_23()
		{
			return null;
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x00002131 File Offset: 0x00000331
		private Bitmap method_24()
		{
			return null;
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x00002134 File Offset: 0x00000334
		private void method_25(Graphics g)
		{
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x00002134 File Offset: 0x00000334
		private void method_26(Graphics G)
		{
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x040002AB RID: 683
		private GraphicsPath graphicsPath_0;

		// Token: 0x040002AC RID: 684
		private bool bool_6;

		// Token: 0x040002AD RID: 685
		private bool bool_7;

		// Token: 0x040002AE RID: 686
		private ButtonImages buttonImages_0;

		// Token: 0x040002AF RID: 687
		private GradientButtonState gradientButtonState_0;

		// Token: 0x040002B0 RID: 688
		private GradientButtonState gradientButtonState_1;

		// Token: 0x040002B1 RID: 689
		private LinearGradientMode linearGradientMode_0;

		// Token: 0x040002B2 RID: 690
		private Color color_5;
	}
}
