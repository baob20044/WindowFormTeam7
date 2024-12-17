using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using Guna.UI2.WinForms;

namespace System.Windows.Forms.Design
{
	// Token: 0x0200001C RID: 28
	public class Guna2CustomCheckBoxActionList : DesignerActionList
	{
		// Token: 0x0600016B RID: 363 RVA: 0x00002128 File Offset: 0x00000328
		public Guna2CustomCheckBoxActionList(IComponent component) : base(null)
		{
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00002131 File Offset: 0x00000331
		private PropertyDescriptor method_0(string propName)
		{
			return null;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002131 File Offset: 0x00000331
		private PropertyDescriptor method_1(string propName, object obj)
		{
			return null;
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600016E RID: 366 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600016F RID: 367 RVA: 0x00002134 File Offset: 0x00000334
		public Color CheckMarkColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000170 RID: 368 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x06000171 RID: 369 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000172 RID: 370 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000173 RID: 371 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000174 RID: 372 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000175 RID: 373 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000176 RID: 374 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000177 RID: 375 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000178 RID: 376 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000179 RID: 377 RVA: 0x00002134 File Offset: 0x00000334
		public int CheckedStateBorderBorderRadius
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600017A RID: 378 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600017B RID: 379 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600017C RID: 380 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600017D RID: 381 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600017F RID: 383 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000180 RID: 384 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000181 RID: 385 RVA: 0x00002134 File Offset: 0x00000334
		public int UncheckedStateBorderRadius
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000182 RID: 386 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000183 RID: 387 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06000184 RID: 388 RVA: 0x00002131 File Offset: 0x00000331
		public override DesignerActionItemCollection GetSortedActionItems()
		{
			return null;
		}

		// Token: 0x04000028 RID: 40
		private Guna2CustomCheckBox guna2CustomCheckBox_0;

		// Token: 0x04000029 RID: 41
		private DesignerActionUIService designerActionUIService_0;
	}
}
