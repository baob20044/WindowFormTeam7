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
	// Token: 0x0200005B RID: 91
	[ToolboxBitmap(typeof(System.Windows.Forms.Button))]
	[Description("An advanced circle button")]
	[Designer(typeof(Guna2GradientCircleButtonDesigner))]
	[DebuggerStepThrough]
	[ToolboxItem(true)]
	public class Guna2GradientCircleButton : GradientCircleButton
	{
		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000635 RID: 1589 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000636 RID: 1590 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000637 RID: 1591 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000638 RID: 1592 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(true)]
		[Description("If true, tiles will be applied")]
		[Browsable(true)]
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

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000639 RID: 1593 RVA: 0x00002131 File Offset: 0x00000331
		[Description("The properties that will be applied when the cursor is over the control")]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public GradientButtonState HoverState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x0600063A RID: 1594 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(true)]
		[Description("The properties that will be applied when the control is in a checked state")]
		public GradientButtonState CheckedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x0600063B RID: 1595 RVA: 0x00002131 File Offset: 0x00000331
		[Description("Custom images of the control")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(true)]
		public ButtonImages CustomImages
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x0600063C RID: 1596 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600063D RID: 1597 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x0600063E RID: 1598 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600063F RID: 1599 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000640 RID: 1600 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000641 RID: 1601 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(false)]
		[Description("The properties that will be applied when the control is checked")]
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

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000643 RID: 1603 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000645 RID: 1605 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "")]
		[Browsable(true)]
		[Description("The border BackColor")]
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

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x000033DC File Offset: 0x000015DC
		// (set) Token: 0x06000647 RID: 1607 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000648 RID: 1608 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000649 RID: 1609 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("The color of the control when pressed down by the mouse")]
		[DefaultValue(typeof(Color), "Black")]
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

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x0600064A RID: 1610 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600064B RID: 1611 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x0600064C RID: 1612 RVA: 0x00003304 File Offset: 0x00001504
		// (set) Token: 0x0600064D RID: 1613 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x0600064E RID: 1614 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600064F RID: 1615 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000650 RID: 1616 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x06000651 RID: 1617 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000652 RID: 1618 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000653 RID: 1619 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000654 RID: 1620 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000655 RID: 1621 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000657 RID: 1623 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000659 RID: 1625 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The control's image")]
		[DefaultValue(typeof(Image), "")]
		[Browsable(true)]
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

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x0600065A RID: 1626 RVA: 0x00003364 File Offset: 0x00001564
		// (set) Token: 0x0600065B RID: 1627 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The size of the control's image")]
		[Browsable(true)]
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

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x0600065D RID: 1629 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x0600065E RID: 1630 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x0600065F RID: 1631 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x00003840 File Offset: 0x00001A40
		// (set) Token: 0x06000661 RID: 1633 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(2)]
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

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000662 RID: 1634 RVA: 0x00003840 File Offset: 0x00001A40
		// (set) Token: 0x06000663 RID: 1635 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x0000346C File Offset: 0x0000166C
		// (set) Token: 0x06000665 RID: 1637 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x00003858 File Offset: 0x00001A58
		// (set) Token: 0x06000667 RID: 1639 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000669 RID: 1641 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "255, 77, 165")]
		[Description("The control's second fill BacColor in a gradient mode")]
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

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x0000331C File Offset: 0x0000151C
		// (set) Token: 0x0600066B RID: 1643 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The control's gradient mode")]
		[Browsable(false)]
		[DefaultValue(0)]
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
	}
}
