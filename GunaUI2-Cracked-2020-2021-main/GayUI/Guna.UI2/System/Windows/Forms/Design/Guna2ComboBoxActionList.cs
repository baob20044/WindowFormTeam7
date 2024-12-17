using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using Guna.UI2.WinForms;

namespace System.Windows.Forms.Design
{
	// Token: 0x02000010 RID: 16
	public class Guna2ComboBoxActionList : DesignerActionList
	{
		// Token: 0x060000C8 RID: 200 RVA: 0x00002128 File Offset: 0x00000328
		public Guna2ComboBoxActionList(IComponent component) : base(null)
		{
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002131 File Offset: 0x00000331
		private PropertyDescriptor method_0(string propName)
		{
			return null;
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060000CB RID: 203 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060000CD RID: 205 RVA: 0x00002134 File Offset: 0x00000334
		public int StartIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060000CF RID: 207 RVA: 0x00002134 File Offset: 0x00000334
		[Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Culture=neutral", typeof(UITypeEditor))]
		public ComboBox.ObjectCollection Items
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x00002134 File Offset: 0x00000334
		public int BorderThickness
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000DA RID: 218 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060000DB RID: 219 RVA: 0x00002134 File Offset: 0x00000334
		public Color BorderColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060000DD RID: 221 RVA: 0x00002134 File Offset: 0x00000334
		public bool AutoRoundedCorners
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060000DF RID: 223 RVA: 0x00002134 File Offset: 0x00000334
		public bool Animated
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002131 File Offset: 0x00000331
		public override DesignerActionItemCollection GetSortedActionItems()
		{
			return null;
		}

		// Token: 0x04000016 RID: 22
		private Guna2ComboBox guna2ComboBox_0;

		// Token: 0x04000017 RID: 23
		private DesignerActionUIService designerActionUIService_0;
	}
}
