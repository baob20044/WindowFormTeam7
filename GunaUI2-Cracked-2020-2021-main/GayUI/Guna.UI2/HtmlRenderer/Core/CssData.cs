using System;
using System.Collections.Generic;
using Guna.UI2.HtmlRenderer.Adapters;
using Guna.UI2.HtmlRenderer.Core.Entities;

namespace Guna.UI2.HtmlRenderer.Core
{
	// Token: 0x0200010E RID: 270
	public sealed class CssData
	{
		// Token: 0x0600127D RID: 4733 RVA: 0x00002167 File Offset: 0x00000367
		internal CssData()
		{
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x00002131 File Offset: 0x00000331
		public static CssData Parse(RAdapter adapter, string stylesheet, bool combineWithDefault = true)
		{
			return null;
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x0600127F RID: 4735 RVA: 0x00002131 File Offset: 0x00000331
		internal IDictionary<string, Dictionary<string, List<CssBlock>>> IDictionary_0
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x00002136 File Offset: 0x00000336
		public bool ContainsCssBlock(string className, string media = "all")
		{
			return false;
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x00002131 File Offset: 0x00000331
		public IEnumerable<CssBlock> GetCssBlock(string className, string media = "all")
		{
			return null;
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x00002134 File Offset: 0x00000334
		public void AddCssBlock(string media, CssBlock cssBlock)
		{
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x00002134 File Offset: 0x00000334
		public void Combine(CssData other)
		{
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x00002131 File Offset: 0x00000331
		public CssData Clone()
		{
			return null;
		}

		// Token: 0x040006F5 RID: 1781
		private static readonly List<CssBlock> list_0 = new List<CssBlock>();

		// Token: 0x040006F6 RID: 1782
		private readonly Dictionary<string, Dictionary<string, List<CssBlock>>> dictionary_0;
	}
}
