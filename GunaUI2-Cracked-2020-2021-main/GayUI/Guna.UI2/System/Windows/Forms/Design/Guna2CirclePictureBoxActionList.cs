using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;

namespace System.Windows.Forms.Design
{
	// Token: 0x0200001A RID: 26
	public class Guna2CirclePictureBoxActionList : DesignerActionList
	{
		// Token: 0x0600015A RID: 346 RVA: 0x00002128 File Offset: 0x00000328
		public Guna2CirclePictureBoxActionList(IComponent component) : base(null)
		{
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00002131 File Offset: 0x00000331
		private PropertyDescriptor method_0(string propName)
		{
			return null;
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600015C RID: 348 RVA: 0x0000334C File Offset: 0x0000154C
		// (set) Token: 0x0600015D RID: 349 RVA: 0x00002134 File Offset: 0x00000334
		public FlipOrientation ImageFlip
		{
			get
			{
				return FlipOrientation.Normal;
			}
			set
			{
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00002145 File Offset: 0x00000345
		// (set) Token: 0x0600015F RID: 351 RVA: 0x00002134 File Offset: 0x00000334
		public float ImageRotate
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000160 RID: 352 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000161 RID: 353 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000163 RID: 355 RVA: 0x00002134 File Offset: 0x00000334
		public Image Image
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00003394 File Offset: 0x00001594
		// (set) Token: 0x06000165 RID: 357 RVA: 0x00002134 File Offset: 0x00000334
		public PictureBoxSizeMode SizeMode
		{
			get
			{
				return PictureBoxSizeMode.Normal;
			}
			set
			{
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000167 RID: 359 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06000168 RID: 360 RVA: 0x00002131 File Offset: 0x00000331
		public override DesignerActionItemCollection GetSortedActionItems()
		{
			return null;
		}

		// Token: 0x04000025 RID: 37
		private Guna2CirclePictureBox guna2CirclePictureBox_0;

		// Token: 0x04000026 RID: 38
		private DesignerActionUIService designerActionUIService_0;
	}
}
