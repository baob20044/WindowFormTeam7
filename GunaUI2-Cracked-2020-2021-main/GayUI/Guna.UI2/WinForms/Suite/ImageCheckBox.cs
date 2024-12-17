using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.WinForms.Enums;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x020000B2 RID: 178
	[ToolboxItem(false)]
	[DefaultEvent("CheckedChanged")]
	public class ImageCheckBox : UIDefaultControl
	{
		// Token: 0x14000031 RID: 49
		// (add) Token: 0x06000E33 RID: 3635 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000E34 RID: 3636 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler CheckedChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected virtual void OnCheckedChanged(EventArgs e)
		{
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06000E36 RID: 3638 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000E37 RID: 3639 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06000E38 RID: 3640 RVA: 0x00002145 File Offset: 0x00000345
		// (set) Token: 0x06000E39 RID: 3641 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(float), "0")]
		[Description("Sets the angle of rotation for the image. Please provide a value between 0 and 360.")]
		[Browsable(true)]
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

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06000E3A RID: 3642 RVA: 0x0000334C File Offset: 0x0000154C
		// (set) Token: 0x06000E3B RID: 3643 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Flips the image to any given orientation. Supports both Vertical  and Horizontal orientation-flipping options.")]
		[DefaultValue(0)]
		[Browsable(true)]
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

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06000E3C RID: 3644 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected ImageControlState DefaultHoverState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06000E3D RID: 3645 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected ImageControlState DefaultCheckedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06000E3E RID: 3646 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected ImageControlState DefaultPressedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06000E3F RID: 3647 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000E40 RID: 3648 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected bool DefaultChecked
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06000E41 RID: 3649 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000E42 RID: 3650 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Image DefaultImage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06000E43 RID: 3651 RVA: 0x00003364 File Offset: 0x00001564
		// (set) Token: 0x06000E44 RID: 3652 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Size DefaultImageSize
		{
			get
			{
				return default(Size);
			}
			set
			{
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06000E45 RID: 3653 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x06000E46 RID: 3654 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Point DefaultImageOffset
		{
			get
			{
				return default(Point);
			}
			set
			{
			}
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnClick(EventArgs e)
		{
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x00002131 File Offset: 0x00000331
		private Image method_1()
		{
			return null;
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x00003364 File Offset: 0x00001564
		private Size method_2()
		{
			return default(Size);
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x0000337C File Offset: 0x0000157C
		private Point method_3()
		{
			return default(Point);
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x00002131 File Offset: 0x00000331
		private Image method_4()
		{
			return null;
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x00003364 File Offset: 0x00001564
		private Size method_5()
		{
			return default(Size);
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x0000337C File Offset: 0x0000157C
		private Point method_6()
		{
			return default(Point);
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x00002131 File Offset: 0x00000331
		private Image method_7()
		{
			return null;
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x00003364 File Offset: 0x00001564
		private Size method_8()
		{
			return default(Size);
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x0000337C File Offset: 0x0000157C
		private Point method_9()
		{
			return default(Point);
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x00002134 File Offset: 0x00000334
		private void method_10(Graphics G)
		{
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x040003AF RID: 943
		private bool bool_5;

		// Token: 0x040003B0 RID: 944
		private Image image_0;

		// Token: 0x040003B1 RID: 945
		private Size size_0;

		// Token: 0x040003B2 RID: 946
		private Point point_0;

		// Token: 0x040003B4 RID: 948
		private bool bool_6;

		// Token: 0x040003B5 RID: 949
		private float float_0;

		// Token: 0x040003B6 RID: 950
		private FlipOrientation flipOrientation_0;

		// Token: 0x040003B7 RID: 951
		private ImageControlState imageControlState_0;

		// Token: 0x040003B8 RID: 952
		private ImageControlState imageControlState_1;

		// Token: 0x040003B9 RID: 953
		private ImageControlState imageControlState_2;
	}
}
