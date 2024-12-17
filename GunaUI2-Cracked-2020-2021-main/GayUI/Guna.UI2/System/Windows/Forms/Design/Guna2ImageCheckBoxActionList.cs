using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;

namespace System.Windows.Forms.Design
{
	// Token: 0x02000016 RID: 22
	public class Guna2ImageCheckBoxActionList : DesignerActionList
	{
		// Token: 0x06000129 RID: 297 RVA: 0x00002128 File Offset: 0x00000328
		public Guna2ImageCheckBoxActionList(IComponent component) : base(null)
		{
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00002131 File Offset: 0x00000331
		private PropertyDescriptor method_0(string propName)
		{
			return null;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00002131 File Offset: 0x00000331
		private PropertyDescriptor method_1(string propName, object obj)
		{
			return null;
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600012D RID: 301 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600012E RID: 302 RVA: 0x0000334C File Offset: 0x0000154C
		// (set) Token: 0x0600012F RID: 303 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00002145 File Offset: 0x00000345
		// (set) Token: 0x06000131 RID: 305 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000133 RID: 307 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00003364 File Offset: 0x00001564
		// (set) Token: 0x06000135 RID: 309 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000136 RID: 310 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x06000137 RID: 311 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000138 RID: 312 RVA: 0x0000334C File Offset: 0x0000154C
		// (set) Token: 0x06000139 RID: 313 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600013A RID: 314 RVA: 0x00002145 File Offset: 0x00000345
		// (set) Token: 0x0600013B RID: 315 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600013C RID: 316 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x0600013D RID: 317 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00003364 File Offset: 0x00001564
		// (set) Token: 0x0600013F RID: 319 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000140 RID: 320 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x06000141 RID: 321 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000142 RID: 322 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000143 RID: 323 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06000144 RID: 324 RVA: 0x00002131 File Offset: 0x00000331
		public override DesignerActionItemCollection GetSortedActionItems()
		{
			return null;
		}

		// Token: 0x0400001F RID: 31
		private Guna2ImageCheckBox guna2ImageCheckBox_0;

		// Token: 0x04000020 RID: 32
		private DesignerActionUIService designerActionUIService_0;
	}
}
