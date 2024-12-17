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
	// Token: 0x02000055 RID: 85
	[DebuggerStepThrough]
	[Designer(typeof(Guna2DateTimePickerDesigner))]
	[Description("An advanced DateTimePicker Control")]
	[ToolboxItem(true)]
	[ToolboxBitmap(typeof(System.Windows.Forms.DateTimePicker))]
	public class Guna2DateTimePicker : Guna.UI2.WinForms.Suite.DateTimePicker
	{
		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000598 RID: 1432 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600059A RID: 1434 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("If true, the border on the control is rounded off automatically")]
		[DefaultValue(false)]
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

		// Token: 0x0600059B RID: 1435 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnResize(EventArgs e)
		{
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00002134 File Offset: 0x00000334
		private void method_22()
		{
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x00002131 File Offset: 0x00000331
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Description("The properties that will be applied when the cursor is over the control")]
		public DateTimePickerState HoverState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x0600059E RID: 1438 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(true)]
		[Description("The properties that will be applied when the control is in a checked state")]
		public DateTimePickerState CheckedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060005A0 RID: 1440 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(0)]
		[Description("The curve angle of the control on all angles")]
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

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x060005A2 RID: 1442 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(DashStyle.Solid)]
		[Browsable(true)]
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

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060005A4 RID: 1444 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "Black")]
		[Description("The border color")]
		[Browsable(true)]
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

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060005A6 RID: 1446 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("The border thickness. The higher the value, the thicker the border")]
		[DefaultValue(0)]
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

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060005A8 RID: 1448 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("Shadow property of the control to add and customize a control's shadow")]
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

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060005AA RID: 1450 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060005AC RID: 1452 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		[Description("The control's color when focused")]
		[DefaultValue(typeof(Color), "")]
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

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x060005AD RID: 1453 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x060005AE RID: 1454 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x00003840 File Offset: 0x00001A40
		// (set) Token: 0x060005B0 RID: 1456 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(0)]
		[Description("The control's horizontal text alignment")]
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

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x0000346C File Offset: 0x0000166C
		// (set) Token: 0x060005B2 RID: 1458 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(5)]
		[Description("This property allows you to change how text is printed onto the control")]
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

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x00003858 File Offset: 0x00001A58
		// (set) Token: 0x060005B4 RID: 1460 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060005B6 RID: 1462 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060005B8 RID: 1464 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(false)]
		[Description("The properties that will be applied when the control is checked")]
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

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060005BA RID: 1466 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(typeof(Color), "255, 136, 77")]
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

		// Token: 0x0400012A RID: 298
		private bool bool_8;

		// Token: 0x0400012B RID: 299
		private int int_2;
	}
}
