using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using Guna.UI2.HtmlRenderer.Core.Handlers;

namespace ns8
{
	// Token: 0x0200012A RID: 298
	internal sealed class Class35 : IDisposable
	{
		// Token: 0x060013BD RID: 5053 RVA: 0x00002134 File Offset: 0x00000334
		public void method_0(Uri imageUri, string filePath, bool async, DownloadFileAsyncCallback cachedFileCallback)
		{
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x00002134 File Offset: 0x00000334
		public void Dispose()
		{
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x00002134 File Offset: 0x00000334
		private void method_1(Uri source, string tempPath, string filePath)
		{
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x00002134 File Offset: 0x00000334
		private void method_2(object data)
		{
		}

		// Token: 0x060013C1 RID: 5057 RVA: 0x00002134 File Offset: 0x00000334
		private void method_3(object sender, AsyncCompletedEventArgs e)
		{
		}

		// Token: 0x060013C2 RID: 5058 RVA: 0x00002134 File Offset: 0x00000334
		private void method_4(WebClient client, Uri source, string tempPath, string filePath, Exception error, bool cancelled)
		{
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x00002134 File Offset: 0x00000334
		private void method_5()
		{
		}

		// Token: 0x040007E4 RID: 2020
		private readonly List<WebClient> list_0;

		// Token: 0x040007E5 RID: 2021
		private readonly Dictionary<string, List<DownloadFileAsyncCallback>> dictionary_0;

		// Token: 0x0200012B RID: 299
		private sealed class Class36
		{
			// Token: 0x060013C5 RID: 5061 RVA: 0x00002167 File Offset: 0x00000367
			public Class36(Uri uri, string tempPath, string filePath)
			{
			}

			// Token: 0x040007E6 RID: 2022
			public readonly Uri uri_0;

			// Token: 0x040007E7 RID: 2023
			public readonly string string_0;

			// Token: 0x040007E8 RID: 2024
			public readonly string string_1;
		}
	}
}
