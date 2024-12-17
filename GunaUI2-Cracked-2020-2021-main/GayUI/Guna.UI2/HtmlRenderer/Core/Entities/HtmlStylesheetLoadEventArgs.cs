using System;
using System.Collections.Generic;

namespace Guna.UI2.HtmlRenderer.Core.Entities
{
	// Token: 0x0200013B RID: 315
	public sealed class HtmlStylesheetLoadEventArgs : EventArgs
	{
		// Token: 0x06001429 RID: 5161 RVA: 0x00002337 File Offset: 0x00000537
		internal HtmlStylesheetLoadEventArgs(string src, Dictionary<string, string> attributes)
		{
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x0600142A RID: 5162 RVA: 0x00002131 File Offset: 0x00000331
		public string Src
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x0600142B RID: 5163 RVA: 0x00002131 File Offset: 0x00000331
		public Dictionary<string, string> Attributes
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x0600142C RID: 5164 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x0600142D RID: 5165 RVA: 0x00002134 File Offset: 0x00000334
		public string SetSrc
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x0600142E RID: 5166 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x0600142F RID: 5167 RVA: 0x00002134 File Offset: 0x00000334
		public string SetStyleSheet
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06001430 RID: 5168 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06001431 RID: 5169 RVA: 0x00002134 File Offset: 0x00000334
		public CssData SetStyleSheetData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x04000824 RID: 2084
		private readonly string string_0;

		// Token: 0x04000825 RID: 2085
		private readonly Dictionary<string, string> dictionary_0;

		// Token: 0x04000826 RID: 2086
		private string string_1;

		// Token: 0x04000827 RID: 2087
		private string string_2;

		// Token: 0x04000828 RID: 2088
		private CssData cssData_0;
	}
}
