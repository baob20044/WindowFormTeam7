using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Guna.UI2.AnimatorNS
{
	// Token: 0x0200018E RID: 398
	[ToolboxItem(false)]
	public class DoubleBitmapControl : Control, IFakeControl
	{
		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06001811 RID: 6161 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06001812 RID: 6162 RVA: 0x00002134 File Offset: 0x00000334
		Bitmap IFakeControl.BgBmp
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06001813 RID: 6163 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06001814 RID: 6164 RVA: 0x00002134 File Offset: 0x00000334
		Bitmap IFakeControl.Frame
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x14000067 RID: 103
		// (add) Token: 0x06001815 RID: 6165 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06001816 RID: 6166 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x14000068 RID: 104
		// (add) Token: 0x06001817 RID: 6167 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06001818 RID: 6168 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x14000069 RID: 105
		// (add) Token: 0x06001819 RID: 6169 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x0600181A RID: 6170 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x0600181C RID: 6172 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0(TransfromNeededEventArg ea)
		{
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x00002134 File Offset: 0x00000334
		protected virtual void OnFramePainting(PaintEventArgs e)
		{
		}

		// Token: 0x0600181F RID: 6175 RVA: 0x00002134 File Offset: 0x00000334
		protected virtual void OnFramePainted(PaintEventArgs e)
		{
		}

		// Token: 0x06001820 RID: 6176 RVA: 0x00002134 File Offset: 0x00000334
		public void InitParent(Control control, Padding padding)
		{
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x00002134 File Offset: 0x00000334
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x00002134 File Offset: 0x00000334
		private void method_1()
		{
		}

		// Token: 0x04000A61 RID: 2657
		private Bitmap bitmap_0;

		// Token: 0x04000A62 RID: 2658
		private Bitmap bitmap_1;

		// Token: 0x04000A66 RID: 2662
		private IContainer icontainer_0;
	}
}
