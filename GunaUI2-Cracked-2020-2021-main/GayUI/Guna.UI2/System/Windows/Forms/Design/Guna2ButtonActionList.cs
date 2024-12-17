using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;

namespace System.Windows.Forms.Design
{
	// Token: 0x02000002 RID: 2
	public class Guna2ButtonActionList : DesignerActionList
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002128 File Offset: 0x00000328
		public Guna2ButtonActionList(IComponent component) : base(null)
		{
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002131 File Offset: 0x00000331
		private PropertyDescriptor method_0(string propName)
		{
			return null;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000004 RID: 4 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000006 RID: 6 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000008 RID: 8 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600000A RID: 10 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x0600000C RID: 12 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000D RID: 13 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600000E RID: 14 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000F RID: 15 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000010 RID: 16 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000011 RID: 17 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000012 RID: 18 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00003304 File Offset: 0x00001504
		// (set) Token: 0x06000014 RID: 20 RVA: 0x00002134 File Offset: 0x00000334
		public ButtonMode ButtonMode
		{
			get
			{
				return ButtonMode.DefaultButton;
			}
			set
			{
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000016 RID: 22 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000018 RID: 24 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600001A RID: 26 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600001C RID: 28 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600001E RID: 30 RVA: 0x00002134 File Offset: 0x00000334
		public bool AutoSize
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002131 File Offset: 0x00000331
		public override DesignerActionItemCollection GetSortedActionItems()
		{
			return null;
		}

		// Token: 0x04000001 RID: 1
		private Guna2Button guna2Button_0;

		// Token: 0x04000002 RID: 2
		private DesignerActionUIService designerActionUIService_0;
	}
}
