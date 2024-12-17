using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.WinForms.Enums;
using Guna.UI2.WinForms.Suite;

namespace Guna.UI2.WinForms
{
	// Token: 0x02000050 RID: 80
	[ToolboxItem(true)]
	[ToolboxBitmap(typeof(System.Windows.Forms.Button))]
	[Description("Advanced controlbox control that supports animations")]
	[DebuggerStepThrough]
	public class Guna2ControlBox : ControlBox
	{
		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x00002131 File Offset: 0x00000331
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Description("The properties that will be applied when the cursor is over the control")]
		public ControlBoxState HoverState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x0600052B RID: 1323 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The control's font style")]
		[Browsable(false)]
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

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x0600052D RID: 1325 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600052F RID: 1327 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Description("The control's ForeColor")]
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

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000531 RID: 1329 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The curve angle of the control on all angles")]
		[DefaultValue(0)]
		[Browsable(true)]
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

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000532 RID: 1330 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x06000533 RID: 1331 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(DashStyle.Solid)]
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

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000535 RID: 1333 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("The border color")]
		[DefaultValue(typeof(Color), "Black")]
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

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000537 RID: 1335 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(0)]
		[Description("The border thickness. The higher the value, the thicker the border")]
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

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000539 RID: 1337 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Shadow property of the control to add and customize a control's shadow")]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
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

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600053B RID: 1339 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x0600053C RID: 1340 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600053D RID: 1341 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "")]
		[Description("The BackColor that will fill the control")]
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

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x0600053E RID: 1342 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600053F RID: 1343 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The control's icon color")]
		[DefaultValue(typeof(Color), "")]
		[Browsable(true)]
		public Color IconColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000540 RID: 1344 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000541 RID: 1345 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("If true, the control will be animated while interacting with the mouse")]
		[DefaultValue(false)]
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

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000542 RID: 1346 RVA: 0x00002145 File Offset: 0x00000345
		// (set) Token: 0x06000543 RID: 1347 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The size of the control's icon")]
		[Browsable(true)]
		[DefaultValue(10f)]
		public float CustomIconSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000544 RID: 1348 RVA: 0x00003990 File Offset: 0x00001B90
		// (set) Token: 0x06000545 RID: 1349 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(ControlBoxType.CloseBox)]
		[Description("The controlbox type: close, maximize or minimize")]
		public ControlBoxType ControlBoxType
		{
			get
			{
				return ControlBoxType.MinimizeBox;
			}
			set
			{
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000546 RID: 1350 RVA: 0x000039A8 File Offset: 0x00001BA8
		// (set) Token: 0x06000547 RID: 1351 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(ControlBoxStyle.Windows10)]
		[Description("The controlbox style: Windows or custom")]
		[Browsable(true)]
		public ControlBoxStyle ControlBoxStyle
		{
			get
			{
				return ControlBoxStyle.Windows10;
			}
			set
			{
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000548 RID: 1352 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000549 RID: 1353 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(typeof(Color), "Black")]
		[Description("The color of the control when pressed down by the mouse")]
		public Color PressedColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x0600054A RID: 1354 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600054B RID: 1355 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(30)]
		[Description("The visual effect of the pressing event. This property helps animate the pressing event")]
		public int PressedDepth
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x0400011E RID: 286
		[CompilerGenerated]
		private Font font_1;

		// Token: 0x0400011F RID: 287
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04000120 RID: 288
		[CompilerGenerated]
		private Color color_4;
	}
}
