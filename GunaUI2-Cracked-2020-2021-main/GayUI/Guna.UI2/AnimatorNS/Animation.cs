using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Guna.UI2.AnimatorNS
{
	// Token: 0x02000180 RID: 384
	public class Animation
	{
		// Token: 0x06001727 RID: 5927 RVA: 0x00002131 File Offset: 0x00000331
		public override string ToString()
		{
			return null;
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06001728 RID: 5928 RVA: 0x00003BB4 File Offset: 0x00001DB4
		// (set) Token: 0x06001729 RID: 5929 RVA: 0x00002134 File Offset: 0x00000334
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[TypeConverter(typeof(PointFConverter))]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public PointF SlideCoeff
		{
			[CompilerGenerated]
			get
			{
				return default(PointF);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x0600172A RID: 5930 RVA: 0x00002145 File Offset: 0x00000345
		// (set) Token: 0x0600172B RID: 5931 RVA: 0x00002134 File Offset: 0x00000334
		public float RotateCoeff
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x0600172C RID: 5932 RVA: 0x00002145 File Offset: 0x00000345
		// (set) Token: 0x0600172D RID: 5933 RVA: 0x00002134 File Offset: 0x00000334
		public float RotateLimit
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x0600172E RID: 5934 RVA: 0x00003BB4 File Offset: 0x00001DB4
		// (set) Token: 0x0600172F RID: 5935 RVA: 0x00002134 File Offset: 0x00000334
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[TypeConverter(typeof(PointFConverter))]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public PointF ScaleCoeff
		{
			[CompilerGenerated]
			get
			{
				return default(PointF);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06001730 RID: 5936 RVA: 0x00002145 File Offset: 0x00000345
		// (set) Token: 0x06001731 RID: 5937 RVA: 0x00002134 File Offset: 0x00000334
		public float TransparencyCoeff
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06001732 RID: 5938 RVA: 0x00002145 File Offset: 0x00000345
		// (set) Token: 0x06001733 RID: 5939 RVA: 0x00002134 File Offset: 0x00000334
		public float LeafCoeff
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06001734 RID: 5940 RVA: 0x00003BB4 File Offset: 0x00001DB4
		// (set) Token: 0x06001735 RID: 5941 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[TypeConverter(typeof(PointFConverter))]
		public PointF MosaicShift
		{
			[CompilerGenerated]
			get
			{
				return default(PointF);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06001736 RID: 5942 RVA: 0x00003BB4 File Offset: 0x00001DB4
		// (set) Token: 0x06001737 RID: 5943 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[TypeConverter(typeof(PointFConverter))]
		public PointF MosaicCoeff
		{
			[CompilerGenerated]
			get
			{
				return default(PointF);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06001738 RID: 5944 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06001739 RID: 5945 RVA: 0x00002134 File Offset: 0x00000334
		public int MosaicSize
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x0600173A RID: 5946 RVA: 0x00003BB4 File Offset: 0x00001DB4
		// (set) Token: 0x0600173B RID: 5947 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[TypeConverter(typeof(PointFConverter))]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public PointF BlindCoeff
		{
			[CompilerGenerated]
			get
			{
				return default(PointF);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x0600173C RID: 5948 RVA: 0x00002145 File Offset: 0x00000345
		// (set) Token: 0x0600173D RID: 5949 RVA: 0x00002134 File Offset: 0x00000334
		public float TimeCoeff
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x0600173E RID: 5950 RVA: 0x00002145 File Offset: 0x00000345
		// (set) Token: 0x0600173F RID: 5951 RVA: 0x00002134 File Offset: 0x00000334
		public float MinTime
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x06001740 RID: 5952 RVA: 0x00002145 File Offset: 0x00000345
		// (set) Token: 0x06001741 RID: 5953 RVA: 0x00002134 File Offset: 0x00000334
		public float MaxTime
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06001742 RID: 5954 RVA: 0x000033DC File Offset: 0x000015DC
		// (set) Token: 0x06001743 RID: 5955 RVA: 0x00002134 File Offset: 0x00000334
		public Padding Padding
		{
			[CompilerGenerated]
			get
			{
				return default(Padding);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06001744 RID: 5956 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06001745 RID: 5957 RVA: 0x00002134 File Offset: 0x00000334
		public bool AnimateOnlyDifferences
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x06001746 RID: 5958 RVA: 0x00002136 File Offset: 0x00000336
		public bool IsNonLinearTransformNeeded
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x00002131 File Offset: 0x00000331
		public Animation Clone()
		{
			return null;
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x06001749 RID: 5961 RVA: 0x00002131 File Offset: 0x00000331
		public static Animation Rotate
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x0600174A RID: 5962 RVA: 0x00002131 File Offset: 0x00000331
		public static Animation HorizSlide
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x0600174B RID: 5963 RVA: 0x00002131 File Offset: 0x00000331
		public static Animation VertSlide
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x0600174C RID: 5964 RVA: 0x00002131 File Offset: 0x00000331
		public static Animation Scale
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x0600174D RID: 5965 RVA: 0x00002131 File Offset: 0x00000331
		public static Animation ScaleAndRotate
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x0600174E RID: 5966 RVA: 0x00002131 File Offset: 0x00000331
		public static Animation HorizSlideAndRotate
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x0600174F RID: 5967 RVA: 0x00002131 File Offset: 0x00000331
		public static Animation ScaleAndHorizSlide
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06001750 RID: 5968 RVA: 0x00002131 File Offset: 0x00000331
		public static Animation Transparent
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06001751 RID: 5969 RVA: 0x00002131 File Offset: 0x00000331
		public static Animation Leaf
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06001752 RID: 5970 RVA: 0x00002131 File Offset: 0x00000331
		public static Animation Mosaic
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06001753 RID: 5971 RVA: 0x00002131 File Offset: 0x00000331
		public static Animation Particles
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x06001754 RID: 5972 RVA: 0x00002131 File Offset: 0x00000331
		public static Animation VertBlind
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x06001755 RID: 5973 RVA: 0x00002131 File Offset: 0x00000331
		public static Animation HorizBlind
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x00002134 File Offset: 0x00000334
		public void Add(Animation a)
		{
		}

		// Token: 0x040009EA RID: 2538
		[CompilerGenerated]
		private PointF pointF_0;

		// Token: 0x040009EB RID: 2539
		[CompilerGenerated]
		private float float_0;

		// Token: 0x040009EC RID: 2540
		[CompilerGenerated]
		private float float_1;

		// Token: 0x040009ED RID: 2541
		[CompilerGenerated]
		private PointF pointF_1;

		// Token: 0x040009EE RID: 2542
		[CompilerGenerated]
		private float float_2;

		// Token: 0x040009EF RID: 2543
		[CompilerGenerated]
		private float float_3;

		// Token: 0x040009F0 RID: 2544
		[CompilerGenerated]
		private PointF pointF_2;

		// Token: 0x040009F1 RID: 2545
		[CompilerGenerated]
		private PointF pointF_3;

		// Token: 0x040009F2 RID: 2546
		[CompilerGenerated]
		private int int_0;

		// Token: 0x040009F3 RID: 2547
		[CompilerGenerated]
		private PointF pointF_4;

		// Token: 0x040009F4 RID: 2548
		[CompilerGenerated]
		private float float_4;

		// Token: 0x040009F5 RID: 2549
		[CompilerGenerated]
		private float float_5;

		// Token: 0x040009F6 RID: 2550
		[CompilerGenerated]
		private float float_6;

		// Token: 0x040009F7 RID: 2551
		[CompilerGenerated]
		private Padding padding_0;

		// Token: 0x040009F8 RID: 2552
		[CompilerGenerated]
		private bool bool_0;
	}
}
