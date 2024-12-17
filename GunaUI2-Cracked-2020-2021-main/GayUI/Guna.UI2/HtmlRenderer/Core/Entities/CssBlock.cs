using System;
using System.Collections.Generic;

namespace Guna.UI2.HtmlRenderer.Core.Entities
{
	// Token: 0x02000130 RID: 304
	public sealed class CssBlock
	{
		// Token: 0x060013F6 RID: 5110 RVA: 0x00002167 File Offset: 0x00000367
		public CssBlock(string @class, Dictionary<string, string> properties, List<CssBlockSelectorItem> selectors = null, bool hover = false)
		{
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x060013F7 RID: 5111 RVA: 0x00002131 File Offset: 0x00000331
		public string Class
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x060013F8 RID: 5112 RVA: 0x00002131 File Offset: 0x00000331
		public List<CssBlockSelectorItem> Selectors
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x060013F9 RID: 5113 RVA: 0x00002131 File Offset: 0x00000331
		public IDictionary<string, string> Properties
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x060013FA RID: 5114 RVA: 0x00002136 File Offset: 0x00000336
		public bool Hover
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x00002134 File Offset: 0x00000334
		public void Merge(CssBlock other)
		{
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x00002131 File Offset: 0x00000331
		public CssBlock Clone()
		{
			return null;
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x00002136 File Offset: 0x00000336
		public bool Equals(CssBlock other)
		{
			return false;
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x00002136 File Offset: 0x00000336
		public bool EqualsSelector(CssBlock other)
		{
			return false;
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x00002136 File Offset: 0x00000336
		public override bool Equals(object obj)
		{
			return false;
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x00002136 File Offset: 0x00000336
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x00002131 File Offset: 0x00000331
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000804 RID: 2052
		private readonly string string_0;

		// Token: 0x04000805 RID: 2053
		private readonly Dictionary<string, string> dictionary_0;

		// Token: 0x04000806 RID: 2054
		private readonly List<CssBlockSelectorItem> list_0;

		// Token: 0x04000807 RID: 2055
		private readonly bool bool_0;
	}
}
