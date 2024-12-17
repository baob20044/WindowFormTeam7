using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Guna.UI2.WinForms.Enums;
using Guna.UI2.WinForms.Suite;

namespace Guna.UI2.WinForms
{
	// Token: 0x02000061 RID: 97
	[Description("An advanced ImageButton Control")]
	[Designer(typeof(Guna2ImageButtonDesigner))]
	[ToolboxItem(true)]
	[ToolboxBitmap(typeof(System.Windows.Forms.Button))]
	[DebuggerStepThrough]
	public class Guna2ImageButton : ImageButton
	{
		// Token: 0x170002CC RID: 716
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060006ED RID: 1773 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x00002131 File Offset: 0x00000331
		[Browsable(true)]
		[Description("The properties that will be applied when the cursor is over the control")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public ImageControlState HoverState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x060006EF RID: 1775 RVA: 0x00002131 File Offset: 0x00000331
		[Browsable(true)]
		[Description("The properties that will be applied when the control is in a checked state")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public ImageControlState CheckedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(true)]
		[Description("The state of the control when pressed")]
		public ImageControlState PressedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x060006F1 RID: 1777 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060006F2 RID: 1778 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The control's font style")]
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

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x060006F3 RID: 1779 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060006F4 RID: 1780 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x060006F5 RID: 1781 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060006F6 RID: 1782 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x060006F7 RID: 1783 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060006F8 RID: 1784 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x060006F9 RID: 1785 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060006FA RID: 1786 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x060006FB RID: 1787 RVA: 0x00003364 File Offset: 0x00001564
		// (set) Token: 0x060006FC RID: 1788 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("The size of the control's image")]
		[DefaultValue(typeof(Size), "64, 64")]
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

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x060006FD RID: 1789 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x060006FE RID: 1790 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(typeof(Point), "0, 0")]
		[Description("Setting the position of the control's image")]
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

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x060006FF RID: 1791 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x06000700 RID: 1792 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		[DefaultValue(typeof(Point), "0, 0")]
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

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000701 RID: 1793 RVA: 0x00003840 File Offset: 0x00001A40
		// (set) Token: 0x06000702 RID: 1794 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
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

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000703 RID: 1795 RVA: 0x00003840 File Offset: 0x00001A40
		// (set) Token: 0x06000704 RID: 1796 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000705 RID: 1797 RVA: 0x0000346C File Offset: 0x0000166C
		// (set) Token: 0x06000706 RID: 1798 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
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

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000707 RID: 1799 RVA: 0x00003858 File Offset: 0x00001A58
		// (set) Token: 0x06000708 RID: 1800 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The control's text transform property which allows you to change the appearance of the text")]
		[DefaultValue(0)]
		[Browsable(false)]
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

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000709 RID: 1801 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600070A RID: 1802 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(false)]
		[Browsable(true)]
		[Description("If true, the control will be checked")]
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

		// Token: 0x04000160 RID: 352
		[CompilerGenerated]
		private Font font_0;

		// Token: 0x04000161 RID: 353
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04000162 RID: 354
		[CompilerGenerated]
		private Color color_1;
	}
}
