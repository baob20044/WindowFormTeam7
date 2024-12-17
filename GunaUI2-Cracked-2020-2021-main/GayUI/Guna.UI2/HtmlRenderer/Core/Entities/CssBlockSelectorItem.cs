using System;
using Guna.UI2.HtmlRenderer.Core.Utils;

namespace Guna.UI2.HtmlRenderer.Core.Entities
{
	// Token: 0x02000131 RID: 305
	public struct CssBlockSelectorItem
	{
		// Token: 0x06001402 RID: 5122 RVA: 0x000024AA File Offset: 0x000006AA
		public CssBlockSelectorItem(string @class, bool directParent)
		{
			ArgChecker.AssertArgNotNullOrEmpty(@class, "Ë½\u00a0ÅÂ\u0096");
			this.string_0 = @class;
			this.bool_0 = directParent;
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06001403 RID: 5123 RVA: 0x00002131 File Offset: 0x00000331
		public string Class
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06001404 RID: 5124 RVA: 0x00002136 File Offset: 0x00000336
		public bool DirectParent
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x00002131 File Offset: 0x00000331
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000808 RID: 2056
		private readonly string string_0;

		// Token: 0x04000809 RID: 2057
		private readonly bool bool_0;
	}
}
