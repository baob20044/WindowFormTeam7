using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Guna.UI2.WinForms.Interfaces;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x020000A9 RID: 169
	[ToolboxItem(false)]
	public class CustomGradientPanel : Panel, IControl
	{
		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x00002136 File Offset: 0x00000336
		[Browsable(false)]
		[Description("Gets a value that indicates whether the Component is currently in design mode.")]
		public bool IsDesignMode
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000CB6 RID: 3254 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000CB7 RID: 3255 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000CB9 RID: 3257 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06000CBA RID: 3258 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000CBB RID: 3259 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06000CBC RID: 3260 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000CBD RID: 3261 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Color DefaultFillColor3
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06000CBE RID: 3262 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000CBF RID: 3263 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Color DefaultFillColor4
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06000CC0 RID: 3264 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000CC1 RID: 3265 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected int DefaultQuality
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x06000CC3 RID: 3267 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06000CC4 RID: 3268 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000CC5 RID: 3269 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06000CC6 RID: 3270 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000CC7 RID: 3271 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06000CC8 RID: 3272 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000CC9 RID: 3273 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06000CCA RID: 3274 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000CCB RID: 3275 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06000CCC RID: 3276 RVA: 0x000033DC File Offset: 0x000015DC
		// (set) Token: 0x06000CCD RID: 3277 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06000CCE RID: 3278 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000CCF RID: 3279 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06000CD0 RID: 3280 RVA: 0x00002131 File Offset: 0x00000331
		private Image method_0()
		{
			return null;
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnResize(EventArgs e)
		{
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x00002134 File Offset: 0x00000334
		private void method_1()
		{
		}

		// Token: 0x0400032A RID: 810
		private ShadowDecoration shadowDecoration_0;

		// Token: 0x0400032B RID: 811
		private Color color_0;

		// Token: 0x0400032C RID: 812
		private int int_0;

		// Token: 0x0400032D RID: 813
		private Color color_1;

		// Token: 0x0400032E RID: 814
		private Padding padding_0;

		// Token: 0x0400032F RID: 815
		private int int_1;

		// Token: 0x04000330 RID: 816
		private Image image_0;

		// Token: 0x04000331 RID: 817
		private CustomizableEdges customizableEdges_0;

		// Token: 0x04000332 RID: 818
		private Color color_2;

		// Token: 0x04000333 RID: 819
		private Color color_3;

		// Token: 0x04000334 RID: 820
		private Color color_4;

		// Token: 0x04000335 RID: 821
		private Color color_5;

		// Token: 0x04000336 RID: 822
		private int int_2;

		// Token: 0x04000337 RID: 823
		private DashStyle dashStyle_0;
	}
}
