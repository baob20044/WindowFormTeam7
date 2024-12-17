using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using Guna.UI2.WinForms;

namespace System.Windows.Forms.Design
{
	// Token: 0x02000022 RID: 34
	public class Guna2RadioButtonActionList : DesignerActionList
	{
		// Token: 0x060001C5 RID: 453 RVA: 0x00002128 File Offset: 0x00000328
		public Guna2RadioButtonActionList(IComponent component) : base(null)
		{
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00002131 File Offset: 0x00000331
		private PropertyDescriptor method_0(string propName)
		{
			return null;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00002131 File Offset: 0x00000331
		private PropertyDescriptor method_1(string propName, object obj)
		{
			return null;
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060001CA RID: 458 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060001CB RID: 459 RVA: 0x00002134 File Offset: 0x00000334
		public string Text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060001CC RID: 460 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060001CD RID: 461 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060001CE RID: 462 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x060001CF RID: 463 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060001DA RID: 474 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060001DB RID: 475 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060001DC RID: 476 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060001DD RID: 477 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060001DE RID: 478 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060001DF RID: 479 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x060001E4 RID: 484 RVA: 0x00002131 File Offset: 0x00000331
		public override DesignerActionItemCollection GetSortedActionItems()
		{
			return null;
		}

		// Token: 0x04000031 RID: 49
		private Guna2RadioButton guna2RadioButton_0;

		// Token: 0x04000032 RID: 50
		private DesignerActionUIService designerActionUIService_0;
	}
}
