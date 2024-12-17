using System;
using System.Collections.Generic;

namespace Guna.UI2.HtmlRenderer.Core.Entities
{
	// Token: 0x02000134 RID: 308
	public sealed class HtmlImageLoadEventArgs : EventArgs
	{
		// Token: 0x0600140A RID: 5130 RVA: 0x00002337 File Offset: 0x00000537
		internal HtmlImageLoadEventArgs(string src, Dictionary<string, string> attributes, HtmlImageLoadCallback callback)
		{
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x0600140B RID: 5131 RVA: 0x00002131 File Offset: 0x00000331
		public string Src
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x0600140C RID: 5132 RVA: 0x00002131 File Offset: 0x00000331
		public Dictionary<string, string> Attributes
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x0600140D RID: 5133 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600140E RID: 5134 RVA: 0x00002134 File Offset: 0x00000334
		public bool Handled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x0600140F RID: 5135 RVA: 0x00002134 File Offset: 0x00000334
		public void Callback()
		{
		}

		// Token: 0x06001410 RID: 5136 RVA: 0x00002134 File Offset: 0x00000334
		public void Callback(string path)
		{
		}

		// Token: 0x06001411 RID: 5137 RVA: 0x00002134 File Offset: 0x00000334
		public void Callback(string path, double x, double y, double width, double height)
		{
		}

		// Token: 0x06001412 RID: 5138 RVA: 0x00002134 File Offset: 0x00000334
		public void Callback(object image)
		{
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x00002134 File Offset: 0x00000334
		public void Callback(object image, double x, double y, double width, double height)
		{
		}

		// Token: 0x0400080E RID: 2062
		private bool bool_0;

		// Token: 0x0400080F RID: 2063
		private readonly string string_0;

		// Token: 0x04000810 RID: 2064
		private readonly Dictionary<string, string> dictionary_0;

		// Token: 0x04000811 RID: 2065
		private readonly HtmlImageLoadCallback htmlImageLoadCallback_0;
	}
}
