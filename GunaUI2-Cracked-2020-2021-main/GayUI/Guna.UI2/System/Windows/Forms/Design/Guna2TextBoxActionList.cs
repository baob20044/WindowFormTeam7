using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using Guna.UI2.WinForms;

namespace System.Windows.Forms.Design
{
	// Token: 0x0200000E RID: 14
	public class Guna2TextBoxActionList : DesignerActionList
	{
		// Token: 0x060000AB RID: 171 RVA: 0x00002128 File Offset: 0x00000328
		public Guna2TextBoxActionList(IComponent component) : base(null)
		{
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002131 File Offset: 0x00000331
		private PropertyDescriptor method_0(string propName)
		{
			return null;
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060000AE RID: 174 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x00002134 File Offset: 0x00000334
		[Editor("System.ComponentModel.Design.MultilineStringEditor, System.Design, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
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

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060000BA RID: 186 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000BB RID: 187 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060000BC RID: 188 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060000BE RID: 190 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x00002134 File Offset: 0x00000334
		[Editor("System.ComponentModel.Design.MultilineStringEditor, System.Design, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
		public string PlaceholderText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x00002134 File Offset: 0x00000334
		public Color PlaceholderForeColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002131 File Offset: 0x00000331
		public override DesignerActionItemCollection GetSortedActionItems()
		{
			return null;
		}

		// Token: 0x04000013 RID: 19
		private Guna2TextBox guna2TextBox_0;

		// Token: 0x04000014 RID: 20
		private DesignerActionUIService designerActionUIService_0;
	}
}
