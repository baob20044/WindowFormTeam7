using System;

namespace Guna.UI2.HtmlRenderer.Adapters.Entities
{
	// Token: 0x02000161 RID: 353
	public struct RColor
	{
		// Token: 0x06001665 RID: 5733 RVA: 0x000024F4 File Offset: 0x000006F4
		private RColor(long value)
		{
			this.long_0 = value;
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x06001666 RID: 5734 RVA: 0x00003C2C File Offset: 0x00001E2C
		public static RColor Transparent
		{
			get
			{
				return default(RColor);
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x06001667 RID: 5735 RVA: 0x00003C2C File Offset: 0x00001E2C
		public static RColor Black
		{
			get
			{
				return default(RColor);
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06001668 RID: 5736 RVA: 0x00003C2C File Offset: 0x00001E2C
		public static RColor White
		{
			get
			{
				return default(RColor);
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06001669 RID: 5737 RVA: 0x00003C2C File Offset: 0x00001E2C
		public static RColor WhiteSmoke
		{
			get
			{
				return default(RColor);
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x0600166A RID: 5738 RVA: 0x00003C2C File Offset: 0x00001E2C
		public static RColor LightGray
		{
			get
			{
				return default(RColor);
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x0600166B RID: 5739 RVA: 0x00002136 File Offset: 0x00000336
		public byte R
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x0600166C RID: 5740 RVA: 0x00002136 File Offset: 0x00000336
		public byte G
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x0600166D RID: 5741 RVA: 0x00002136 File Offset: 0x00000336
		public byte B
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x0600166E RID: 5742 RVA: 0x00002136 File Offset: 0x00000336
		public byte A
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x0600166F RID: 5743 RVA: 0x00002136 File Offset: 0x00000336
		public bool IsEmpty
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x00002136 File Offset: 0x00000336
		public static bool operator ==(RColor left, RColor right)
		{
			return false;
		}

		// Token: 0x06001671 RID: 5745 RVA: 0x00002136 File Offset: 0x00000336
		public static bool operator !=(RColor left, RColor right)
		{
			return false;
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x00003C2C File Offset: 0x00001E2C
		public static RColor FromArgb(int alpha, int red, int green, int blue)
		{
			return default(RColor);
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x00003C2C File Offset: 0x00001E2C
		public static RColor FromArgb(int red, int green, int blue)
		{
			return default(RColor);
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x00002136 File Offset: 0x00000336
		public override bool Equals(object obj)
		{
			return false;
		}

		// Token: 0x06001675 RID: 5749 RVA: 0x00002136 File Offset: 0x00000336
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x00002131 File Offset: 0x00000331
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001677 RID: 5751 RVA: 0x00002134 File Offset: 0x00000334
		private static void smethod_0(int value)
		{
		}

		// Token: 0x04000963 RID: 2403
		public static readonly RColor Empty;

		// Token: 0x04000964 RID: 2404
		private readonly long long_0;
	}
}
