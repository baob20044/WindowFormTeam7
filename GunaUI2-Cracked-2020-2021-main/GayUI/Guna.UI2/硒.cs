using System;
using System.ComponentModel;

// Token: 0x02000279 RID: 633
internal sealed class 硒 : MulticastDelegate
{
	// Token: 0x06001CAC RID: 7340
	public extern 硒(object object_0, IntPtr intptr_0);

	// Token: 0x06001CAD RID: 7341
	public extern IAsyncResult BeginInvoke(IntPtr intptr_0, AsyncCallback asyncCallback_0, object object_0);

	// Token: 0x06001CAE RID: 7342
	public extern void EndInvoke(IAsyncResult iasyncResult_0);

	// Token: 0x06001CAF RID: 7343
	public extern LicenseUsageMode Invoke();

	// Token: 0x06001CB0 RID: 7344 RVA: 0x00003057 File Offset: 0x00001257
	static 硒()
	{
		{FE3C441D-DF9D-407b-917D-0B4471A8296C}.dau(635);
	}

	// Token: 0x04000C3C RID: 3132
	internal static 硒 硒_0;
}
