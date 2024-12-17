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
	// Token: 0x020000C0 RID: 192
	[DefaultEvent("CheckedChanged")]
	[ToolboxItem(false)]
	public class ToggleSwitch : Control, IControl
	{
		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06001057 RID: 4183 RVA: 0x00002136 File Offset: 0x00000336
		[Description("Gets a value that indicates whether the Component is currently in design mode.")]
		[Browsable(false)]
		public bool IsDesignMode
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06001058 RID: 4184 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06001059 RID: 4185 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x0600105A RID: 4186 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0()
		{
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x00002134 File Offset: 0x00000334
		private void method_1(object sender)
		{
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x0600105C RID: 4188 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected ToggleSwitchState DefaultCheckedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x0600105D RID: 4189 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected ToggleSwitchState DefaultUncheckedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x0600105E RID: 4190 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600105F RID: 4191 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06001060 RID: 4192 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x06001061 RID: 4193 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06001062 RID: 4194 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06001063 RID: 4195 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06001064 RID: 4196 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06001065 RID: 4197 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06001066 RID: 4198 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseDown(MouseEventArgs e)
		{
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseUp(MouseEventArgs e)
		{
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseEnter(EventArgs e)
		{
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseLeave(EventArgs e)
		{
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnLostFocus(EventArgs e)
		{
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x0600106B RID: 4203 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600106C RID: 4204 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x0600106D RID: 4205 RVA: 0x00002134 File Offset: 0x00000334
		private void method_2(Graphics G)
		{
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaintBackground(PaintEventArgs e)
		{
		}

		// Token: 0x14000041 RID: 65
		// (add) Token: 0x06001070 RID: 4208 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06001071 RID: 4209 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06001072 RID: 4210 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected virtual void OnCheckedChanged(EventArgs e)
		{
		}

		// Token: 0x06001073 RID: 4211 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnClick(EventArgs e)
		{
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x00002134 File Offset: 0x00000334
		private void method_3(Graphics G, ToggleSwitchState appearance)
		{
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x04000481 RID: 1153
		private CustomizableEdges customizableEdges_0;

		// Token: 0x04000482 RID: 1154
		private AnimationManager animationManager_0;

		// Token: 0x04000483 RID: 1155
		private ToggleSwitchState toggleSwitchState_0;

		// Token: 0x04000484 RID: 1156
		private ToggleSwitchState toggleSwitchState_1;

		// Token: 0x04000485 RID: 1157
		private bool bool_0;

		// Token: 0x04000486 RID: 1158
		private DashStyle dashStyle_0;

		// Token: 0x04000487 RID: 1159
		private ShadowDecoration shadowDecoration_0;

		// Token: 0x04000488 RID: 1160
		private bool bool_1;

		// Token: 0x04000489 RID: 1161
		private bool bool_2;

		// Token: 0x0400048A RID: 1162
		internal bool bool_3;

		// Token: 0x0400048B RID: 1163
		internal bool bool_4;

		// Token: 0x0400048C RID: 1164
		internal MouseState mouseState_0;

		// Token: 0x0400048D RID: 1165
		private bool bool_5;
	}
}
