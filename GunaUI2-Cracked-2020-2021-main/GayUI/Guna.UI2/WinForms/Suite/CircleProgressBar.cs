using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.WinForms.Enums;
using Guna.UI2.WinForms.Interfaces;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x020000A4 RID: 164
	[ToolboxItem(false)]
	[DefaultEvent("ValueChanged")]
	public class CircleProgressBar : ContainerControl, IControl
	{
		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06000B88 RID: 2952 RVA: 0x00002136 File Offset: 0x00000336
		[Description("Gets a value that indicates whether the Component is currently in design mode.")]
		[Browsable(false)]
		public bool IsDesignMode
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06000B8A RID: 2954 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000B8B RID: 2955 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06000B8C RID: 2956 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected virtual void OnMaximumChanged(EventArgs e)
		{
		}

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x06000B8D RID: 2957 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000B8E RID: 2958 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06000B8F RID: 2959 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected virtual void OnMinimumChanged(EventArgs e)
		{
		}

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x06000B90 RID: 2960 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000B91 RID: 2961 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06000B92 RID: 2962 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected virtual void OnValueChanged(EventArgs e)
		{
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000B93 RID: 2963 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000B94 RID: 2964 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06000B95 RID: 2965 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0(Graphics G)
		{
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaintBackground(PaintEventArgs e)
		{
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x00002134 File Offset: 0x00000334
		private void method_1()
		{
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x00002134 File Offset: 0x00000334
		private void method_2(object sender, EventArgs e)
		{
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000B99 RID: 2969 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000B9A RID: 2970 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected bool DefaultAnimated
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06000B9B RID: 2971 RVA: 0x00002145 File Offset: 0x00000345
		// (set) Token: 0x06000B9C RID: 2972 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected float DefaultAnimationSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06000B9D RID: 2973 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000B9E RID: 2974 RVA: 0x00002134 File Offset: 0x00000334
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(false)]
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

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000B9F RID: 2975 RVA: 0x0000346C File Offset: 0x0000166C
		// (set) Token: 0x06000BA0 RID: 2976 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000BA1 RID: 2977 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000BA2 RID: 2978 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000BA3 RID: 2979 RVA: 0x00003364 File Offset: 0x00001564
		// (set) Token: 0x06000BA4 RID: 2980 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000BA5 RID: 2981 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x06000BA6 RID: 2982 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000BA7 RID: 2983 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000BA8 RID: 2984 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06000BA9 RID: 2985 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000BAA RID: 2986 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected int DefaultFillOffset
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06000BAB RID: 2987 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000BAC RID: 2988 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected bool DefaultEnsureVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06000BAD RID: 2989 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000BAE RID: 2990 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000BAF RID: 2991 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000BB0 RID: 2992 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected int DefaultFillThickness
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000BB1 RID: 2993 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000BB2 RID: 2994 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected int DefaultProgressOffset
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06000BB3 RID: 2995 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000BB4 RID: 2996 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected int DefaultProgressThickness
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06000BB5 RID: 2997 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000BB6 RID: 2998 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06000BB7 RID: 2999 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000BB8 RID: 3000 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06000BB9 RID: 3001 RVA: 0x00003948 File Offset: 0x00001B48
		// (set) Token: 0x06000BBA RID: 3002 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06000BBB RID: 3003 RVA: 0x0000331C File Offset: 0x0000151C
		// (set) Token: 0x06000BBC RID: 3004 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06000BBD RID: 3005 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000BBE RID: 3006 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06000BBF RID: 3007 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000BC0 RID: 3008 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		protected Color DefaultInnerColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06000BC1 RID: 3009 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000BC2 RID: 3010 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06000BC3 RID: 3011 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000BC4 RID: 3012 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06000BC5 RID: 3013 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000BC6 RID: 3014 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06000BC7 RID: 3015 RVA: 0x00002131 File Offset: 0x00000331
		[Browsable(false)]
		public string ProgressPercentText
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06000BC8 RID: 3016 RVA: 0x00002154 File Offset: 0x00000354
		[Browsable(false)]
		public double ProgressTotalPercent
		{
			get
			{
				return 0.0;
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x00002154 File Offset: 0x00000354
		[Browsable(false)]
		public double ProgressTotalValue
		{
			get
			{
				return 0.0;
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06000BCA RID: 3018 RVA: 0x00003960 File Offset: 0x00001B60
		// (set) Token: 0x06000BCB RID: 3019 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected LineCap DefaultProgressStartCap
		{
			get
			{
				return LineCap.Flat;
			}
			set
			{
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000BCC RID: 3020 RVA: 0x00003960 File Offset: 0x00001B60
		// (set) Token: 0x06000BCD RID: 3021 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected LineCap DefaultProgressEndCap
		{
			get
			{
				return LineCap.Flat;
			}
			set
			{
			}
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x00002145 File Offset: 0x00000345
		private float method_3()
		{
			return 0f;
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x00002145 File Offset: 0x00000345
		private float method_4()
		{
			return 0f;
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x00002145 File Offset: 0x00000345
		private float method_5()
		{
			return 0f;
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x00002145 File Offset: 0x00000345
		private float method_6()
		{
			return 0f;
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x00002145 File Offset: 0x00000345
		public float ProgressX(int i)
		{
			return 0f;
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x00002145 File Offset: 0x00000345
		public float ProgressY(int i)
		{
			return 0f;
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x00002145 File Offset: 0x00000345
		public float BaseX(int i)
		{
			return 0f;
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x00002145 File Offset: 0x00000345
		public float BaseY(int i)
		{
			return 0f;
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x00002134 File Offset: 0x00000334
		public void Reset()
		{
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x00002134 File Offset: 0x00000334
		public void Increment(int Value)
		{
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x00002134 File Offset: 0x00000334
		public void Decrement(int Value)
		{
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x00002131 File Offset: 0x00000331
		private Brush method_7()
		{
			return null;
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x040002B9 RID: 697
		internal float float_0;

		// Token: 0x040002BA RID: 698
		private int int_0;

		// Token: 0x040002BB RID: 699
		private int int_1;

		// Token: 0x040002BC RID: 700
		private bool bool_0;

		// Token: 0x040002BD RID: 701
		private bool bool_1;

		// Token: 0x040002BE RID: 702
		private int int_2;

		// Token: 0x040002BF RID: 703
		private int int_3;

		// Token: 0x040002C0 RID: 704
		private Color color_0;

		// Token: 0x040002C1 RID: 705
		private int int_4;

		// Token: 0x040002C2 RID: 706
		private int int_5;

		// Token: 0x040002C3 RID: 707
		private int int_6;

		// Token: 0x040002C4 RID: 708
		private LineCap lineCap_0;

		// Token: 0x040002C5 RID: 709
		private LineCap lineCap_1;

		// Token: 0x040002C9 RID: 713
		private bool bool_2;

		// Token: 0x040002CA RID: 714
		private Timer timer_0;

		// Token: 0x040002CB RID: 715
		private float float_1;

		// Token: 0x040002CC RID: 716
		private ShadowDecoration shadowDecoration_0;

		// Token: 0x040002CD RID: 717
		private TextRenderingHint textRenderingHint_0;

		// Token: 0x040002CE RID: 718
		private Image image_0;

		// Token: 0x040002CF RID: 719
		private Size size_0;

		// Token: 0x040002D0 RID: 720
		private Point point_0;

		// Token: 0x040002D1 RID: 721
		private bool bool_3;

		// Token: 0x040002D2 RID: 722
		private Color color_1;

		// Token: 0x040002D3 RID: 723
		private Color color_2;

		// Token: 0x040002D4 RID: 724
		private BrushMode brushMode_0;

		// Token: 0x040002D5 RID: 725
		private LinearGradientMode linearGradientMode_0;

		// Token: 0x040002D6 RID: 726
		private Color color_3;
	}
}
