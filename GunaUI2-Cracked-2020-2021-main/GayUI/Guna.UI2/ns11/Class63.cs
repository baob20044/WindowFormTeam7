using System;
using System.Security.Cryptography;
using System.Windows.Forms;
using Guna.UI2.Licensing;
using Microsoft.VisualBasic.Devices;
using ns12;

namespace ns11
{
	// Token: 0x0200015B RID: 347
	internal class Class63 : Interface0
	{
		// Token: 0x0600164F RID: 5711 RVA: 0x000068A4 File Offset: 0x00004AA4
		private Class63.Enum4 method_0(string a, int b)
		{
			return Class63.Enum4.const_0;
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x000068A4 File Offset: 0x00004AA4
		private CryptoStreamMode method_1(string a, int b)
		{
			return (CryptoStreamMode)Class63.Enum4.const_0;
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x00002131 File Offset: 0x00000331
		private object method_2(Class63.Enum4 req, object obj)
		{
			return null;
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06001652 RID: 5714 RVA: 0x00002131 File Offset: 0x00000331
		public Summary Summary_0
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x00002134 File Offset: 0x00000334
		public void imethod_0()
		{
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x00002134 File Offset: 0x00000334
		public void imethod_1(string email)
		{
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x00002134 File Offset: 0x00000334
		public void imethod_2(string email, string code)
		{
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x00002134 File Offset: 0x00000334
		public void imethod_3(string email, string code)
		{
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x00002134 File Offset: 0x00000334
		internal void method_3()
		{
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x00002134 File Offset: 0x00000334
		private void method_4()
		{
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x00002134 File Offset: 0x00000334
		private void method_5(string data, Class63.Enum5 action)
		{
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x00002134 File Offset: 0x00000334
		private void method_6()
		{
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x00002134 File Offset: 0x00000334
		private void method_7(object sender, EventArgs e)
		{
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x00002134 File Offset: 0x00000334
		private void method_8(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x00002134 File Offset: 0x00000334
		private void method_9(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x00002134 File Offset: 0x00000334
		private void method_10(string message, Class63.Enum5 action)
		{
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x00002136 File Offset: 0x00000336
		private int method_11(Class63.Enum6 a)
		{
			return 0;
		}

		// Token: 0x040008F2 RID: 2290
		private Summary summary_0;

		// Token: 0x040008F3 RID: 2291
		public string string_0;

		// Token: 0x040008F4 RID: 2292
		internal static Network network_0 = new Network();

		// Token: 0x040008F5 RID: 2293
		private string string_1;

		// Token: 0x040008F6 RID: 2294
		private Class63.Enum5 enum5_0;

		// Token: 0x040008F7 RID: 2295
		private Timer timer_0;

		// Token: 0x040008F8 RID: 2296
		private WebBrowser webBrowser_0;

		// Token: 0x040008F9 RID: 2297
		private WebBrowser webBrowser_1;

		// Token: 0x040008FA RID: 2298
		private Class63.Enum6 enum6_0;

		// Token: 0x0200015C RID: 348
		private struct Struct3
		{
			// Token: 0x040008FB RID: 2299
			public string string_0;

			// Token: 0x040008FC RID: 2300
			public DateTime dateTime_0;

			// Token: 0x040008FD RID: 2301
			public string string_1;

			// Token: 0x040008FE RID: 2302
			public string string_2;

			// Token: 0x040008FF RID: 2303
			public string string_3;

			// Token: 0x04000900 RID: 2304
			public string string_4;

			// Token: 0x04000901 RID: 2305
			public double double_0;

			// Token: 0x04000902 RID: 2306
			public string string_5;
		}

		// Token: 0x0200015D RID: 349
		private enum Enum4
		{
			// Token: 0x04000904 RID: 2308
			const_0,
			// Token: 0x04000905 RID: 2309
			const_1,
			// Token: 0x04000906 RID: 2310
			const_2,
			// Token: 0x04000907 RID: 2311
			const_3,
			// Token: 0x04000908 RID: 2312
			const_4,
			// Token: 0x04000909 RID: 2313
			const_5,
			// Token: 0x0400090A RID: 2314
			const_6,
			// Token: 0x0400090B RID: 2315
			const_7,
			// Token: 0x0400090C RID: 2316
			const_8,
			// Token: 0x0400090D RID: 2317
			const_9,
			// Token: 0x0400090E RID: 2318
			const_10,
			// Token: 0x0400090F RID: 2319
			const_11,
			// Token: 0x04000910 RID: 2320
			const_12,
			// Token: 0x04000911 RID: 2321
			const_13,
			// Token: 0x04000912 RID: 2322
			const_14,
			// Token: 0x04000913 RID: 2323
			const_15,
			// Token: 0x04000914 RID: 2324
			const_16,
			// Token: 0x04000915 RID: 2325
			const_17,
			// Token: 0x04000916 RID: 2326
			const_18,
			// Token: 0x04000917 RID: 2327
			const_19,
			// Token: 0x04000918 RID: 2328
			const_20,
			// Token: 0x04000919 RID: 2329
			const_21,
			// Token: 0x0400091A RID: 2330
			const_22,
			// Token: 0x0400091B RID: 2331
			const_23,
			// Token: 0x0400091C RID: 2332
			const_24,
			// Token: 0x0400091D RID: 2333
			const_25,
			// Token: 0x0400091E RID: 2334
			const_26,
			// Token: 0x0400091F RID: 2335
			const_27,
			// Token: 0x04000920 RID: 2336
			const_28,
			// Token: 0x04000921 RID: 2337
			const_29,
			// Token: 0x04000922 RID: 2338
			const_30,
			// Token: 0x04000923 RID: 2339
			const_31,
			// Token: 0x04000924 RID: 2340
			const_32,
			// Token: 0x04000925 RID: 2341
			const_33,
			// Token: 0x04000926 RID: 2342
			const_34,
			// Token: 0x04000927 RID: 2343
			const_35,
			// Token: 0x04000928 RID: 2344
			const_36,
			// Token: 0x04000929 RID: 2345
			const_37,
			// Token: 0x0400092A RID: 2346
			const_38,
			// Token: 0x0400092B RID: 2347
			const_39,
			// Token: 0x0400092C RID: 2348
			const_40,
			// Token: 0x0400092D RID: 2349
			const_41,
			// Token: 0x0400092E RID: 2350
			const_42,
			// Token: 0x0400092F RID: 2351
			const_43,
			// Token: 0x04000930 RID: 2352
			const_44,
			// Token: 0x04000931 RID: 2353
			const_45,
			// Token: 0x04000932 RID: 2354
			const_46,
			// Token: 0x04000933 RID: 2355
			const_47,
			// Token: 0x04000934 RID: 2356
			const_48,
			// Token: 0x04000935 RID: 2357
			const_49,
			// Token: 0x04000936 RID: 2358
			const_50,
			// Token: 0x04000937 RID: 2359
			const_51,
			// Token: 0x04000938 RID: 2360
			const_52,
			// Token: 0x04000939 RID: 2361
			const_53,
			// Token: 0x0400093A RID: 2362
			const_54,
			// Token: 0x0400093B RID: 2363
			const_55,
			// Token: 0x0400093C RID: 2364
			const_56,
			// Token: 0x0400093D RID: 2365
			const_57,
			// Token: 0x0400093E RID: 2366
			const_58,
			// Token: 0x0400093F RID: 2367
			const_59,
			// Token: 0x04000940 RID: 2368
			const_60,
			// Token: 0x04000941 RID: 2369
			const_61,
			// Token: 0x04000942 RID: 2370
			const_62,
			// Token: 0x04000943 RID: 2371
			const_63,
			// Token: 0x04000944 RID: 2372
			const_64,
			// Token: 0x04000945 RID: 2373
			const_65,
			// Token: 0x04000946 RID: 2374
			const_66,
			// Token: 0x04000947 RID: 2375
			const_67,
			// Token: 0x04000948 RID: 2376
			const_68,
			// Token: 0x04000949 RID: 2377
			const_69,
			// Token: 0x0400094A RID: 2378
			const_70,
			// Token: 0x0400094B RID: 2379
			const_71,
			// Token: 0x0400094C RID: 2380
			const_72
		}

		// Token: 0x0200015E RID: 350
		private enum Enum5
		{
			// Token: 0x0400094E RID: 2382
			const_0,
			// Token: 0x0400094F RID: 2383
			const_1,
			// Token: 0x04000950 RID: 2384
			const_2,
			// Token: 0x04000951 RID: 2385
			const_3,
			// Token: 0x04000952 RID: 2386
			const_4
		}

		// Token: 0x0200015F RID: 351
		private enum Enum6
		{
			// Token: 0x04000954 RID: 2388
			const_0,
			// Token: 0x04000955 RID: 2389
			const_1,
			// Token: 0x04000956 RID: 2390
			const_2,
			// Token: 0x04000957 RID: 2391
			const_3,
			// Token: 0x04000958 RID: 2392
			const_4,
			// Token: 0x04000959 RID: 2393
			const_5,
			// Token: 0x0400095A RID: 2394
			const_6,
			// Token: 0x0400095B RID: 2395
			const_7,
			// Token: 0x0400095C RID: 2396
			const_8,
			// Token: 0x0400095D RID: 2397
			const_9,
			// Token: 0x0400095E RID: 2398
			const_10
		}
	}
}
