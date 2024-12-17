using System;
using System.Collections.Generic;

namespace Guna.UI2.HtmlRenderer.Core.Entities
{
	// Token: 0x02000135 RID: 309
	public sealed class HtmlLinkClickedEventArgs : EventArgs
	{
		// Token: 0x06001414 RID: 5140 RVA: 0x00002337 File Offset: 0x00000537
		public HtmlLinkClickedEventArgs(string link, Dictionary<string, string> attributes)
		{
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06001415 RID: 5141 RVA: 0x00002131 File Offset: 0x00000331
		public string Link
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06001416 RID: 5142 RVA: 0x00002131 File Offset: 0x00000331
		public Dictionary<string, string> Attributes
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06001417 RID: 5143 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06001418 RID: 5144 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06001419 RID: 5145 RVA: 0x00002131 File Offset: 0x00000331
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000812 RID: 2066
		private readonly string string_0;

		// Token: 0x04000813 RID: 2067
		private readonly Dictionary<string, string> dictionary_0;

		// Token: 0x04000814 RID: 2068
		private bool bool_0;
	}
}
