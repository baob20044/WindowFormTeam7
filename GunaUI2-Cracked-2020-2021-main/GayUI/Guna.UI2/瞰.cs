using System;
using System.Drawing;

// Token: 0x020001D7 RID: 471
internal sealed class 瞰 : MulticastDelegate
{
	// Token: 0x06001982 RID: 6530
	public extern 瞰(object object_0, IntPtr intptr_0);

	// Token: 0x06001983 RID: 6531
	public extern IAsyncResult BeginInvoke(IntPtr intptr_0, AsyncCallback asyncCallback_0, object object_0);

	// Token: 0x06001984 RID: 6532
	public extern void EndInvoke(IAsyncResult iasyncResult_0);

	// Token: 0x06001985 RID: 6533
	public extern bool Invoke(Color color_0, Color color_1);

	// Token: 0x06001986 RID: 6534 RVA: 0x000028BF File Offset: 0x00000ABF
	static 瞰()
	{
		{FE3C441D-DF9D-407b-917D-0B4471A8296C}.dau(473);
	}

	// Token: 0x04000B5D RID: 2909
	internal static 瞰 瞰_0;

	// Token: 0x04000B5E RID: 2910
	internal static 瞰 瞰_1;
}
