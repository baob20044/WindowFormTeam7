using System;
using System.Collections.Generic;
using System.IO;
using Guna.UI2.HtmlRenderer.Adapters;
using Guna.UI2.HtmlRenderer.Adapters.Entities;
using Guna.UI2.HtmlRenderer.Core;
using ns6;

namespace ns8
{
	// Token: 0x0200012C RID: 300
	internal sealed class Class37 : IDisposable
	{
		// Token: 0x060013C6 RID: 5062 RVA: 0x00002167 File Offset: 0x00000367
		public Class37(HtmlContainerInt htmlContainer, Delegate6<RImage, RRect, bool> loadCompleteCallback)
		{
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x060013C7 RID: 5063 RVA: 0x00002131 File Offset: 0x00000331
		public RImage RImage_0
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x060013C8 RID: 5064 RVA: 0x00003C14 File Offset: 0x00001E14
		public RRect RRect_0
		{
			get
			{
				return default(RRect);
			}
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x00002134 File Offset: 0x00000334
		public void method_0(string src, Dictionary<string, string> attributes)
		{
		}

		// Token: 0x060013CA RID: 5066 RVA: 0x00002134 File Offset: 0x00000334
		public void Dispose()
		{
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x00002134 File Offset: 0x00000334
		private void method_1(string path, object image, RRect imageRectangle)
		{
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x00002134 File Offset: 0x00000334
		private void method_2(string src)
		{
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x00002131 File Offset: 0x00000331
		private RImage method_3(string src)
		{
			return null;
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x00002134 File Offset: 0x00000334
		private void method_4(string path)
		{
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x00002134 File Offset: 0x00000334
		private void method_5(FileInfo source)
		{
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x00002134 File Offset: 0x00000334
		private void method_6(string source)
		{
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x00002134 File Offset: 0x00000334
		private void method_7(Uri source)
		{
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x00002134 File Offset: 0x00000334
		private void method_8(Uri imageUri, string filePath, Exception error, bool canceled)
		{
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x00002134 File Offset: 0x00000334
		private void method_9(bool async = true)
		{
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x00002134 File Offset: 0x00000334
		private void method_10()
		{
		}

		// Token: 0x040007E9 RID: 2025
		private readonly HtmlContainerInt htmlContainerInt_0;

		// Token: 0x040007EA RID: 2026
		private readonly Delegate6<RImage, RRect, bool> delegate6_0;

		// Token: 0x040007EB RID: 2027
		private FileStream fileStream_0;

		// Token: 0x040007EC RID: 2028
		private RImage rimage_0;

		// Token: 0x040007ED RID: 2029
		private RRect rrect_0;

		// Token: 0x040007EE RID: 2030
		private bool bool_0;

		// Token: 0x040007EF RID: 2031
		private bool bool_1;

		// Token: 0x040007F0 RID: 2032
		private bool bool_2;
	}
}
