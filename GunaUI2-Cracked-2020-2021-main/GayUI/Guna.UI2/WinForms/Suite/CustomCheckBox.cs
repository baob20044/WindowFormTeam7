using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.Material.Animation;
using Guna.UI2.WinForms.Enums;
using Guna.UI2.WinForms.Interfaces;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x020000A8 RID: 168
	[DefaultEvent("CheckedChanged")]
	[ToolboxItem(false)]
	public class CustomCheckBox : Control, IControl
	{
		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000C92 RID: 3218 RVA: 0x00002136 File Offset: 0x00000336
		[Browsable(false)]
		[Description("Gets a value that indicates whether the Component is currently in design mode.")]
		public bool IsDesignMode
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000C93 RID: 3219 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000C94 RID: 3220 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Style the control's border sides.")]
		[Browsable(true)]
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

		// Token: 0x06000C95 RID: 3221 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0()
		{
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x00002134 File Offset: 0x00000334
		private void method_1(object sender)
		{
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000C97 RID: 3223 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000C98 RID: 3224 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000C99 RID: 3225 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000C9A RID: 3226 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06000C9B RID: 3227 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x06000C9C RID: 3228 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06000C9D RID: 3229 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000C9E RID: 3230 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Color DefaultCheckMarkColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06000C9F RID: 3231 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000CA0 RID: 3232 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06000CA1 RID: 3233 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseDown(MouseEventArgs e)
		{
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseUp(MouseEventArgs e)
		{
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseEnter(EventArgs e)
		{
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseLeave(EventArgs e)
		{
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnLostFocus(EventArgs e)
		{
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06000CA6 RID: 3238 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000CA7 RID: 3239 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06000CA8 RID: 3240 RVA: 0x00002134 File Offset: 0x00000334
		private void method_2(Graphics G)
		{
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaintBackground(PaintEventArgs e)
		{
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06000CAB RID: 3243 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected CustomCheckBoxState DefaultCheckedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000CAC RID: 3244 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected CustomCheckBoxState DefaultUncheckedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x06000CAD RID: 3245 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000CAE RID: 3246 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06000CAF RID: 3247 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected virtual void OnCheckedChanged(EventArgs e)
		{
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnClick(EventArgs e)
		{
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x00002131 File Offset: 0x00000331
		private Bitmap method_3(Color color, int width, int height)
		{
			return null;
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x00002131 File Offset: 0x00000331
		private Bitmap method_4()
		{
			return null;
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x00002134 File Offset: 0x00000334
		private void method_5(Graphics G, CustomCheckBoxState appearance)
		{
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x0400031B RID: 795
		private CustomizableEdges customizableEdges_0;

		// Token: 0x0400031C RID: 796
		private AnimationManager animationManager_0;

		// Token: 0x0400031D RID: 797
		private bool bool_0;

		// Token: 0x0400031E RID: 798
		private bool bool_1;

		// Token: 0x0400031F RID: 799
		private DashStyle dashStyle_0;

		// Token: 0x04000320 RID: 800
		private Color color_0;

		// Token: 0x04000321 RID: 801
		private ShadowDecoration shadowDecoration_0;

		// Token: 0x04000322 RID: 802
		private bool bool_2;

		// Token: 0x04000323 RID: 803
		internal bool bool_3;

		// Token: 0x04000324 RID: 804
		internal bool bool_4;

		// Token: 0x04000325 RID: 805
		internal MouseState mouseState_0;

		// Token: 0x04000326 RID: 806
		private bool bool_5;

		// Token: 0x04000327 RID: 807
		private CustomCheckBoxState customCheckBoxState_0;

		// Token: 0x04000328 RID: 808
		private CustomCheckBoxState customCheckBoxState_1;
	}
}
