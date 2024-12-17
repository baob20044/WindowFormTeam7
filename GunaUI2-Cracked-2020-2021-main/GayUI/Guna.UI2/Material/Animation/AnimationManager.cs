using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Guna.UI2.Material.Animation
{
	// Token: 0x020000F4 RID: 244
	public class AnimationManager
	{
		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x0600116E RID: 4462 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600116F RID: 4463 RVA: 0x00002134 File Offset: 0x00000334
		public bool InterruptAnimation
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

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06001170 RID: 4464 RVA: 0x00002154 File Offset: 0x00000354
		// (set) Token: 0x06001171 RID: 4465 RVA: 0x00002134 File Offset: 0x00000334
		public double Increment
		{
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06001172 RID: 4466 RVA: 0x00002154 File Offset: 0x00000354
		// (set) Token: 0x06001173 RID: 4467 RVA: 0x00002134 File Offset: 0x00000334
		public double SecondaryIncrement
		{
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06001174 RID: 4468 RVA: 0x00003B84 File Offset: 0x00001D84
		// (set) Token: 0x06001175 RID: 4469 RVA: 0x00002134 File Offset: 0x00000334
		public AnimationType AnimationType
		{
			[CompilerGenerated]
			get
			{
				return AnimationType.Linear;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06001176 RID: 4470 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06001177 RID: 4471 RVA: 0x00002134 File Offset: 0x00000334
		public bool Singular
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

		// Token: 0x1400004A RID: 74
		// (add) Token: 0x06001178 RID: 4472 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06001179 RID: 4473 RVA: 0x00002134 File Offset: 0x00000334
		public event AnimationManager.AnimationFinished OnAnimationFinished
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

		// Token: 0x1400004B RID: 75
		// (add) Token: 0x0600117A RID: 4474 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x0600117B RID: 4475 RVA: 0x00002134 File Offset: 0x00000334
		public event AnimationManager.AnimationProgress OnAnimationProgress
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

		// Token: 0x0600117C RID: 4476 RVA: 0x00002167 File Offset: 0x00000367
		public AnimationManager(bool singular = true)
		{
		}

		// Token: 0x0600117D RID: 4477 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0(object sender, EventArgs e)
		{
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x00002136 File Offset: 0x00000336
		public bool IsAnimating()
		{
			return false;
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x00002134 File Offset: 0x00000334
		public void StartNewAnimation(AnimationDirection animationDirection, object[] data = null)
		{
		}

		// Token: 0x06001180 RID: 4480 RVA: 0x00002134 File Offset: 0x00000334
		public void StartNewAnimation(AnimationDirection animationDirection, Point animationSource, object[] data = null)
		{
		}

		// Token: 0x06001181 RID: 4481 RVA: 0x00002134 File Offset: 0x00000334
		public void UpdateProgress(int index)
		{
		}

		// Token: 0x06001182 RID: 4482 RVA: 0x00002134 File Offset: 0x00000334
		private void method_1(int index)
		{
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x00002134 File Offset: 0x00000334
		private void method_2(int index)
		{
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x00002154 File Offset: 0x00000354
		public double GetProgress()
		{
			return 0.0;
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x00002154 File Offset: 0x00000354
		public double GetProgress(int index)
		{
			return 0.0;
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x0000337C File Offset: 0x0000157C
		public Point GetSource(int index)
		{
			return default(Point);
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x0000337C File Offset: 0x0000157C
		public Point GetSource()
		{
			return default(Point);
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x00003B9C File Offset: 0x00001D9C
		public AnimationDirection GetDirection()
		{
			return AnimationDirection.In;
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x00003B9C File Offset: 0x00001D9C
		public AnimationDirection GetDirection(int index)
		{
			return AnimationDirection.In;
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x00002131 File Offset: 0x00000331
		public object[] GetData()
		{
			return null;
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x00002131 File Offset: 0x00000331
		public object[] GetData(int index)
		{
			return null;
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x00002136 File Offset: 0x00000336
		public int GetAnimationCount()
		{
			return 0;
		}

		// Token: 0x0600118D RID: 4493 RVA: 0x00002134 File Offset: 0x00000334
		public void SetProgress(double progress)
		{
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x00002134 File Offset: 0x00000334
		public void SetDirection(AnimationDirection direction)
		{
		}

		// Token: 0x0600118F RID: 4495 RVA: 0x00002134 File Offset: 0x00000334
		public void SetData(object[] data)
		{
		}

		// Token: 0x0400068F RID: 1679
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x04000690 RID: 1680
		[CompilerGenerated]
		private double double_0;

		// Token: 0x04000691 RID: 1681
		[CompilerGenerated]
		private double double_1;

		// Token: 0x04000692 RID: 1682
		[CompilerGenerated]
		private AnimationType animationType_0;

		// Token: 0x04000693 RID: 1683
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x04000696 RID: 1686
		private readonly List<double> list_0;

		// Token: 0x04000697 RID: 1687
		private readonly List<Point> list_1;

		// Token: 0x04000698 RID: 1688
		private readonly List<AnimationDirection> list_2;

		// Token: 0x04000699 RID: 1689
		private readonly List<object[]> list_3;

		// Token: 0x0400069A RID: 1690
		private const double double_2 = 0.0;

		// Token: 0x0400069B RID: 1691
		private const double double_3 = 1.0;

		// Token: 0x0400069C RID: 1692
		private readonly Timer timer_0;

		// Token: 0x020000F5 RID: 245
		// (Invoke) Token: 0x06001191 RID: 4497
		public delegate void AnimationFinished(object sender);

		// Token: 0x020000F6 RID: 246
		// (Invoke) Token: 0x06001195 RID: 4501
		public delegate void AnimationProgress(object sender);
	}
}
