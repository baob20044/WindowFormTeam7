using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;

namespace System.Windows.Forms.Design
{
	// Token: 0x02000026 RID: 38
	public class Guna2VScrollBarActionList : DesignerActionList
	{
		// Token: 0x060001FE RID: 510 RVA: 0x00002128 File Offset: 0x00000328
		public Guna2VScrollBarActionList(IComponent component) : base(null)
		{
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00002131 File Offset: 0x00000331
		private PropertyDescriptor method_0(string propName)
		{
			return null;
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000200 RID: 512 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000201 RID: 513 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000202 RID: 514 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000203 RID: 515 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000204 RID: 516 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000205 RID: 517 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000206 RID: 518 RVA: 0x000033C4 File Offset: 0x000015C4
		// (set) Token: 0x06000207 RID: 519 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000208 RID: 520 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000209 RID: 521 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600020A RID: 522 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600020B RID: 523 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600020C RID: 524 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600020D RID: 525 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600020E RID: 526 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600020F RID: 527 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000210 RID: 528 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000211 RID: 529 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000212 RID: 530 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000213 RID: 531 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000214 RID: 532 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000215 RID: 533 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000216 RID: 534 RVA: 0x000033DC File Offset: 0x000015DC
		// (set) Token: 0x06000217 RID: 535 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000218 RID: 536 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000219 RID: 537 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x0600021A RID: 538 RVA: 0x00002131 File Offset: 0x00000331
		public override DesignerActionItemCollection GetSortedActionItems()
		{
			return null;
		}

		// Token: 0x04000037 RID: 55
		private Guna2VScrollBar guna2VScrollBar_0;

		// Token: 0x04000038 RID: 56
		private DesignerActionUIService designerActionUIService_0;
	}
}
