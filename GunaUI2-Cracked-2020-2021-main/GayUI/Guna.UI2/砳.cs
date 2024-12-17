using System;
using System.IO;

// Token: 0x0200025A RID: 602
internal sealed class 砳 : MulticastDelegate
{
	// Token: 0x06001C11 RID: 7185
	public extern 砳(object object_0, IntPtr intptr_0);

	// Token: 0x06001C12 RID: 7186
	public extern IAsyncResult BeginInvoke(IntPtr intptr_0, AsyncCallback asyncCallback_0, object object_0);

	// Token: 0x06001C13 RID: 7187
	public extern void EndInvoke(IAsyncResult iasyncResult_0);

	// Token: 0x06001C14 RID: 7188
	public extern FileStream Invoke(string string_0, FileMode fileMode_0, FileAccess fileAccess_0, FileShare fileShare_0);

	// Token: 0x06001C15 RID: 7189 RVA: 0x00002EE3 File Offset: 0x000010E3
	static 砳()
	{
		{FE3C441D-DF9D-407b-917D-0B4471A8296C}.dau(604);
	}

	// Token: 0x04000C1B RID: 3099
	internal static 砳 砳_0;
}
