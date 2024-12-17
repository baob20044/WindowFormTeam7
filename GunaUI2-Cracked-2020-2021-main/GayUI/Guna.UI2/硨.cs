using System;
using System.Drawing;
using System.Drawing.Imaging;

// Token: 0x0200028F RID: 655
internal sealed class 硨 : MulticastDelegate
{
	// Token: 0x06001D1A RID: 7450
	public extern 硨(object object_0, IntPtr intptr_0);

	// Token: 0x06001D1B RID: 7451
	public extern IAsyncResult BeginInvoke(IntPtr intptr_0, AsyncCallback asyncCallback_0, object object_0);

	// Token: 0x06001D1C RID: 7452
	public extern void EndInvoke(IAsyncResult iasyncResult_0);

	// Token: 0x06001D1D RID: 7453
	public extern BitmapData Invoke(object object_0, Rectangle rectangle_0, ImageLockMode imageLockMode_0, PixelFormat pixelFormat_0);

	// Token: 0x06001D1E RID: 7454 RVA: 0x0000315F File Offset: 0x0000135F
	static 硨()
	{
		{FE3C441D-DF9D-407b-917D-0B4471A8296C}.dau(657);
	}

	// Token: 0x04000C58 RID: 3160
	internal static 硨 硨_0;
}
