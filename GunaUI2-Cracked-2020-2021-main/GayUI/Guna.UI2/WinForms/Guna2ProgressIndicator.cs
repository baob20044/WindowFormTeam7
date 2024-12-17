using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.WinForms.Enums;
using Guna.UI2.WinForms.Suite;

namespace Guna.UI2.WinForms
{
	// Token: 0x0200007E RID: 126
	[ToolboxBitmap(typeof(System.Windows.Forms.ProgressBar))]
	[ToolboxItem(true)]
	public class Guna2ProgressIndicator : UIDefaultControl
	{
		// Token: 0x06000977 RID: 2423 RVA: 0x00002134 File Offset: 0x00000334
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x00002134 File Offset: 0x00000334
		private void method_1()
		{
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x0600097A RID: 2426 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x0600097B RID: 2427 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		[Description("The control's font style")]
		[EditorBrowsable(EditorBrowsableState.Never)]
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

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x0600097C RID: 2428 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x0600097D RID: 2429 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Description("The control's text")]
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

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x0600097E RID: 2430 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600097F RID: 2431 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The control's ForeColor")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
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

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000980 RID: 2432 RVA: 0x00003A20 File Offset: 0x00001C20
		// (set) Token: 0x06000981 RID: 2433 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The progress style of the ProressIndicator control")]
		[DefaultValue(ProgressIndicatorStyle.Default)]
		[Browsable(true)]
		protected ProgressIndicatorStyle DefaultStyle
		{
			get
			{
				return ProgressIndicatorStyle.Default;
			}
			set
			{
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000982 RID: 2434 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000983 RID: 2435 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(false)]
		[Description("If true, the background will allow a transparent color")]
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

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000984 RID: 2436 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000985 RID: 2437 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Gets or sets the base color for the circles.")]
		[DefaultValue(typeof(Color), "94, 148, 255")]
		[Category("Appearance")]
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

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000986 RID: 2438 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000987 RID: 2439 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(false)]
		[Description("Gets or sets a value indicating if the animation should start automatically.")]
		[Category("Behavior")]
		public bool AutoStart
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000988 RID: 2440 RVA: 0x00002145 File Offset: 0x00000345
		// (set) Token: 0x06000989 RID: 2441 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Gets or sets the scale for the circles")]
		[DefaultValue(1.5f)]
		[Category("Appearance")]
		public float CircleSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x0600098A RID: 2442 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600098B RID: 2443 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Gets or sets the animation speed.")]
		[DefaultValue(75)]
		[Category("Behavior")]
		public int AnimationSpeed
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x0600098C RID: 2444 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600098D RID: 2445 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Gets or sets the number of circles used in the animation.")]
		[Category("Behavior")]
		[DefaultValue(8)]
		public int NumberOfCircles
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x00002134 File Offset: 0x00000334
		public void Start()
		{
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x00002134 File Offset: 0x00000334
		public void Stop()
		{
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnResize(EventArgs e)
		{
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnSizeChanged(EventArgs e)
		{
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x00002134 File Offset: 0x00000334
		private void method_2()
		{
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x00002134 File Offset: 0x00000334
		private void method_3()
		{
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x00002134 File Offset: 0x00000334
		private void method_4(object sender, EventArgs e)
		{
		}

		// Token: 0x040001F7 RID: 503
		private IContainer icontainer_0;

		// Token: 0x040001F8 RID: 504
		private Timer timer_0;

		// Token: 0x040001F9 RID: 505
		private int int_2;

		// Token: 0x040001FA RID: 506
		private int int_3;

		// Token: 0x040001FB RID: 507
		private Color color_1;

		// Token: 0x040001FC RID: 508
		private bool bool_5;

		// Token: 0x040001FD RID: 509
		private bool bool_6;

		// Token: 0x040001FE RID: 510
		private float float_0;

		// Token: 0x040001FF RID: 511
		private int int_4;

		// Token: 0x04000200 RID: 512
		private int int_5;

		// Token: 0x04000201 RID: 513
		private ProgressIndicatorStyle progressIndicatorStyle_0;

		// Token: 0x04000202 RID: 514
		[CompilerGenerated]
		private Font font_0;

		// Token: 0x04000203 RID: 515
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04000204 RID: 516
		[CompilerGenerated]
		private Color color_2;

		// Token: 0x04000205 RID: 517
		private float float_1;
	}
}
