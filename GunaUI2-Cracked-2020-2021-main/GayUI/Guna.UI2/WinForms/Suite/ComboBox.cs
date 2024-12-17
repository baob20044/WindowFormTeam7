using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using Guna.UI2.Material.Animation;
using Guna.UI2.WinForms.Enums;
using Guna.UI2.WinForms.Interfaces;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x020000A5 RID: 165
	[ToolboxItem(false)]
	public class ComboBox : ComboBox, IControl
	{
		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06000BDB RID: 3035 RVA: 0x00002136 File Offset: 0x00000336
		[Description("Gets a value that indicates whether the Component is currently in design mode.")]
		[Browsable(false)]
		public bool IsDesignMode
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06000BDD RID: 3037 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000BDE RID: 3038 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06000BDF RID: 3039 RVA: 0x00003840 File Offset: 0x00001A40
		// (set) Token: 0x06000BE0 RID: 3040 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(HorizontalAlignment.Left)]
		[Description("Gets or sets how text is aligned in a TextBox control.")]
		[Browsable(true)]
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

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06000BE1 RID: 3041 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected ComboBoxItemsAppearance DefaultItemsAppearance
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06000BE2 RID: 3042 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected ComboBoxState DefaultHoverState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06000BE3 RID: 3043 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected ComboBoxState DefaultFocusedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06000BE4 RID: 3044 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000BE5 RID: 3045 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
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

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06000BE6 RID: 3046 RVA: 0x0000346C File Offset: 0x0000166C
		// (set) Token: 0x06000BE7 RID: 3047 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06000BE8 RID: 3048 RVA: 0x00003858 File Offset: 0x00001A58
		// (set) Token: 0x06000BE9 RID: 3049 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06000BEA RID: 3050 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000BEB RID: 3051 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06000BEC RID: 3052 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000BED RID: 3053 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected int DefaultStartIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000BEF RID: 3055 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06000BF0 RID: 3056 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000BF1 RID: 3057 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000BF3 RID: 3059 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Color DefaultFocusedColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06000BF4 RID: 3060 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000BF5 RID: 3061 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06000BF6 RID: 3062 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x06000BF7 RID: 3063 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000BF8 RID: 3064 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000BF9 RID: 3065 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected bool DefaultAnimated
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0()
		{
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x00002134 File Offset: 0x00000334
		private void method_1(object sender)
		{
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x00002134 File Offset: 0x00000334
		private void method_2(object sender)
		{
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseDown(MouseEventArgs e)
		{
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseUp(MouseEventArgs e)
		{
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x00002134 File Offset: 0x00000334
		private void method_3(MouseState m)
		{
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x00002134 File Offset: 0x00000334
		private void method_4(bool m)
		{
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseEnter(EventArgs e)
		{
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseLeave(EventArgs e)
		{
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnLostFocus(EventArgs e)
		{
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnGotFocus(EventArgs e)
		{
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_5()
		{
			return default(Color);
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_6()
		{
			return default(Color);
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x00002131 File Offset: 0x00000331
		private Font method_7()
		{
			return null;
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x00002131 File Offset: 0x00000331
		private Font method_8()
		{
			return null;
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_9()
		{
			return default(Color);
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_10()
		{
			return default(Color);
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_11()
		{
			return default(Color);
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_12()
		{
			return default(Color);
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_13()
		{
			return default(Color);
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x00002131 File Offset: 0x00000331
		private Font method_14()
		{
			return null;
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x00002131 File Offset: 0x00000331
		private Font method_15()
		{
			return null;
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x00002131 File Offset: 0x00000331
		private Bitmap method_16(Color color)
		{
			return null;
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x00002131 File Offset: 0x00000331
		private string method_17(string s)
		{
			return null;
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06000C12 RID: 3090 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x06000C13 RID: 3091 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000C14 RID: 3092 RVA: 0x00003978 File Offset: 0x00001B78
		// (set) Token: 0x06000C15 RID: 3093 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected TextBoxStyle DefaultStyle
		{
			get
			{
				return TextBoxStyle.Default;
			}
			set
			{
			}
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnDrawItem(DrawItemEventArgs e)
		{
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x00002134 File Offset: 0x00000334
		private void method_18(Graphics G)
		{
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x040002D7 RID: 727
		private TextRenderingHint textRenderingHint_0;

		// Token: 0x040002D8 RID: 728
		private TextTransform textTransform_0;

		// Token: 0x040002D9 RID: 729
		private int int_0;

		// Token: 0x040002DA RID: 730
		private int int_1;

		// Token: 0x040002DB RID: 731
		private Color color_0;

		// Token: 0x040002DC RID: 732
		private Color color_1;

		// Token: 0x040002DD RID: 733
		private int int_2;

		// Token: 0x040002DE RID: 734
		private MouseState mouseState_0;

		// Token: 0x040002DF RID: 735
		private GraphicsPath graphicsPath_0;

		// Token: 0x040002E0 RID: 736
		private CustomizableEdges customizableEdges_0;

		// Token: 0x040002E1 RID: 737
		private HorizontalAlignment horizontalAlignment_0;

		// Token: 0x040002E2 RID: 738
		private ComboBoxItemsAppearance comboBoxItemsAppearance_0;

		// Token: 0x040002E3 RID: 739
		private ComboBoxState comboBoxState_0;

		// Token: 0x040002E4 RID: 740
		private ComboBoxState comboBoxState_1;

		// Token: 0x040002E5 RID: 741
		private ShadowDecoration shadowDecoration_0;

		// Token: 0x040002E6 RID: 742
		private DashStyle dashStyle_0;

		// Token: 0x040002E7 RID: 743
		private bool bool_0;

		// Token: 0x040002E8 RID: 744
		private AnimationManager animationManager_0;

		// Token: 0x040002E9 RID: 745
		private AnimationManager animationManager_1;

		// Token: 0x040002EA RID: 746
		private bool bool_1;

		// Token: 0x040002EB RID: 747
		private Point point_0;

		// Token: 0x040002EC RID: 748
		private TextBoxStyle textBoxStyle_0;
	}
}
