using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security;
using System.Windows.Forms;
using Guna.UI2.WinForms.Enums;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x020000B9 RID: 185
	[DefaultEvent("Scroll")]
	[ToolboxItem(false)]
	[DefaultProperty("Value")]
	public class ScrollBar : Control
	{
		// Token: 0x1400003A RID: 58
		// (add) Token: 0x06000F37 RID: 3895 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000F38 RID: 3896 RVA: 0x00002134 File Offset: 0x00000334
		public event ScrollEventHandler Scroll
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

		// Token: 0x06000F39 RID: 3897 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0(ScrollEventType type, int oldValue, int newValue, ScrollOrientation orientation)
		{
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06000F3A RID: 3898 RVA: 0x0000343C File Offset: 0x0000163C
		private Rectangle Rectangle_0
		{
			get
			{
				return default(Rectangle);
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06000F3B RID: 3899 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public ScrollBarState DefaultHoverState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06000F3C RID: 3900 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public ScrollBarState DefaultPressedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06000F3D RID: 3901 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000F3E RID: 3902 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("Style the control's border sides.")]
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

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06000F3F RID: 3903 RVA: 0x000033C4 File Offset: 0x000015C4
		// (set) Token: 0x06000F40 RID: 3904 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Sets the thumb's style in relation to the ScrollBar.")]
		[DefaultValue(0)]
		public ThumbStyle ThumbStyle
		{
			get
			{
				return ThumbStyle.Default;
			}
			set
			{
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06000F41 RID: 3905 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000F42 RID: 3906 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(0)]
		[Browsable(true)]
		public int BorderRadius
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06000F43 RID: 3907 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000F44 RID: 3908 RVA: 0x00002134 File Offset: 0x00000334
		public int MouseWheelBarPartitions
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06000F45 RID: 3909 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000F46 RID: 3910 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("The border BackColor")]
		[DefaultValue(typeof(Color), "")]
		public Color BorderColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06000F47 RID: 3911 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000F48 RID: 3912 RVA: 0x00002134 File Offset: 0x00000334
		public int ScrollbarSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06000F49 RID: 3913 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000F4A RID: 3914 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(false)]
		public bool HighlightOnWheel
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06000F4B RID: 3915 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000F4C RID: 3916 RVA: 0x00002134 File Offset: 0x00000334
		public int Minimum
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06000F4D RID: 3917 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000F4E RID: 3918 RVA: 0x00002134 File Offset: 0x00000334
		public int Maximum
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06000F4F RID: 3919 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000F50 RID: 3920 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(1)]
		public int SmallChange
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06000F51 RID: 3921 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000F52 RID: 3922 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(5)]
		public int LargeChange
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06000F53 RID: 3923 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000F54 RID: 3924 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		public Color ThumbColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06000F55 RID: 3925 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000F56 RID: 3926 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "213, 218, 223")]
		[Browsable(true)]
		public Color FillColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06000F57 RID: 3927 RVA: 0x00002145 File Offset: 0x00000345
		// (set) Token: 0x06000F58 RID: 3928 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(10f)]
		public float ThumbSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06000F59 RID: 3929 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000F5A RID: 3930 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public new Font Font
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06000F5B RID: 3931 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000F5C RID: 3932 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new string Text
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06000F5D RID: 3933 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000F5E RID: 3934 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new Color ForeColor
		{
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1400003B RID: 59
		// (add) Token: 0x06000F5F RID: 3935 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000F60 RID: 3936 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06000F61 RID: 3937 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000F62 RID: 3938 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(0)]
		[Browsable(true)]
		public int Value
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x00002134 File Offset: 0x00000334
		private void method_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x00002134 File Offset: 0x00000334
		internal void method_2(ScrollOrientation orientation)
		{
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x00002136 File Offset: 0x00000336
		public bool HitTest(Point point)
		{
			return false;
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x00002134 File Offset: 0x00000334
		[SecuritySafeCritical]
		public void BeginUpdate()
		{
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x00002134 File Offset: 0x00000334
		[SecuritySafeCritical]
		public void EndUpdate()
		{
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnGotFocus(EventArgs e)
		{
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnLostFocus(EventArgs e)
		{
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnEnter(EventArgs e)
		{
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnLeave(EventArgs e)
		{
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseWheel(MouseEventArgs e)
		{
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseDown(MouseEventArgs e)
		{
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseUp(MouseEventArgs e)
		{
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseEnter(EventArgs e)
		{
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseLeave(EventArgs e)
		{
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseMove(MouseEventArgs e)
		{
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnKeyDown(KeyEventArgs e)
		{
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnKeyUp(KeyEventArgs e)
		{
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x00002134 File Offset: 0x00000334
		protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
		{
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnSizeChanged(EventArgs e)
		{
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x00002136 File Offset: 0x00000336
		protected override bool ProcessDialogKey(Keys keyData)
		{
			return false;
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnEnabledChanged(EventArgs e)
		{
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x00002134 File Offset: 0x00000334
		private void method_3()
		{
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x00002134 File Offset: 0x00000334
		private void method_4()
		{
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x00002134 File Offset: 0x00000334
		private void method_5(object sender, EventArgs e)
		{
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x00002136 File Offset: 0x00000336
		private int method_6(bool smallIncrement, bool up)
		{
			return 0;
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x00002136 File Offset: 0x00000336
		private int method_7()
		{
			return 0;
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x00002136 File Offset: 0x00000336
		private int method_8()
		{
			return 0;
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x00002134 File Offset: 0x00000334
		private void method_9()
		{
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x00002134 File Offset: 0x00000334
		private void method_10()
		{
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x00002134 File Offset: 0x00000334
		private void method_11(int position)
		{
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x00002134 File Offset: 0x00000334
		private void method_12(bool enableTimer)
		{
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_13(Color color1, Color color2)
		{
			return default(Color);
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x04000408 RID: 1032
		private bool bool_0;

		// Token: 0x04000409 RID: 1033
		private bool bool_1;

		// Token: 0x0400040A RID: 1034
		internal bool bool_2;

		// Token: 0x0400040B RID: 1035
		private Rectangle rectangle_0;

		// Token: 0x0400040C RID: 1036
		private Rectangle rectangle_1;

		// Token: 0x0400040D RID: 1037
		private bool bool_3;

		// Token: 0x0400040E RID: 1038
		private bool bool_4;

		// Token: 0x0400040F RID: 1039
		private bool bool_5;

		// Token: 0x04000410 RID: 1040
		private int int_0;

		// Token: 0x04000411 RID: 1041
		private int int_1;

		// Token: 0x04000412 RID: 1042
		private int int_2;

		// Token: 0x04000413 RID: 1043
		private int int_3;

		// Token: 0x04000414 RID: 1044
		private int int_4;

		// Token: 0x04000415 RID: 1045
		private int int_5;

		// Token: 0x04000416 RID: 1046
		private int int_6;

		// Token: 0x04000417 RID: 1047
		private readonly Timer timer_0;

		// Token: 0x04000418 RID: 1048
		private int int_7;

		// Token: 0x04000419 RID: 1049
		private ScrollBarState scrollBarState_0;

		// Token: 0x0400041A RID: 1050
		private ScrollBarState scrollBarState_1;

		// Token: 0x0400041B RID: 1051
		private CustomizableEdges customizableEdges_0;

		// Token: 0x0400041C RID: 1052
		private ThumbStyle thumbStyle_0;

		// Token: 0x0400041D RID: 1053
		private int int_8;

		// Token: 0x0400041E RID: 1054
		private Color color_0;

		// Token: 0x0400041F RID: 1055
		private bool bool_6;

		// Token: 0x04000420 RID: 1056
		private bool bool_7;

		// Token: 0x04000421 RID: 1057
		private bool bool_8;

		// Token: 0x04000422 RID: 1058
		private ScrollOrientation scrollOrientation_0;

		// Token: 0x04000423 RID: 1059
		private int int_9;

		// Token: 0x04000424 RID: 1060
		private int int_10;

		// Token: 0x04000425 RID: 1061
		private int int_11;

		// Token: 0x04000426 RID: 1062
		private int int_12;

		// Token: 0x04000427 RID: 1063
		private int int_13;

		// Token: 0x04000428 RID: 1064
		private Color color_1;

		// Token: 0x04000429 RID: 1065
		private Color color_2;

		// Token: 0x0400042A RID: 1066
		private float float_0;

		// Token: 0x0400042B RID: 1067
		[CompilerGenerated]
		private Font font_0;

		// Token: 0x0400042C RID: 1068
		[CompilerGenerated]
		private string string_0;

		// Token: 0x0400042D RID: 1069
		[CompilerGenerated]
		private Color color_3;

		// Token: 0x0400042F RID: 1071
		private bool bool_9;

		// Token: 0x04000430 RID: 1072
		private Timer timer_1;
	}
}
