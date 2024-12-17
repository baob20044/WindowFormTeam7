using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms.Enums;
using Guna.UI2.WinForms.Interfaces;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x020000B6 RID: 182
	[ToolboxItem(false)]
	public class PictureBox : PictureBox, IControl
	{
		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06000EE2 RID: 3810 RVA: 0x00002136 File Offset: 0x00000336
		[Description("Gets a value that indicates whether the Component is currently in design mode.")]
		[Browsable(false)]
		public bool IsDesignMode
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06000EE4 RID: 3812 RVA: 0x00002145 File Offset: 0x00000345
		// (set) Token: 0x06000EE5 RID: 3813 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Sets the angle of rotation for the image. Please provide a value between 0 and 360.")]
		[Browsable(true)]
		[DefaultValue(typeof(float), "0")]
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

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06000EE6 RID: 3814 RVA: 0x0000334C File Offset: 0x0000154C
		// (set) Token: 0x06000EE7 RID: 3815 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("Flips the image to any given orientation. Supports both Vertical  and Horizontal orientation-flipping options.")]
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

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06000EE8 RID: 3816 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000EE9 RID: 3817 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06000EEA RID: 3818 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000EEB RID: 3819 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected int DefaultBorderRadius
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06000EEC RID: 3820 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000EED RID: 3821 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
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

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06000EEE RID: 3822 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000EEF RID: 3823 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06000EF0 RID: 3824 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0(Graphics G)
		{
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaintBackground(PaintEventArgs e)
		{
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x00002131 File Offset: 0x00000331
		private Bitmap method_1()
		{
			return null;
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06000EF3 RID: 3827 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000EF4 RID: 3828 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Style the control's border sides.")]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
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

		// Token: 0x06000EF5 RID: 3829 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x040003E7 RID: 999
		private ShadowDecoration shadowDecoration_0;

		// Token: 0x040003E8 RID: 1000
		private int int_0;

		// Token: 0x040003E9 RID: 1001
		private Color color_0;

		// Token: 0x040003EA RID: 1002
		private float float_0;

		// Token: 0x040003EB RID: 1003
		private FlipOrientation flipOrientation_0;

		// Token: 0x040003EC RID: 1004
		private bool bool_0;

		// Token: 0x040003ED RID: 1005
		private CustomizableEdges customizableEdges_0;
	}
}
