using System;

namespace Guna.UI2.HtmlRenderer.Core.Entities
{
	// Token: 0x0200013C RID: 316
	public sealed class LinkElementData<T>
	{
		// Token: 0x06001432 RID: 5170 RVA: 0x00002167 File Offset: 0x00000367
		public LinkElementData(string id, string href, T rectangle)
		{
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06001433 RID: 5171 RVA: 0x00002131 File Offset: 0x00000331
		public string Id
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06001434 RID: 5172 RVA: 0x00002131 File Offset: 0x00000331
		public string Href
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06001435 RID: 5173 RVA: 0x00006874 File Offset: 0x00004A74
		public T Rectangle
		{
			get
			{
				return default(T);
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06001436 RID: 5174 RVA: 0x00002136 File Offset: 0x00000336
		public bool IsAnchor
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06001437 RID: 5175 RVA: 0x00002131 File Offset: 0x00000331
		public string AnchorId
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x00002131 File Offset: 0x00000331
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000829 RID: 2089
		private readonly string string_0;

		// Token: 0x0400082A RID: 2090
		private readonly string string_1;

		// Token: 0x0400082B RID: 2091
		private readonly T gparam_0;
	}
}
