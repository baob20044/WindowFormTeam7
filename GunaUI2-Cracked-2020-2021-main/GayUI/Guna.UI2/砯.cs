using System;
using System.ComponentModel;

// Token: 0x02000256 RID: 598
internal sealed class 砯 : MulticastDelegate
{
	// Token: 0x06001BFD RID: 7165
	public extern 砯(object object_0, IntPtr intptr_0);

	// Token: 0x06001BFE RID: 7166
	public extern IAsyncResult BeginInvoke(IntPtr intptr_0, AsyncCallback asyncCallback_0, object object_0);

	// Token: 0x06001BFF RID: 7167
	public extern void EndInvoke(IAsyncResult iasyncResult_0);

	// Token: 0x06001C00 RID: 7168
	public extern void Invoke(object object_0, AsyncCompletedEventHandler asyncCompletedEventHandler_0);

	// Token: 0x06001C01 RID: 7169 RVA: 0x00002EB3 File Offset: 0x000010B3
	static 砯()
	{
		{FE3C441D-DF9D-407b-917D-0B4471A8296C}.dau(600);
	}

	// Token: 0x04000C15 RID: 3093
	internal static 砯 砯_0;

	// Token: 0x04000C16 RID: 3094
	internal static 砯 砯_1;
}
