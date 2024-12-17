using System;

// Token: 0x02000259 RID: 601
internal sealed class 砲 : MulticastDelegate
{
	// Token: 0x06001C0C RID: 7180
	public extern 砲(object object_0, IntPtr intptr_0);

	// Token: 0x06001C0D RID: 7181
	public extern IAsyncResult BeginInvoke(IntPtr intptr_0, AsyncCallback asyncCallback_0, object object_0);

	// Token: 0x06001C0E RID: 7182
	public extern void EndInvoke(IAsyncResult iasyncResult_0);

	// Token: 0x06001C0F RID: 7183
	public extern void Invoke(string string_0, string string_1);

	// Token: 0x06001C10 RID: 7184 RVA: 0x00002ED7 File Offset: 0x000010D7
	static 砲()
	{
		{FE3C441D-DF9D-407b-917D-0B4471A8296C}.dau(603);
	}

	// Token: 0x04000C19 RID: 3097
	internal static 砲 砲_0;

	// Token: 0x04000C1A RID: 3098
	internal static 砲 砲_1;
}
