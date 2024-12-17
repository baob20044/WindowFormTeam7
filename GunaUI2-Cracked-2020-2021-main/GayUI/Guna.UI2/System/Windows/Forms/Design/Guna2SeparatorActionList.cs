using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using Guna.UI2.WinForms;

namespace System.Windows.Forms.Design
{
	// Token: 0x0200000C RID: 12
	public class Guna2SeparatorActionList : DesignerActionList
	{
		// Token: 0x0600009E RID: 158 RVA: 0x00002128 File Offset: 0x00000328
		public Guna2SeparatorActionList(IComponent component) : base(null)
		{
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002131 File Offset: 0x00000331
		private PropertyDescriptor method_0(string propName)
		{
			return null;
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x00002134 File Offset: 0x00000334
		public DashStyle FillStyle
		{
			get
			{
				return DashStyle.Solid;
			}
			set
			{
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x00002134 File Offset: 0x00000334
		public int FillThickness
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x060000A8 RID: 168 RVA: 0x00002131 File Offset: 0x00000331
		public override DesignerActionItemCollection GetSortedActionItems()
		{
			return null;
		}

		// Token: 0x04000010 RID: 16
		private Guna2Separator guna2Separator_0;

		// Token: 0x04000011 RID: 17
		private DesignerActionUIService designerActionUIService_0;
	}
}
