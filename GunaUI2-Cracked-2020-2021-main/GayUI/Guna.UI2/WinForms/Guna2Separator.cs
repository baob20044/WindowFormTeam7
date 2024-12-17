using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms.Design;
using Guna.UI2.WinForms.Suite;

namespace Guna.UI2.WinForms
{
	// Token: 0x0200006C RID: 108
	[ToolboxItem(true)]
	[Designer(typeof(Guna2SeparatorDesigner))]
	[Description("A Separator Control")]
	[DebuggerStepThrough]
	public class Guna2Separator : Separator
	{
		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000814 RID: 2068 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000815 RID: 2069 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		[Description("The separator's font style")]
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

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000816 RID: 2070 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000817 RID: 2071 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The separator's text")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
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

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000818 RID: 2072 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000819 RID: 2073 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Description("The separator's ForeColor")]
		[Browsable(false)]
		public new string ForeColor
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

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x0600081A RID: 2074 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600081B RID: 2075 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "193, 200, 207")]
		[Browsable(true)]
		[Description("The BackColor that will fill the control")]
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

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x0600081C RID: 2076 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600081D RID: 2077 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(1)]
		[Description("The thickness of the separator control")]
		[Browsable(true)]
		public int FillThickness
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x0600081E RID: 2078 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x0600081F RID: 2079 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(DashStyle.Solid)]
		[Description("The css-style of the separator")]
		[Browsable(true)]
		public DashStyle FillStyle
		{
			get
			{
				return DashStyle.Solid;
			}
			set
			{
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000821 RID: 2081 RVA: 0x00002134 File Offset: 0x00000334
		[Description("If true, the background will allow a transparent color")]
		[Browsable(true)]
		[DefaultValue(false)]
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

		// Token: 0x04000193 RID: 403
		[CompilerGenerated]
		private Font font_0;

		// Token: 0x04000194 RID: 404
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04000195 RID: 405
		[CompilerGenerated]
		private string string_1;
	}
}
