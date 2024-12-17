using System;

// Token: 0x02000247 RID: 583
internal sealed class 砠 : MulticastDelegate
{
	// Token: 0x06001BB2 RID: 7090
	public extern 砠(object object_0, IntPtr intptr_0);

	// Token: 0x06001BB3 RID: 7091
	public extern IAsyncResult BeginInvoke(IntPtr intptr_0, AsyncCallback asyncCallback_0, object object_0);

	// Token: 0x06001BB4 RID: 7092
	public extern void EndInvoke(IAsyncResult iasyncResult_0);

	// Token: 0x06001BB5 RID: 7093
	public extern string Invoke(object object_0, int int_0, int int_1);

	// Token: 0x06001BB6 RID: 7094 RVA: 0x00002DFF File Offset: 0x00000FFF
	static 砠()
	{
		{FE3C441D-DF9D-407b-917D-0B4471A8296C}.dau(585);
	}

	// Token: 0x04000C02 RID: 3074
	internal static 砠 砠_0;
}
