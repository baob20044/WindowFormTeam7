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
	// Token: 0x0200005A RID: 90
	[Description("An advanced button control that supports a gradient background")]
	[ToolboxBitmap(typeof(System.Windows.Forms.Button))]
	[ToolboxItem(true)]
	[DebuggerStepThrough]
	[Designer(typeof(Guna2GradientButtonDesigner))]
	public class Guna2GradientButton : GradientButton
	{
		// Token: 0x17000260 RID: 608
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060005FC RID: 1532 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060005FE RID: 1534 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x060005FF RID: 1535 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnResize(EventArgs e)
		{
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00002134 File Offset: 0x00000334
		private void method_26()
		{
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000601 RID: 1537 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Description("The properties that will be applied when the cursor is over the control")]
		[Browsable(true)]
		public GradientButtonState HoverState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x00002131 File Offset: 0x00000331
		[Description("The properties that will be applied when the control is in a checked state")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(true)]
		public GradientButtonState CheckedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x00002131 File Offset: 0x00000331
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Description("Custom images of the control")]
		public ButtonImages CustomImages
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000604 RID: 1540 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000605 RID: 1541 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000606 RID: 1542 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000607 RID: 1543 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000608 RID: 1544 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000609 RID: 1545 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The properties that will be applied when the control is checked")]
		[DefaultValue(false)]
		[Browsable(true)]
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

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x0600060A RID: 1546 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600060B RID: 1547 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The BackColor that will fill the control")]
		[DefaultValue(typeof(Color), "94, 148, 255")]
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

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x0600060C RID: 1548 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600060D RID: 1549 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x0600060E RID: 1550 RVA: 0x000033DC File Offset: 0x000015DC
		// (set) Token: 0x0600060F RID: 1551 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The thickness of the border. The higher the value, the thicker the border")]
		[DefaultValue(typeof(Padding), "0, 0, 0, 0")]
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

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000610 RID: 1552 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000611 RID: 1553 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000612 RID: 1554 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000613 RID: 1555 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The visual effect of the pressing event. This property helps animate the pressing event")]
		[DefaultValue(30)]
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

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000614 RID: 1556 RVA: 0x00003304 File Offset: 0x00001504
		// (set) Token: 0x06000615 RID: 1557 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(0)]
		[Description("The type of Button. The control can act as a toggle button, radio button or a general button")]
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

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000616 RID: 1558 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000617 RID: 1559 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(0)]
		[Description("The curve angle of the control on all angles")]
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

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000618 RID: 1560 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x06000619 RID: 1561 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x0600061A RID: 1562 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600061B RID: 1563 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The border color")]
		[DefaultValue(typeof(Color), "Black")]
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

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600061D RID: 1565 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(0)]
		[Description("The border thickness. The higher the value, the thicker the border")]
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

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x0600061E RID: 1566 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x0600061F RID: 1567 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000621 RID: 1569 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000622 RID: 1570 RVA: 0x00003364 File Offset: 0x00001564
		// (set) Token: 0x06000623 RID: 1571 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000624 RID: 1572 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x06000625 RID: 1573 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Setting the position of the control's image")]
		[DefaultValue(typeof(Point), "0, 0")]
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

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000626 RID: 1574 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x06000627 RID: 1575 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Point), "0, 0")]
		[Browsable(true)]
		[Description("The control's text position")]
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

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000628 RID: 1576 RVA: 0x00003840 File Offset: 0x00001A40
		// (set) Token: 0x06000629 RID: 1577 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The control's horizontal text alignment")]
		[DefaultValue(2)]
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

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x0600062A RID: 1578 RVA: 0x00003840 File Offset: 0x00001A40
		// (set) Token: 0x0600062B RID: 1579 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The control's image alignment")]
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

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x0000346C File Offset: 0x0000166C
		// (set) Token: 0x0600062D RID: 1581 RVA: 0x00002134 File Offset: 0x00000334
		[Description("This property allows you to change how text is printed onto the control")]
		[DefaultValue(5)]
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

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x0600062E RID: 1582 RVA: 0x00003858 File Offset: 0x00001A58
		// (set) Token: 0x0600062F RID: 1583 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000631 RID: 1585 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The second fill BackColor in a gradient mode")]
		[DefaultValue(typeof(Color), "255, 77, 165")]
		[Browsable(true)]
		public Color FillColor2
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000632 RID: 1586 RVA: 0x0000331C File Offset: 0x0000151C
		// (set) Token: 0x06000633 RID: 1587 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The gradient mode")]
		[DefaultValue(0)]
		[Browsable(false)]
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

		// Token: 0x0400014C RID: 332
		private bool bool_8;

		// Token: 0x0400014D RID: 333
		private int int_4;
	}
}
