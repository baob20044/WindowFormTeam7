using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Guna.UI2.AnimatorNS
{
	// Token: 0x02000188 RID: 392
	public class AnimationCompletedEventArg : EventArgs
	{
		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x0600179E RID: 6046 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x0600179F RID: 6047 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x060017A0 RID: 6048 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060017A1 RID: 6049 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x060017A2 RID: 6050 RVA: 0x000068EC File Offset: 0x00004AEC
		// (set) Token: 0x060017A3 RID: 6051 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x04000A2C RID: 2604
		[CompilerGenerated]
		private Animation animation_0;

		// Token: 0x04000A2D RID: 2605
		[CompilerGenerated]
		private Control control_0;

		// Token: 0x04000A2E RID: 2606
		[CompilerGenerated]
		private AnimateMode animateMode_0;
	}
}
