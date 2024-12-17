using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Guna.UI2.WinForms.Enums;
using Guna.UI2.WinForms.Suite;

namespace Guna.UI2.WinForms
{
	// Token: 0x02000067 RID: 103
	[ToolboxBitmap(typeof(System.Windows.Forms.ProgressBar))]
	[ToolboxItem(true)]
	[DebuggerStepThrough]
	[Description("An advanced progress bar control")]
	[Designer(typeof(Guna2ProgressBarDesigner))]
	public class Guna2ProgressBar : Guna.UI2.WinForms.Suite.ProgressBar
	{
		// Token: 0x17000313 RID: 787
		// (get) Token: 0x0600077B RID: 1915 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600077C RID: 1916 RVA: 0x00002134 File Offset: 0x00000334
		[Description("If true, the border on the control is rounded off automatically")]
		[DefaultValue(false)]
		[Browsable(true)]
		public bool AutoRoundedCorners
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnResize(EventArgs e)
		{
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00002134 File Offset: 0x00000334
		private void method_7()
		{
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x0600077F RID: 1919 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000780 RID: 1920 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The curve angle of the control on all angles")]
		[Browsable(true)]
		[DefaultValue(0)]
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

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000781 RID: 1921 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x06000782 RID: 1922 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(DashStyle.Solid)]
		[Browsable(true)]
		[Description("The css-like style of the border. You can customize the border to meet your design needs")]
		public DashStyle BorderStyle
		{
			get
			{
				return DashStyle.Solid;
			}
			set
			{
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000783 RID: 1923 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000784 RID: 1924 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "Black")]
		[Browsable(true)]
		[Description("The control's border color")]
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

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000785 RID: 1925 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000786 RID: 1926 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The border thickness. The higher the value, the thicker the border")]
		[DefaultValue(0)]
		[Browsable(true)]
		public int BorderThickness
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000787 RID: 1927 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000788 RID: 1928 RVA: 0x00002134 File Offset: 0x00000334
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(true)]
		[Description("Shadow property of the control to add and customize a control's shadow")]
		public ShadowDecoration ShadowDecoration
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000789 RID: 1929 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600078A RID: 1930 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(false)]
		[Description("If true, the background will allow a transparent color")]
		[Browsable(true)]
		public bool UseTransparentBackground
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x0600078B RID: 1931 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x0600078C RID: 1932 RVA: 0x00002134 File Offset: 0x00000334
		[Description("If control's text")]
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

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x0600078D RID: 1933 RVA: 0x0000346C File Offset: 0x0000166C
		// (set) Token: 0x0600078E RID: 1934 RVA: 0x00002134 File Offset: 0x00000334
		[Description("This property allows you to change how text is printed onto the control")]
		[Browsable(true)]
		[DefaultValue(5)]
		public TextRenderingHint TextRenderingHint
		{
			get
			{
				return TextRenderingHint.SystemDefault;
			}
			set
			{
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x0600078F RID: 1935 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x06000790 RID: 1936 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Point), "0, 0")]
		[Description("The control's text position")]
		[Browsable(true)]
		public Point TextOffset
		{
			get
			{
				return default(Point);
			}
			set
			{
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000791 RID: 1937 RVA: 0x00003840 File Offset: 0x00001A40
		// (set) Token: 0x06000792 RID: 1938 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The control's horizontal text alignment")]
		[Browsable(true)]
		[DefaultValue(2)]
		public HorizontalAlignment TextAlign
		{
			get
			{
				return HorizontalAlignment.Left;
			}
			set
			{
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000793 RID: 1939 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000794 RID: 1940 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(false)]
		[Browsable(true)]
		[Description("If true, the control's percentile value will be shown")]
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

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000795 RID: 1941 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000796 RID: 1942 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The control's maximum value")]
		[DefaultValue(100)]
		[Browsable(true)]
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

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000797 RID: 1943 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000798 RID: 1944 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("The control's minimum value")]
		[DefaultValue(0)]
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

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000799 RID: 1945 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600079A RID: 1946 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The control's value")]
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

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x0600079B RID: 1947 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600079C RID: 1948 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(false)]
		[Description("If true, the control will progress in a backward direction")]
		public bool Backwards
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x0600079D RID: 1949 RVA: 0x00003334 File Offset: 0x00001534
		// (set) Token: 0x0600079E RID: 1950 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(ProgressBarStyle.Blocks)]
		[Description("The progress bar style")]
		[Browsable(true)]
		public ProgressBarStyle Style
		{
			get
			{
				return ProgressBarStyle.Blocks;
			}
			set
			{
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x0600079F RID: 1951 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060007A0 RID: 1952 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The progress bar color")]
		[Browsable(true)]
		[DefaultValue(typeof(Color), "139, 201, 77")]
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

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x060007A1 RID: 1953 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060007A2 RID: 1954 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The progress bar second color in a gradient mode")]
		[DefaultValue(typeof(Color), "139, 201, 77")]
		[Browsable(true)]
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

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x060007A3 RID: 1955 RVA: 0x00003948 File Offset: 0x00001B48
		// (set) Token: 0x060007A4 RID: 1956 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(BrushMode.Gradient)]
		[Description("The progress bar brush mode")]
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

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x060007A5 RID: 1957 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060007A6 RID: 1958 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("The BackColor that will fill the control")]
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

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x060007A7 RID: 1959 RVA: 0x0000331C File Offset: 0x0000151C
		// (set) Token: 0x060007A8 RID: 1960 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The control's gradient mode")]
		[DefaultValue(typeof(LinearGradientMode), "")]
		[Browsable(true)]
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

		// Token: 0x0400016F RID: 367
		private bool bool_7;

		// Token: 0x04000170 RID: 368
		private int int_6;

		// Token: 0x04000171 RID: 369
		[CompilerGenerated]
		private string string_0;
	}
}
