using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.WinForms.Enums;
using Guna.UI2.WinForms.Interfaces;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x020000C1 RID: 193
	[ToolboxBitmap(typeof(TrackBar))]
	[ToolboxItem(false)]
	[DefaultEvent("Scroll")]
	public class TrackBar : Control, IControl
	{
		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06001076 RID: 4214 RVA: 0x00002136 File Offset: 0x00000336
		[Browsable(false)]
		[Description("Gets a value that indicates whether the Component is currently in design mode.")]
		public bool IsDesignMode
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06001077 RID: 4215 RVA: 0x00003810 File Offset: 0x00001A10
		[Browsable(false)]
		public MouseState MouseState
		{
			get
			{
				return MouseState.HOVER;
			}
		}

		// Token: 0x14000042 RID: 66
		// (add) Token: 0x06001078 RID: 4216 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06001079 RID: 4217 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler ValueChanged
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

		// Token: 0x0600107A RID: 4218 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected virtual void OnValueChanged(EventArgs e)
		{
		}

		// Token: 0x14000043 RID: 67
		// (add) Token: 0x0600107B RID: 4219 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x0600107C RID: 4220 RVA: 0x00002134 File Offset: 0x00000334
		public event ScrollEventHandler Scroll
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

		// Token: 0x0600107D RID: 4221 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		private void method_0(ScrollEventType scrollType, int newValue)
		{
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x0600107E RID: 4222 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected TrackBarState DefaultHoverState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x0600107F RID: 4223 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06001080 RID: 4224 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected bool DefaultUseSelectable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06001081 RID: 4225 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06001082 RID: 4226 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected bool DefaultDisplayFocus
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06001083 RID: 4227 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06001084 RID: 4228 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected int DefaultValue
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06001085 RID: 4229 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06001086 RID: 4230 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected int DefaultMinimum
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06001087 RID: 4231 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06001088 RID: 4232 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected int DefaultMaximum
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06001089 RID: 4233 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600108A RID: 4234 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected int DefaultSmallChange
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x0600108B RID: 4235 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600108C RID: 4236 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected int DefaultLargeChange
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x0600108D RID: 4237 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600108E RID: 4238 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected int DefaultMouseWheelBarPartitions
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x0600108F RID: 4239 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06001090 RID: 4240 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Color DefaultThumbColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06001091 RID: 4241 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06001092 RID: 4242 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06001093 RID: 4243 RVA: 0x000033AC File Offset: 0x000015AC
		// (set) Token: 0x06001094 RID: 4244 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected TrackBarStyle DefaultStyle
		{
			get
			{
				return TrackBarStyle.Default;
			}
			set
			{
			}
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x00002134 File Offset: 0x00000334
		private void method_1(Graphics G)
		{
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x00002134 File Offset: 0x00000334
		private void method_2(Graphics g, Color thumbColor, Color barColor)
		{
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x00002134 File Offset: 0x00000334
		private void method_3(Graphics g, Color thumbColor, Color barColor)
		{
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnGotFocus(EventArgs e)
		{
		}

		// Token: 0x0600109B RID: 4251 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnLostFocus(EventArgs e)
		{
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnEnter(EventArgs e)
		{
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnLeave(EventArgs e)
		{
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnKeyDown(KeyEventArgs e)
		{
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnKeyUp(KeyEventArgs e)
		{
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x00002136 File Offset: 0x00000336
		protected override bool ProcessDialogKey(Keys keyData)
		{
			return false;
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseEnter(EventArgs e)
		{
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseDown(MouseEventArgs e)
		{
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseMove(MouseEventArgs e)
		{
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseUp(MouseEventArgs e)
		{
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseLeave(EventArgs e)
		{
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseWheel(MouseEventArgs e)
		{
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnEnabledChanged(EventArgs e)
		{
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x00002134 File Offset: 0x00000334
		private void method_4(int val)
		{
		}

		// Token: 0x0400048F RID: 1167
		private Orientation orientation_0;

		// Token: 0x04000490 RID: 1168
		private bool bool_0;

		// Token: 0x04000491 RID: 1169
		private int int_0;

		// Token: 0x04000492 RID: 1170
		private int int_1;

		// Token: 0x04000493 RID: 1171
		private int int_2;

		// Token: 0x04000494 RID: 1172
		private int int_3;

		// Token: 0x04000495 RID: 1173
		private int int_4;

		// Token: 0x04000496 RID: 1174
		private int int_5;

		// Token: 0x04000497 RID: 1175
		private bool bool_1;

		// Token: 0x04000498 RID: 1176
		private bool bool_2;

		// Token: 0x04000499 RID: 1177
		private bool bool_3;

		// Token: 0x0400049C RID: 1180
		private TrackBarState trackBarState_0;

		// Token: 0x0400049D RID: 1181
		private Color color_0;

		// Token: 0x0400049E RID: 1182
		private Color color_1;

		// Token: 0x0400049F RID: 1183
		private TrackBarStyle trackBarStyle_0;
	}
}
