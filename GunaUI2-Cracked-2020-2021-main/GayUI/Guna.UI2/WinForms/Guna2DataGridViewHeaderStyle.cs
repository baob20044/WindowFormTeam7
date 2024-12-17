using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Guna.UI2.WinForms
{
	// Token: 0x0200003F RID: 63
	[Description("DataGridViewHeaderStyle")]
	[DebuggerStepThrough]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class Guna2DataGridViewHeaderStyle
	{
		// Token: 0x06000385 RID: 901 RVA: 0x00002131 File Offset: 0x00000331
		private Guna2DataGridView method_0()
		{
			return null;
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00002131 File Offset: 0x00000331
		private DataGridViewCellStyle method_1()
		{
			return null;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00002167 File Offset: 0x00000367
		public Guna2DataGridViewHeaderStyle(DataGridViewCellStyle sender, Guna2DataGridView parent)
		{
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000388 RID: 904 RVA: 0x00003870 File Offset: 0x00001A70
		// (set) Token: 0x06000389 RID: 905 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The height size mode")]
		public DataGridViewColumnHeadersHeightSizeMode HeaightSizeMode
		{
			get
			{
				return DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			}
			set
			{
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600038A RID: 906 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600038B RID: 907 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The height")]
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

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600038C RID: 908 RVA: 0x00003888 File Offset: 0x00001A88
		// (set) Token: 0x0600038D RID: 909 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The DataGridView HeaderBorderStyle ")]
		public DataGridViewHeaderBorderStyle BorderStyle
		{
			get
			{
				return DataGridViewHeaderBorderStyle.Custom;
			}
			set
			{
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600038E RID: 910 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600038F RID: 911 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000390 RID: 912 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000391 RID: 913 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000392 RID: 914 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000393 RID: 915 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The Font style")]
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

		// Token: 0x06000394 RID: 916 RVA: 0x00002131 File Offset: 0x00000331
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040000D0 RID: 208
		private Guna2DataGridView guna2DataGridView_0;

		// Token: 0x040000D1 RID: 209
		private DataGridViewCellStyle dataGridViewCellStyle_0;
	}
}
