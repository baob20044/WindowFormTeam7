using System;

namespace Guna.UI2.HtmlRenderer.Adapters.Entities
{
	// Token: 0x02000168 RID: 360
	public struct RSize
	{
		// Token: 0x060016B2 RID: 5810 RVA: 0x00002562 File Offset: 0x00000762
		public RSize(RSize size)
		{
			this.double_1 = size.double_1;
			this.double_0 = size.double_0;
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x0000257C File Offset: 0x0000077C
		public RSize(RPoint pt)
		{
			this.double_1 = pt.X;
			this.double_0 = pt.Y;
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x00002598 File Offset: 0x00000798
		public RSize(double width, double height)
		{
			this.double_1 = width;
			this.double_0 = height;
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x060016B5 RID: 5813 RVA: 0x00002136 File Offset: 0x00000336
		public bool IsEmpty
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x060016B6 RID: 5814 RVA: 0x00002154 File Offset: 0x00000354
		// (set) Token: 0x060016B7 RID: 5815 RVA: 0x00002134 File Offset: 0x00000334
		public double Width
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x060016B8 RID: 5816 RVA: 0x00002154 File Offset: 0x00000354
		// (set) Token: 0x060016B9 RID: 5817 RVA: 0x00002134 File Offset: 0x00000334
		public double Height
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x00003BE4 File Offset: 0x00001DE4
		public static explicit operator RPoint(RSize size)
		{
			return default(RPoint);
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x00003BFC File Offset: 0x00001DFC
		public static RSize operator +(RSize sz1, RSize sz2)
		{
			return default(RSize);
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x00003BFC File Offset: 0x00001DFC
		public static RSize operator -(RSize sz1, RSize sz2)
		{
			return default(RSize);
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x00002136 File Offset: 0x00000336
		public static bool operator ==(RSize sz1, RSize sz2)
		{
			return false;
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x00002136 File Offset: 0x00000336
		public static bool operator !=(RSize sz1, RSize sz2)
		{
			return false;
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x00003BFC File Offset: 0x00001DFC
		public static RSize Add(RSize sz1, RSize sz2)
		{
			return default(RSize);
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x00003BFC File Offset: 0x00001DFC
		public static RSize Subtract(RSize sz1, RSize sz2)
		{
			return default(RSize);
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x00002136 File Offset: 0x00000336
		public override bool Equals(object obj)
		{
			return false;
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x00002136 File Offset: 0x00000336
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x00003BE4 File Offset: 0x00001DE4
		public RPoint ToPointF()
		{
			return default(RPoint);
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x00002131 File Offset: 0x00000331
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400097E RID: 2430
		public static readonly RSize Empty;

		// Token: 0x0400097F RID: 2431
		private double double_0;

		// Token: 0x04000980 RID: 2432
		private double double_1;
	}
}
