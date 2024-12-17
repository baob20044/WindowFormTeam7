using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using ns13;

namespace Guna.UI2.AnimatorNS
{
	// Token: 0x02000182 RID: 386
	[ToolboxItem(false)]
	[ProvideProperty("Decoration", typeof(Control))]
	public class Animator : Component, IExtenderProvider
	{
		// Token: 0x1400005B RID: 91
		// (add) Token: 0x06001757 RID: 5975 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06001758 RID: 5976 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler<AnimationCompletedEventArg> AnimationCompleted
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

		// Token: 0x1400005C RID: 92
		// (add) Token: 0x06001759 RID: 5977 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x0600175A RID: 5978 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler AllAnimationsCompleted
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

		// Token: 0x1400005D RID: 93
		// (add) Token: 0x0600175B RID: 5979 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x0600175C RID: 5980 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler<TransfromNeededEventArg> TransfromNeeded
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

		// Token: 0x1400005E RID: 94
		// (add) Token: 0x0600175D RID: 5981 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x0600175E RID: 5982 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler<NonLinearTransfromNeededEventArg> NonLinearTransfromNeeded
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

		// Token: 0x1400005F RID: 95
		// (add) Token: 0x0600175F RID: 5983 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06001760 RID: 5984 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler<MouseEventArgs> MouseDown
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

		// Token: 0x14000060 RID: 96
		// (add) Token: 0x06001761 RID: 5985 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06001762 RID: 5986 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler<PaintEventArgs> FramePainted
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

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x06001763 RID: 5987 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06001764 RID: 5988 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(1500)]
		public int MaxAnimationTime
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x06001765 RID: 5989 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06001766 RID: 5990 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue("")]
		[TypeConverter(typeof(ExpandableObjectConverter))]
		public Animation DefaultAnimation
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

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x06001767 RID: 5991 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06001768 RID: 5992 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Cursor), "Default")]
		public Cursor Cursor
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

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x06001769 RID: 5993 RVA: 0x00002136 File Offset: 0x00000336
		public bool IsCompleted
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x0600176A RID: 5994 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600176B RID: 5995 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(10)]
		public int Interval
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x0600176C RID: 5996 RVA: 0x000068BC File Offset: 0x00004ABC
		// (set) Token: 0x0600176D RID: 5997 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(AnimationType.VertBlind)]
		public AnimationType AnimationType
		{
			get
			{
				return AnimationType.Custom;
			}
			set
			{
			}
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x0000214C File Offset: 0x0000034C
		public Animator()
		{
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x0000214C File Offset: 0x0000034C
		public Animator(IContainer container)
		{
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x00002134 File Offset: 0x00000334
		protected virtual void Init()
		{
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0()
		{
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x00002134 File Offset: 0x00000334
		private void method_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06001773 RID: 6003 RVA: 0x00002134 File Offset: 0x00000334
		private void method_2(object sender, EventArgs e)
		{
		}

		// Token: 0x06001774 RID: 6004 RVA: 0x00002134 File Offset: 0x00000334
		private void method_3()
		{
		}

		// Token: 0x06001775 RID: 6005 RVA: 0x00002134 File Offset: 0x00000334
		private void method_4()
		{
		}

		// Token: 0x06001776 RID: 6006 RVA: 0x00002136 File Offset: 0x00000336
		private bool method_5(Control control, AnimateMode mode)
		{
			return false;
		}

		// Token: 0x06001777 RID: 6007 RVA: 0x00002134 File Offset: 0x00000334
		private void method_6(Control control, AnimateMode mode)
		{
		}

		// Token: 0x06001778 RID: 6008 RVA: 0x00002134 File Offset: 0x00000334
		private void method_7(Animator.QueueItem item)
		{
		}

		// Token: 0x06001779 RID: 6009 RVA: 0x00002134 File Offset: 0x00000334
		private void method_8(AnimationType animationType)
		{
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x0600177A RID: 6010 RVA: 0x00002145 File Offset: 0x00000345
		// (set) Token: 0x0600177B RID: 6011 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(0.02f)]
		public float TimeStep
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600177C RID: 6012 RVA: 0x00002134 File Offset: 0x00000334
		public void Show(Control control, bool parallel = false, Animation animation = null)
		{
		}

		// Token: 0x0600177D RID: 6013 RVA: 0x00002134 File Offset: 0x00000334
		public void ShowSync(Control control, bool parallel = false, Animation animation = null)
		{
		}

		// Token: 0x0600177E RID: 6014 RVA: 0x00002134 File Offset: 0x00000334
		public void Hide(Control control, bool parallel = false, Animation animation = null)
		{
		}

		// Token: 0x0600177F RID: 6015 RVA: 0x00002134 File Offset: 0x00000334
		public void HideSync(Control control, bool parallel = false, Animation animation = null)
		{
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x00002134 File Offset: 0x00000334
		public void BeginUpdate(Control control, bool parallel = false, Animation animation = null, Rectangle clipRectangle = default(Rectangle))
		{
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x00002134 File Offset: 0x00000334
		public void EndUpdate(Control control)
		{
		}

		// Token: 0x06001782 RID: 6018 RVA: 0x00002134 File Offset: 0x00000334
		public void EndUpdateSync(Control control)
		{
		}

		// Token: 0x06001783 RID: 6019 RVA: 0x00002134 File Offset: 0x00000334
		public void WaitAllAnimations()
		{
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x00002134 File Offset: 0x00000334
		public void WaitAnimation(Control animatedControl)
		{
		}

		// Token: 0x06001785 RID: 6021 RVA: 0x00002134 File Offset: 0x00000334
		private void method_9(Animator.QueueItem item)
		{
		}

		// Token: 0x06001786 RID: 6022 RVA: 0x00002134 File Offset: 0x00000334
		public void AddToQueue(Control control, AnimateMode mode, bool parallel = true, Animation animation = null, Rectangle clipRectangle = default(Rectangle))
		{
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x00002131 File Offset: 0x00000331
		private Controller method_10(Control control, AnimateMode mode, Animation animation, Rectangle clipRect)
		{
			return null;
		}

		// Token: 0x06001788 RID: 6024 RVA: 0x00002134 File Offset: 0x00000334
		private void method_11(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06001789 RID: 6025 RVA: 0x00002134 File Offset: 0x00000334
		protected virtual void OnMouseDown(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x00002134 File Offset: 0x00000334
		protected virtual void OnNonLinearTransfromNeeded(object sender, NonLinearTransfromNeededEventArg e)
		{
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x00002134 File Offset: 0x00000334
		protected virtual void OnTransformNeeded(object sender, TransfromNeededEventArg e)
		{
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x00002134 File Offset: 0x00000334
		public void ClearQueue()
		{
		}

		// Token: 0x0600178D RID: 6029 RVA: 0x00002134 File Offset: 0x00000334
		protected virtual void OnAnimationCompleted(AnimationCompletedEventArg e)
		{
		}

		// Token: 0x0600178E RID: 6030 RVA: 0x00002134 File Offset: 0x00000334
		protected virtual void OnAllAnimationsCompleted()
		{
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x000068D4 File Offset: 0x00004AD4
		public DecorationType GetDecoration(Control control)
		{
			return DecorationType.None;
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x00002134 File Offset: 0x00000334
		public void SetDecoration(Control control, DecorationType decoration)
		{
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x00002136 File Offset: 0x00000336
		public bool CanExtend(object extendee)
		{
			return false;
		}

		// Token: 0x04000A08 RID: 2568
		private IContainer icontainer_0;

		// Token: 0x04000A09 RID: 2569
		protected List<Animator.QueueItem> queue;

		// Token: 0x04000A0A RID: 2570
		private Thread thread_0;

		// Token: 0x04000A0B RID: 2571
		private System.Windows.Forms.Timer timer_0;

		// Token: 0x04000A12 RID: 2578
		[CompilerGenerated]
		private int int_0;

		// Token: 0x04000A13 RID: 2579
		[CompilerGenerated]
		private Animation animation_0;

		// Token: 0x04000A14 RID: 2580
		[CompilerGenerated]
		private Cursor cursor_0;

		// Token: 0x04000A15 RID: 2581
		[CompilerGenerated]
		private int int_1;

		// Token: 0x04000A16 RID: 2582
		private AnimationType animationType_0;

		// Token: 0x04000A17 RID: 2583
		private Control control_0;

		// Token: 0x04000A18 RID: 2584
		private int int_2;

		// Token: 0x04000A19 RID: 2585
		[CompilerGenerated]
		private float float_0;

		// Token: 0x04000A1A RID: 2586
		private List<Animator.QueueItem> list_0;

		// Token: 0x04000A1B RID: 2587
		private readonly Dictionary<Control, Control11> dictionary_0;

		// Token: 0x02000183 RID: 387
		protected class QueueItem
		{
			// Token: 0x17000798 RID: 1944
			// (get) Token: 0x06001792 RID: 6034 RVA: 0x00003B0C File Offset: 0x00001D0C
			// (set) Token: 0x06001793 RID: 6035 RVA: 0x00002134 File Offset: 0x00000334
			public DateTime ActivateTime
			{
				[CompilerGenerated]
				get
				{
					return default(DateTime);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000799 RID: 1945
			// (get) Token: 0x06001794 RID: 6036 RVA: 0x00002136 File Offset: 0x00000336
			// (set) Token: 0x06001795 RID: 6037 RVA: 0x00002134 File Offset: 0x00000334
			public bool IsActive
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			// Token: 0x06001796 RID: 6038 RVA: 0x00002131 File Offset: 0x00000331
			public override string ToString()
			{
				return null;
			}

			// Token: 0x04000A1C RID: 2588
			public Animation animation;

			// Token: 0x04000A1D RID: 2589
			public Controller controller;

			// Token: 0x04000A1E RID: 2590
			public Control control;

			// Token: 0x04000A1F RID: 2591
			[CompilerGenerated]
			private DateTime dateTime_0;

			// Token: 0x04000A20 RID: 2592
			public AnimateMode mode;

			// Token: 0x04000A21 RID: 2593
			public Rectangle clipRectangle;

			// Token: 0x04000A22 RID: 2594
			public bool isActive;
		}
	}
}
