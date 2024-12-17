using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;

namespace System.Windows.Forms.Design
{
	// Token: 0x02000012 RID: 18
	public class Guna2ImageButtonActionList : DesignerActionList
	{
		// Token: 0x060000E3 RID: 227 RVA: 0x00002128 File Offset: 0x00000328
		public Guna2ImageButtonActionList(IComponent component) : base(null)
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002131 File Offset: 0x00000331
		private PropertyDescriptor method_0(string propName)
		{
			return null;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002131 File Offset: 0x00000331
		private PropertyDescriptor method_1(string propName, object obj)
		{
			return null;
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x0000334C File Offset: 0x0000154C
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00002145 File Offset: 0x00000345
		// (set) Token: 0x060000EB RID: 235 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060000ED RID: 237 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00003364 File Offset: 0x00001564
		// (set) Token: 0x060000EF RID: 239 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x0000334C File Offset: 0x0000154C
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x00002134 File Offset: 0x00000334
		public FlipOrientation PressedStateImageFlip
		{
			get
			{
				return FlipOrientation.Normal;
			}
			set
			{
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00002145 File Offset: 0x00000345
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x00002134 File Offset: 0x00000334
		public float PressedStateImageRotate
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x00002134 File Offset: 0x00000334
		public Image PressedStateImage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00003364 File Offset: 0x00001564
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x00002134 File Offset: 0x00000334
		public Size PressedStateImageSize
		{
			get
			{
				return default(Size);
			}
			set
			{
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060000FA RID: 250 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x060000FB RID: 251 RVA: 0x00002134 File Offset: 0x00000334
		public Point PressedStateImageOffset
		{
			get
			{
				return default(Point);
			}
			set
			{
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060000FC RID: 252 RVA: 0x0000334C File Offset: 0x0000154C
		// (set) Token: 0x060000FD RID: 253 RVA: 0x00002134 File Offset: 0x00000334
		public FlipOrientation HoverStateImageFlip
		{
			get
			{
				return FlipOrientation.Normal;
			}
			set
			{
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00002145 File Offset: 0x00000345
		// (set) Token: 0x060000FF RID: 255 RVA: 0x00002134 File Offset: 0x00000334
		public float HoverStateImageRotate
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000101 RID: 257 RVA: 0x00002134 File Offset: 0x00000334
		public Image HoverStateImage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00003364 File Offset: 0x00001564
		// (set) Token: 0x06000103 RID: 259 RVA: 0x00002134 File Offset: 0x00000334
		public Size HoverStateImageSize
		{
			get
			{
				return default(Size);
			}
			set
			{
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000104 RID: 260 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x06000105 RID: 261 RVA: 0x00002134 File Offset: 0x00000334
		public Point HoverStateImageOffset
		{
			get
			{
				return default(Point);
			}
			set
			{
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000107 RID: 263 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06000108 RID: 264 RVA: 0x00002131 File Offset: 0x00000331
		public override DesignerActionItemCollection GetSortedActionItems()
		{
			return null;
		}

		// Token: 0x04000019 RID: 25
		private Guna2ImageButton guna2ImageButton_0;

		// Token: 0x0400001A RID: 26
		private DesignerActionUIService designerActionUIService_0;
	}
}
