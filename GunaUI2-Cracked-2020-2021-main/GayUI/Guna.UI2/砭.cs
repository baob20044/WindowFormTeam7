using System;
using System.Threading;

// Token: 0x02000254 RID: 596
internal sealed class 砭 : MulticastDelegate
{
	// Token: 0x06001BF3 RID: 7155
	public extern 砭(object object_0, IntPtr intptr_0);

	// Token: 0x06001BF4 RID: 7156
	public extern IAsyncResult BeginInvoke(IntPtr intptr_0, AsyncCallback asyncCallback_0, object object_0);

	// Token: 0x06001BF5 RID: 7157
	public extern void EndInvoke(IAsyncResult iasyncResult_0);

	// Token: 0x06001BF6 RID: 7158
	public extern bool Invoke(WaitCallback waitCallback_0, object object_0);

	// Token: 0x06001BF7 RID: 7159 RVA: 0x00002E9B File Offset: 0x0000109B
	static 砭()
	{
		{FE3C441D-DF9D-407b-917D-0B4471A8296C}.dau(598);
	}

	// Token: 0x04000C13 RID: 3091
	internal static 砭 砭_0;
}
