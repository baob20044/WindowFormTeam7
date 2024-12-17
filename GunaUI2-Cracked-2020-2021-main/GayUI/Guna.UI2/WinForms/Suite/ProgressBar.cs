using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.WinForms.Enums;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x020000B7 RID: 183
	[ToolboxItem(false)]
	[DefaultEvent("ValueChanged")]
	public class ProgressBar : UIDefaultControl
	{
		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06000EF7 RID: 3831 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000EF8 RID: 3832 RVA: 0x00002134 File Offset: 0x00000334
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Description("Style the control's border sides.")]
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

		// Token: 0x06000EF9 RID: 3833 RVA: 0x00002134 File Offset: 0x00000334
		private void method_1(object sender, EventArgs e)
		{
		}

		// Token: 0x14000037 RID: 55
		// (add) Token: 0x06000EFA RID: 3834 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000EFB RID: 3835 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler MaximumChanged
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

		// Token: 0x06000EFC RID: 3836 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected virtual void OnMaximumChanged(EventArgs e)
		{
		}

		// Token: 0x14000038 RID: 56
		// (add) Token: 0x06000EFD RID: 3837 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000EFE RID: 3838 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler MinimumChanged
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

		// Token: 0x06000EFF RID: 3839 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected virtual void OnMinimumChanged(EventArgs e)
		{
		}

		// Token: 0x14000039 RID: 57
		// (add) Token: 0x06000F00 RID: 3840 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000F01 RID: 3841 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler ValueChanged
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

		// Token: 0x06000F02 RID: 3842 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected virtual void OnValueChanged(EventArgs e)
		{
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06000F03 RID: 3843 RVA: 0x0000346C File Offset: 0x0000166C
		// (set) Token: 0x06000F04 RID: 3844 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06000F05 RID: 3845 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x06000F06 RID: 3846 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06000F07 RID: 3847 RVA: 0x00003840 File Offset: 0x00001A40
		// (set) Token: 0x06000F08 RID: 3848 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06000F09 RID: 3849 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000F0A RID: 3850 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected bool DefaultShowPercentage
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06000F0B RID: 3851 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000F0C RID: 3852 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected int DefaultMaximum
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06000F0D RID: 3853 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000F0E RID: 3854 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected int DefaultMinimum
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06000F0F RID: 3855 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000F10 RID: 3856 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected int DefaultValue
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06000F11 RID: 3857 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000F12 RID: 3858 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected bool DefaultBackwards
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06000F13 RID: 3859 RVA: 0x00003334 File Offset: 0x00001534
		// (set) Token: 0x06000F14 RID: 3860 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected ProgressBarStyle DefaultStyle
		{
			get
			{
				return ProgressBarStyle.Blocks;
			}
			set
			{
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06000F15 RID: 3861 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000F16 RID: 3862 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Color DefaultProgressColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06000F17 RID: 3863 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000F18 RID: 3864 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Color DefaultProgressColor2
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06000F19 RID: 3865 RVA: 0x00003948 File Offset: 0x00001B48
		// (set) Token: 0x06000F1A RID: 3866 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected BrushMode DefaultProgressBrushMode
		{
			get
			{
				return BrushMode.Gradient;
			}
			set
			{
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06000F1B RID: 3867 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000F1C RID: 3868 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06000F1D RID: 3869 RVA: 0x0000331C File Offset: 0x0000151C
		// (set) Token: 0x06000F1E RID: 3870 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06000F1F RID: 3871 RVA: 0x00002154 File Offset: 0x00000354
		[Browsable(false)]
		public double ProgressTotalValue
		{
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06000F20 RID: 3872 RVA: 0x00002154 File Offset: 0x00000354
		[Browsable(false)]
		public double ProgressTotalPercent
		{
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06000F21 RID: 3873 RVA: 0x00002131 File Offset: 0x00000331
		[Browsable(false)]
		public string ProgressPercentText
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x00002136 File Offset: 0x00000336
		private int method_2()
		{
			return 0;
		}

		// Token: 0x06000F23 RID: 3875 RVA: 0x00002136 File Offset: 0x00000336
		private int method_3()
		{
			return 0;
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x00002145 File Offset: 0x00000345
		private float method_4()
		{
			return 0f;
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x00002134 File Offset: 0x00000334
		public void Increment(int Value)
		{
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x00002134 File Offset: 0x00000334
		public void Decrement(int Value)
		{
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x00002131 File Offset: 0x00000331
		private Brush method_5()
		{
			return null;
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x00002134 File Offset: 0x00000334
		private void method_6(Graphics G)
		{
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x040003EE RID: 1006
		private CustomizableEdges customizableEdges_0;

		// Token: 0x040003EF RID: 1007
		private Orientation orientation_0;

		// Token: 0x040003F0 RID: 1008
		private int int_2;

		// Token: 0x040003F1 RID: 1009
		private Timer timer_0;

		// Token: 0x040003F5 RID: 1013
		private TextRenderingHint textRenderingHint_0;

		// Token: 0x040003F6 RID: 1014
		private Point point_0;

		// Token: 0x040003F7 RID: 1015
		private HorizontalAlignment horizontalAlignment_0;

		// Token: 0x040003F8 RID: 1016
		private bool bool_5;

		// Token: 0x040003F9 RID: 1017
		private int int_3;

		// Token: 0x040003FA RID: 1018
		private int int_4;

		// Token: 0x040003FB RID: 1019
		private int int_5;

		// Token: 0x040003FC RID: 1020
		private bool bool_6;

		// Token: 0x040003FD RID: 1021
		private ProgressBarStyle progressBarStyle_0;

		// Token: 0x040003FE RID: 1022
		private Color color_1;

		// Token: 0x040003FF RID: 1023
		private Color color_2;

		// Token: 0x04000400 RID: 1024
		private BrushMode brushMode_0;

		// Token: 0x04000401 RID: 1025
		private Color color_3;

		// Token: 0x04000402 RID: 1026
		private LinearGradientMode linearGradientMode_0;
	}
}
