using System;

// Token: 0x0200026F RID: 623
internal sealed class 硈 : MulticastDelegate
{
	// Token: 0x06001C7A RID: 7290
	public extern 硈(object object_0, IntPtr intptr_0);

	// Token: 0x06001C7B RID: 7291
	public extern IAsyncResult BeginInvoke(IntPtr intptr_0, AsyncCallback asyncCallback_0, object object_0);

	// Token: 0x06001C7C RID: 7292
	public extern void EndInvoke(IAsyncResult iasyncResult_0);

	// Token: 0x06001C7D RID: 7293
	public extern string Invoke(object object_0, byte[] byte_0, int int_0, int int_1);

	// Token: 0x06001C7E RID: 7294 RVA: 0x00002FDF File Offset: 0x000011DF
	static 硈()
	{
		{FE3C441D-DF9D-407b-917D-0B4471A8296C}.dau(625);
	}

	// Token: 0x04000C31 RID: 3121
	internal static 硈 硈_0;
}
