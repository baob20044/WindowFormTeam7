using System;
using System.Security.AccessControl;

// Token: 0x0200029D RID: 669
internal sealed class 硶 : MulticastDelegate
{
	// Token: 0x06001D60 RID: 7520
	public extern 硶(object object_0, IntPtr intptr_0);

	// Token: 0x06001D61 RID: 7521
	public extern IAsyncResult BeginInvoke(IntPtr intptr_0, AsyncCallback asyncCallback_0, object object_0);

	// Token: 0x06001D62 RID: 7522
	public extern void EndInvoke(IAsyncResult iasyncResult_0);

	// Token: 0x06001D63 RID: 7523
	public extern void Invoke(string string_0, FileSecurity fileSecurity_0);

	// Token: 0x06001D64 RID: 7524 RVA: 0x00003207 File Offset: 0x00001407
	static 硶()
	{
		{FE3C441D-DF9D-407b-917D-0B4471A8296C}.dau(671);
	}

	// Token: 0x04000C69 RID: 3177
	internal static 硶 硶_0;
}
