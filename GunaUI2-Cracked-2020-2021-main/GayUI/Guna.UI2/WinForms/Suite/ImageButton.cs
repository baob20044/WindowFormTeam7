using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.WinForms.Enums;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x020000B1 RID: 177
	[ToolboxItem(false)]
	public class ImageButton : UIDefaultControl, IButtonControl
	{
		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06000DFF RID: 3583 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000E00 RID: 3584 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06000E01 RID: 3585 RVA: 0x00003ADC File Offset: 0x00001CDC
		// (set) Token: 0x06000E02 RID: 3586 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(0)]
		public DialogResult DialogResult
		{
			get
			{
				return DialogResult.None;
			}
			set
			{
			}
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x00002134 File Offset: 0x00000334
		public void NotifyDefault(bool value)
		{
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x00002134 File Offset: 0x00000334
		public void PerformClick()
		{
		}

		// Token: 0x14000030 RID: 48
		// (add) Token: 0x06000E05 RID: 3589 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000E06 RID: 3590 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06000E07 RID: 3591 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected virtual void OnCheckedChanged(EventArgs e)
		{
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnKeyDown(KeyEventArgs kevent)
		{
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnGotFocus(EventArgs e)
		{
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnLostFocus(EventArgs e)
		{
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06000E0B RID: 3595 RVA: 0x00002145 File Offset: 0x00000345
		// (set) Token: 0x06000E0C RID: 3596 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Sets the angle of rotation for the image. Please provide a value between 0 and 360.")]
		[DefaultValue(0)]
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

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06000E0D RID: 3597 RVA: 0x0000334C File Offset: 0x0000154C
		// (set) Token: 0x06000E0E RID: 3598 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(0)]
		[Description("Flips the image to any given orientation. Supports both Vertical  and Horizontal orientation-flipping options.")]
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

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06000E0F RID: 3599 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected ImageControlState DefaultHoverState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06000E10 RID: 3600 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected ImageControlState DefaultCheckedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06000E11 RID: 3601 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected ImageControlState DefaultPressedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06000E12 RID: 3602 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000E13 RID: 3603 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06000E14 RID: 3604 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000E15 RID: 3605 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06000E16 RID: 3606 RVA: 0x00003364 File Offset: 0x00001564
		// (set) Token: 0x06000E17 RID: 3607 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06000E18 RID: 3608 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x06000E19 RID: 3609 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06000E1A RID: 3610 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x06000E1B RID: 3611 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Point DefaultTextOffset
		{
			get
			{
				return default(Point);
			}
			set
			{
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06000E1C RID: 3612 RVA: 0x00003840 File Offset: 0x00001A40
		// (set) Token: 0x06000E1D RID: 3613 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected HorizontalAlignment DefaultTextAlign
		{
			get
			{
				return HorizontalAlignment.Left;
			}
			set
			{
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06000E1E RID: 3614 RVA: 0x00003840 File Offset: 0x00001A40
		// (set) Token: 0x06000E1F RID: 3615 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected HorizontalAlignment DefaultImageAlign
		{
			get
			{
				return HorizontalAlignment.Left;
			}
			set
			{
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06000E20 RID: 3616 RVA: 0x0000346C File Offset: 0x0000166C
		// (set) Token: 0x06000E21 RID: 3617 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected TextRenderingHint DefaultTextRenderingHint
		{
			get
			{
				return TextRenderingHint.SystemDefault;
			}
			set
			{
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06000E22 RID: 3618 RVA: 0x00003858 File Offset: 0x00001A58
		// (set) Token: 0x06000E23 RID: 3619 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected TextTransform DefaultTextTransform
		{
			get
			{
				return TextTransform.None;
			}
			set
			{
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06000E24 RID: 3620 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000E25 RID: 3621 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06000E26 RID: 3622 RVA: 0x00002131 File Offset: 0x00000331
		private Image method_1()
		{
			return null;
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x00003364 File Offset: 0x00001564
		private Size method_2()
		{
			return default(Size);
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x0000337C File Offset: 0x0000157C
		private Point method_3()
		{
			return default(Point);
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x00002131 File Offset: 0x00000331
		private Image method_4()
		{
			return null;
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x00003364 File Offset: 0x00001564
		private Size method_5()
		{
			return default(Size);
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x0000337C File Offset: 0x0000157C
		private Point method_6()
		{
			return default(Point);
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x00002131 File Offset: 0x00000331
		private Image method_7()
		{
			return null;
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x00003364 File Offset: 0x00001564
		private Size method_8()
		{
			return default(Size);
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x0000337C File Offset: 0x0000157C
		private Point method_9()
		{
			return default(Point);
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x00002134 File Offset: 0x00000334
		private void method_10(Graphics G)
		{
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x0400039D RID: 925
		private bool bool_5;

		// Token: 0x0400039E RID: 926
		private bool bool_6;

		// Token: 0x0400039F RID: 927
		private DialogResult dialogResult_0;

		// Token: 0x040003A1 RID: 929
		private float float_0;

		// Token: 0x040003A2 RID: 930
		private FlipOrientation flipOrientation_0;

		// Token: 0x040003A3 RID: 931
		private ImageControlState imageControlState_0;

		// Token: 0x040003A4 RID: 932
		private ImageControlState imageControlState_1;

		// Token: 0x040003A5 RID: 933
		private ImageControlState imageControlState_2;

		// Token: 0x040003A6 RID: 934
		private bool bool_7;

		// Token: 0x040003A7 RID: 935
		private Image image_0;

		// Token: 0x040003A8 RID: 936
		private Size size_0;

		// Token: 0x040003A9 RID: 937
		private Point point_0;

		// Token: 0x040003AA RID: 938
		private Point point_1;

		// Token: 0x040003AB RID: 939
		private HorizontalAlignment horizontalAlignment_0;

		// Token: 0x040003AC RID: 940
		private HorizontalAlignment horizontalAlignment_1;

		// Token: 0x040003AD RID: 941
		private TextRenderingHint textRenderingHint_0;

		// Token: 0x040003AE RID: 942
		private TextTransform textTransform_0;
	}
}
