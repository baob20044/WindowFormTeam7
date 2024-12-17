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
	// Token: 0x02000062 RID: 98
	[ToolboxItem(true)]
	[Designer(typeof(Guna2ImageCheckBoxDesigner))]
	[DebuggerStepThrough]
	[ToolboxBitmap(typeof(CheckBox))]
	[Description("An Advanced ImageCheckBox Control")]
	public class Guna2ImageCheckBox : ImageCheckBox
	{
		// Token: 0x170002DD RID: 733
		// (get) Token: 0x0600070C RID: 1804 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600070D RID: 1805 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x0600070E RID: 1806 RVA: 0x00002131 File Offset: 0x00000331
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Description("The properties that will be applied when the cursor is over the control")]
		public ImageControlState HoverState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x0600070F RID: 1807 RVA: 0x00002131 File Offset: 0x00000331
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Description("The properties that will be applied when the control is in a checked state")]
		public ImageControlState CheckedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x00002131 File Offset: 0x00000331
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Description("The properties that will be applied when the control is pressed")]
		public ImageControlState PressedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000711 RID: 1809 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000712 RID: 1810 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		[Description("The control's font style")]
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

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000713 RID: 1811 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000714 RID: 1812 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Description("The control's text")]
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

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000715 RID: 1813 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000716 RID: 1814 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
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

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000717 RID: 1815 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000718 RID: 1816 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000719 RID: 1817 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600071A RID: 1818 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(false)]
		[Description("If true, the control will be in a checked state")]
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

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x0600071B RID: 1819 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x0600071C RID: 1820 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x0600071D RID: 1821 RVA: 0x00003364 File Offset: 0x00001564
		// (set) Token: 0x0600071E RID: 1822 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Size), "20, 20")]
		[Description("The size of the control's image")]
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

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x0600071F RID: 1823 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x06000720 RID: 1824 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x04000163 RID: 355
		[CompilerGenerated]
		private Font font_0;

		// Token: 0x04000164 RID: 356
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04000165 RID: 357
		[CompilerGenerated]
		private Color color_1;
	}
}
