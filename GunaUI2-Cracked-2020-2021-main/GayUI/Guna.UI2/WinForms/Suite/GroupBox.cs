using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using Guna.UI2.WinForms.Enums;
using Guna.UI2.WinForms.Interfaces;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x020000AD RID: 173
	[ToolboxItem(false)]
	public class GroupBox : ContainerControl, IControl
	{
		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06000D6F RID: 3439 RVA: 0x00002136 File Offset: 0x00000336
		[Browsable(false)]
		[Description("Gets a value that indicates whether the Component is currently in design mode.")]
		public bool IsDesignMode
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06000D70 RID: 3440 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000D71 RID: 3441 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06000D72 RID: 3442 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000D73 RID: 3443 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06000D74 RID: 3444 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000D75 RID: 3445 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06000D76 RID: 3446 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000D77 RID: 3447 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06000D78 RID: 3448 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000D79 RID: 3449 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06000D7A RID: 3450 RVA: 0x000033DC File Offset: 0x000015DC
		// (set) Token: 0x06000D7B RID: 3451 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06000D7C RID: 3452 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000D7D RID: 3453 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06000D7E RID: 3454 RVA: 0x0000346C File Offset: 0x0000166C
		// (set) Token: 0x06000D7F RID: 3455 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected TextRenderingHint DefaultTextRenderingHint
		{
			get
			{
				return TextRenderingHint.SystemDefault;
			}
			set
			{
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06000D80 RID: 3456 RVA: 0x00003840 File Offset: 0x00001A40
		// (set) Token: 0x06000D81 RID: 3457 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected HorizontalAlignment DefaultTextAlign
		{
			get
			{
				return HorizontalAlignment.Left;
			}
			set
			{
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06000D82 RID: 3458 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x06000D83 RID: 3459 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06000D84 RID: 3460 RVA: 0x00003858 File Offset: 0x00001A58
		// (set) Token: 0x06000D85 RID: 3461 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected TextTransform DefaultTextTransform
		{
			get
			{
				return TextTransform.None;
			}
			set
			{
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06000D86 RID: 3462 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000D87 RID: 3463 RVA: 0x00002134 File Offset: 0x00000334
		[Localizable(true)]
		[Category("Options")]
		public override string Text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06000D88 RID: 3464 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x06000D89 RID: 3465 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Point DefaultTextOffset
		{
			get
			{
				return default(Point);
			}
			set
			{
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06000D8B RID: 3467 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000D8C RID: 3468 RVA: 0x00002134 File Offset: 0x00000334
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(true)]
		[Description("Style the control's border sides.")]
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

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06000D8D RID: 3469 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000D8E RID: 3470 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06000D8F RID: 3471 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0(Graphics G)
		{
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaintBackground(PaintEventArgs e)
		{
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnResize(EventArgs e)
		{
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x0400036D RID: 877
		private ShadowDecoration shadowDecoration_0;

		// Token: 0x0400036E RID: 878
		private Color color_0;

		// Token: 0x0400036F RID: 879
		private Color color_1;

		// Token: 0x04000370 RID: 880
		private int int_0;

		// Token: 0x04000371 RID: 881
		private Padding padding_0;

		// Token: 0x04000372 RID: 882
		private Color color_2;

		// Token: 0x04000373 RID: 883
		private int int_1;

		// Token: 0x04000374 RID: 884
		private TextRenderingHint textRenderingHint_0;

		// Token: 0x04000375 RID: 885
		private HorizontalAlignment horizontalAlignment_0;

		// Token: 0x04000376 RID: 886
		private DashStyle dashStyle_0;

		// Token: 0x04000377 RID: 887
		private TextTransform textTransform_0;

		// Token: 0x04000378 RID: 888
		private Point point_0;

		// Token: 0x04000379 RID: 889
		private CustomizableEdges customizableEdges_0;

		// Token: 0x0400037A RID: 890
		private bool bool_0;
	}
}
