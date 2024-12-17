using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.Material.Animation;
using Guna.UI2.WinForms.Enums;
using Guna.UI2.WinForms.Interfaces;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x020000A7 RID: 167
	[ToolboxItem(false)]
	public class CustomButtonBase : Control, IButtonControl, IControl
	{
		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000C41 RID: 3137 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000C42 RID: 3138 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		public new bool AutoSize
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0()
		{
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x00003364 File Offset: 0x00001564
		private Size method_1()
		{
			return default(Size);
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x00003364 File Offset: 0x00001564
		public override Size GetPreferredSize(Size proposedSize)
		{
			return default(Size);
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x00002134 File Offset: 0x00000334
		protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
		{
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000C48 RID: 3144 RVA: 0x00002136 File Offset: 0x00000336
		[Description("Gets a value that indicates whether the Component is currently in design mode.")]
		[Browsable(false)]
		public bool IsDesignMode
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000C49 RID: 3145 RVA: 0x00003ADC File Offset: 0x00001CDC
		// (set) Token: 0x06000C4A RID: 3146 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(0)]
		public DialogResult DialogResult
		{
			get
			{
				return DialogResult.None;
			}
			set
			{
			}
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x00002134 File Offset: 0x00000334
		public void NotifyDefault(bool value)
		{
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x00002134 File Offset: 0x00000334
		public void PerformClick()
		{
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000C4D RID: 3149 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000C4E RID: 3150 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06000C4F RID: 3151 RVA: 0x00002134 File Offset: 0x00000334
		protected void InitializeAnimationManager()
		{
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x00002134 File Offset: 0x00000334
		private void method_2(object sender)
		{
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x00002134 File Offset: 0x00000334
		private void method_3(object sender)
		{
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x00002134 File Offset: 0x00000334
		private void method_4(object sender)
		{
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x00002134 File Offset: 0x00000334
		private void method_5()
		{
		}

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x06000C54 RID: 3156 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000C55 RID: 3157 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler CheckedChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected virtual void OnCheckedChanged(EventArgs e)
		{
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000C57 RID: 3159 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000C58 RID: 3160 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06000C59 RID: 3161 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000C5A RID: 3162 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06000C5B RID: 3163 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x06000C5C RID: 3164 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000C5D RID: 3165 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000C5E RID: 3166 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000C5F RID: 3167 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000C60 RID: 3168 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000C61 RID: 3169 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000C62 RID: 3170 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000C63 RID: 3171 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000C64 RID: 3172 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Image DefaultImage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06000C65 RID: 3173 RVA: 0x00003364 File Offset: 0x00001564
		// (set) Token: 0x06000C66 RID: 3174 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Size DefaultImageSize
		{
			get
			{
				return default(Size);
			}
			set
			{
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000C67 RID: 3175 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x06000C68 RID: 3176 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Point DefaultImageOffset
		{
			get
			{
				return default(Point);
			}
			set
			{
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000C69 RID: 3177 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x06000C6A RID: 3178 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000C6B RID: 3179 RVA: 0x00003840 File Offset: 0x00001A40
		// (set) Token: 0x06000C6C RID: 3180 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06000C6D RID: 3181 RVA: 0x00003840 File Offset: 0x00001A40
		// (set) Token: 0x06000C6E RID: 3182 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected HorizontalAlignment DefaultImageAlign
		{
			get
			{
				return HorizontalAlignment.Left;
			}
			set
			{
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06000C6F RID: 3183 RVA: 0x0000346C File Offset: 0x0000166C
		// (set) Token: 0x06000C70 RID: 3184 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000C71 RID: 3185 RVA: 0x00003858 File Offset: 0x00001A58
		// (set) Token: 0x06000C72 RID: 3186 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000C73 RID: 3187 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000C74 RID: 3188 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected bool DefaultTile
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06000C75 RID: 3189 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000C76 RID: 3190 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000C78 RID: 3192 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected bool DefaultChecked
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000C79 RID: 3193 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000C7A RID: 3194 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000C7B RID: 3195 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000C7C RID: 3196 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06000C7D RID: 3197 RVA: 0x000033DC File Offset: 0x000015DC
		// (set) Token: 0x06000C7E RID: 3198 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06000C7F RID: 3199 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000C80 RID: 3200 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Color DefaultPressedColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000C81 RID: 3201 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000C82 RID: 3202 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected int DefaultPressedDepth
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000C83 RID: 3203 RVA: 0x00003304 File Offset: 0x00001504
		// (set) Token: 0x06000C84 RID: 3204 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected ButtonMode DefaultButtonMode
		{
			get
			{
				return ButtonMode.DefaultButton;
			}
			set
			{
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000C85 RID: 3205 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000C86 RID: 3206 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		[Description("Set the use of transfarant backgroud on this control.")]
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

		// Token: 0x06000C87 RID: 3207 RVA: 0x00002134 File Offset: 0x00000334
		private void method_6(Graphics G)
		{
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaintBackground(PaintEventArgs e)
		{
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnResize(EventArgs e)
		{
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnGotFocus(EventArgs e)
		{
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnLostFocus(EventArgs e)
		{
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseDown(MouseEventArgs e)
		{
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseUp(MouseEventArgs e)
		{
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseEnter(EventArgs e)
		{
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseLeave(EventArgs e)
		{
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnKeyDown(KeyEventArgs kevent)
		{
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnClick(EventArgs e)
		{
		}

		// Token: 0x040002FA RID: 762
		private Graphics graphics_0;

		// Token: 0x040002FB RID: 763
		private DialogResult dialogResult_0;

		// Token: 0x040002FC RID: 764
		protected AnimationManager AnimationManager;

		// Token: 0x040002FD RID: 765
		protected AnimationManager HoveredAnimationManager;

		// Token: 0x040002FE RID: 766
		protected AnimationManager CheckedAnimationManager;

		// Token: 0x04000300 RID: 768
		private Color color_0;

		// Token: 0x04000301 RID: 769
		private int int_0;

		// Token: 0x04000302 RID: 770
		private DashStyle dashStyle_0;

		// Token: 0x04000303 RID: 771
		private Color color_1;

		// Token: 0x04000304 RID: 772
		private int int_1;

		// Token: 0x04000305 RID: 773
		private ShadowDecoration shadowDecoration_0;

		// Token: 0x04000306 RID: 774
		private Image image_0;

		// Token: 0x04000307 RID: 775
		private Size size_0;

		// Token: 0x04000308 RID: 776
		private Point point_0;

		// Token: 0x04000309 RID: 777
		private Point point_1;

		// Token: 0x0400030A RID: 778
		private HorizontalAlignment horizontalAlignment_0;

		// Token: 0x0400030B RID: 779
		private HorizontalAlignment horizontalAlignment_1;

		// Token: 0x0400030C RID: 780
		private TextRenderingHint textRenderingHint_0;

		// Token: 0x0400030D RID: 781
		private TextTransform textTransform_0;

		// Token: 0x0400030E RID: 782
		private bool bool_0;

		// Token: 0x0400030F RID: 783
		private bool bool_1;

		// Token: 0x04000310 RID: 784
		internal bool bool_2;

		// Token: 0x04000311 RID: 785
		private bool bool_3;

		// Token: 0x04000312 RID: 786
		private Color color_2;

		// Token: 0x04000313 RID: 787
		private Color color_3;

		// Token: 0x04000314 RID: 788
		private Padding padding_0;

		// Token: 0x04000315 RID: 789
		private Color color_4;

		// Token: 0x04000316 RID: 790
		private int int_2;

		// Token: 0x04000317 RID: 791
		private ButtonMode buttonMode_0;

		// Token: 0x04000318 RID: 792
		private bool bool_4;

		// Token: 0x04000319 RID: 793
		private bool bool_5;

		// Token: 0x0400031A RID: 794
		internal MouseState mouseState_0;
	}
}
