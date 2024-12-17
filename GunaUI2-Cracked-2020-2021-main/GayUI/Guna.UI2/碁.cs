using System;
using System.IO;

// Token: 0x020002A8 RID: 680
internal sealed class 碁 : MulticastDelegate
{
	// Token: 0x06001D97 RID: 7575
	public extern 碁(object object_0, IntPtr intptr_0);

	// Token: 0x06001D98 RID: 7576
	public extern IAsyncResult BeginInvoke(IntPtr intptr_0, AsyncCallback asyncCallback_0, object object_0);

	// Token: 0x06001D99 RID: 7577
	public extern void EndInvoke(IAsyncResult iasyncResult_0);

	// Token: 0x06001D9A RID: 7578
	public extern Stream Invoke(object object_0, string string_0);

	// Token: 0x06001D9B RID: 7579 RVA: 0x0000328B File Offset: 0x0000148B
	static 碁()
	{
		{FE3C441D-DF9D-407b-917D-0B4471A8296C}.dau(682);
	}

	// Token: 0x04000C74 RID: 3188
	internal static 碁 碁_0;
}
