using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ns7
{
	// Token: 0x02000124 RID: 292
	internal static class Class30
	{
		// Token: 0x06001390 RID: 5008 RVA: 0x00002131 File Offset: 0x00000331
		public static string smethod_0(string stylesheet, ref int startIdx)
		{
			return null;
		}

		// Token: 0x06001391 RID: 5009 RVA: 0x00002131 File Offset: 0x00000331
		public static MatchCollection smethod_1(string regex, string source)
		{
			return null;
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x00002131 File Offset: 0x00000331
		public static string smethod_2(string regex, string source)
		{
			return null;
		}

		// Token: 0x06001393 RID: 5011 RVA: 0x00002131 File Offset: 0x00000331
		public static string smethod_3(string regex, string source, out int position)
		{
			return null;
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x00002131 File Offset: 0x00000331
		private static Regex smethod_4(string regex)
		{
			return null;
		}

		// Token: 0x040007C3 RID: 1987
		public const string string_0 = "@media[^\\{\\}]*\\{";

		// Token: 0x040007C4 RID: 1988
		public const string string_1 = "[^\\{\\}]*\\{[^\\{\\}]*\\}";

		// Token: 0x040007C5 RID: 1989
		public const string string_2 = "{[0-9]+|[0-9]*\\.[0-9]+}";

		// Token: 0x040007C6 RID: 1990
		public const string string_3 = "([0-9]+|[0-9]*\\.[0-9]+)\\%";

		// Token: 0x040007C7 RID: 1991
		public const string string_4 = "([0-9]+|[0-9]*\\.[0-9]+)(em|ex|px|in|cm|mm|pt|pc)";

		// Token: 0x040007C8 RID: 1992
		public const string string_5 = "(normal|{[0-9]+|[0-9]*\\.[0-9]+}|([0-9]+|[0-9]*\\.[0-9]+)(em|ex|px|in|cm|mm|pt|pc)|([0-9]+|[0-9]*\\.[0-9]+)\\%)";

		// Token: 0x040007C9 RID: 1993
		public const string string_6 = "(\"[^\"]*\"|'[^']*'|\\S+\\s*)(\\s*\\,\\s*(\"[^\"]*\"|'[^']*'|\\S+))*";

		// Token: 0x040007CA RID: 1994
		public const string string_7 = "(normal|italic|oblique)";

		// Token: 0x040007CB RID: 1995
		public const string string_8 = "(normal|small-caps)";

		// Token: 0x040007CC RID: 1996
		public const string string_9 = "(normal|bold|bolder|lighter|100|200|300|400|500|600|700|800|900)";

		// Token: 0x040007CD RID: 1997
		public const string string_10 = "(([0-9]+|[0-9]*\\.[0-9]+)(em|ex|px|in|cm|mm|pt|pc)|([0-9]+|[0-9]*\\.[0-9]+)\\%|xx-small|x-small|small|medium|large|x-large|xx-large|larger|smaller)";

		// Token: 0x040007CE RID: 1998
		public const string string_11 = "(([0-9]+|[0-9]*\\.[0-9]+)(em|ex|px|in|cm|mm|pt|pc)|([0-9]+|[0-9]*\\.[0-9]+)\\%|xx-small|x-small|small|medium|large|x-large|xx-large|larger|smaller)(\\/(normal|{[0-9]+|[0-9]*\\.[0-9]+}|([0-9]+|[0-9]*\\.[0-9]+)(em|ex|px|in|cm|mm|pt|pc)|([0-9]+|[0-9]*\\.[0-9]+)\\%))?(\\s|$)";

		// Token: 0x040007CF RID: 1999
		private static readonly Dictionary<string, Regex> dictionary_0 = new Dictionary<string, Regex>();
	}
}
