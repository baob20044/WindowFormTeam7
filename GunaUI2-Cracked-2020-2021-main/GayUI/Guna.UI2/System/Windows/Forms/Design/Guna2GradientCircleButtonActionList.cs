using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;

namespace System.Windows.Forms.Design
{
	// Token: 0x02000008 RID: 8
	public class Guna2GradientCircleButtonActionList : DesignerActionList
	{
		// Token: 0x06000064 RID: 100 RVA: 0x00002128 File Offset: 0x00000328
		public Guna2GradientCircleButtonActionList(IComponent component) : base(null)
		{
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002131 File Offset: 0x00000331
		private PropertyDescriptor method_0(string propName)
		{
			return null;
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000066 RID: 102 RVA: 0x0000331C File Offset: 0x0000151C
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000069 RID: 105 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000070 RID: 112 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000072 RID: 114 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000074 RID: 116 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000076 RID: 118 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000078 RID: 120 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00003304 File Offset: 0x00001504
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600007F RID: 127 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000081 RID: 129 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06000082 RID: 130 RVA: 0x00002131 File Offset: 0x00000331
		public override DesignerActionItemCollection GetSortedActionItems()
		{
			return null;
		}

		// Token: 0x0400000A RID: 10
		private Guna2GradientCircleButton guna2GradientCircleButton_0;

		// Token: 0x0400000B RID: 11
		private DesignerActionUIService designerActionUIService_0;
	}
}
