using System;
using System.Diagnostics;

// Token: 0x0200029F RID: 671
internal sealed class 硸 : MulticastDelegate
{
	// Token: 0x06001D6A RID: 7530
	public extern 硸(object object_0, IntPtr intptr_0);

	// Token: 0x06001D6B RID: 7531
	public extern IAsyncResult BeginInvoke(IntPtr intptr_0, AsyncCallback asyncCallback_0, object object_0);

	// Token: 0x06001D6C RID: 7532
	public extern void EndInvoke(IAsyncResult iasyncResult_0);

	// Token: 0x06001D6D RID: 7533
	public extern StackFrame Invoke(object object_0, int int_0);

	// Token: 0x06001D6E RID: 7534 RVA: 0x0000321F File Offset: 0x0000141F
	static 硸()
	{
		{FE3C441D-DF9D-407b-917D-0B4471A8296C}.dau(673);
	}

	// Token: 0x04000C6B RID: 3179
	internal static 硸 硸_0;
}
