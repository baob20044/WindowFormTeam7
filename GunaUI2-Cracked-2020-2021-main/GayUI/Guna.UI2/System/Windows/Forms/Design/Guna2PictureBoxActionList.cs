using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;

namespace System.Windows.Forms.Design
{
	// Token: 0x02000018 RID: 24
	public class Guna2PictureBoxActionList : DesignerActionList
	{
		// Token: 0x06000147 RID: 327 RVA: 0x00002128 File Offset: 0x00000328
		public Guna2PictureBoxActionList(IComponent component) : base(null)
		{
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00002131 File Offset: 0x00000331
		private PropertyDescriptor method_0(string propName)
		{
			return null;
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000149 RID: 329 RVA: 0x0000334C File Offset: 0x0000154C
		// (set) Token: 0x0600014A RID: 330 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00002145 File Offset: 0x00000345
		// (set) Token: 0x0600014C RID: 332 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600014D RID: 333 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600014E RID: 334 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600014F RID: 335 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000150 RID: 336 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000151 RID: 337 RVA: 0x00003394 File Offset: 0x00001594
		// (set) Token: 0x06000152 RID: 338 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000153 RID: 339 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000154 RID: 340 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000156 RID: 342 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06000157 RID: 343 RVA: 0x00002131 File Offset: 0x00000331
		public override DesignerActionItemCollection GetSortedActionItems()
		{
			return null;
		}

		// Token: 0x04000022 RID: 34
		private Guna2PictureBox guna2PictureBox_0;

		// Token: 0x04000023 RID: 35
		private DesignerActionUIService designerActionUIService_0;
	}
}
