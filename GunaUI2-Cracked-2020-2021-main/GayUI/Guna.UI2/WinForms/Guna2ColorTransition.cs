using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Guna.UI2.WinForms
{
	// Token: 0x0200004E RID: 78
	[ToolboxItem(true)]
	[DebuggerStepThrough]
	[Description("Advanced Color transition component")]
	public class Guna2ColorTransition : Component
	{
		// Token: 0x060004ED RID: 1261 RVA: 0x0000214C File Offset: 0x0000034C
		public Guna2ColorTransition()
		{
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x0000214C File Offset: 0x0000034C
		public Guna2ColorTransition(IContainer container)
		{
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00002134 File Offset: 0x00000334
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0()
		{
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00002134 File Offset: 0x00000334
		private void method_1()
		{
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x060004F2 RID: 1266 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x060004F3 RID: 1267 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x060004F4 RID: 1268 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected virtual void OnValueChanged(EventArgs e)
		{
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060004F6 RID: 1270 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		public Color[] ColorArray
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060004F8 RID: 1272 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The start color to apply to the parent's BackColor")]
		[Browsable(true)]
		[DefaultValue(typeof(Color), "Red")]
		public Color StartColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060004FA RID: 1274 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "Blue")]
		[Description("The end color to apply to the parent's BackColor")]
		[Browsable(true)]
		public Color EndColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060004FC RID: 1276 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("The transition progress value")]
		[DefaultValue(0)]
		public int ProgressValue
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060004FE RID: 1278 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(20)]
		[Description("The transition interval")]
		[Browsable(true)]
		public int Interval
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x000032EC File Offset: 0x000014EC
		[Description("The current color applied to the parent's BackColor")]
		[Browsable(true)]
		public Color Value
		{
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000500 RID: 1280 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000501 RID: 1281 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(false)]
		[Browsable(true)]
		[Description("If true, the transition will start automatically")]
		public bool AutoTransition
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000502 RID: 1282 RVA: 0x00002136 File Offset: 0x00000336
		[DefaultValue(100)]
		[Description("The control's maximum value")]
		public int Maximum
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x00002136 File Offset: 0x00000336
		[DefaultValue(0)]
		[Description("The control's minimum value")]
		public int Minimum
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00002134 File Offset: 0x00000334
		private void method_2()
		{
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00002134 File Offset: 0x00000334
		private void method_3(object sender, EventArgs e)
		{
		}

		// Token: 0x04000112 RID: 274
		private Timer timer_0;

		// Token: 0x04000113 RID: 275
		private IContainer icontainer_0;

		// Token: 0x04000115 RID: 277
		private Color[] color_0;

		// Token: 0x04000116 RID: 278
		private Color color_1;

		// Token: 0x04000117 RID: 279
		private Color color_2;

		// Token: 0x04000118 RID: 280
		private int int_0;

		// Token: 0x04000119 RID: 281
		private Color color_3;

		// Token: 0x0400011A RID: 282
		private int int_1;

		// Token: 0x0400011B RID: 283
		private int int_2;
	}
}
