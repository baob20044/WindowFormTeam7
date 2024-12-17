using System;
using System.Text;

// Token: 0x0200024D RID: 589
internal sealed class 砦 : MulticastDelegate
{
	// Token: 0x06001BD0 RID: 7120
	public extern 砦(object object_0, IntPtr intptr_0);

	// Token: 0x06001BD1 RID: 7121
	public extern IAsyncResult BeginInvoke(IntPtr intptr_0, AsyncCallback asyncCallback_0, object object_0);

	// Token: 0x06001BD2 RID: 7122
	public extern void EndInvoke(IAsyncResult iasyncResult_0);

	// Token: 0x06001BD3 RID: 7123
	public extern StringBuilder Invoke(object object_0, string string_0, object object_1, object object_2);

	// Token: 0x06001BD4 RID: 7124 RVA: 0x00002E47 File Offset: 0x00001047
	static 砦()
	{
		{FE3C441D-DF9D-407b-917D-0B4471A8296C}.dau(591);
	}

	// Token: 0x04000C09 RID: 3081
	internal static 砦 砦_0;
}
