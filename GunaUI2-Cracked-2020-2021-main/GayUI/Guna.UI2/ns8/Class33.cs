using System;
using System.Globalization;
using Guna.UI2.HtmlRenderer.Adapters;
using Guna.UI2.HtmlRenderer.Core;
using ns9;

namespace ns8
{
	// Token: 0x02000127 RID: 295
	internal sealed class Class33 : IDisposable
	{
		// Token: 0x060013A6 RID: 5030 RVA: 0x00006304 File Offset: 0x00004504
		static Class33()
		{
			if (瞈.瞈_7(砞.砞_1()).StartsWith("í¬", StringComparison.InvariantCultureIgnoreCase))
			{
				Class33.string_0 = "ß±¹Ð\u0091\u0096\f^A}c\u0093+ÃÒ<Ï";
				Class33.string_1 = "È±¼ÍÔ\u0097";
				Class33.string_2 = "È±¼ÍÔ\u0097Å^\u0003\u007fs\u0088!ÞÏ<\u009d6Ä+*w°\u0002";
				Class33.string_3 = "Ä«ºÖØ\u0097Å^A>{\u0093!Ã";
				Class33.string_4 = "È±¼ÍÔ\u0097Å^\u0003KE¶dÉÙyÑuØf'y°";
				Class33.string_5 = "È±¼ÍÔ\u0097Å^\u0003wz\u009b#È";
				Class33.string_6 = "Î°¾ÁÖ\u008c\u0096FV{eÚ(\u008aÕ4Ü5Ô+5q\u00a0\u001f\u007fi¾";
				Class33.string_7 = "Ä«ºÖØ\u0097Å^E>a\u0093 DÓ";
				Class33.string_8 = "È±¼ÍÔ\u0097Å^\u0003KE¶dÉÙyÑuÇb\"÷º";
				return;
			}
			if (CultureInfo.CurrentUICulture.Name.StartsWith("ï»", StringComparison.InvariantCultureIgnoreCase))
			{
				Class33.string_0 = "Ê²\u00a0Á\u0091\u0084\u0090ASú\u007f\u0096!Ã";
				Class33.string_1 = "À±¼ÍÔ\u0097\u0080\\";
				Class33.string_2 = "Ç·¢Ï\u009c¤\u0081@Amd\u009fdÆÓ)Ô7Ãn(";
				Class33.string_3 = "Ç·¢Ï\u0091\u0013\u0083TJ{y";
				Class33.string_4 = "É·\u00a0À\u009c°·~\u0004ux\u008a-ÈÎ<Ó";
				Class33.string_5 = "É·\u00a0À\u0091\u008e\u008aBM{e\u009f*";
				Class33.string_6 = "É·\u00a0À\u0091\u0096\u0095WM}\u007f\u009f6Ã\u009c,Ó&Ôyh0û";
				Class33.string_7 = "Ý·¨ÁÞÅ\u0013TBpr\u0094";
				Class33.string_8 = "Ý·¨ÁÞÈ°`h>|\u00954ÄÙ+Ø<";
				return;
			}
			if (CultureInfo.CurrentUICulture.Name.StartsWith("âª", StringComparison.InvariantCultureIgnoreCase))
			{
				Class33.string_0 = "Ø»\u00a0ÁË\u008c\u008a\\E>c\u008f0ÙÓ";
				Class33.string_1 = "È±¼ÍÐ";
				Class33.string_2 = "È±¼ÍÐÅ\u008c\\@we\u0093>×ÓyÙ7Ý+*w»\a";
				Class33.string_3 = "Ê®¾Í\u0091\u0089\u008c\\O";
				Class33.string_4 = "È±¼ÍÐÅ°`h>~\u0097)ÌÛ0Ó7";
				Class33.string_5 = "È±¼ÍÐÅ\u008c_I\u007fp\u0093*È";
				Class33.string_6 = "Ø¿\u00a0ÒÐÅ\u008c_I\u007fp\u0093*È\u009c:Ò<\u0091e)s°B\u007fi";
				Class33.string_7 = "Ê®¾Í\u0091\u008c\u0089\u0012Rws\u009f+";
				Class33.string_8 = "È±¼ÍÐÅ°`h>a\u0093 ÈÓ";
				return;
			}
			if (CultureInfo.CurrentUICulture.Name.StartsWith("î­", StringComparison.InvariantCultureIgnoreCase))
			{
				Class33.string_0 = "Ø»\u00a0ÁÒ\u0086\u008c]J\u007feÚ0ÂØ6";
				Class33.string_1 = "È±¼ÍÐ\u0097";
				Class33.string_2 = "È±¼ÍÐ\u0097ÅVMlr\u0099'ÄO7\u009d6Ô+#p¹\r2\"";
				Class33.string_3 = "Ê¼¾ÍÃÅ\u0080\\H\u007ft\u009f";
				Class33.string_4 = "È±¼ÍÐ\u0097ÅgvR7\u009e!\u008dÐ8\u009d;Üj!{»";
				Class33.string_5 = "È±¼ÍÐ\u0097Å[I\u007fp\u009f*";
				Class33.string_6 = "Ì«­ÖÕ\u0084\u0097\u0012Msv\u009d!Ã\u009c:Ò?Þ%h0";
				Class33.string_7 = "Ê¼¾ÍÃÅ\u0093[@{x";
				Class33.string_8 = "È±¼ÍÐ\u0097ÅgvR7\u009e!\u008dÐ8\u009d$Øo#q";
				return;
			}
			if (CultureInfo.CurrentUICulture.Name.StartsWith("ù«", StringComparison.InvariantCultureIgnoreCase))
			{
				Class33.string_0 = "ҙҕӽӤҁҧҩ\u0012ЖџТ";
				Class33.string_1 = "ґӠӳҜӱӛӗЂѦђ";
				Class33.string_2 = "ґӠӳҜӱӛӗЂѦђ7ӊѰӭ҉И\u009dГӰрѽФӭ";
				Class33.string_3 = "ҔӫҌґ҈ҧӝ\u0012ЛР7һЅӦ҇ѣ҈";
				Class33.string_4 = "ґӠӳҜӱӛӗЂѦђ7ӊѰӭ҉И\u009dѪ҆еѷўӥњѤѺҨҋ";
				Class33.string_5 = "ґӠӳҜӱӛӗЂѦђ7ӂѳғҍЙҍѤ҄жѾЫ";
				Class33.string_6 = "ҪӠ҉ӤҁӘӝѰѨ>ЯӍѺҜӼѩҋѧҌгѳ>ӯќѫi¾ê";
				Class33.string_7 = "ҕҜӶӤӺҧҩ\u0012ЖЦУӏѺ";
				Class33.string_8 = "ґӠӳҜӱӛӗЂѦђ7ӊѰӭ҉И\u009dѠ҉пѳР";
				return;
			}
			if (CultureInfo.CurrentUICulture.Name.StartsWith("ø¨", StringComparison.InvariantCultureIgnoreCase))
			{
				Class33.string_0 = "Ý:\u00a0Î\u0091\u0084\u0089^P";
				Class33.string_1 = "À±¼ÍÔ\u0097\u0084";
				Class33.string_2 = "À±¼ÍÔ\u0097\u0084\u0012Húy\u0091%ÉÎ<Î!";
				Class33.string_3 = "]®¼ÊÐÅ\u0089ÖJu";
				Class33.string_4 = "À±¼ÍÔ\u0097\u0084\u0012Fw{\u009e!ÃÏyè\0ý";
				Class33.string_5 = "À±¼ÍÔ\u0097\u0084\u0012Fw{\u009e";
				Class33.string_6 = "Ø®­ÖÐÅ\u0087[Hz7\u0089+À\u0092w\u0093";
				Class33.string_7 = "]®¼ÊÐÅ\u0093[@{x";
				Class33.string_8 = "À±¼ÍÔ\u0097\u0084\u0012Rws\u009f+\u008dé\vñ";
				return;
			}
			if (CultureInfo.CurrentUICulture.Name.StartsWith("ã«", StringComparison.InvariantCultureIgnoreCase))
			{
				Class33.string_0 = "]­¿ÞÔ\u0096ÅYMhö\u0096%ÞÆ-\\!Ð";
				Class33.string_1 = "Æ?¿ËÝ\u0004\u0096";
				Class33.string_2 = "Ã·ºÅÅ\u008e\u008aHÅm7\u0099©ÀU7Ø9\u0091f§mº\0°4ñ";
				Class33.string_3 = "Ã·ºÅÅ\u008e\u008aHÅm7\u0097!ÊÒ Ô&Px'";
				Class33.string_4 = "À7¼\u0084ä·©\u0012Iÿd\u0095(LÏ8";
				Class33.string_5 = "À7¼\u0084Ü\u0004\u0096]Hÿd\u009b";
				Class33.string_6 = "À7¼\u0084Ü\u0080\u008bFÍmrÚ)LÏ2T<Å%h0";
				Class33.string_7 = "Ý·¨ÁBÅ\u0088WCpn\u00930LÏ8";
				Class33.string_8 = "Ý·¨ÁBÅ°`h>z\u001b7ÂÐ¸Î3";
				return;
			}
			if (CultureInfo.CurrentUICulture.Name.StartsWith("è­", StringComparison.InvariantCultureIgnoreCase))
			{
				Class33.string_0 = "Ý§®ÖÐ\u0091ÅDŅ{";
				Class33.string_1 = "À±¼IÃ\u008a\u0093SP";
				Class33.string_2 = "À±¼IÃ\u008a\u0093SP>v\u009e6ÈÏ,\u009d=Õ`'d\u00a0";
				Class33.string_3 = "Äª©ÒǨ\b\u0091\u0012Kz|\u009b>";
				Class33.string_4 = "À±¼IÃ\u008a\u0093SP>B¨\b\u008dÏ7P?Ú~";
				Class33.string_5 = "À±¼IÃ\u008a\u0093SP>d\u0094©ÀÙ2";
				Class33.string_6 = "Þ²£ǚØ\u0091ÅAJóz\u009f/\u008dÖ8Ö=\u009f%h";
				Class33.string_7 = "Äª©ÒǨ\b\u0091\u0012Rws\u009f+";
				Class33.string_8 = "À±¼IÃ\u008a\u0093SP>B¨\b\u008dÊ0Ù7Þ";
				return;
			}
			if (CultureInfo.CurrentUICulture.Name.StartsWith("ï¿", StringComparison.InvariantCultureIgnoreCase))
			{
				Class33.string_0 = "Ý8\u00a0Ã\u0091\u0084\u0089F";
				Class33.string_1 = "À±¼ÍX\u0097";
				Class33.string_2 = "À±¼ÍÔ\u0097Å^Mp|×%ÉÎ<Î!Ô";
				Class33.string_3 = "N¼¢\u0084Ý\u008c\u008bY";
				Class33.string_4 = "À±¼ÍÔ\u0097ÅPMr{\u009f È\u0091\fï\u001e";
				Class33.string_5 = "À±¼ÍÔ\u0097ÅPMr{\u009f È";
				Class33.string_6 = "Ì»¡\u0084Ó\u008c\u0089^AzrÚ7ÂÑw\u0093|";
				Class33.string_7 = "N¼¢\u0084Ç\u008c\u0081WK";
				Class33.string_8 = "À±¼ÍÔ\u0097ÅDMzr\u0095iøî\u0015";
				return;
			}
			if (CultureInfo.CurrentUICulture.Name.StartsWith("å²", StringComparison.InvariantCultureIgnoreCase))
			{
				Class33.string_0 = "Ê²\u00a0ÁÂÅ\u0096WH{t\u008e!ßÙ7";
				Class33.string_1 = "À±¼ÍZ\u0097\u0080\\";
				Class33.string_2 = "Ç·¢Ï\u0091\u0084\u0081@Am7\u0091+ÝÕ²Ï7ß";
				Class33.string_3 = "Ç·¢Ï\u0091\u008a\u0095WJ{y";
				Class33.string_4 = "Þ\u008c\u0080\u0084ð\u0083\u0087WArs\u0093*Ê\u009c2Ò\"Øà4{»";
				Class33.string_5 = "Ê¸®ÁÔ\u0089\u0081[Jy7\u0091+ÝÕ²Ï7ß";
				Class33.string_6 = "É»»ÅÐ\u0097ÅSB|r\u009f(ÉÕ7ÚrÐg50ûB";
				Class33.string_7 = "Ý·¨ÁÞÅ\u008aBApr\u0094";
				Class33.string_8 = "Þ\u008c\u0080\u0084Ç\u008c\u0081WK>|\u00954ÄW+Ø<";
				return;
			}
			if (CultureInfo.CurrentUICulture.Name.StartsWith("í·", StringComparison.InvariantCultureIgnoreCase))
			{
				Class33.string_0 = "Ý¿\u00a0ÍÅ\u0096\u0080\u0012O\u007f~\u0091/Ä";
				Class33.string_1 = "À±¼ÍÞ\u008c";
				Class33.string_2 = "À±¼ÍÞ\u008cÅ^Mp|\u0093*\u008dÓ*Ò;Ån";
				Class33.string_3 = "Ê¨­Å\u0091\u0089\u008c\\Ou~";
				Class33.string_4 = "À±¼ÍÞ\u008cÅYQhv\u0094døî\u0015";
				Class33.string_5 = "À±¼ÍÞ\u008cÅYQhv";
				Class33.string_6 = "ß¿\u00a0ÈÔ\u008b\u0084\u0012Oka\u009bdÃÕ4Ø>Ýïh0û";
				Class33.string_7 = "Ê¨­Å\u0091\u0093\u008cVAq";
				Class33.string_8 = "À±¼ÍÞ\u008cÅDMzr\u0095døî\u0015";
				return;
			}
			Class33.string_0 = "Ø»\u00a0ÁÒ\u0091ÅSHr";
			Class33.string_1 = "È±¼Ý";
			Class33.string_2 = "È±¼Ý\u0091\u0089\u008c\\O>v\u009e ßÙ*Î";
			Class33.string_3 = "Ä®©Ê\u0091\u0089\u008c\\O";
			Class33.string_4 = "È±¼Ý\u0091\u008c\u0088SC{7¯\u0016á";
			Class33.string_5 = "È±¼Ý\u0091\u008c\u0088SC{";
			Class33.string_6 = "Ø¿ºÁ\u0091\u008c\u0088SC{7\u009b7\u0083\u0092w";
			Class33.string_7 = "Ä®©Ê\u0091\u0093\u008cVAq";
			Class33.string_8 = "È±¼Ý\u0091\u0093\u008cVAq7¯\u0016á";
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x00002167 File Offset: 0x00000367
		public Class33(Class38 selectionHandler, HtmlContainerInt htmlContainer)
		{
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x00002134 File Offset: 0x00000334
		public void method_0(RControl parent, Class50 rect, Class41 link)
		{
		}

		// Token: 0x060013A9 RID: 5033 RVA: 0x00002134 File Offset: 0x00000334
		public void Dispose()
		{
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x00002134 File Offset: 0x00000334
		private void method_1()
		{
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x00002134 File Offset: 0x00000334
		private void method_2(object sender, EventArgs e)
		{
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x00002134 File Offset: 0x00000334
		private void method_3(object sender, EventArgs e)
		{
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x00002134 File Offset: 0x00000334
		private void method_4(object sender, EventArgs e)
		{
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x00002134 File Offset: 0x00000334
		private void method_5(object sender, EventArgs e)
		{
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x00002134 File Offset: 0x00000334
		private void method_6(object sender, EventArgs e)
		{
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x00002134 File Offset: 0x00000334
		private void method_7(object sender, EventArgs e)
		{
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x00002134 File Offset: 0x00000334
		private void method_8(object sender, EventArgs e)
		{
		}

		// Token: 0x040007D1 RID: 2001
		private static readonly string string_0;

		// Token: 0x040007D2 RID: 2002
		private static readonly string string_1;

		// Token: 0x040007D3 RID: 2003
		private static readonly string string_2;

		// Token: 0x040007D4 RID: 2004
		private static readonly string string_3;

		// Token: 0x040007D5 RID: 2005
		private static readonly string string_4;

		// Token: 0x040007D6 RID: 2006
		private static readonly string string_5;

		// Token: 0x040007D7 RID: 2007
		private static readonly string string_6;

		// Token: 0x040007D8 RID: 2008
		private static readonly string string_7;

		// Token: 0x040007D9 RID: 2009
		private static readonly string string_8;

		// Token: 0x040007DA RID: 2010
		private readonly Class38 class38_0;

		// Token: 0x040007DB RID: 2011
		private readonly HtmlContainerInt htmlContainerInt_0;

		// Token: 0x040007DC RID: 2012
		private RContextMenu rcontextMenu_0;

		// Token: 0x040007DD RID: 2013
		private RControl rcontrol_0;

		// Token: 0x040007DE RID: 2014
		private Class50 class50_0;

		// Token: 0x040007DF RID: 2015
		private Class41 class41_0;
	}
}
