using System;

namespace Guna.UI2.HtmlRenderer.Core.Entities
{
	// Token: 0x02000138 RID: 312
	public sealed class HtmlRenderErrorEventArgs : EventArgs
	{
		// Token: 0x06001420 RID: 5152 RVA: 0x00002337 File Offset: 0x00000537
		public HtmlRenderErrorEventArgs(HtmlRenderErrorType type, string message, Exception exception = null)
		{
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06001421 RID: 5153 RVA: 0x0000685C File Offset: 0x00004A5C
		public HtmlRenderErrorType Type
		{
			get
			{
				return HtmlRenderErrorType.General;
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06001422 RID: 5154 RVA: 0x00002131 File Offset: 0x00000331
		public string Message
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06001423 RID: 5155 RVA: 0x00002131 File Offset: 0x00000331
		public Exception Exception
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x00002131 File Offset: 0x00000331
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000816 RID: 2070
		private readonly HtmlRenderErrorType htmlRenderErrorType_0;

		// Token: 0x04000817 RID: 2071
		private readonly string string_0;

		// Token: 0x04000818 RID: 2072
		private readonly Exception exception_0;
	}
}
