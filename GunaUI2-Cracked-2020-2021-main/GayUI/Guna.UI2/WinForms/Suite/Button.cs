using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x0200009E RID: 158
	public class Button : CustomButtonBase
	{
		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000AF5 RID: 2805 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000AF6 RID: 2806 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06000AF7 RID: 2807 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000AF8 RID: 2808 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Style the control's border sides.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(true)]
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

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06000AF9 RID: 2809 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected ButtonImages DefaultCustomImages
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000AFA RID: 2810 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected ButtonState DefaultHoverState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000AFB RID: 2811 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected ButtonState DefaultCheckedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000AFC RID: 2812 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000AFD RID: 2813 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06000AFE RID: 2814 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_7()
		{
			return default(Color);
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_8()
		{
			return default(Color);
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_9()
		{
			return default(Color);
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_10()
		{
			return default(Color);
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x00002131 File Offset: 0x00000331
		private Font method_11()
		{
			return null;
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x00002131 File Offset: 0x00000331
		private Image method_12()
		{
			return null;
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_13()
		{
			return default(Color);
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_14()
		{
			return default(Color);
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_15()
		{
			return default(Color);
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_16()
		{
			return default(Color);
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x00002131 File Offset: 0x00000331
		private Font method_17()
		{
			return null;
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x00002131 File Offset: 0x00000331
		private Image method_18()
		{
			return null;
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x00002131 File Offset: 0x00000331
		private Image method_19()
		{
			return null;
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x00002131 File Offset: 0x00000331
		private Image method_20()
		{
			return null;
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x00002131 File Offset: 0x00000331
		private Bitmap method_21()
		{
			return null;
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x00002134 File Offset: 0x00000334
		private void method_22(Graphics g)
		{
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x00002134 File Offset: 0x00000334
		private void method_23(Graphics G)
		{
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x04000293 RID: 659
		private GraphicsPath graphicsPath_0;

		// Token: 0x04000294 RID: 660
		private CustomizableEdges customizableEdges_0;

		// Token: 0x04000295 RID: 661
		private bool bool_6;

		// Token: 0x04000296 RID: 662
		private ButtonImages buttonImages_0;

		// Token: 0x04000297 RID: 663
		private ButtonState buttonState_0;

		// Token: 0x04000298 RID: 664
		private ButtonState buttonState_1;

		// Token: 0x04000299 RID: 665
		private bool bool_7;
	}
}
