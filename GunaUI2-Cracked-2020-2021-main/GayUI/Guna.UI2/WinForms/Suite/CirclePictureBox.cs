using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms.Enums;
using Guna.UI2.WinForms.Interfaces;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x020000A3 RID: 163
	[ToolboxItem(false)]
	public class CirclePictureBox : PictureBox, IControl
	{
		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000B78 RID: 2936 RVA: 0x00002136 File Offset: 0x00000336
		[Browsable(false)]
		[Description("Gets a value that indicates whether the Component is currently in design mode.")]
		public bool IsDesignMode
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06000B7A RID: 2938 RVA: 0x00002145 File Offset: 0x00000345
		// (set) Token: 0x06000B7B RID: 2939 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(float), "0")]
		[Browsable(true)]
		[Description("Sets the angle of rotation for the image. Please provide a value between 0 and 360.")]
		public float ImageRotate
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06000B7C RID: 2940 RVA: 0x0000334C File Offset: 0x0000154C
		// (set) Token: 0x06000B7D RID: 2941 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Flips the image to any given orientation. Supports both Vertical  and Horizontal orientation-flipping options.")]
		[Browsable(true)]
		[DefaultValue(0)]
		public FlipOrientation ImageFlip
		{
			get
			{
				return FlipOrientation.Normal;
			}
			set
			{
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000B7E RID: 2942 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000B7F RID: 2943 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected ShadowDecoration DefaultShadowDecoration
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000B80 RID: 2944 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000B81 RID: 2945 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		protected Color DefaultFillColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000B82 RID: 2946 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000B83 RID: 2947 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected bool DefaultUseTransparentBackground
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0()
		{
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaintBackground(PaintEventArgs e)
		{
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x00002131 File Offset: 0x00000331
		private Bitmap method_1()
		{
			return null;
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x040002B3 RID: 691
		private float float_0;

		// Token: 0x040002B4 RID: 692
		private FlipOrientation flipOrientation_0;

		// Token: 0x040002B5 RID: 693
		private ShadowDecoration shadowDecoration_0;

		// Token: 0x040002B6 RID: 694
		private Color color_0;

		// Token: 0x040002B7 RID: 695
		private bool bool_0;

		// Token: 0x040002B8 RID: 696
		private Graphics graphics_0;
	}
}
