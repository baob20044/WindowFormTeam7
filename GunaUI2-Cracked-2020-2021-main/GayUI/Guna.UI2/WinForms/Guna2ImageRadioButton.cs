using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Guna.UI2.WinForms.Suite;

namespace Guna.UI2.WinForms
{
	// Token: 0x02000063 RID: 99
	[ToolboxItem(true)]
	[ToolboxBitmap(typeof(RadioButton))]
	[Designer(typeof(Guna2ImageRadioButtonDesigner))]
	[DebuggerStepThrough]
	[Description("An advanced ImageRadioButton control")]
	public class Guna2ImageRadioButton : ImageRadioButton
	{
		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000722 RID: 1826 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000723 RID: 1827 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x00002131 File Offset: 0x00000331
		[Description("The properties that will be applied when the cursor is over the control")]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public ImageControlState HoverState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000725 RID: 1829 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(true)]
		[Description("The properties that will be applied when the control is in a checked state")]
		public ImageControlState CheckedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000726 RID: 1830 RVA: 0x00002131 File Offset: 0x00000331
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Description("The properties that will be applied when the control is in a pressed state")]
		public ImageControlState PressedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000727 RID: 1831 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000728 RID: 1832 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000729 RID: 1833 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x0600072A RID: 1834 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Description("The control's font text")]
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

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x0600072B RID: 1835 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600072C RID: 1836 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		[Description("The control's font ForeColor")]
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

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x0600072D RID: 1837 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600072E RID: 1838 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("If true, the background will allow a transparent color")]
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

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x0600072F RID: 1839 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000730 RID: 1840 RVA: 0x00002134 File Offset: 0x00000334
		[Description("If true, the control will be in a checked state")]
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

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000731 RID: 1841 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000732 RID: 1842 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000733 RID: 1843 RVA: 0x00003364 File Offset: 0x00001564
		// (set) Token: 0x06000734 RID: 1844 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000735 RID: 1845 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x06000736 RID: 1846 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x04000166 RID: 358
		[CompilerGenerated]
		private Font font_0;

		// Token: 0x04000167 RID: 359
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04000168 RID: 360
		[CompilerGenerated]
		private Color color_1;
	}
}
