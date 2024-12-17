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
	// Token: 0x020000AA RID: 170
	[DefaultEvent("CheckedChanged")]
	[ToolboxItem(false)]
	public class CustomRadioButton : Control, IControl
	{
		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06000CD5 RID: 3285 RVA: 0x00002136 File Offset: 0x00000336
		[Description("Gets a value that indicates whether the Component is currently in design mode.")]
		[Browsable(false)]
		public bool IsDesignMode
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0()
		{
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x00002134 File Offset: 0x00000334
		private void method_1()
		{
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x00002134 File Offset: 0x00000334
		private void method_2(object sender)
		{
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06000CDA RID: 3290 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected CustomRadionButtonState DefaultCheckedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06000CDB RID: 3291 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected CustomRadionButtonState DefaultUncheckedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06000CDC RID: 3292 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000CDD RID: 3293 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06000CDE RID: 3294 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000CDF RID: 3295 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06000CE0 RID: 3296 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x06000CE1 RID: 3297 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06000CE2 RID: 3298 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000CE3 RID: 3299 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06000CE4 RID: 3300 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseDown(MouseEventArgs e)
		{
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseUp(MouseEventArgs e)
		{
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseEnter(EventArgs e)
		{
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseLeave(EventArgs e)
		{
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnLostFocus(EventArgs e)
		{
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000CEA RID: 3306 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06000CEB RID: 3307 RVA: 0x00002134 File Offset: 0x00000334
		private void method_3(Graphics G)
		{
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaintBackground(PaintEventArgs e)
		{
		}

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x06000CED RID: 3309 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000CEE RID: 3310 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06000CEF RID: 3311 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected virtual void OnCheckedChanged(EventArgs e)
		{
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnClick(EventArgs e)
		{
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x00002134 File Offset: 0x00000334
		private void method_4(Graphics G, CustomRadionButtonState appearance)
		{
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x04000338 RID: 824
		private AnimationManager animationManager_0;

		// Token: 0x04000339 RID: 825
		private CustomRadionButtonState customRadionButtonState_0;

		// Token: 0x0400033A RID: 826
		private CustomRadionButtonState customRadionButtonState_1;

		// Token: 0x0400033B RID: 827
		private bool bool_0;

		// Token: 0x0400033C RID: 828
		private bool bool_1;

		// Token: 0x0400033D RID: 829
		private DashStyle dashStyle_0;

		// Token: 0x0400033E RID: 830
		private ShadowDecoration shadowDecoration_0;

		// Token: 0x0400033F RID: 831
		private bool bool_2;

		// Token: 0x04000340 RID: 832
		internal bool bool_3;

		// Token: 0x04000341 RID: 833
		internal bool bool_4;

		// Token: 0x04000342 RID: 834
		internal MouseState mouseState_0;

		// Token: 0x04000343 RID: 835
		private bool bool_5;
	}
}
