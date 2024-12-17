using System;
using System.Windows.Forms;

// Token: 0x0200020F RID: 527
internal sealed class 矨 : MulticastDelegate
{
	// Token: 0x06001A9A RID: 6810
	public extern 矨(object object_0, IntPtr intptr_0);

	// Token: 0x06001A9B RID: 6811
	public extern IAsyncResult BeginInvoke(IntPtr intptr_0, AsyncCallback asyncCallback_0, object object_0);

	// Token: 0x06001A9C RID: 6812
	public extern void EndInvoke(IAsyncResult iasyncResult_0);

	// Token: 0x06001A9D RID: 6813
	public extern DrawItemState Invoke(object object_0);

	// Token: 0x06001A9E RID: 6814 RVA: 0x00002B5F File Offset: 0x00000D5F
	static 矨()
	{
		{FE3C441D-DF9D-407b-917D-0B4471A8296C}.dau(529);
	}

	// Token: 0x04000BB9 RID: 3001
	internal static 矨 矨_0;
}
