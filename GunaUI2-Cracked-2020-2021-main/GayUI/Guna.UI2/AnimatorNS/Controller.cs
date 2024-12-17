using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Guna.UI2.AnimatorNS
{
	// Token: 0x0200018C RID: 396
	public class Controller
	{
		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x060017CD RID: 6093 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060017CE RID: 6094 RVA: 0x00002134 File Offset: 0x00000334
		protected Bitmap BgBmp
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x060017CF RID: 6095 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060017D0 RID: 6096 RVA: 0x00002134 File Offset: 0x00000334
		public Bitmap Frame
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x060017D1 RID: 6097 RVA: 0x00002145 File Offset: 0x00000345
		// (set) Token: 0x060017D2 RID: 6098 RVA: 0x00002134 File Offset: 0x00000334
		public float CurrentTime
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x060017D3 RID: 6099 RVA: 0x00002145 File Offset: 0x00000345
		// (set) Token: 0x060017D4 RID: 6100 RVA: 0x00002134 File Offset: 0x00000334
		private protected float TimeStep
		{
			[CompilerGenerated]
			protected get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x14000061 RID: 97
		// (add) Token: 0x060017D5 RID: 6101 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x060017D6 RID: 6102 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x14000062 RID: 98
		// (add) Token: 0x060017D7 RID: 6103 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x060017D8 RID: 6104 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x14000063 RID: 99
		// (add) Token: 0x060017D9 RID: 6105 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x060017DA RID: 6106 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler<PaintEventArgs> FramePainting
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

		// Token: 0x14000064 RID: 100
		// (add) Token: 0x060017DB RID: 6107 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x060017DC RID: 6108 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x14000065 RID: 101
		// (add) Token: 0x060017DD RID: 6109 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x060017DE RID: 6110 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x060017DF RID: 6111 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060017E0 RID: 6112 RVA: 0x00002134 File Offset: 0x00000334
		public Control DoubleBitmap
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x060017E1 RID: 6113 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060017E2 RID: 6114 RVA: 0x00002134 File Offset: 0x00000334
		public Control AnimatedControl
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

		// Token: 0x060017E3 RID: 6115 RVA: 0x00002134 File Offset: 0x00000334
		public void Dispose()
		{
		}

		// Token: 0x060017E4 RID: 6116 RVA: 0x00002134 File Offset: 0x00000334
		public void Hide()
		{
		}

		// Token: 0x060017E5 RID: 6117 RVA: 0x0000343C File Offset: 0x0000163C
		protected virtual Rectangle GetBounds()
		{
			return default(Rectangle);
		}

		// Token: 0x060017E6 RID: 6118 RVA: 0x0000343C File Offset: 0x0000163C
		protected virtual Rectangle ControlRectToMyRect(Rectangle rect)
		{
			return default(Rectangle);
		}

		// Token: 0x060017E7 RID: 6119 RVA: 0x00002167 File Offset: 0x00000367
		public Controller(Control control, AnimateMode mode, Animation animation, float timeStep, Rectangle controlClipRect)
		{
		}

		// Token: 0x060017E8 RID: 6120 RVA: 0x00002134 File Offset: 0x00000334
		protected virtual void OnMouseDown(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x060017E9 RID: 6121 RVA: 0x00002134 File Offset: 0x00000334
		protected virtual void OnFramePainting(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060017EA RID: 6122 RVA: 0x00002134 File Offset: 0x00000334
		protected virtual void OnFramePainted(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060017EB RID: 6123 RVA: 0x00002131 File Offset: 0x00000331
		protected virtual Bitmap GetBackground(Control ctrl, bool includeForeground = false, bool clip = false)
		{
			return null;
		}

		// Token: 0x060017EC RID: 6124 RVA: 0x00002131 File Offset: 0x00000331
		private Bitmap method_0(Control ctrl, bool includeForeground, bool clip)
		{
			return null;
		}

		// Token: 0x060017ED RID: 6125 RVA: 0x00002131 File Offset: 0x00000331
		protected virtual Bitmap GetForeground(Control ctrl)
		{
			return null;
		}

		// Token: 0x060017EE RID: 6126 RVA: 0x00002134 File Offset: 0x00000334
		protected virtual void OnTransfromNeeded(object sender, TransfromNeededEventArg e)
		{
		}

		// Token: 0x060017EF RID: 6127 RVA: 0x00002131 File Offset: 0x00000331
		protected virtual Bitmap OnNonLinearTransfromNeeded()
		{
			return null;
		}

		// Token: 0x060017F0 RID: 6128 RVA: 0x00002134 File Offset: 0x00000334
		public void EndUpdate()
		{
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x060017F1 RID: 6129 RVA: 0x00002136 File Offset: 0x00000336
		public bool IsCompleted
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060017F2 RID: 6130 RVA: 0x00002134 File Offset: 0x00000334
		internal void method_1()
		{
		}

		// Token: 0x04000A47 RID: 2631
		protected Bitmap ctrlBmp;

		// Token: 0x04000A48 RID: 2632
		[CompilerGenerated]
		private float float_0;

		// Token: 0x04000A49 RID: 2633
		[CompilerGenerated]
		private float float_1;

		// Token: 0x04000A4F RID: 2639
		[CompilerGenerated]
		private Control control_0;

		// Token: 0x04000A50 RID: 2640
		[CompilerGenerated]
		private Control control_1;

		// Token: 0x04000A51 RID: 2641
		private Point[] point_0;

		// Token: 0x04000A52 RID: 2642
		private byte[] byte_0;

		// Token: 0x04000A53 RID: 2643
		protected Rectangle CustomClipRect;

		// Token: 0x04000A54 RID: 2644
		private AnimateMode animateMode_0;

		// Token: 0x04000A55 RID: 2645
		private Animation animation_0;
	}
}
