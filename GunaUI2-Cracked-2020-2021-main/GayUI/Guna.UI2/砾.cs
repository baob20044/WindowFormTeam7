using System;
using System.Threading;

// Token: 0x02000265 RID: 613
internal sealed class 砾 : MulticastDelegate
{
	// Token: 0x06001C48 RID: 7240
	public extern 砾(object object_0, IntPtr intptr_0);

	// Token: 0x06001C49 RID: 7241
	public extern IAsyncResult BeginInvoke(IntPtr intptr_0, AsyncCallback asyncCallback_0, object object_0);

	// Token: 0x06001C4A RID: 7242
	public extern void EndInvoke(IAsyncResult iasyncResult_0);

	// Token: 0x06001C4B RID: 7243
	public extern bool Invoke(WaitCallback waitCallback_0);

	// Token: 0x06001C4C RID: 7244 RVA: 0x00002F67 File Offset: 0x00001167
	static 砾()
	{
		{FE3C441D-DF9D-407b-917D-0B4471A8296C}.dau(615);
	}

	// Token: 0x04000C27 RID: 3111
	internal static 砾 砾_0;
}
