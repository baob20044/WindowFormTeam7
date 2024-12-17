using System;
using System.Drawing;
using System.Windows.Forms;

namespace Guna.UI2.AnimatorNS
{
	// Token: 0x0200018F RID: 399
	public interface IFakeControl
	{
		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06001823 RID: 6179
		// (set) Token: 0x06001824 RID: 6180
		Bitmap BgBmp { get; set; }

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06001825 RID: 6181
		// (set) Token: 0x06001826 RID: 6182
		Bitmap Frame { get; set; }

		// Token: 0x1400006A RID: 106
		// (add) Token: 0x06001827 RID: 6183
		// (remove) Token: 0x06001828 RID: 6184
		event EventHandler<TransfromNeededEventArg> TransfromNeeded;

		// Token: 0x1400006B RID: 107
		// (add) Token: 0x06001829 RID: 6185
		// (remove) Token: 0x0600182A RID: 6186
		event EventHandler<PaintEventArgs> FramePainting;

		// Token: 0x1400006C RID: 108
		// (add) Token: 0x0600182B RID: 6187
		// (remove) Token: 0x0600182C RID: 6188
		event EventHandler<PaintEventArgs> FramePainted;

		// Token: 0x0600182D RID: 6189
		void InitParent(Control animatedControl, Padding padding);
	}
}
