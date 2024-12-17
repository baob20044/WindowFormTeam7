using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using Guna.UI2.WinForms;

namespace System.Windows.Forms.Design
{
	// Token: 0x0200000A RID: 10
	public class Guna2ProgressBarActionList : DesignerActionList
	{
		// Token: 0x06000085 RID: 133 RVA: 0x00002128 File Offset: 0x00000328
		public Guna2ProgressBarActionList(IComponent component) : base(null)
		{
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002131 File Offset: 0x00000331
		private PropertyDescriptor method_0(string propName)
		{
			return null;
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000088 RID: 136 RVA: 0x00002134 File Offset: 0x00000334
		public int Value
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600008A RID: 138 RVA: 0x00002134 File Offset: 0x00000334
		public int Maximum
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600008C RID: 140 RVA: 0x00002134 File Offset: 0x00000334
		public int Minimum
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600008F RID: 143 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000090 RID: 144 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000091 RID: 145 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00002134 File Offset: 0x00000334
		public Color ProgressColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000093 RID: 147 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000094 RID: 148 RVA: 0x00002134 File Offset: 0x00000334
		public Color ProgressColor2
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00003334 File Offset: 0x00001534
		// (set) Token: 0x06000096 RID: 150 RVA: 0x00002134 File Offset: 0x00000334
		public ProgressBarStyle Style
		{
			get
			{
				return ProgressBarStyle.Blocks;
			}
			set
			{
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000098 RID: 152 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600009A RID: 154 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x0600009B RID: 155 RVA: 0x00002131 File Offset: 0x00000331
		public override DesignerActionItemCollection GetSortedActionItems()
		{
			return null;
		}

		// Token: 0x0400000D RID: 13
		private Guna2ProgressBar guna2ProgressBar_0;

		// Token: 0x0400000E RID: 14
		private DesignerActionUIService designerActionUIService_0;
	}
}
