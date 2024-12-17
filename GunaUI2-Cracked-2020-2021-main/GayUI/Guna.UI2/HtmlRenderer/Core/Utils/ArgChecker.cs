using System;

namespace Guna.UI2.HtmlRenderer.Core.Utils
{
	// Token: 0x02000112 RID: 274
	public static class ArgChecker
	{
		// Token: 0x060012D9 RID: 4825 RVA: 0x00002134 File Offset: 0x00000334
		public static void AssertIsTrue<TException>(bool condition, string message) where TException : Exception, new()
		{
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x00002134 File Offset: 0x00000334
		public static void AssertArgNotNull(object arg, string argName)
		{
		}

		// Token: 0x060012DB RID: 4827 RVA: 0x00002134 File Offset: 0x00000334
		public static void AssertArgNotNull(IntPtr arg, string argName)
		{
		}

		// Token: 0x060012DC RID: 4828 RVA: 0x00002134 File Offset: 0x00000334
		public static void AssertArgNotNullOrEmpty(string arg, string argName)
		{
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x00003D04 File Offset: 0x00001F04
		public static T AssertArgOfType<T>(object arg, string argName)
		{
			return default(T);
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x00002134 File Offset: 0x00000334
		public static void AssertFileExist(string arg, string argName)
		{
		}
	}
}
