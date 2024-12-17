using System;
using System.Collections.Generic;
using Guna.UI2.HtmlRenderer.Adapters;
using Guna.UI2.HtmlRenderer.Adapters.Entities;

namespace ns8
{
	// Token: 0x02000128 RID: 296
	internal sealed class Class34
	{
		// Token: 0x060013B2 RID: 5042 RVA: 0x00002167 File Offset: 0x00000367
		public Class34(RAdapter adapter)
		{
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x00002136 File Offset: 0x00000336
		public bool method_0(string family)
		{
			return false;
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x00002134 File Offset: 0x00000334
		public void method_1(RFontFamily fontFamily)
		{
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x00002134 File Offset: 0x00000334
		public void method_2(string fromFamily, string toFamily)
		{
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x00002131 File Offset: 0x00000331
		public RFont method_3(string family, double size, RFontStyle style)
		{
			return null;
		}

		// Token: 0x060013B7 RID: 5047 RVA: 0x00002131 File Offset: 0x00000331
		private RFont method_4(string family, double size, RFontStyle style)
		{
			return null;
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x00002131 File Offset: 0x00000331
		private RFont method_5(string family, double size, RFontStyle style)
		{
			return null;
		}

		// Token: 0x040007E0 RID: 2016
		private readonly RAdapter radapter_0;

		// Token: 0x040007E1 RID: 2017
		private readonly Dictionary<string, string> dictionary_0;

		// Token: 0x040007E2 RID: 2018
		private readonly Dictionary<string, RFontFamily> dictionary_1;

		// Token: 0x040007E3 RID: 2019
		private readonly Dictionary<string, Dictionary<double, Dictionary<RFontStyle, RFont>>> dictionary_2;
	}
}
