using System;
using System.Drawing;

// Token: 0x020001F5 RID: 501
internal sealed class 矎 : MulticastDelegate
{
	// Token: 0x06001A18 RID: 6680
	public extern 矎(object object_0, IntPtr intptr_0);

	// Token: 0x06001A19 RID: 6681
	public extern IAsyncResult BeginInvoke(IntPtr intptr_0, AsyncCallback asyncCallback_0, object object_0);

	// Token: 0x06001A1A RID: 6682
	public extern void EndInvoke(IAsyncResult iasyncResult_0);

	// Token: 0x06001A1B RID: 6683
	public extern SizeF Invoke(object object_0, string string_0, Font font_0);

	// Token: 0x06001A1C RID: 6684 RVA: 0x00002A27 File Offset: 0x00000C27
	static 矎()
	{
		{FE3C441D-DF9D-407b-917D-0B4471A8296C}.dau(503);
	}

	// Token: 0x04000B8F RID: 2959
	internal static 矎 矎_0;
}
