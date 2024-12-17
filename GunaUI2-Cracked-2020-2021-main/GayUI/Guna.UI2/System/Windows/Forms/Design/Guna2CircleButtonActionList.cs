using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;

namespace System.Windows.Forms.Design
{
	// Token: 0x02000004 RID: 4
	public class Guna2CircleButtonActionList : DesignerActionList
	{
		// Token: 0x06000022 RID: 34 RVA: 0x00002128 File Offset: 0x00000328
		public Guna2CircleButtonActionList(IComponent component) : base(null)
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002131 File Offset: 0x00000331
		private PropertyDescriptor method_0(string propName)
		{
			return null;
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000025 RID: 37 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000027 RID: 39 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600002C RID: 44 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x0600002D RID: 45 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600002E RID: 46 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600002F RID: 47 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000030 RID: 48 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000031 RID: 49 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000032 RID: 50 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000033 RID: 51 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00003304 File Offset: 0x00001504
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x0600003C RID: 60 RVA: 0x00002131 File Offset: 0x00000331
		public override DesignerActionItemCollection GetSortedActionItems()
		{
			return null;
		}

		// Token: 0x04000004 RID: 4
		private Guna2CircleButton guna2CircleButton_0;

		// Token: 0x04000005 RID: 5
		private DesignerActionUIService designerActionUIService_0;
	}
}
