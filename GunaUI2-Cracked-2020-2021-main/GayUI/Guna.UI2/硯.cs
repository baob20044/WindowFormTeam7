using System;
using System.Drawing;

// Token: 0x02000296 RID: 662
internal sealed class 硯 : MulticastDelegate
{
	// Token: 0x06001D3D RID: 7485
	public extern 硯(object object_0, IntPtr intptr_0);

	// Token: 0x06001D3E RID: 7486
	public extern IAsyncResult BeginInvoke(IntPtr intptr_0, AsyncCallback asyncCallback_0, object object_0);

	// Token: 0x06001D3F RID: 7487
	public extern void EndInvoke(IAsyncResult iasyncResult_0);

	// Token: 0x06001D40 RID: 7488
	public extern Rectangle Invoke(int int_0, int int_1, int int_2, int int_3);

	// Token: 0x06001D41 RID: 7489 RVA: 0x000031B3 File Offset: 0x000013B3
	static 硯()
	{
		{FE3C441D-DF9D-407b-917D-0B4471A8296C}.dau(664);
	}

	// Token: 0x04000C61 RID: 3169
	internal static 硯 硯_0;
}
