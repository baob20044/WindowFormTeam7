using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.WinForms.Enums;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x020000B3 RID: 179
	[DefaultEvent("CheckedChanged")]
	[ToolboxItem(false)]
	public class ImageRadioButton : UIDefaultControl
	{
		// Token: 0x06000E54 RID: 3668 RVA: 0x00002134 File Offset: 0x00000334
		private void method_1()
		{
		}

		// Token: 0x14000032 RID: 50
		// (add) Token: 0x06000E55 RID: 3669 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000E56 RID: 3670 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06000E57 RID: 3671 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected virtual void OnCheckedChanged(EventArgs e)
		{
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06000E58 RID: 3672 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000E59 RID: 3673 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06000E5A RID: 3674 RVA: 0x00002145 File Offset: 0x00000345
		// (set) Token: 0x06000E5B RID: 3675 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06000E5C RID: 3676 RVA: 0x0000334C File Offset: 0x0000154C
		// (set) Token: 0x06000E5D RID: 3677 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06000E5E RID: 3678 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected ImageControlState DefaultHoverState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06000E5F RID: 3679 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected ImageControlState DefaultCheckedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06000E60 RID: 3680 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected ImageControlState DefaultPressedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06000E61 RID: 3681 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000E62 RID: 3682 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06000E63 RID: 3683 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000E64 RID: 3684 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06000E65 RID: 3685 RVA: 0x00003364 File Offset: 0x00001564
		// (set) Token: 0x06000E66 RID: 3686 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06000E67 RID: 3687 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x06000E68 RID: 3688 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06000E69 RID: 3689 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnClick(EventArgs e)
		{
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x00002131 File Offset: 0x00000331
		private Image method_2()
		{
			return null;
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x00003364 File Offset: 0x00001564
		private Size method_3()
		{
			return default(Size);
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x0000337C File Offset: 0x0000157C
		private Point method_4()
		{
			return default(Point);
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x00002131 File Offset: 0x00000331
		private Image method_5()
		{
			return null;
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x00003364 File Offset: 0x00001564
		private Size method_6()
		{
			return default(Size);
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x0000337C File Offset: 0x0000157C
		private Point method_7()
		{
			return default(Point);
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x00002131 File Offset: 0x00000331
		private Image method_8()
		{
			return null;
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x00003364 File Offset: 0x00001564
		private Size method_9()
		{
			return default(Size);
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x0000337C File Offset: 0x0000157C
		private Point method_10()
		{
			return default(Point);
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x00002134 File Offset: 0x00000334
		private void method_11(Graphics G)
		{
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x040003BA RID: 954
		private bool bool_5;

		// Token: 0x040003BB RID: 955
		private Image image_0;

		// Token: 0x040003BC RID: 956
		private Size size_0;

		// Token: 0x040003BD RID: 957
		private Point point_0;

		// Token: 0x040003BF RID: 959
		private bool bool_6;

		// Token: 0x040003C0 RID: 960
		private float float_0;

		// Token: 0x040003C1 RID: 961
		private FlipOrientation flipOrientation_0;

		// Token: 0x040003C2 RID: 962
		private ImageControlState imageControlState_0;

		// Token: 0x040003C3 RID: 963
		private ImageControlState imageControlState_1;

		// Token: 0x040003C4 RID: 964
		private ImageControlState imageControlState_2;
	}
}
