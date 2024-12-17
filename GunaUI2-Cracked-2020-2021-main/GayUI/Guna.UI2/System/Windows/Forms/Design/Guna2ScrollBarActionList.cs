using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;

namespace System.Windows.Forms.Design
{
	// Token: 0x02000028 RID: 40
	public class Guna2ScrollBarActionList : DesignerActionList
	{
		// Token: 0x0600021D RID: 541 RVA: 0x00002128 File Offset: 0x00000328
		public Guna2ScrollBarActionList(IComponent component) : base(null)
		{
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00002131 File Offset: 0x00000331
		private PropertyDescriptor method_0(string propName)
		{
			return null;
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600021F RID: 543 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000220 RID: 544 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000221 RID: 545 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000222 RID: 546 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000223 RID: 547 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000224 RID: 548 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000225 RID: 549 RVA: 0x000033C4 File Offset: 0x000015C4
		// (set) Token: 0x06000226 RID: 550 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000227 RID: 551 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000228 RID: 552 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000229 RID: 553 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600022A RID: 554 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600022B RID: 555 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600022C RID: 556 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600022D RID: 557 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600022E RID: 558 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600022F RID: 559 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000230 RID: 560 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000231 RID: 561 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000232 RID: 562 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000233 RID: 563 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000234 RID: 564 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000235 RID: 565 RVA: 0x000033DC File Offset: 0x000015DC
		// (set) Token: 0x06000236 RID: 566 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000237 RID: 567 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000238 RID: 568 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06000239 RID: 569 RVA: 0x00002131 File Offset: 0x00000331
		public override DesignerActionItemCollection GetSortedActionItems()
		{
			return null;
		}

		// Token: 0x0400003A RID: 58
		private Guna2HScrollBar guna2HScrollBar_0;

		// Token: 0x0400003B RID: 59
		private DesignerActionUIService designerActionUIService_0;
	}
}
