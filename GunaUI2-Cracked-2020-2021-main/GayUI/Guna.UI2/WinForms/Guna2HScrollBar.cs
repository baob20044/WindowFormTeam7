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
	// Token: 0x0200005F RID: 95
	[DebuggerStepThrough]
	[Description("A horizontal ScrollBar Control")]
	[ToolboxItem(true)]
	[ToolboxBitmap(typeof(System.Windows.Forms.HScrollBar))]
	[Designer(typeof(Guna2ScrollBarDesigner))]
	public class Guna2HScrollBar : Guna.UI2.WinForms.Suite.HScrollBar
	{
		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x060006A9 RID: 1705 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060006AA RID: 1706 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Attaches the ScrollBar to the scroll events of any scrollable container-control or DataGridView.")]
		[DefaultValue(typeof(Control), "")]
		public Control BindingContainer
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x060006AB RID: 1707 RVA: 0x000033C4 File Offset: 0x000015C4
		// (set) Token: 0x060006AC RID: 1708 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("Sets the thumb's style in relation to the ScrollBar.")]
		[DefaultValue(0)]
		public ThumbStyle ThumbStyle
		{
			get
			{
				return ThumbStyle.Default;
			}
			set
			{
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060006AE RID: 1710 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(typeof(Color), "")]
		[Description("The border BackColor")]
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

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x060006B0 RID: 1712 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060006B1 RID: 1713 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(false)]
		[Description("If true, the border on the control is rounded off automatically")]
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

		// Token: 0x060006B2 RID: 1714 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnResize(EventArgs e)
		{
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00002134 File Offset: 0x00000334
		private void method_5()
		{
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00002134 File Offset: 0x00000334
		private void method_6()
		{
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x00002134 File Offset: 0x00000334
		private void method_7()
		{
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x00002134 File Offset: 0x00000334
		private void method_8()
		{
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x00002134 File Offset: 0x00000334
		private void method_9()
		{
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00002134 File Offset: 0x00000334
		private void method_10()
		{
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00002134 File Offset: 0x00000334
		private void method_11(object sender, ControlEventArgs e)
		{
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x00002134 File Offset: 0x00000334
		private void method_12(object sender, ControlEventArgs e)
		{
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x00002134 File Offset: 0x00000334
		private void method_13(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00002134 File Offset: 0x00000334
		private void method_14(object sender, ScrollEventArgs e)
		{
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00002134 File Offset: 0x00000334
		private void method_15(object sender, DataGridViewRowEventArgs e)
		{
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x00002134 File Offset: 0x00000334
		private void method_16(object sender, DataGridViewRowsAddedEventArgs e)
		{
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00002134 File Offset: 0x00000334
		private void method_17(object sender, DataGridViewRowsRemovedEventArgs e)
		{
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00002134 File Offset: 0x00000334
		private void method_18(Control control)
		{
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(true)]
		[Description("The properties that will be applied when the cursor is over the control")]
		public ScrollBarState HoverState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x060006C2 RID: 1730 RVA: 0x00002131 File Offset: 0x00000331
		[Browsable(true)]
		[Description("The properties that will be applied when the control is in pressed state")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public ScrollBarState PressedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x060006C3 RID: 1731 RVA: 0x000033DC File Offset: 0x000015DC
		// (set) Token: 0x060006C4 RID: 1732 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The control's padding property")]
		public new Padding Padding
		{
			[CompilerGenerated]
			get
			{
				return default(Padding);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x060006C5 RID: 1733 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060006C6 RID: 1734 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The control's font")]
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

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x060006C7 RID: 1735 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060006C8 RID: 1736 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The control's text")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
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

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x060006C9 RID: 1737 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060006CA RID: 1738 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Description("The control's ForeColor")]
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

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x060006CB RID: 1739 RVA: 0x00002145 File Offset: 0x00000345
		// (set) Token: 0x060006CC RID: 1740 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(10f)]
		[Browsable(true)]
		[Description("The control's thumb size")]
		public float ThumbSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060006CE RID: 1742 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060006D0 RID: 1744 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("The MouseWheel Bar Partitions when using the mouse wheel")]
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

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x060006D1 RID: 1745 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060006D2 RID: 1746 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("The size of the scrollbar")]
		public int ScrollbarSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x060006D3 RID: 1747 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060006D4 RID: 1748 RVA: 0x00002134 File Offset: 0x00000334
		[Description("If true, the bar will be highlighted on mouse wheel")]
		[DefaultValue(false)]
		public bool HighlightOnWheel
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x060006D5 RID: 1749 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060006D6 RID: 1750 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The minimum scrollbar value")]
		[DefaultValue(0)]
		[Browsable(true)]
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

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x060006D7 RID: 1751 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060006D8 RID: 1752 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(100)]
		[Description("The maximum scrollbar value")]
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

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x060006D9 RID: 1753 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060006DA RID: 1754 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(1)]
		[Description("The minimum scrollbar value change")]
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

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x060006DB RID: 1755 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060006DC RID: 1756 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The maximum scrollbar value change")]
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

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x060006DD RID: 1757 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060006DE RID: 1758 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("The scrollbar thumb color")]
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

		// Token: 0x060006DF RID: 1759 RVA: 0x00002134 File Offset: 0x00000334
		private void method_19()
		{
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00002134 File Offset: 0x00000334
		private void method_20(object sender, EventArgs e)
		{
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x060006E1 RID: 1761 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060006E2 RID: 1762 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The control's fill color")]
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

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x060006E3 RID: 1763 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060006E4 RID: 1764 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(0)]
		[Description("The scrollbar current value")]
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

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x000033DC File Offset: 0x000015DC
		// (set) Token: 0x060006E6 RID: 1766 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(typeof(Padding), "0, 0, 0, 0")]
		[Description("The bar positioning property")]
		public Padding FillOffset
		{
			get
			{
				return default(Padding);
			}
			set
			{
			}
		}

		// Token: 0x04000152 RID: 338
		private Control control_0;

		// Token: 0x04000153 RID: 339
		private bool bool_0;

		// Token: 0x04000154 RID: 340
		private int int_0;

		// Token: 0x04000155 RID: 341
		private int int_1;

		// Token: 0x04000156 RID: 342
		private int int_2;

		// Token: 0x04000157 RID: 343
		private int int_3;

		// Token: 0x04000158 RID: 344
		private int int_4;

		// Token: 0x04000159 RID: 345
		private System.Windows.Forms.HScrollBar hscrollBar_0;

		// Token: 0x0400015A RID: 346
		[CompilerGenerated]
		private Padding padding_1;

		// Token: 0x0400015B RID: 347
		[CompilerGenerated]
		private Font font_0;

		// Token: 0x0400015C RID: 348
		[CompilerGenerated]
		private string string_0;

		// Token: 0x0400015D RID: 349
		[CompilerGenerated]
		private Color color_0;

		// Token: 0x0400015E RID: 350
		private Timer timer_0;

		// Token: 0x0400015F RID: 351
		private IContainer icontainer_1;

		// Token: 0x02000060 RID: 96
		// (Invoke) Token: 0x060006E8 RID: 1768
		private delegate void Delegate2();
	}
}
