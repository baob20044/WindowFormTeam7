using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;

namespace System.Windows.Forms.Design
{
	// Token: 0x02000006 RID: 6
	public class Guna2GradientButtonActionList : DesignerActionList
	{
		// Token: 0x0600003F RID: 63 RVA: 0x00002128 File Offset: 0x00000328
		public Guna2GradientButtonActionList(IComponent component) : base(null)
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002131 File Offset: 0x00000331
		private PropertyDescriptor method_0(string propName)
		{
			return null;
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000041 RID: 65 RVA: 0x0000331C File Offset: 0x0000151C
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00002134 File Offset: 0x00000334
		public LinearGradientMode GradientMode
		{
			get
			{
				return LinearGradientMode.Horizontal;
			}
			set
			{
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600004A RID: 74 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600004B RID: 75 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600004D RID: 77 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600004E RID: 78 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600004F RID: 79 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000051 RID: 81 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000052 RID: 82 RVA: 0x00002134 File Offset: 0x00000334
		public Color FillColor2
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000053 RID: 83 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00003304 File Offset: 0x00001504
		// (set) Token: 0x06000056 RID: 86 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000058 RID: 88 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600005A RID: 90 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000060 RID: 96 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06000061 RID: 97 RVA: 0x00002131 File Offset: 0x00000331
		public override DesignerActionItemCollection GetSortedActionItems()
		{
			return null;
		}

		// Token: 0x04000007 RID: 7
		private Guna2GradientButton guna2GradientButton_0;

		// Token: 0x04000008 RID: 8
		private DesignerActionUIService designerActionUIService_0;
	}
}
