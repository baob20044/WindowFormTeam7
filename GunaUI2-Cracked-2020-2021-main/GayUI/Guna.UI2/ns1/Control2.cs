using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.WinForms.Suite;
using ns0;

namespace ns1
{
	// Token: 0x020000AF RID: 175
	internal class Control2 : UserControl
	{
		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06000D93 RID: 3475 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000D94 RID: 3476 RVA: 0x00002134 File Offset: 0x00000334
		public Color Color_0
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06000D95 RID: 3477 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000D96 RID: 3478 RVA: 0x00002134 File Offset: 0x00000334
		public Color Color_1
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06000D97 RID: 3479 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000D98 RID: 3480 RVA: 0x00002134 File Offset: 0x00000334
		public Color Color_2
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x00002134 File Offset: 0x00000334
		public void method_0(int Value)
		{
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x00002134 File Offset: 0x00000334
		public void method_1(int Value)
		{
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06000D9B RID: 3483 RVA: 0x00002131 File Offset: 0x00000331
		[Browsable(false)]
		public string String_0
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06000D9C RID: 3484 RVA: 0x00002154 File Offset: 0x00000354
		[Browsable(false)]
		public double Double_0
		{
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06000D9D RID: 3485 RVA: 0x00002154 File Offset: 0x00000354
		[Browsable(false)]
		public double Double_1
		{
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06000D9E RID: 3486 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000D9F RID: 3487 RVA: 0x00002134 File Offset: 0x00000334
		public bool Boolean_0
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x14000027 RID: 39
		// (add) Token: 0x06000DA0 RID: 3488 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000DA1 RID: 3489 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler Event_0
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06000DA2 RID: 3490 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000DA3 RID: 3491 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(0)]
		public int Int32_0
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06000DA4 RID: 3492 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000DA5 RID: 3493 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(30)]
		public int Int32_1
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06000DA6 RID: 3494 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000DA7 RID: 3495 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(30)]
		public int Int32_2
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06000DA8 RID: 3496 RVA: 0x00003960 File Offset: 0x00001B60
		// (set) Token: 0x06000DA9 RID: 3497 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(0)]
		public LineCap LineCap_0
		{
			get
			{
				return LineCap.Flat;
			}
			set
			{
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06000DAA RID: 3498 RVA: 0x00003960 File Offset: 0x00001B60
		// (set) Token: 0x06000DAB RID: 3499 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(0)]
		public LineCap LineCap_1
		{
			get
			{
				return LineCap.Flat;
			}
			set
			{
			}
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x00002134 File Offset: 0x00000334
		private void method_2()
		{
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x00002136 File Offset: 0x00000336
		private int method_3(int Pass)
		{
			return 0;
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x00002134 File Offset: 0x00000334
		private void method_4(object sender, EventArgs e)
		{
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x00002134 File Offset: 0x00000334
		private void method_5(bool b = false)
		{
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x00002134 File Offset: 0x00000334
		private void method_6(object sender, EventArgs e)
		{
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x00002134 File Offset: 0x00000334
		private void method_7(object sender, EventArgs e)
		{
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06000DB4 RID: 3508 RVA: 0x00003B24 File Offset: 0x00001D24
		// (set) Token: 0x06000DB5 RID: 3509 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(0)]
		public ColorStyle ColorStyle_0
		{
			get
			{
				return ColorStyle.Default;
			}
			set
			{
			}
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x00002134 File Offset: 0x00000334
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x00002134 File Offset: 0x00000334
		private void method_8()
		{
		}

		// Token: 0x14000028 RID: 40
		// (add) Token: 0x06000DB8 RID: 3512 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000DB9 RID: 3513 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler Event_1
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000029 RID: 41
		// (add) Token: 0x06000DBA RID: 3514 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000DBB RID: 3515 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler Event_2
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x00002134 File Offset: 0x00000334
		private void method_9(object sender, EventArgs e)
		{
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x00002134 File Offset: 0x00000334
		private void method_10(object sender, EventArgs e)
		{
		}

		// Token: 0x0400037E RID: 894
		internal Label label_0;

		// Token: 0x0400037F RID: 895
		internal Label label_1;

		// Token: 0x04000380 RID: 896
		private Class0 class0_0;

		// Token: 0x04000381 RID: 897
		internal Label label_2;

		// Token: 0x04000382 RID: 898
		[CompilerGenerated]
		private EventHandler ValueChanged;

		// Token: 0x04000383 RID: 899
		private int int_0;

		// Token: 0x04000384 RID: 900
		private int int_1;

		// Token: 0x04000385 RID: 901
		private Color color_0;

		// Token: 0x04000386 RID: 902
		private Color color_1;

		// Token: 0x04000387 RID: 903
		private IContainer icontainer_0;

		// Token: 0x04000388 RID: 904
		private Color color_2;

		// Token: 0x04000389 RID: 905
		private Color color_3;

		// Token: 0x0400038A RID: 906
		private Color color_4;

		// Token: 0x0400038B RID: 907
		private int int_2;

		// Token: 0x0400038C RID: 908
		private bool bool_0;

		// Token: 0x0400038D RID: 909
		private int int_3;

		// Token: 0x0400038E RID: 910
		private LineCap lineCap_0;

		// Token: 0x0400038F RID: 911
		private LineCap lineCap_1;

		// Token: 0x04000390 RID: 912
		private ColorStyle colorStyle_0;

		// Token: 0x04000391 RID: 913
		[CompilerGenerated]
		private new EventHandler LostFocus;

		// Token: 0x04000392 RID: 914
		[CompilerGenerated]
		private new EventHandler GotFocus;
	}
}
