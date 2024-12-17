using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Guna.UI2.WinForms.Enums;
using Guna.UI2.WinForms.Suite;

namespace Guna.UI2.WinForms
{
	// Token: 0x0200004A RID: 74
	[DebuggerStepThrough]
	[ToolboxItem(true)]
	[Designer(typeof(Guna2ButtonDesigner))]
	[ToolboxBitmap(typeof(System.Windows.Forms.Button))]
	[Description("An advanced Button control that supports animations, border styles, radius customizations, etc")]
	public class Guna2Button : Guna.UI2.WinForms.Suite.Button
	{
		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x00002131 File Offset: 0x00000331
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Description("The properties that will be applied when the cursor is over the control")]
		public Guna.UI2.WinForms.Suite.ButtonState HoverState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000448 RID: 1096 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(false)]
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

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x00002131 File Offset: 0x00000331
		[Browsable(true)]
		[Description("The properties that will be applied when the control is in a checked state")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public Guna.UI2.WinForms.Suite.ButtonState CheckedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x0600044A RID: 1098 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600044B RID: 1099 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x0600044C RID: 1100 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnResize(EventArgs e)
		{
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00002134 File Offset: 0x00000334
		private void method_24()
		{
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x0600044E RID: 1102 RVA: 0x00002131 File Offset: 0x00000331
		[Browsable(true)]
		[Description("Custom images of the control")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public ButtonImages CustomImages
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000450 RID: 1104 RVA: 0x00002134 File Offset: 0x00000334
		[Description("If true, the background will allow a transparent color")]
		[DefaultValue(false)]
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

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000452 RID: 1106 RVA: 0x00002134 File Offset: 0x00000334
		[Description("If true, the control will be animated while interacting with the mouse")]
		[Browsable(true)]
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

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000454 RID: 1108 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("The properties that will be applied when the control is checked")]
		[DefaultValue(false)]
		public bool Checked
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000456 RID: 1110 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The BackColor that will fill the control")]
		[Browsable(true)]
		[DefaultValue(typeof(Color), "94, 148, 255")]
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

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000458 RID: 1112 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The border BackColor")]
		[DefaultValue(typeof(Color), "")]
		[Browsable(true)]
		public Color CustomBorderColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x000033DC File Offset: 0x000015DC
		// (set) Token: 0x0600045A RID: 1114 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Padding), "0, 0, 0, 0")]
		[Browsable(true)]
		[Description("The thickness of the border. The higher the value, the thicker the border")]
		public Padding CustomBorderThickness
		{
			get
			{
				return default(Padding);
			}
			set
			{
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600045C RID: 1116 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "Black")]
		[Description("The color of the control when pressed down by the mouse")]
		[Browsable(true)]
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

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600045E RID: 1118 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(30)]
		[Browsable(true)]
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

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x0600045F RID: 1119 RVA: 0x00003304 File Offset: 0x00001504
		// (set) Token: 0x06000460 RID: 1120 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The type of Button. The control can act as a toggle button, radio button or a general button")]
		[DefaultValue(0)]
		public ButtonMode ButtonMode
		{
			get
			{
				return ButtonMode.DefaultButton;
			}
			set
			{
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000462 RID: 1122 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x06000464 RID: 1124 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The css-like style of the border. You can customize the border to meet your design needs")]
		[DefaultValue(DashStyle.Solid)]
		[Browsable(true)]
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

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000466 RID: 1126 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000468 RID: 1128 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x0600046A RID: 1130 RVA: 0x00002134 File Offset: 0x00000334
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(true)]
		[Description("Shadow property of the control")]
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

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x0600046C RID: 1132 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(typeof(Image), "")]
		[Description("The control's image")]
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

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x00003364 File Offset: 0x00001564
		// (set) Token: 0x0600046E RID: 1134 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("The size of the control's image")]
		[DefaultValue(typeof(Size), "20, 20")]
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

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x06000470 RID: 1136 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x06000472 RID: 1138 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("The control's text position")]
		[DefaultValue(typeof(Point), "0, 0")]
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

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x00003840 File Offset: 0x00001A40
		// (set) Token: 0x06000474 RID: 1140 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(2)]
		[Description("The control's text alignment")]
		[Browsable(true)]
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

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x00003840 File Offset: 0x00001A40
		// (set) Token: 0x06000476 RID: 1142 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(2)]
		[Description("The control's image alignment")]
		[Browsable(true)]
		public HorizontalAlignment ImageAlign
		{
			get
			{
				return HorizontalAlignment.Left;
			}
			set
			{
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x0000346C File Offset: 0x0000166C
		// (set) Token: 0x06000478 RID: 1144 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("This property allows you to change how text is printed onto the control")]
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

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x00003858 File Offset: 0x00001A58
		// (set) Token: 0x0600047A RID: 1146 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(0)]
		[Browsable(true)]
		[Description("The control's text transform property which allows you to change the appearance of the text")]
		public TextTransform TextTransform
		{
			get
			{
				return TextTransform.None;
			}
			set
			{
			}
		}

		// Token: 0x0400010F RID: 271
		private bool bool_8;

		// Token: 0x04000110 RID: 272
		private int int_3;
	}
}
