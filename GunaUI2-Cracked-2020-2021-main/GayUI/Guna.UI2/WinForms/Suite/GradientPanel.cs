using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Guna.UI2.WinForms.Interfaces;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x020000AC RID: 172
	[ToolboxItem(false)]
	public class GradientPanel : Panel, IControl
	{
		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06000D52 RID: 3410 RVA: 0x00002136 File Offset: 0x00000336
		[Browsable(false)]
		[Description("Gets a value that indicates whether the Component is currently in design mode.")]
		public bool IsDesignMode
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06000D53 RID: 3411 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000D54 RID: 3412 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("Style the control's border sides.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public CustomizableEdges CustomizableEdges
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06000D55 RID: 3413 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000D56 RID: 3414 RVA: 0x00002134 File Offset: 0x00000334
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(false)]
		protected ShadowDecoration DefaultShadowDecoration
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06000D57 RID: 3415 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x06000D58 RID: 3416 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected DashStyle DefaultBorderStyle
		{
			get
			{
				return DashStyle.Solid;
			}
			set
			{
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06000D59 RID: 3417 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000D5A RID: 3418 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Color DefaultFillColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06000D5B RID: 3419 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000D5C RID: 3420 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Color DefaultFillColor2
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06000D5D RID: 3421 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000D5E RID: 3422 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Color DefaultBorderColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06000D5F RID: 3423 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000D60 RID: 3424 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected int DefaultBorderThickness
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06000D61 RID: 3425 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000D62 RID: 3426 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Color DefaultCustomBorderColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06000D63 RID: 3427 RVA: 0x000033DC File Offset: 0x000015DC
		// (set) Token: 0x06000D64 RID: 3428 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Padding DefaultCustomBorderThickness
		{
			get
			{
				return default(Padding);
			}
			set
			{
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06000D65 RID: 3429 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000D66 RID: 3430 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected int DefaultBorderRadius
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06000D67 RID: 3431 RVA: 0x0000331C File Offset: 0x0000151C
		// (set) Token: 0x06000D68 RID: 3432 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected LinearGradientMode DefaultGradientMode
		{
			get
			{
				return LinearGradientMode.Horizontal;
			}
			set
			{
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06000D6A RID: 3434 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000D6B RID: 3435 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected bool DefaultUseTransparentBackground
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0(Graphics G)
		{
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaintBackground(PaintEventArgs e)
		{
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x04000361 RID: 865
		private CustomizableEdges customizableEdges_0;

		// Token: 0x04000362 RID: 866
		private ShadowDecoration shadowDecoration_0;

		// Token: 0x04000363 RID: 867
		private Color color_0;

		// Token: 0x04000364 RID: 868
		private Color color_1;

		// Token: 0x04000365 RID: 869
		private Color color_2;

		// Token: 0x04000366 RID: 870
		private int int_0;

		// Token: 0x04000367 RID: 871
		private Color color_3;

		// Token: 0x04000368 RID: 872
		private Padding padding_0;

		// Token: 0x04000369 RID: 873
		private int int_1;

		// Token: 0x0400036A RID: 874
		private LinearGradientMode linearGradientMode_0;

		// Token: 0x0400036B RID: 875
		private DashStyle dashStyle_0;

		// Token: 0x0400036C RID: 876
		private bool bool_0;
	}
}
