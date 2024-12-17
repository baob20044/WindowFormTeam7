using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using Guna.UI2.WinForms;

namespace System.Windows.Forms.Design
{
	// Token: 0x0200002C RID: 44
	public class Guna2DateTimePickerActionList : DesignerActionList
	{
		// Token: 0x0600025B RID: 603 RVA: 0x00002128 File Offset: 0x00000328
		public Guna2DateTimePickerActionList(IComponent component) : base(null)
		{
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00002131 File Offset: 0x00000331
		private PropertyDescriptor method_0(string propName)
		{
			return null;
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600025D RID: 605 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x0600025E RID: 606 RVA: 0x00002134 File Offset: 0x00000334
		public Font Font
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600025F RID: 607 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000260 RID: 608 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000261 RID: 609 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000262 RID: 610 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000263 RID: 611 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x06000264 RID: 612 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000265 RID: 613 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000266 RID: 614 RVA: 0x00002134 File Offset: 0x00000334
		public Color ForeColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000267 RID: 615 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000268 RID: 616 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000269 RID: 617 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600026A RID: 618 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600026B RID: 619 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600026C RID: 620 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600026D RID: 621 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600026E RID: 622 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600026F RID: 623 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000270 RID: 624 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000271 RID: 625 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000272 RID: 626 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000273 RID: 627 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000274 RID: 628 RVA: 0x00002134 File Offset: 0x00000334
		public bool AutoSize
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00002131 File Offset: 0x00000331
		public override DesignerActionItemCollection GetSortedActionItems()
		{
			return null;
		}

		// Token: 0x04000040 RID: 64
		private Guna2DateTimePicker guna2DateTimePicker_0;

		// Token: 0x04000041 RID: 65
		private DesignerActionUIService designerActionUIService_0;
	}
}
