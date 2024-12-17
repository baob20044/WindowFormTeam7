using System;
using System.Drawing;

// Token: 0x0200020E RID: 526
internal sealed class 矧 : MulticastDelegate
{
	// Token: 0x06001A95 RID: 6805
	public extern 矧(object object_0, IntPtr intptr_0);

	// Token: 0x06001A96 RID: 6806
	public extern IAsyncResult BeginInvoke(IntPtr intptr_0, AsyncCallback asyncCallback_0, object object_0);

	// Token: 0x06001A97 RID: 6807
	public extern void EndInvoke(IAsyncResult iasyncResult_0);

	// Token: 0x06001A98 RID: 6808
	public extern void Invoke(object object_0, string string_0, Font font_0, Brush brush_0, RectangleF rectangleF_0, StringFormat stringFormat_0);

	// Token: 0x06001A99 RID: 6809 RVA: 0x00002B53 File Offset: 0x00000D53
	static 矧()
	{
		{FE3C441D-DF9D-407b-917D-0B4471A8296C}.dau(528);
	}

	// Token: 0x04000BB8 RID: 3000
	internal static 矧 矧_0;
}
