using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.WinForms.Suite;

namespace Guna.UI2.WinForms
{
	// Token: 0x0200006A RID: 106
	[Description("An advanced resize control")]
	[ToolboxItem(true)]
	[DebuggerStepThrough]
	public class Guna2ResizeBox : ResizeControl
	{
		// Token: 0x17000349 RID: 841
		// (get) Token: 0x060007FD RID: 2045 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060007FE RID: 2046 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		[Description("The control's font style")]
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

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x060007FF RID: 2047 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000800 RID: 2048 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
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

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000801 RID: 2049 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000802 RID: 2050 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The control's ForeColor")]
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

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000803 RID: 2051 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000804 RID: 2052 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Control), "")]
		[Description("The target control to resize")]
		[Browsable(true)]
		public Control TargetControl
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000805 RID: 2053 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000806 RID: 2054 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000807 RID: 2055 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000808 RID: 2056 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The BackColor that will fill the control")]
		[Browsable(true)]
		[DefaultValue(typeof(Color), "Black")]
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

		// Token: 0x0400018D RID: 397
		[CompilerGenerated]
		private Font font_0;

		// Token: 0x0400018E RID: 398
		[CompilerGenerated]
		private string string_0;

		// Token: 0x0400018F RID: 399
		[CompilerGenerated]
		private Color color_1;
	}
}
