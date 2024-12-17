using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.Material.Animation;
using Guna.UI2.WinForms.Enums;
using Guna.UI2.WinForms.Interfaces;

namespace ns0
{
	// Token: 0x02000070 RID: 112
	[DebuggerStepThrough]
	[DefaultEvent("Scroll")]
	[ToolboxItem(true)]
	[Description("An advanced Slider Control")]
	[ToolboxBitmap(typeof(TrackBar))]
	internal class Control0 : Control, IControl
	{
		// Token: 0x17000361 RID: 865
		// (get) Token: 0x0600084E RID: 2126 RVA: 0x00002136 File Offset: 0x00000336
		[Description("Gets a value that indicates whether the Component is currently in design mode.")]
		[Browsable(false)]
		public bool IsDesignMode
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0()
		{
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00002134 File Offset: 0x00000334
		private void method_1(object sender)
		{
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00002134 File Offset: 0x00000334
		private void method_2(object sender)
		{
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00002134 File Offset: 0x00000334
		private void method_3()
		{
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06000854 RID: 2132 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000855 RID: 2133 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler Event_0
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

		// Token: 0x06000856 RID: 2134 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected virtual void OnValueChanged(EventArgs e)
		{
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06000857 RID: 2135 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000858 RID: 2136 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler Event_1
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

		// Token: 0x06000859 RID: 2137 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected virtual void OnScroll(EventArgs e)
		{
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x0600085A RID: 2138 RVA: 0x0000343C File Offset: 0x0000163C
		// (set) Token: 0x0600085B RID: 2139 RVA: 0x00002134 File Offset: 0x00000334
		private Rectangle Rectangle_0
		{
			get
			{
				return default(Rectangle);
			}
			set
			{
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x0600085C RID: 2140 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600085D RID: 2141 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The slider's thumb color")]
		[Category("Colors")]
		[DefaultValue(typeof(Color), "98, 0, 238")]
		public Color Color_0
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x0600085E RID: 2142 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600085F RID: 2143 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The slider's fill color")]
		[Category("Colors")]
		[DefaultValue(typeof(Color), "198, 174, 231")]
		public Color Color_1
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000860 RID: 2144 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000861 RID: 2145 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The slider's minimum value")]
		[DefaultValue(0)]
		public int Int32_0
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000862 RID: 2146 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000863 RID: 2147 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(100)]
		[Description("The slider's maximum value")]
		public int Int32_1
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000864 RID: 2148 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000865 RID: 2149 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(false)]
		[Description("If true, the slider slides backwards")]
		public bool Boolean_0
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000866 RID: 2150 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000867 RID: 2151 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The slider's current value")]
		[DefaultValue(0)]
		public int Int32_2
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000868 RID: 2152 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000869 RID: 2153 RVA: 0x00002134 File Offset: 0x00000334
		private int Int32_3
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x0600086A RID: 2154 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600086B RID: 2155 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The slider's small change")]
		[DefaultValue(1)]
		public int Int32_4
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x0600086C RID: 2156 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600086D RID: 2157 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The slider's large change")]
		[DefaultValue(10)]
		public int Int32_5
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x0600086E RID: 2158 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x0600086F RID: 2159 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The slider's font style")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public Font Font_0
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

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000870 RID: 2160 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000871 RID: 2161 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The slider's text")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public string String_0
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

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000872 RID: 2162 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000873 RID: 2163 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		[Description("The slider's ForeColor")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Color Color_2
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

		// Token: 0x06000874 RID: 2164 RVA: 0x00002134 File Offset: 0x00000334
		private void method_4()
		{
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x00002134 File Offset: 0x00000334
		private void method_5()
		{
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnGotFocus(EventArgs e)
		{
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnLostFocus(EventArgs e)
		{
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnKeyUp(KeyEventArgs e)
		{
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseDown(MouseEventArgs e)
		{
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseEnter(EventArgs e)
		{
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseLeave(EventArgs e)
		{
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseMove(MouseEventArgs e)
		{
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseUp(MouseEventArgs e)
		{
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseWheel(MouseEventArgs e)
		{
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnSizeChanged(EventArgs e)
		{
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00002136 File Offset: 0x00000336
		protected override bool ProcessDialogKey(Keys keyData)
		{
			return false;
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x040001AA RID: 426
		private MouseState mouseState_0;

		// Token: 0x040001AB RID: 427
		private Orientation orientation_0;

		// Token: 0x040001AC RID: 428
		private int int_0;

		// Token: 0x040001AD RID: 429
		private Rectangle rectangle_0;

		// Token: 0x040001AE RID: 430
		private Rectangle rectangle_1;

		// Token: 0x040001AF RID: 431
		private Rectangle rectangle_2;

		// Token: 0x040001B0 RID: 432
		private Rectangle rectangle_3;

		// Token: 0x040001B1 RID: 433
		private int int_1;

		// Token: 0x040001B2 RID: 434
		private int int_2;

		// Token: 0x040001B3 RID: 435
		private bool bool_0;

		// Token: 0x040001B4 RID: 436
		private AnimationManager animationManager_0;

		// Token: 0x040001B5 RID: 437
		private AnimationManager animationManager_1;

		// Token: 0x040001B6 RID: 438
		[CompilerGenerated]
		private EventHandler ValueChanged;

		// Token: 0x040001B7 RID: 439
		[CompilerGenerated]
		private EventHandler Scroll;

		// Token: 0x040001B8 RID: 440
		private Color color_0;

		// Token: 0x040001B9 RID: 441
		private Color color_1;

		// Token: 0x040001BA RID: 442
		private int int_3;

		// Token: 0x040001BB RID: 443
		private int int_4;

		// Token: 0x040001BC RID: 444
		private bool bool_1;

		// Token: 0x040001BD RID: 445
		private int int_5;

		// Token: 0x040001BE RID: 446
		private int int_6;

		// Token: 0x040001BF RID: 447
		private int int_7;

		// Token: 0x040001C0 RID: 448
		[CompilerGenerated]
		private Font font_0;

		// Token: 0x040001C1 RID: 449
		[CompilerGenerated]
		private string string_0;

		// Token: 0x040001C2 RID: 450
		[CompilerGenerated]
		private Color color_2;
	}
}
