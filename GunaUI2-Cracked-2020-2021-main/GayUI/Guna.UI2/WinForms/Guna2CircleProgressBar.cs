using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.WinForms.Enums;
using Guna.UI2.WinForms.Suite;

namespace Guna.UI2.WinForms
{
	// Token: 0x0200004D RID: 77
	[DebuggerStepThrough]
	[ToolboxItem(true)]
	[Description("Advanced progress bar control")]
	[ToolboxBitmap(typeof(System.Windows.Forms.ProgressBar))]
	public class Guna2CircleProgressBar : CircleProgressBar
	{
		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060004B8 RID: 1208 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The control's text")]
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

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060004BA RID: 1210 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060004BC RID: 1212 RVA: 0x00002134 File Offset: 0x00000334
		[Description("If true, the control will be animated while interacting with the mouse")]
		[DefaultValue(false)]
		[Browsable(true)]
		public bool Animated
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x00002145 File Offset: 0x00000345
		// (set) Token: 0x060004BE RID: 1214 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("The speed of the control's animation")]
		[DefaultValue(0.6f)]
		public float AnimationSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060004C0 RID: 1216 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Shadow property of the control to add and customize a control's shadow")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(true)]
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

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x0000346C File Offset: 0x0000166C
		// (set) Token: 0x060004C2 RID: 1218 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(5)]
		[Description("This property allows you to change how text is printed onto the control")]
		[Browsable(true)]
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

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060004C4 RID: 1220 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The control's image")]
		[Browsable(true)]
		[DefaultValue(typeof(Image), "")]
		public Image Image
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x00003364 File Offset: 0x00001564
		// (set) Token: 0x060004C6 RID: 1222 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(typeof(Size), "42, 42")]
		[Description("The size of the control's image")]
		public Size ImageSize
		{
			get
			{
				return default(Size);
			}
			set
			{
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x060004C8 RID: 1224 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Point), "0, 0")]
		[Description("Setting the position of the control's image")]
		[Browsable(true)]
		public Point ImageOffset
		{
			get
			{
				return default(Point);
			}
			set
			{
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060004CA RID: 1226 RVA: 0x00002134 File Offset: 0x00000334
		[Description("If true, the control's percentile value will be shown")]
		[DefaultValue(false)]
		[Browsable(true)]
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

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060004CC RID: 1228 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("Setting the position on the control that will be filled")]
		[DefaultValue(0)]
		public int FillOffset
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060004CD RID: 1229 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060004CE RID: 1230 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(false)]
		public bool EnsureVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060004D0 RID: 1232 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(false)]
		[Description("If true, the control will progress in a backward direction")]
		[Browsable(true)]
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

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060004D2 RID: 1234 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The thickness of the control's progress")]
		[DefaultValue(23)]
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

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060004D4 RID: 1236 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The position of the control's progress")]
		[DefaultValue(0)]
		[Browsable(true)]
		public int ProgressOffset
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060004D6 RID: 1238 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The thickness of the control's progress")]
		[DefaultValue(23)]
		[Browsable(true)]
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

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060004D8 RID: 1240 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "139, 201, 77")]
		[Browsable(true)]
		[Description("The progress BackColor")]
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

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060004DA RID: 1242 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "139, 201, 77")]
		[Description("The progress second BackColor")]
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

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x00003948 File Offset: 0x00001B48
		// (set) Token: 0x060004DC RID: 1244 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(BrushMode.Gradient)]
		[Browsable(true)]
		[Description("The progress brush mode while running")]
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

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x0000331C File Offset: 0x0000151C
		// (set) Token: 0x060004DE RID: 1246 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("The progress gradient mode")]
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

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060004E0 RID: 1248 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "213, 218, 223")]
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

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060004E2 RID: 1250 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The inner BackColor of the control")]
		[Browsable(true)]
		[DefaultValue(typeof(Color), "Transparent")]
		public Color InnerColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x00003960 File Offset: 0x00001B60
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("The design type of progress start")]
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

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x00003960 File Offset: 0x00001B60
		// (set) Token: 0x060004E6 RID: 1254 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(0)]
		[Description("The design type of progress end")]
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

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060004E8 RID: 1256 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The progress maximum value")]
		[DefaultValue(100)]
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

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060004EA RID: 1258 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The progress minimum value")]
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

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060004EC RID: 1260 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(0)]
		[Description("The progress value")]
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

		// Token: 0x04000111 RID: 273
		[CompilerGenerated]
		private string string_0;
	}
}
