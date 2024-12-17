using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Guna.UI2.WinForms
{
	// Token: 0x02000037 RID: 55
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[DebuggerStepThrough]
	public class Guna2ToolStripProfessionalRenderer : ToolStripProfessionalRenderer
	{
		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060002FD RID: 765 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060002FE RID: 766 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public new ProfessionalColorTable ColorTable
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

		// Token: 0x060002FF RID: 767 RVA: 0x00002134 File Offset: 0x00000334
		public void Invalidate()
		{
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00002177 File Offset: 0x00000377
		public Guna2ToolStripProfessionalRenderer(Guna2ContextMenuStrip _gunaContextMenuStrip)
		{
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00002177 File Offset: 0x00000377
		public Guna2ToolStripProfessionalRenderer()
		{
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00002131 File Offset: 0x00000331
		public override string ToString()
		{
			return null;
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000303 RID: 771 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000304 RID: 772 RVA: 0x00002134 File Offset: 0x00000334
		public Color SeparatorColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000305 RID: 773 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000306 RID: 774 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000307 RID: 775 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000308 RID: 776 RVA: 0x00002134 File Offset: 0x00000334
		public Color ArrowColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000309 RID: 777 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600030A RID: 778 RVA: 0x00002134 File Offset: 0x00000334
		public Color SelectionArrowColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x0600030B RID: 779 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600030C RID: 780 RVA: 0x00002134 File Offset: 0x00000334
		public Color SelectionBackColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600030D RID: 781 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600030E RID: 782 RVA: 0x00002134 File Offset: 0x00000334
		public Color SelectionForeColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600030F RID: 783 RVA: 0x0000346C File Offset: 0x0000166C
		// (set) Token: 0x06000310 RID: 784 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06000311 RID: 785 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
		{
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
		{
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
		{
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
		{
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
		{
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0000343C File Offset: 0x0000163C
		private Rectangle method_0(ToolStripItem item)
		{
			return default(Rectangle);
		}

		// Token: 0x04000087 RID: 135
		[CompilerGenerated]
		private ProfessionalColorTable professionalColorTable_0;

		// Token: 0x04000088 RID: 136
		private Guna2ContextMenuStrip guna2ContextMenuStrip_0;

		// Token: 0x04000089 RID: 137
		private Color color_0;

		// Token: 0x0400008A RID: 138
		private Color color_1;

		// Token: 0x0400008B RID: 139
		private Color color_2;

		// Token: 0x0400008C RID: 140
		private Color color_3;

		// Token: 0x0400008D RID: 141
		private Color color_4;

		// Token: 0x0400008E RID: 142
		private Color color_5;

		// Token: 0x0400008F RID: 143
		private TextRenderingHint textRenderingHint_0;
	}
}
