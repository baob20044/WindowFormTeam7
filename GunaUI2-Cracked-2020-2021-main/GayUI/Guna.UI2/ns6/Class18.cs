using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Guna.UI2.HtmlRenderer.Adapters.Entities;

namespace ns6
{
	// Token: 0x02000116 RID: 278
	internal static class Class18
	{
		// Token: 0x060012EB RID: 4843 RVA: 0x00002136 File Offset: 0x00000336
		public static bool smethod_0(char ch)
		{
			return false;
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x00002136 File Offset: 0x00000336
		public static bool smethod_1(char ch, bool hex = false)
		{
			return false;
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x00002136 File Offset: 0x00000336
		public static int smethod_2(char ch, bool hex = false)
		{
			return 0;
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x00003BFC File Offset: 0x00001DFC
		public static RSize smethod_3(RSize size, RSize other)
		{
			return default(RSize);
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x00002131 File Offset: 0x00000331
		public static Uri smethod_4(string path)
		{
			return null;
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x00003D1C File Offset: 0x00001F1C
		public static TValue smethod_5<TKey, TValue>(IDictionary<TKey, TValue> dic, TValue defaultValue = default(TValue))
		{
			return default(TValue);
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x00002131 File Offset: 0x00000331
		public static FileInfo smethod_6(string path)
		{
			return null;
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x00002131 File Offset: 0x00000331
		public static string smethod_7(WebClient client)
		{
			return null;
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x00002131 File Offset: 0x00000331
		public static FileInfo smethod_8(Uri imageUri)
		{
			return null;
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x00002136 File Offset: 0x00000336
		public static int smethod_9(string str, int idx, out int length)
		{
			return 0;
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x00002136 File Offset: 0x00000336
		public static bool smethod_10(string str, int idx, int length, string str2)
		{
			return false;
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x00002131 File Offset: 0x00000331
		private static string smethod_11(string source)
		{
			return null;
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x00002131 File Offset: 0x00000331
		public static string smethod_12(int number, string style = "upper-alpha")
		{
			return null;
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x00002131 File Offset: 0x00000331
		private static string smethod_13(int number, bool lowercase)
		{
			return null;
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x00002131 File Offset: 0x00000331
		private static string smethod_14(int number)
		{
			return null;
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x00002131 File Offset: 0x00000331
		private static string smethod_15(int number, bool lowercase)
		{
			return null;
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x00002131 File Offset: 0x00000331
		private static string smethod_16(int number, string[,] alphabet)
		{
			return null;
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x00002131 File Offset: 0x00000331
		private static string smethod_17(int number, string[] alphabet)
		{
			return null;
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x00003D34 File Offset: 0x00001F34
		// Note: this type is marked as 'beforefieldinit'.
		static Class18()
		{
			string[,] array = new string[4, 10];
			array[0, 0] = "";
			array[0, 1] = "Â";
			array[0, 2] = "Â\u0097";
			array[0, 3] = "Â\u0097\u0085";
			array[0, 4] = "Â\u0088";
			array[0, 5] = "Ý";
			array[0, 6] = "Ý\u0097";
			array[0, 7] = "Ý\u0097\u0085";
			array[0, 8] = "Ý\u0097\u0085í";
			array[0, 9] = "Â\u0086";
			array[1, 0] = "";
			array[1, 1] = "Ó";
			array[1, 2] = "Ó\u0086";
			array[1, 3] = "Ó\u0086\u0094";
			array[1, 4] = "Ó\u0092";
			array[1, 5] = "Ç";
			array[1, 6] = "Ç\u0086";
			array[1, 7] = "Ç\u0086\u0094";
			array[1, 8] = "Ç\u0086\u0094ü";
			array[1, 9] = "Ó\u009d";
			array[2, 0] = "";
			array[2, 1] = "È";
			array[2, 2] = "È\u009d";
			array[2, 3] = "È\u009d\u008f";
			array[2, 4] = "È\u009a";
			array[2, 5] = "Ï";
			array[2, 6] = "Ï\u009d";
			array[2, 7] = "Ï\u009d\u008f";
			array[2, 8] = "Ï\u009d\u008fç";
			array[2, 9] = "È\u0093";
			array[3, 0] = "";
			array[3, 1] = "Æ";
			array[3, 2] = "Æ\u0093";
			array[3, 3] = "Æ\u0093\u0081";
			array[3, 4] = "Æö\u009a\u008d";
			array[3, 5] = "£\u0088å";
			array[3, 6] = "£\u0088åé";
			array[3, 7] = "£\u0088åéü";
			array[3, 8] = "£\u0088åéü¨";
			array[3, 9] = "Æö\u0094\u008d";
			Class18.string_0 = array;
			string[,] array2 = new string[3, 9];
			array2[0, 0] = "՛";
			array2[0, 1] = "՚";
			array2[0, 2] = "ՙ";
			array2[0, 3] = "՘";
			array2[0, 4] = "՟";
			array2[0, 5] = "՞";
			array2[0, 6] = "՝";
			array2[0, 7] = "՜";
			array2[0, 8] = "Փ";
			array2[1, 0] = "Ւ";
			array2[1, 1] = "Ր";
			array2[1, 2] = "՗";
			array2[1, 3] = "Օ";
			array2[1, 4] = "ի";
			array2[1, 5] = "ժ";
			array2[1, 6] = "թ";
			array2[1, 7] = "կ";
			array2[1, 8] = "խ";
			array2[2, 0] = "լ";
			array2[2, 1] = "գ";
			array2[2, 2] = "բ";
			array2[2, 3] = "ա";
			array2[2, 4] = "աԹ";
			array2[2, 5] = "աԶ";
			array2[2, 6] = "աԷ";
			array2[2, 7] = "աԴ";
			array2[2, 8] = "աԴԫ";
			Class18.string_1 = array2;
			string[,] array3 = new string[3, 9];
			array3[0, 0] = "ၛ";
			array3[0, 1] = "ၚ";
			array3[0, 2] = "ၙ";
			array3[0, 3] = "ၘ";
			array3[0, 4] = "ၟ";
			array3[0, 5] = "ၞ";
			array3[0, 6] = "ၝ";
			array3[0, 7] = "ၺ";
			array3[0, 8] = "ၜ";
			array3[1, 0] = "ၓ";
			array3[1, 1] = "ၕ";
			array3[1, 2] = "ၑ";
			array3[1, 3] = "ၐ";
			array3[1, 4] = "ၗ";
			array3[1, 5] = "ၹ";
			array3[1, 6] = "ၖ";
			array3[1, 7] = "ၕ";
			array3[1, 8] = "ၔ";
			array3[2, 0] = "ၫ";
			array3[2, 1] = "ၪ";
			array3[2, 2] = "ၩ";
			array3[2, 3] = "ၸ";
			array3[2, 4] = "ၯ";
			array3[2, 5] = "ၮ";
			array3[2, 6] = "ၭ";
			array3[2, 7] = "ၬ";
			array3[2, 8] = "ၣ";
			Class18.string_2 = array3;
			string[,] array4 = new string[3, 9];
			array4[0, 0] = "ֺ";
			array4[0, 1] = "ֹ";
			array4[0, 2] = "ָ";
			array4[0, 3] = "ֿ";
			array4[0, 4] = "־";
			array4[0, 5] = "ֽ";
			array4[0, 6] = "ּ";
			array4[0, 7] = "ֳ";
			array4[0, 8] = "ֲ";
			array4[1, 0] = "ֱ";
			array4[1, 1] = "ְ";
			array4[1, 2] = "ַ";
			array4[1, 3] = "ֶ";
			array4[1, 4] = "ֵ";
			array4[1, 5] = "ִ";
			array4[1, 6] = "׋";
			array4[1, 7] = "׊";
			array4[1, 8] = "׉";
			array4[2, 0] = "׈";
			array4[2, 1] = "׏";
			array4[2, 2] = "׎";
			array4[2, 3] = "׍";
			array4[2, 4] = "׌";
			array4[2, 5] = "׃";
			array4[2, 6] = "ׂ";
			array4[2, 7] = "ׁ";
			array4[2, 8] = "׀";
			Class18.string_3 = array4;
			Class18.string_4 = new string[]
			{
				"ド",
				"ト",
				"ノ",
				"ヌ",
				"ヂ",
				"ダ",
				"テ",
				"ツ",
				"ペ",
				"ヘ",
				"マ",
				"ボ",
				"ヒ",
				"バ",
				"ブ",
				"ピ",
				"リ",
				"ワ",
				"ロ",
				"ャ",
				"メ",
				"ム",
				"ョ",
				"ユ",
				"ュ",
				"ヤ",
				"ヹ",
				"ヾ",
				"ン",
				"ヰ",
				"ヵ",
				"ヴ",
				"》",
				"《",
				"〉",
				"〈",
				"『",
				"「",
				"。",
				"、",
				"\u3000",
				"〇",
				"〆",
				"々",
				"〛",
				"〚",
				"〙",
				"〘"
			};
			Class18.string_5 = new string[]
			{
				"〩",
				"〯",
				"〭",
				"〣",
				"〡",
				"〠",
				"〦",
				"〤",
				"〺",
				"〸",
				"〾",
				"〼",
				"〲",
				"〰",
				"〶",
				"〴",
				"お",
				"く",
				"き",
				"ぃ",
				"ぁ",
				"぀",
				"ぇ",
				"う",
				"ぅ",
				"い",
				"す",
				"ぞ",
				"こ",
				"ぐ",
				"さ",
				"ご",
				"に",
				"な",
				"ど",
				"は",
				"ね",
				"っ",
				"ぢ",
				"ち",
				"だ",
				"で",
				"て",
				"つ",
				"ほ",
				"ぺ",
				"べ",
				"へ"
			};
		}

		// Token: 0x04000717 RID: 1815
		private static readonly string[,] string_0;

		// Token: 0x04000718 RID: 1816
		private static readonly string[,] string_1;

		// Token: 0x04000719 RID: 1817
		private static readonly string[,] string_2;

		// Token: 0x0400071A RID: 1818
		private static readonly string[,] string_3;

		// Token: 0x0400071B RID: 1819
		private static readonly string[] string_4;

		// Token: 0x0400071C RID: 1820
		private static readonly string[] string_5;

		// Token: 0x0400071D RID: 1821
		public static string string_6;
	}
}
