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
	// Token: 0x0200004B RID: 75
	[ToolboxItem(true)]
	[DebuggerStepThrough]
	[ToolboxBitmap(typeof(System.Windows.Forms.Button))]
	[Designer(typeof(Guna2CircleButtonDesigner))]
	[Description("Advanced circle button control with animation effects features")]
	public class Guna2CircleButton : CircleButton
	{
		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600047D RID: 1149 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(true)]
		[Description("The properties that will be applied when the cursor is over the control")]
		public Guna.UI2.WinForms.Suite.ButtonState HoverState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x00002131 File Offset: 0x00000331
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Description("The properties that will be applied when the control is in a checked state")]
		public Guna.UI2.WinForms.Suite.ButtonState CheckedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x00002131 File Offset: 0x00000331
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

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000481 RID: 1153 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000482 RID: 1154 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(true)]
		[Description("If true, tiles will be applied")]
		public bool Tile
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000483 RID: 1155 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000484 RID: 1156 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(false)]
		[Browsable(true)]
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

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000486 RID: 1158 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(false)]
		[Description("If true, the control will be animated while interacting with the mouse")]
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

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000488 RID: 1160 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The properties that will be applied when the control is checked")]
		[Browsable(true)]
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

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600048A RID: 1162 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("The BackColor that will fill the control")]
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

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600048C RID: 1164 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("The border BackColor")]
		[DefaultValue(typeof(Color), "")]
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

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x000033DC File Offset: 0x000015DC
		// (set) Token: 0x0600048E RID: 1166 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Padding), "0, 0, 0, 0")]
		[Description("The thickness of the border. The higher the value, the thicker the border")]
		[Browsable(true)]
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

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000490 RID: 1168 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The color of the control when pressed down by the mouse")]
		[DefaultValue(typeof(Color), "Black")]
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

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000492 RID: 1170 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(30)]
		[Description("The visual effect of the pressing event. This property helps animate the pressing event")]
		[Browsable(true)]
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

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x00003304 File Offset: 0x00001504
		// (set) Token: 0x06000494 RID: 1172 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000496 RID: 1174 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		[Description("The curve angle of the control on all angles")]
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

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x06000498 RID: 1176 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The css-like style of the border. You can customize the border to meet your design needs")]
		[Browsable(true)]
		[DefaultValue(DashStyle.Solid)]
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

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600049A RID: 1178 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The border color")]
		[Browsable(true)]
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

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600049C RID: 1180 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x0600049E RID: 1182 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
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

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060004A0 RID: 1184 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("The control's image")]
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

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x00003364 File Offset: 0x00001564
		// (set) Token: 0x060004A2 RID: 1186 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The size of the control's image")]
		[DefaultValue(typeof(Size), "20, 20")]
		[Browsable(true)]
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

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x060004A4 RID: 1188 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x060004A6 RID: 1190 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The control's text position")]
		[Browsable(true)]
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

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x00003840 File Offset: 0x00001A40
		// (set) Token: 0x060004A8 RID: 1192 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x00003840 File Offset: 0x00001A40
		// (set) Token: 0x060004AA RID: 1194 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The control's horizontal text alignment")]
		[DefaultValue(2)]
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

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x0000346C File Offset: 0x0000166C
		// (set) Token: 0x060004AC RID: 1196 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(5)]
		[Description("The control's image alignment")]
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

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x00003858 File Offset: 0x00001A58
		// (set) Token: 0x060004AE RID: 1198 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("This property allows you to change how text is printed onto the control")]
		[DefaultValue(0)]
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
	}
}
