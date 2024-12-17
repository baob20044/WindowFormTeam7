using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Guna.UI2.WinForms
{
	// Token: 0x02000040 RID: 64
	[DebuggerStepThrough]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[Description("DataGridViewRowsStyle")]
	public class Guna2DataGridViewRowsStyle
	{
		// Token: 0x06000395 RID: 917 RVA: 0x00002131 File Offset: 0x00000331
		private Guna2DataGridView method_0()
		{
			return null;
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00002131 File Offset: 0x00000331
		private DataGridViewCellStyle method_1()
		{
			return null;
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00002167 File Offset: 0x00000367
		public Guna2DataGridViewRowsStyle(DataGridViewCellStyle sender, Guna2DataGridView parent)
		{
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000398 RID: 920 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000399 RID: 921 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The Dheight")]
		public int Height
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x0600039A RID: 922 RVA: 0x000038A0 File Offset: 0x00001AA0
		// (set) Token: 0x0600039B RID: 923 RVA: 0x00002134 File Offset: 0x00000334
		public DataGridViewCellBorderStyle BorderStyle
		{
			get
			{
				return DataGridViewCellBorderStyle.Custom;
			}
			set
			{
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x0600039C RID: 924 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600039D RID: 925 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The BackColor")]
		public Color BackColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x0600039E RID: 926 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600039F RID: 927 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The ForeColor")]
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

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060003A1 RID: 929 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The font style")]
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

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060003A3 RID: 931 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The Selection BackColor")]
		public Color SelectionBackColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The selection ForeColor")]
		public Color SelectionForeColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00002131 File Offset: 0x00000331
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040000D2 RID: 210
		private Guna2DataGridView guna2DataGridView_0;

		// Token: 0x040000D3 RID: 211
		private DataGridViewCellStyle dataGridViewCellStyle_0;

		// Token: 0x040000D4 RID: 212
		private DataGridViewCellBorderStyle dataGridViewCellBorderStyle_0;
	}
}
