using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using Guna.UI2.WinForms;

namespace System.Windows.Forms.Design
{
	// Token: 0x0200001E RID: 30
	public class Guna2CheckBoxActionList : DesignerActionList
	{
		// Token: 0x06000187 RID: 391 RVA: 0x00002128 File Offset: 0x00000328
		public Guna2CheckBoxActionList(IComponent component) : base(null)
		{
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00002131 File Offset: 0x00000331
		private PropertyDescriptor method_0(string propName)
		{
			return null;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002131 File Offset: 0x00000331
		private PropertyDescriptor method_1(string propName, object obj)
		{
			return null;
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x0600018B RID: 395 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600018C RID: 396 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x0600018D RID: 397 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600018E RID: 398 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600018F RID: 399 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000190 RID: 400 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000191 RID: 401 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000192 RID: 402 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x06000193 RID: 403 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000194 RID: 404 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000195 RID: 405 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000196 RID: 406 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000197 RID: 407 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000198 RID: 408 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000199 RID: 409 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600019B RID: 411 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600019C RID: 412 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600019D RID: 413 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600019E RID: 414 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600019F RID: 415 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x060001A4 RID: 420 RVA: 0x00002131 File Offset: 0x00000331
		public override DesignerActionItemCollection GetSortedActionItems()
		{
			return null;
		}

		// Token: 0x0400002B RID: 43
		private Guna2CheckBox guna2CheckBox_0;

		// Token: 0x0400002C RID: 44
		private DesignerActionUIService designerActionUIService_0;
	}
}
