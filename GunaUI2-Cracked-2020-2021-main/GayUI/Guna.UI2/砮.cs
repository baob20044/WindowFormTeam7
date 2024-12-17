using System;

// Token: 0x02000255 RID: 597
internal sealed class 砮 : MulticastDelegate
{
	// Token: 0x06001BF8 RID: 7160
	public extern 砮(object object_0, IntPtr intptr_0);

	// Token: 0x06001BF9 RID: 7161
	public extern IAsyncResult BeginInvoke(IntPtr intptr_0, AsyncCallback asyncCallback_0, object object_0);

	// Token: 0x06001BFA RID: 7162
	public extern void EndInvoke(IAsyncResult iasyncResult_0);

	// Token: 0x06001BFB RID: 7163
	public extern void Invoke(object object_0, Uri uri_0, string string_0);

	// Token: 0x06001BFC RID: 7164 RVA: 0x00002EA7 File Offset: 0x000010A7
	static 砮()
	{
		{FE3C441D-DF9D-407b-917D-0B4471A8296C}.dau(599);
	}

	// Token: 0x04000C14 RID: 3092
	internal static 砮 砮_0;
}
