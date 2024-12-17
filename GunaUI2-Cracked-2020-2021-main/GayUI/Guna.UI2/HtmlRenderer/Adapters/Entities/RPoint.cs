using System;

namespace Guna.UI2.HtmlRenderer.Adapters.Entities
{
	// Token: 0x02000166 RID: 358
	public struct RPoint
	{
		// Token: 0x0600167E RID: 5758 RVA: 0x000024FD File Offset: 0x000006FD
		public RPoint(double x, double y)
		{
			this.double_0 = x;
			this.double_1 = y;
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x0600167F RID: 5759 RVA: 0x00002136 File Offset: 0x00000336
		public bool IsEmpty
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x06001680 RID: 5760 RVA: 0x00002154 File Offset: 0x00000354
		// (set) Token: 0x06001681 RID: 5761 RVA: 0x00002134 File Offset: 0x00000334
		public double X
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x06001682 RID: 5762 RVA: 0x00002154 File Offset: 0x00000354
		// (set) Token: 0x06001683 RID: 5763 RVA: 0x00002134 File Offset: 0x00000334
		public double Y
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x00003BE4 File Offset: 0x00001DE4
		public static RPoint operator +(RPoint pt, RSize sz)
		{
			return default(RPoint);
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x00003BE4 File Offset: 0x00001DE4
		public static RPoint operator -(RPoint pt, RSize sz)
		{
			return default(RPoint);
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x00002136 File Offset: 0x00000336
		public static bool operator ==(RPoint left, RPoint right)
		{
			return false;
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x00002136 File Offset: 0x00000336
		public static bool operator !=(RPoint left, RPoint right)
		{
			return false;
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x00003BE4 File Offset: 0x00001DE4
		public static RPoint Add(RPoint pt, RSize sz)
		{
			return default(RPoint);
		}

		// Token: 0x06001689 RID: 5769 RVA: 0x00003BE4 File Offset: 0x00001DE4
		public static RPoint Subtract(RPoint pt, RSize sz)
		{
			return default(RPoint);
		}

		// Token: 0x0600168A RID: 5770 RVA: 0x00002136 File Offset: 0x00000336
		public override bool Equals(object obj)
		{
			return false;
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x00002136 File Offset: 0x00000336
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x00002131 File Offset: 0x00000331
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000976 RID: 2422
		public static readonly RPoint Empty;

		// Token: 0x04000977 RID: 2423
		private double double_0;

		// Token: 0x04000978 RID: 2424
		private double double_1;
	}
}
