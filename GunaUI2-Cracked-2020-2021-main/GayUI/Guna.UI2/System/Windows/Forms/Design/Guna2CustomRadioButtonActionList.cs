using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using Guna.UI2.WinForms;

namespace System.Windows.Forms.Design
{
	// Token: 0x02000020 RID: 32
	public class Guna2CustomRadioButtonActionList : DesignerActionList
	{
		// Token: 0x060001A7 RID: 423 RVA: 0x00002128 File Offset: 0x00000328
		public Guna2CustomRadioButtonActionList(IComponent component) : base(null)
		{
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002131 File Offset: 0x00000331
		private PropertyDescriptor method_0(string propName)
		{
			return null;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00002131 File Offset: 0x00000331
		private PropertyDescriptor method_1(string propName, object obj)
		{
			return null;
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060001AA RID: 426 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x060001AB RID: 427 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060001AC RID: 428 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060001AD RID: 429 RVA: 0x00002134 File Offset: 0x00000334
		public Color CheckedStateBorderColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060001AE RID: 430 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060001AF RID: 431 RVA: 0x00002134 File Offset: 0x00000334
		public Color CheckedStateFillColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x00002134 File Offset: 0x00000334
		public int CheckedStateBorderThickness
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x00002134 File Offset: 0x00000334
		public Color CheckedStateInnerColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x00002134 File Offset: 0x00000334
		public int CheckedStateInnerOffset
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x00002134 File Offset: 0x00000334
		public Color UncheckedStateBorderColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x00002134 File Offset: 0x00000334
		public Color UncheckedStateFillColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060001BB RID: 443 RVA: 0x00002134 File Offset: 0x00000334
		public int UncheckedStateBorderThickness
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060001BC RID: 444 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060001BD RID: 445 RVA: 0x00002134 File Offset: 0x00000334
		public Color UncheckedStateInnerColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060001BE RID: 446 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060001BF RID: 447 RVA: 0x00002134 File Offset: 0x00000334
		public int UncheckedStateInnerOffset
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x060001C2 RID: 450 RVA: 0x00002131 File Offset: 0x00000331
		public override DesignerActionItemCollection GetSortedActionItems()
		{
			return null;
		}

		// Token: 0x0400002E RID: 46
		private Guna2CustomRadioButton guna2CustomRadioButton_0;

		// Token: 0x0400002F RID: 47
		private DesignerActionUIService designerActionUIService_0;
	}
}
