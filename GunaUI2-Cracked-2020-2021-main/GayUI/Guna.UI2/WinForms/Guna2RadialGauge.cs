using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.WinForms.Enums;
using Guna.UI2.WinForms.Interfaces;

namespace Guna.UI2.WinForms
{
	// Token: 0x02000068 RID: 104
	[DebuggerStepThrough]
	[DefaultEvent("ValueChanged")]
	[Description("An advanced Radial Gauge Control")]
	[ToolboxItem(true)]
	public class Guna2RadialGauge : Control, IControl
	{
		// Token: 0x17000329 RID: 809
		// (get) Token: 0x060007A9 RID: 1961 RVA: 0x00002136 File Offset: 0x00000336
		[Description("Gets a value that indicates whether the Component is currently in design mode.")]
		[Browsable(false)]
		public bool IsDesignMode
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00002136 File Offset: 0x00000336
		private int method_0()
		{
			return 0;
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x0000337C File Offset: 0x0000157C
		private Point method_1(Point originPoint, double radius, double angleDegrees)
		{
			return default(Point);
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x060007AD RID: 1965 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x060007AE RID: 1966 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x060007AF RID: 1967 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected virtual void OnValueChanged(EventArgs e)
		{
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x060007B0 RID: 1968 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060007B1 RID: 1969 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		[Description("The control's text")]
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

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x060007B2 RID: 1970 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060007B3 RID: 1971 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "125, 137, 149")]
		public Color ArrowColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x060007B4 RID: 1972 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060007B5 RID: 1973 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(true)]
		[Description("If true, the arrow will be visible")]
		public bool ArrowVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x060007B6 RID: 1974 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060007B7 RID: 1975 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The control's arrow thickness, the higher the value, the thicker the arrow")]
		[DefaultValue(4)]
		public int ArrowThickness
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x060007B8 RID: 1976 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060007B9 RID: 1977 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The BackColor that will fill the control")]
		[Browsable(true)]
		[DefaultValue(typeof(Color), "213, 218, 223")]
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

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x060007BA RID: 1978 RVA: 0x00002136 File Offset: 0x00000336
		[Description("The gauge's maximum value")]
		[DefaultValue(100)]
		public int Maximum
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x060007BB RID: 1979 RVA: 0x00002136 File Offset: 0x00000336
		[Description("The gauge's minimum value")]
		[DefaultValue(0)]
		public int Minimum
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x060007BC RID: 1980 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060007BD RID: 1981 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "77, 196, 255")]
		[Description("The gauge's progress color")]
		public Color ProgressColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x060007BE RID: 1982 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060007BF RID: 1983 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "77, 196, 255")]
		[Description("The gauge's second progress color in a gradient mode")]
		public Color ProgressColor2
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060007C1 RID: 1985 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(true)]
		[Description("If true, the gauge's progress value/percentage will be shown")]
		public bool ShowPercentage
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x00002131 File Offset: 0x00000331
		[Description("The gauge's progress percentile text")]
		[Browsable(false)]
		public string ProgressPercentText
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x060007C3 RID: 1987 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060007C4 RID: 1988 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The gauge's progress thickness, the higher the value, the thicker")]
		[DefaultValue(25)]
		public int ProgressThickness
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x060007C5 RID: 1989 RVA: 0x00002154 File Offset: 0x00000354
		[Browsable(false)]
		[Description("The gauge's progress total percentage")]
		public double ProgressTotalPercent
		{
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x060007C6 RID: 1990 RVA: 0x00002154 File Offset: 0x00000354
		[Browsable(false)]
		[Description("The gauge's progress total value")]
		public double ProgressTotalValue
		{
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x060007C7 RID: 1991 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060007C8 RID: 1992 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The gauge's progress value")]
		[DefaultValue(0)]
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

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x060007C9 RID: 1993 RVA: 0x00003948 File Offset: 0x00001B48
		// (set) Token: 0x060007CA RID: 1994 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(BrushMode.Gradient)]
		[Browsable(true)]
		[Description("The gauge's progress brush mode")]
		public BrushMode ProgressBrushMode
		{
			get
			{
				return BrushMode.Gradient;
			}
			set
			{
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x060007CB RID: 1995 RVA: 0x0000331C File Offset: 0x0000151C
		// (set) Token: 0x060007CC RID: 1996 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The gauge's progress gradient mode")]
		[Browsable(true)]
		[DefaultValue(LinearGradientMode.Horizontal)]
		public LinearGradientMode GradientMode
		{
			get
			{
				return LinearGradientMode.Horizontal;
			}
			set
			{
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x060007CD RID: 1997 RVA: 0x00003960 File Offset: 0x00001B60
		// (set) Token: 0x060007CE RID: 1998 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The gauge's progress start cap or design")]
		[DefaultValue(0)]
		public LineCap ProgressStartCap
		{
			get
			{
				return LineCap.Flat;
			}
			set
			{
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x060007CF RID: 1999 RVA: 0x00003960 File Offset: 0x00001B60
		// (set) Token: 0x060007D0 RID: 2000 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The gauge's progress end cap or design")]
		[DefaultValue(0)]
		public LineCap ProgressEndCap
		{
			get
			{
				return LineCap.Flat;
			}
			set
			{
			}
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnResize(EventArgs e)
		{
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00002131 File Offset: 0x00000331
		private Brush method_2()
		{
			return null;
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x00002134 File Offset: 0x00000334
		private void method_3(Graphics G)
		{
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x00002134 File Offset: 0x00000334
		private void method_4(Graphics G)
		{
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00002134 File Offset: 0x00000334
		private void method_5(Graphics G)
		{
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x00002134 File Offset: 0x00000334
		private void method_6(Graphics G)
		{
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x04000172 RID: 370
		private float float_0;

		// Token: 0x04000173 RID: 371
		private int int_0;

		// Token: 0x04000175 RID: 373
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04000176 RID: 374
		private Color color_0;

		// Token: 0x04000177 RID: 375
		private bool bool_0;

		// Token: 0x04000178 RID: 376
		private int int_1;

		// Token: 0x04000179 RID: 377
		private Color color_1;

		// Token: 0x0400017A RID: 378
		private Color color_2;

		// Token: 0x0400017B RID: 379
		private Color color_3;

		// Token: 0x0400017C RID: 380
		private bool bool_1;

		// Token: 0x0400017D RID: 381
		private int int_2;

		// Token: 0x0400017E RID: 382
		private int int_3;

		// Token: 0x0400017F RID: 383
		private BrushMode brushMode_0;

		// Token: 0x04000180 RID: 384
		private LinearGradientMode linearGradientMode_0;

		// Token: 0x04000181 RID: 385
		private LineCap lineCap_0;

		// Token: 0x04000182 RID: 386
		private LineCap lineCap_1;
	}
}
