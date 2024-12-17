using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Guna.UI2.AnimatorNS
{
	// Token: 0x0200018A RID: 394
	public class NonLinearTransfromNeededEventArg : EventArgs
	{
		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x060017B6 RID: 6070 RVA: 0x00002145 File Offset: 0x00000345
		// (set) Token: 0x060017B7 RID: 6071 RVA: 0x00002134 File Offset: 0x00000334
		public float CurrentTime
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x060017B8 RID: 6072 RVA: 0x0000343C File Offset: 0x0000163C
		// (set) Token: 0x060017B9 RID: 6073 RVA: 0x00002134 File Offset: 0x00000334
		public Rectangle ClientRectangle
		{
			[CompilerGenerated]
			get
			{
				return default(Rectangle);
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x060017BA RID: 6074 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060017BB RID: 6075 RVA: 0x00002134 File Offset: 0x00000334
		public byte[] Pixels
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x060017BC RID: 6076 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060017BD RID: 6077 RVA: 0x00002134 File Offset: 0x00000334
		public int Stride
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x060017BE RID: 6078 RVA: 0x0000343C File Offset: 0x0000163C
		// (set) Token: 0x060017BF RID: 6079 RVA: 0x00002134 File Offset: 0x00000334
		public Rectangle SourceClientRectangle
		{
			[CompilerGenerated]
			get
			{
				return default(Rectangle);
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x060017C0 RID: 6080 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060017C1 RID: 6081 RVA: 0x00002134 File Offset: 0x00000334
		public byte[] SourcePixels
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x060017C2 RID: 6082 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060017C3 RID: 6083 RVA: 0x00002134 File Offset: 0x00000334
		public int SourceStride
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

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x060017C4 RID: 6084 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060017C5 RID: 6085 RVA: 0x00002134 File Offset: 0x00000334
		public Animation Animation
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x060017C6 RID: 6086 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060017C7 RID: 6087 RVA: 0x00002134 File Offset: 0x00000334
		public Control Control
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x060017C8 RID: 6088 RVA: 0x000068EC File Offset: 0x00004AEC
		// (set) Token: 0x060017C9 RID: 6089 RVA: 0x00002134 File Offset: 0x00000334
		public AnimateMode Mode
		{
			[CompilerGenerated]
			get
			{
				return AnimateMode.Show;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x060017CA RID: 6090 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060017CB RID: 6091 RVA: 0x00002134 File Offset: 0x00000334
		public bool UseDefaultTransform
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

		// Token: 0x04000A37 RID: 2615
		[CompilerGenerated]
		private float float_0;

		// Token: 0x04000A38 RID: 2616
		[CompilerGenerated]
		private Rectangle rectangle_0;

		// Token: 0x04000A39 RID: 2617
		[CompilerGenerated]
		private byte[] byte_0;

		// Token: 0x04000A3A RID: 2618
		[CompilerGenerated]
		private int int_0;

		// Token: 0x04000A3B RID: 2619
		[CompilerGenerated]
		private Rectangle rectangle_1;

		// Token: 0x04000A3C RID: 2620
		[CompilerGenerated]
		private byte[] byte_1;

		// Token: 0x04000A3D RID: 2621
		[CompilerGenerated]
		private int int_1;

		// Token: 0x04000A3E RID: 2622
		[CompilerGenerated]
		private Animation animation_0;

		// Token: 0x04000A3F RID: 2623
		[CompilerGenerated]
		private Control control_0;

		// Token: 0x04000A40 RID: 2624
		[CompilerGenerated]
		private AnimateMode animateMode_0;

		// Token: 0x04000A41 RID: 2625
		[CompilerGenerated]
		private bool bool_0;
	}
}
