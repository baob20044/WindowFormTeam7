using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;

namespace System.Windows.Forms.Design
{
	// Token: 0x02000024 RID: 36
	public class Guna2TrackBarActionList : DesignerActionList
	{
		// Token: 0x060001E7 RID: 487 RVA: 0x00002128 File Offset: 0x00000328
		public Guna2TrackBarActionList(IComponent component) : base(null)
		{
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00002131 File Offset: 0x00000331
		private PropertyDescriptor method_0(string propName)
		{
			return null;
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060001EA RID: 490 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060001EB RID: 491 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060001EC RID: 492 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060001ED RID: 493 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060001EE RID: 494 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060001EF RID: 495 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060001F4 RID: 500 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x000033AC File Offset: 0x000015AC
		// (set) Token: 0x060001FA RID: 506 RVA: 0x00002134 File Offset: 0x00000334
		public TrackBarStyle Style
		{
			get
			{
				return TrackBarStyle.Default;
			}
			set
			{
			}
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00002131 File Offset: 0x00000331
		public override DesignerActionItemCollection GetSortedActionItems()
		{
			return null;
		}

		// Token: 0x04000034 RID: 52
		private Guna2TrackBar guna2TrackBar_0;

		// Token: 0x04000035 RID: 53
		private DesignerActionUIService designerActionUIService_0;
	}
}
