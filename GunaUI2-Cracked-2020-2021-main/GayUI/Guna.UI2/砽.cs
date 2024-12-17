using System;

// Token: 0x02000264 RID: 612
internal sealed class 砽 : MulticastDelegate
{
	// Token: 0x06001C43 RID: 7235
	public extern 砽(object object_0, IntPtr intptr_0);

	// Token: 0x06001C44 RID: 7236
	public extern IAsyncResult BeginInvoke(IntPtr intptr_0, AsyncCallback asyncCallback_0, object object_0);

	// Token: 0x06001C45 RID: 7237
	public extern void EndInvoke(IAsyncResult iasyncResult_0);

	// Token: 0x06001C46 RID: 7238
	public extern bool Invoke(string string_0, UriKind uriKind_0, ref Uri uri_0);

	// Token: 0x06001C47 RID: 7239 RVA: 0x00002F5B File Offset: 0x0000115B
	static 砽()
	{
		{FE3C441D-DF9D-407b-917D-0B4471A8296C}.dau(614);
	}

	// Token: 0x04000C26 RID: 3110
	internal static 砽 砽_0;
}
