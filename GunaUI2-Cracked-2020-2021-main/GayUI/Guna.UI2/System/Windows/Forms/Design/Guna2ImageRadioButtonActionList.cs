using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;

namespace System.Windows.Forms.Design
{
	// Token: 0x02000014 RID: 20
	public class Guna2ImageRadioButtonActionList : DesignerActionList
	{
		// Token: 0x0600010B RID: 267 RVA: 0x00002128 File Offset: 0x00000328
		public Guna2ImageRadioButtonActionList(IComponent component) : base(null)
		{
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002131 File Offset: 0x00000331
		private PropertyDescriptor method_0(string propName)
		{
			return null;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002131 File Offset: 0x00000331
		private PropertyDescriptor method_1(string propName, object obj)
		{
			return null;
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600010F RID: 271 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000110 RID: 272 RVA: 0x0000334C File Offset: 0x0000154C
		// (set) Token: 0x06000111 RID: 273 RVA: 0x00002134 File Offset: 0x00000334
		public FlipOrientation CheckedStateImageFlip
		{
			get
			{
				return FlipOrientation.Normal;
			}
			set
			{
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00002145 File Offset: 0x00000345
		// (set) Token: 0x06000113 RID: 275 RVA: 0x00002134 File Offset: 0x00000334
		public float CheckedStateImageRotate
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000115 RID: 277 RVA: 0x00002134 File Offset: 0x00000334
		public Image CheckedStateImage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00003364 File Offset: 0x00001564
		// (set) Token: 0x06000117 RID: 279 RVA: 0x00002134 File Offset: 0x00000334
		public Size CheckedStateImageSize
		{
			get
			{
				return default(Size);
			}
			set
			{
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000118 RID: 280 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x06000119 RID: 281 RVA: 0x00002134 File Offset: 0x00000334
		public Point CheckedStateImageOffset
		{
			get
			{
				return default(Point);
			}
			set
			{
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600011A RID: 282 RVA: 0x0000334C File Offset: 0x0000154C
		// (set) Token: 0x0600011B RID: 283 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00002145 File Offset: 0x00000345
		// (set) Token: 0x0600011D RID: 285 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x0600011F RID: 287 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00003364 File Offset: 0x00001564
		// (set) Token: 0x06000121 RID: 289 RVA: 0x00002134 File Offset: 0x00000334
		public Size ImageSize
		{
			get
			{
				return default(Size);
			}
			set
			{
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000122 RID: 290 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x06000123 RID: 291 RVA: 0x00002134 File Offset: 0x00000334
		public Point ImageOffset
		{
			get
			{
				return default(Point);
			}
			set
			{
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000125 RID: 293 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06000126 RID: 294 RVA: 0x00002131 File Offset: 0x00000331
		public override DesignerActionItemCollection GetSortedActionItems()
		{
			return null;
		}

		// Token: 0x0400001C RID: 28
		private Guna2ImageRadioButton guna2ImageRadioButton_0;

		// Token: 0x0400001D RID: 29
		private DesignerActionUIService designerActionUIService_0;
	}
}
