using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.Material.Animation;
using Guna.UI2.WinForms.Enums;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x020000A6 RID: 166
	[ToolboxItem(false)]
	public class ControlBox : UIDefaultControl
	{
		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000C1A RID: 3098 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected ControlBoxState DefaultHoverState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000C1B RID: 3099 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000C1C RID: 3100 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000C1D RID: 3101 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000C1E RID: 3102 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000C1F RID: 3103 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000C20 RID: 3104 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Color DefaultIconColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000C21 RID: 3105 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000C22 RID: 3106 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000C23 RID: 3107 RVA: 0x00002145 File Offset: 0x00000345
		// (set) Token: 0x06000C24 RID: 3108 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected float DefaultCustomIconSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000C25 RID: 3109 RVA: 0x00003990 File Offset: 0x00001B90
		// (set) Token: 0x06000C26 RID: 3110 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected ControlBoxType DefaultControlBoxType
		{
			get
			{
				return ControlBoxType.MinimizeBox;
			}
			set
			{
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000C27 RID: 3111 RVA: 0x000039A8 File Offset: 0x00001BA8
		// (set) Token: 0x06000C28 RID: 3112 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected ControlBoxStyle DefaultControlBoxStyle
		{
			get
			{
				return ControlBoxStyle.Windows10;
			}
			set
			{
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000C29 RID: 3113 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000C2A RID: 3114 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000C2B RID: 3115 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000C2C RID: 3116 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000C2D RID: 3117 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000C2E RID: 3118 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected bool DefaultShowIcon
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000C2F RID: 3119 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000C30 RID: 3120 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(false)]
		protected bool DefaultCustomClick
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

		// Token: 0x06000C31 RID: 3121 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_1()
		{
			return default(Color);
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_2()
		{
			return default(Color);
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_3()
		{
			return default(Color);
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x00002134 File Offset: 0x00000334
		private void method_4()
		{
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x00002134 File Offset: 0x00000334
		private void method_5(object sender)
		{
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseUp(MouseEventArgs e)
		{
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseEnter(EventArgs e)
		{
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseLeave(EventArgs e)
		{
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnClick(EventArgs e)
		{
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x00002134 File Offset: 0x00000334
		public void PerformClick()
		{
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseDown(MouseEventArgs e)
		{
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnKeyDown(KeyEventArgs e)
		{
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x00002131 File Offset: 0x00000331
		private Image method_6(Color color, Color bg)
		{
			return null;
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x00002134 File Offset: 0x00000334
		private void method_7(Graphics G)
		{
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x00002134 File Offset: 0x00000334
		private void method_8()
		{
		}

		// Token: 0x040002ED RID: 749
		private ControlBoxState controlBoxState_0;

		// Token: 0x040002EE RID: 750
		private CustomizableEdges customizableEdges_0;

		// Token: 0x040002EF RID: 751
		private Color color_1;

		// Token: 0x040002F0 RID: 752
		private Color color_2;

		// Token: 0x040002F1 RID: 753
		private bool bool_5;

		// Token: 0x040002F2 RID: 754
		private Font font_0;

		// Token: 0x040002F3 RID: 755
		private ControlBoxType controlBoxType_0;

		// Token: 0x040002F4 RID: 756
		private ControlBoxStyle controlBoxStyle_0;

		// Token: 0x040002F5 RID: 757
		private Color color_3;

		// Token: 0x040002F6 RID: 758
		private int int_2;

		// Token: 0x040002F7 RID: 759
		private bool bool_6;

		// Token: 0x040002F8 RID: 760
		[CompilerGenerated]
		private bool bool_7;

		// Token: 0x040002F9 RID: 761
		private AnimationManager animationManager_0;
	}
}
