using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using Guna.UI2.WinForms.Enums;
using Guna.UI2.WinForms.Interfaces;
using Guna.UI2.WinForms.Suite;

namespace Guna.UI2.WinForms
{
	// Token: 0x0200003D RID: 61
	[Description("Guna chip control")]
	public class Guna2Chip : Control, IControl
	{
		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000356 RID: 854 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000357 RID: 855 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
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

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000358 RID: 856 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000359 RID: 857 RVA: 0x00002134 File Offset: 0x00000334
		[Description("If true, the border on the control is rounded off automatically")]
		[Browsable(true)]
		[DefaultValue(false)]
		public bool AutoRoundedCorners
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnResize(EventArgs e)
		{
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0()
		{
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600035C RID: 860 RVA: 0x00002136 File Offset: 0x00000336
		[Description("Gets a value that indicates whether the Component is currently in design mode.")]
		[Browsable(false)]
		public bool IsDesignMode
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x0600035D RID: 861 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x0600035E RID: 862 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The css-like style of the border. You can customize the border to meet your design needs")]
		[Browsable(true)]
		[DefaultValue(DashStyle.Solid)]
		public DashStyle BorderStyle
		{
			get
			{
				return DashStyle.Solid;
			}
			set
			{
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600035F RID: 863 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000360 RID: 864 RVA: 0x00002134 File Offset: 0x00000334
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(true)]
		[Description("Shadow property of the control to add and customize a control's shadow")]
		public ShadowDecoration ShadowDecoration
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000361 RID: 865 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000362 RID: 866 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The BackColor that will fill the control")]
		[Browsable(true)]
		[DefaultValue(typeof(Color), "255, 77, 165")]
		public Color FillColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000363 RID: 867 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000364 RID: 868 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "")]
		[Browsable(true)]
		[Description("The control's border color")]
		public Color BorderColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000365 RID: 869 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000366 RID: 870 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The border thickness. The higher the value, the thicker the border")]
		[DefaultValue(0)]
		[Browsable(true)]
		public int BorderThickness
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000367 RID: 871 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000368 RID: 872 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(0)]
		[Description("The curve angle of the control on all angles")]
		public int BorderRadius
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000369 RID: 873 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600036A RID: 874 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("If true, the background will allow a transparent color")]
		[DefaultValue(false)]
		public bool UseTransparentBackground
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600036B RID: 875 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x0600036C RID: 876 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Gets or sets the text asociated with this control.")]
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

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600036D RID: 877 RVA: 0x00003840 File Offset: 0x00001A40
		// (set) Token: 0x0600036E RID: 878 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The control's text alignment")]
		[Browsable(true)]
		[DefaultValue(2)]
		public HorizontalAlignment TextAlign
		{
			get
			{
				return HorizontalAlignment.Left;
			}
			set
			{
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x0600036F RID: 879 RVA: 0x00003858 File Offset: 0x00001A58
		// (set) Token: 0x06000370 RID: 880 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The control's text transform property which allows you to change the appearance of the text")]
		[Browsable(true)]
		[DefaultValue(0)]
		public TextTransform TextTransform
		{
			get
			{
				return TextTransform.None;
			}
			set
			{
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000371 RID: 881 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x06000372 RID: 882 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The control's text position")]
		[DefaultValue(typeof(Point), "0, 0")]
		[Browsable(true)]
		public Point TextOffset
		{
			get
			{
				return default(Point);
			}
			set
			{
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000373 RID: 883 RVA: 0x0000346C File Offset: 0x0000166C
		// (set) Token: 0x06000374 RID: 884 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("This property allows you to change how text is printed onto the control")]
		[DefaultValue(5)]
		public TextRenderingHint TextRenderingHint
		{
			get
			{
				return TextRenderingHint.SystemDefault;
			}
			set
			{
			}
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00002134 File Offset: 0x00000334
		private void method_1(Graphics G)
		{
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaintBackground(PaintEventArgs e)
		{
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x040000C1 RID: 193
		private CustomizableEdges customizableEdges_0;

		// Token: 0x040000C2 RID: 194
		private bool bool_0;

		// Token: 0x040000C3 RID: 195
		private int int_0;

		// Token: 0x040000C4 RID: 196
		private DashStyle dashStyle_0;

		// Token: 0x040000C5 RID: 197
		private ShadowDecoration shadowDecoration_0;

		// Token: 0x040000C6 RID: 198
		private Color color_0;

		// Token: 0x040000C7 RID: 199
		private Color color_1;

		// Token: 0x040000C8 RID: 200
		private int int_1;

		// Token: 0x040000C9 RID: 201
		private int int_2;

		// Token: 0x040000CA RID: 202
		private bool bool_1;

		// Token: 0x040000CB RID: 203
		private HorizontalAlignment horizontalAlignment_0;

		// Token: 0x040000CC RID: 204
		private TextTransform textTransform_0;

		// Token: 0x040000CD RID: 205
		private Point point_0;

		// Token: 0x040000CE RID: 206
		private TextRenderingHint textRenderingHint_0;
	}
}
