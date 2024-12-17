using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using Guna.UI2.WinForms;

namespace System.Windows.Forms.Design
{
	// Token: 0x0200002A RID: 42
	public class Guna2NumericUpDownActionList : DesignerActionList
	{
		// Token: 0x0600023C RID: 572 RVA: 0x00002128 File Offset: 0x00000328
		public Guna2NumericUpDownActionList(IComponent component) : base(null)
		{
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00002131 File Offset: 0x00000331
		private PropertyDescriptor method_0(string propName)
		{
			return null;
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600023E RID: 574 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600023F RID: 575 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000240 RID: 576 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000241 RID: 577 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000242 RID: 578 RVA: 0x000033F4 File Offset: 0x000015F4
		// (set) Token: 0x06000243 RID: 579 RVA: 0x00002134 File Offset: 0x00000334
		public decimal Value
		{
			get
			{
				return 0m;
			}
			set
			{
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000244 RID: 580 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000245 RID: 581 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000246 RID: 582 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000247 RID: 583 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000248 RID: 584 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x06000249 RID: 585 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x0600024A RID: 586 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600024B RID: 587 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600024C RID: 588 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600024D RID: 589 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x0600024E RID: 590 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600024F RID: 591 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000250 RID: 592 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000251 RID: 593 RVA: 0x00002134 File Offset: 0x00000334
		public Color UpDownButtonFillColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000252 RID: 594 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000253 RID: 595 RVA: 0x00002134 File Offset: 0x00000334
		public Color UpDownButtonForeColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000254 RID: 596 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000255 RID: 597 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000256 RID: 598 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000257 RID: 599 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06000258 RID: 600 RVA: 0x00002131 File Offset: 0x00000331
		public override DesignerActionItemCollection GetSortedActionItems()
		{
			return null;
		}

		// Token: 0x0400003D RID: 61
		private Guna2NumericUpDown guna2NumericUpDown_0;

		// Token: 0x0400003E RID: 62
		private DesignerActionUIService designerActionUIService_0;
	}
}
