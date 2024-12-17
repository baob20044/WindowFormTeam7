using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Guna.UI2.WinForms.Enums;
using Guna.UI2.WinForms.Suite;

namespace Guna.UI2.WinForms
{
	// Token: 0x02000074 RID: 116
	[ToolboxItem(true)]
	[Designer(typeof(Guna2TrackBarDesigner))]
	[DebuggerStepThrough]
	[ToolboxBitmap(typeof(System.Windows.Forms.TrackBar))]
	[Description("A TrackBar Control")]
	public class Guna2TrackBar : Guna.UI2.WinForms.Suite.TrackBar
	{
		// Token: 0x17000391 RID: 913
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x00002131 File Offset: 0x00000331
		[Browsable(true)]
		[Description("The properties that will be applied when the cursor is over the control")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public TrackBarState HoverState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x060008CB RID: 2251 RVA: 0x000033AC File Offset: 0x000015AC
		// (set) Token: 0x060008CC RID: 2252 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Gets or Sets the style of the trackbar")]
		[DefaultValue(TrackBarStyle.Default)]
		[Browsable(true)]
		public TrackBarStyle Style
		{
			get
			{
				return TrackBarStyle.Default;
			}
			set
			{
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x060008CD RID: 2253 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060008CE RID: 2254 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The trackbar's font style")]
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

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x060008CF RID: 2255 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060008D0 RID: 2256 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		[Description("The trackbar's text")]
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

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x060008D1 RID: 2257 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060008D2 RID: 2258 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The trackbar's ForeColor")]
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

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x060008D3 RID: 2259 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060008D4 RID: 2260 RVA: 0x00002134 File Offset: 0x00000334
		[Category("Behaviour")]
		[DefaultValue(true)]
		[Browsable(false)]
		public bool UseSelectable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x060008D5 RID: 2261 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060008D6 RID: 2262 RVA: 0x00002134 File Offset: 0x00000334
		[Category("Appearance")]
		[DefaultValue(false)]
		[Browsable(false)]
		public bool DisplayFocus
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x060008D7 RID: 2263 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060008D8 RID: 2264 RVA: 0x00002134 File Offset: 0x00000334
		[Category("Appearance")]
		[DefaultValue(true)]
		public bool IndicateFocus
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x060008D9 RID: 2265 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060008DA RID: 2266 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The trackbar's current value")]
		[DefaultValue(50)]
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

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x060008DB RID: 2267 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060008DC RID: 2268 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The trackbar's minimum value")]
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

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x060008DD RID: 2269 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060008DE RID: 2270 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(100)]
		[Description("The trackbar's maximum value")]
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

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x060008DF RID: 2271 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060008E0 RID: 2272 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(1)]
		[Description("The trackbar's small change")]
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

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x060008E1 RID: 2273 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060008E2 RID: 2274 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The trackbar's large change")]
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

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x060008E3 RID: 2275 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060008E4 RID: 2276 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The trackbar's mouse wheel trackbar change")]
		[DefaultValue(10)]
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

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x060008E5 RID: 2277 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060008E6 RID: 2278 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("The trackbar's thumb color")]
		[DefaultValue(typeof(Color), "160, 113 225")]
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

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x060008E7 RID: 2279 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060008E8 RID: 2280 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "192, 200, 207")]
		[Description("The trackbar's fill color")]
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

		// Token: 0x040001CD RID: 461
		[CompilerGenerated]
		private Font font_0;

		// Token: 0x040001CE RID: 462
		[CompilerGenerated]
		private string string_0;

		// Token: 0x040001CF RID: 463
		[CompilerGenerated]
		private Color color_2;
	}
}
