using System;
using System.Security.AccessControl;

// Token: 0x0200029B RID: 667
internal sealed class 硴 : MulticastDelegate
{
	// Token: 0x06001D56 RID: 7510
	public extern 硴(object object_0, IntPtr intptr_0);

	// Token: 0x06001D57 RID: 7511
	public extern IAsyncResult BeginInvoke(IntPtr intptr_0, AsyncCallback asyncCallback_0, object object_0);

	// Token: 0x06001D58 RID: 7512
	public extern void EndInvoke(IAsyncResult iasyncResult_0);

	// Token: 0x06001D59 RID: 7513
	public extern FileSecurity Invoke(string string_0);

	// Token: 0x06001D5A RID: 7514 RVA: 0x000031EF File Offset: 0x000013EF
	static 硴()
	{
		{FE3C441D-DF9D-407b-917D-0B4471A8296C}.dau(669);
	}

	// Token: 0x04000C67 RID: 3175
	internal static 硴 硴_0;
}
