using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Guna.UI2.AnimatorNS
{
	// Token: 0x02000189 RID: 393
	public class TransfromNeededEventArg : EventArgs
	{
		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x060017A6 RID: 6054 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060017A7 RID: 6055 RVA: 0x00002134 File Offset: 0x00000334
		public Matrix Matrix
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x060017A8 RID: 6056 RVA: 0x00002145 File Offset: 0x00000345
		// (set) Token: 0x060017A9 RID: 6057 RVA: 0x00002134 File Offset: 0x00000334
		public float CurrentTime
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x060017AA RID: 6058 RVA: 0x0000343C File Offset: 0x0000163C
		// (set) Token: 0x060017AB RID: 6059 RVA: 0x00002134 File Offset: 0x00000334
		public Rectangle ClientRectangle
		{
			[CompilerGenerated]
			get
			{
				return default(Rectangle);
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x060017AC RID: 6060 RVA: 0x0000343C File Offset: 0x0000163C
		// (set) Token: 0x060017AD RID: 6061 RVA: 0x00002134 File Offset: 0x00000334
		public Rectangle ClipRectangle
		{
			[CompilerGenerated]
			get
			{
				return default(Rectangle);
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x060017AE RID: 6062 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060017AF RID: 6063 RVA: 0x00002134 File Offset: 0x00000334
		public Animation Animation
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x060017B0 RID: 6064 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060017B1 RID: 6065 RVA: 0x00002134 File Offset: 0x00000334
		public Control Control
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x060017B2 RID: 6066 RVA: 0x000068EC File Offset: 0x00004AEC
		// (set) Token: 0x060017B3 RID: 6067 RVA: 0x00002134 File Offset: 0x00000334
		public AnimateMode Mode
		{
			[CompilerGenerated]
			get
			{
				return AnimateMode.Show;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x060017B4 RID: 6068 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060017B5 RID: 6069 RVA: 0x00002134 File Offset: 0x00000334
		public bool UseDefaultMatrix
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x04000A2F RID: 2607
		[CompilerGenerated]
		private Matrix matrix_0;

		// Token: 0x04000A30 RID: 2608
		[CompilerGenerated]
		private float float_0;

		// Token: 0x04000A31 RID: 2609
		[CompilerGenerated]
		private Rectangle rectangle_0;

		// Token: 0x04000A32 RID: 2610
		[CompilerGenerated]
		private Rectangle rectangle_1;

		// Token: 0x04000A33 RID: 2611
		[CompilerGenerated]
		private Animation animation_0;

		// Token: 0x04000A34 RID: 2612
		[CompilerGenerated]
		private Control control_0;

		// Token: 0x04000A35 RID: 2613
		[CompilerGenerated]
		private AnimateMode animateMode_0;

		// Token: 0x04000A36 RID: 2614
		[CompilerGenerated]
		private bool bool_0;
	}
}
