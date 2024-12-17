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
	// Token: 0x0200004F RID: 79
	[DebuggerStepThrough]
	[Designer(typeof(Guna2ComboBoxDesigner))]
	[ToolboxBitmap(typeof(System.Windows.Forms.ComboBox))]
	[Description("Advanced ComboBox Control")]
	[ToolboxItem(true)]
	public class Guna2ComboBox : Guna.UI2.WinForms.Suite.ComboBox
	{
		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000508 RID: 1288 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06000509 RID: 1289 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnResize(EventArgs e)
		{
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00002134 File Offset: 0x00000334
		private void method_19()
		{
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x0600050C RID: 1292 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x0600050D RID: 1293 RVA: 0x00003978 File Offset: 0x00001B78
		// (set) Token: 0x0600050E RID: 1294 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("Gets or Sets the style of the textbox")]
		[DefaultValue(TextBoxStyle.Default)]
		public TextBoxStyle Style
		{
			get
			{
				return TextBoxStyle.Default;
			}
			set
			{
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x0600050F RID: 1295 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000510 RID: 1296 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(false)]
		[Browsable(true)]
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

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(true)]
		[Description("The properties that will be applied when the cursor is over the control")]
		public ComboBoxState HoverState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x00002131 File Offset: 0x00000331
		[Browsable(true)]
		[Description("The properties that will be applied when the control is focused")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public ComboBoxState FocusedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x00002131 File Offset: 0x00000331
		[Description("The appearance of the control's items")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(true)]
		public ComboBoxItemsAppearance ItemsAppearance
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000515 RID: 1301 RVA: 0x00002134 File Offset: 0x00000334
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(true)]
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

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x0000346C File Offset: 0x0000166C
		// (set) Token: 0x06000517 RID: 1303 RVA: 0x00002134 File Offset: 0x00000334
		[Description("This property allows you to change how text is printed onto the control")]
		[Browsable(true)]
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

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x00003858 File Offset: 0x00001A58
		// (set) Token: 0x06000519 RID: 1305 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The control's text transform property which allows you to change the appearance of the text")]
		[DefaultValue(0)]
		[Browsable(true)]
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

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600051B RID: 1307 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
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

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600051D RID: 1309 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(-1)]
		[Description("The starting or pre-selected index or position in the items list")]
		public int StartIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x0600051E RID: 1310 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600051F RID: 1311 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "White")]
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

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000521 RID: 1313 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "217, 221, 226")]
		[Browsable(true)]
		[Description("The border color")]
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

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000522 RID: 1314 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000523 RID: 1315 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		[DefaultValue(typeof(Color), "136, 191, 255")]
		[Description("The control's color when focused")]
		public Color FocusedColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000525 RID: 1317 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The border thickness. The higher the value, the thicker the border")]
		[DefaultValue(1)]
		[Browsable(true)]
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

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x06000527 RID: 1319 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x0400011C RID: 284
		private bool bool_2;

		// Token: 0x0400011D RID: 285
		private int int_3;
	}
}
