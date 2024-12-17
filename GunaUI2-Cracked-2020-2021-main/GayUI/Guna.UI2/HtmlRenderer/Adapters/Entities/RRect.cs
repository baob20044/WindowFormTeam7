using System;

namespace Guna.UI2.HtmlRenderer.Adapters.Entities
{
	// Token: 0x02000167 RID: 359
	public struct RRect
	{
		// Token: 0x0600168D RID: 5773 RVA: 0x0000250D File Offset: 0x0000070D
		public RRect(double x, double y, double width, double height)
		{
			this.double_2 = x;
			this.double_3 = y;
			this.double_1 = width;
			this.double_0 = height;
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x0000252C File Offset: 0x0000072C
		public RRect(RPoint location, RSize size)
		{
			this.double_2 = location.X;
			this.double_3 = location.Y;
			this.double_1 = size.Width;
			this.double_0 = size.Height;
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x0600168F RID: 5775 RVA: 0x00003BE4 File Offset: 0x00001DE4
		// (set) Token: 0x06001690 RID: 5776 RVA: 0x00002134 File Offset: 0x00000334
		public RPoint Location
		{
			get
			{
				return default(RPoint);
			}
			set
			{
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06001691 RID: 5777 RVA: 0x00003BFC File Offset: 0x00001DFC
		// (set) Token: 0x06001692 RID: 5778 RVA: 0x00002134 File Offset: 0x00000334
		public RSize Size
		{
			get
			{
				return default(RSize);
			}
			set
			{
			}
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06001693 RID: 5779 RVA: 0x00002154 File Offset: 0x00000354
		// (set) Token: 0x06001694 RID: 5780 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06001695 RID: 5781 RVA: 0x00002154 File Offset: 0x00000354
		// (set) Token: 0x06001696 RID: 5782 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06001697 RID: 5783 RVA: 0x00002154 File Offset: 0x00000354
		// (set) Token: 0x06001698 RID: 5784 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06001699 RID: 5785 RVA: 0x00002154 File Offset: 0x00000354
		// (set) Token: 0x0600169A RID: 5786 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x0600169B RID: 5787 RVA: 0x00002154 File Offset: 0x00000354
		public double Left
		{
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x0600169C RID: 5788 RVA: 0x00002154 File Offset: 0x00000354
		public double Top
		{
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x0600169D RID: 5789 RVA: 0x00002154 File Offset: 0x00000354
		public double Right
		{
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x0600169E RID: 5790 RVA: 0x00002154 File Offset: 0x00000354
		public double Bottom
		{
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x0600169F RID: 5791 RVA: 0x00002136 File Offset: 0x00000336
		public bool IsEmpty
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x00002136 File Offset: 0x00000336
		public static bool operator ==(RRect left, RRect right)
		{
			return false;
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x00002136 File Offset: 0x00000336
		public static bool operator !=(RRect left, RRect right)
		{
			return false;
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x00003C14 File Offset: 0x00001E14
		public static RRect FromLTRB(double left, double top, double right, double bottom)
		{
			return default(RRect);
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x00002136 File Offset: 0x00000336
		public override bool Equals(object obj)
		{
			return false;
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x00002136 File Offset: 0x00000336
		public bool Contains(double x, double y)
		{
			return false;
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x00002136 File Offset: 0x00000336
		public bool Contains(RPoint pt)
		{
			return false;
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x00002136 File Offset: 0x00000336
		public bool Contains(RRect rect)
		{
			return false;
		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x00002134 File Offset: 0x00000334
		public void Inflate(double x, double y)
		{
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x00002134 File Offset: 0x00000334
		public void Inflate(RSize size)
		{
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x00003C14 File Offset: 0x00001E14
		public static RRect Inflate(RRect rect, double x, double y)
		{
			return default(RRect);
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x00002134 File Offset: 0x00000334
		public void Intersect(RRect rect)
		{
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x00003C14 File Offset: 0x00001E14
		public static RRect Intersect(RRect a, RRect b)
		{
			return default(RRect);
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x00002136 File Offset: 0x00000336
		public bool IntersectsWith(RRect rect)
		{
			return false;
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x00003C14 File Offset: 0x00001E14
		public static RRect Union(RRect a, RRect b)
		{
			return default(RRect);
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x00002134 File Offset: 0x00000334
		public void Offset(RPoint pos)
		{
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x00002134 File Offset: 0x00000334
		public void Offset(double x, double y)
		{
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x00002136 File Offset: 0x00000336
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x00002131 File Offset: 0x00000331
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000979 RID: 2425
		public static readonly RRect Empty;

		// Token: 0x0400097A RID: 2426
		private double double_0;

		// Token: 0x0400097B RID: 2427
		private double double_1;

		// Token: 0x0400097C RID: 2428
		private double double_2;

		// Token: 0x0400097D RID: 2429
		private double double_3;
	}
}
