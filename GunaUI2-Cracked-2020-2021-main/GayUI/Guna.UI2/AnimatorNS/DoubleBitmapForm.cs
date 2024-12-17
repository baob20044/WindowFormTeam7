using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Guna.UI2.AnimatorNS
{
	// Token: 0x02000190 RID: 400
	public partial class DoubleBitmapForm : Form, IFakeControl
	{
		// Token: 0x1400006D RID: 109
		// (add) Token: 0x0600182E RID: 6190 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x0600182F RID: 6191 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x06001831 RID: 6193 RVA: 0x00002131 File Offset: 0x00000331
		protected override CreateParams CreateParams
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06001832 RID: 6194 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x06001833 RID: 6195 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0(TransfromNeededEventArg ea)
		{
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x00002134 File Offset: 0x00000334
		protected virtual void OnFramePainting(PaintEventArgs e)
		{
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x00002134 File Offset: 0x00000334
		protected virtual void OnFramePainted(PaintEventArgs e)
		{
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x00002134 File Offset: 0x00000334
		public void InitParent(Control control, Padding padding)
		{
		}

		// Token: 0x06001837 RID: 6199 RVA: 0x00002134 File Offset: 0x00000334
		private void method_1(object sender, EventArgs e)
		{
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06001838 RID: 6200 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06001839 RID: 6201 RVA: 0x00002134 File Offset: 0x00000334
		public Bitmap BgBmp
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x0600183A RID: 6202 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x0600183B RID: 6203 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1400006E RID: 110
		// (add) Token: 0x0600183C RID: 6204 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x0600183D RID: 6205 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1400006F RID: 111
		// (add) Token: 0x0600183E RID: 6206 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x0600183F RID: 6207 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06001841 RID: 6209 RVA: 0x00002134 File Offset: 0x00000334
		private void method_2()
		{
		}

		// Token: 0x04000A67 RID: 2663
		private Bitmap bitmap_0;

		// Token: 0x04000A68 RID: 2664
		private Bitmap bitmap_1;

		// Token: 0x04000A6A RID: 2666
		private Padding padding_0;

		// Token: 0x04000A6B RID: 2667
		private Control control_0;

		// Token: 0x04000A6C RID: 2668
		private Point point_0;

		// Token: 0x04000A6F RID: 2671
		private IContainer icontainer_0;
	}
}
