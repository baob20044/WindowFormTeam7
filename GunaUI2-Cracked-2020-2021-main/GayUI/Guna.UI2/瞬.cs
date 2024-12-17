using System;
using System.Drawing;

// Token: 0x020001D3 RID: 467
internal sealed class 瞬 : MulticastDelegate
{
	// Token: 0x0600196E RID: 6510
	public extern 瞬(object object_0, IntPtr intptr_0);

	// Token: 0x0600196F RID: 6511
	public extern IAsyncResult BeginInvoke(IntPtr intptr_0, AsyncCallback asyncCallback_0, object object_0);

	// Token: 0x06001970 RID: 6512
	public extern void EndInvoke(IAsyncResult iasyncResult_0);

	// Token: 0x06001971 RID: 6513
	public extern PointF Invoke(Point point_0);

	// Token: 0x06001972 RID: 6514 RVA: 0x0000288F File Offset: 0x00000A8F
	static 瞬()
	{
		{FE3C441D-DF9D-407b-917D-0B4471A8296C}.dau(469);
	}

	// Token: 0x04000B59 RID: 2905
	internal static 瞬 瞬_0;
}
