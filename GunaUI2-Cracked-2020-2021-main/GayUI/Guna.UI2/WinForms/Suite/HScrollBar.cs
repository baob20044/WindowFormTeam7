using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security;
using System.Windows.Forms;
using Guna.UI2.WinForms.Enums;
using Guna.UI2.WinForms.Interfaces;
using ns0;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x020000B0 RID: 176
	[ToolboxItem(false)]
	[DefaultProperty("Value")]
	[DefaultEvent("Scroll")]
	public class HScrollBar : UserControl, IControl
	{
		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06000DBE RID: 3518 RVA: 0x00002136 File Offset: 0x00000336
		[Description("Gets a value that indicates whether the Component is currently in design mode.")]
		[Browsable(false)]
		public bool IsDesignMode
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x00002134 File Offset: 0x00000334
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0()
		{
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06000DC2 RID: 3522 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected ScrollBarState DefaultHoverState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06000DC3 RID: 3523 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected ScrollBarState DefaultPressedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06000DC4 RID: 3524 RVA: 0x000033DC File Offset: 0x000015DC
		// (set) Token: 0x06000DC5 RID: 3525 RVA: 0x00002134 File Offset: 0x00000334
		public new Padding Padding
		{
			[CompilerGenerated]
			get
			{
				return default(Padding);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06000DC6 RID: 3526 RVA: 0x000033C4 File Offset: 0x000015C4
		// (set) Token: 0x06000DC7 RID: 3527 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Sets the thumb's style in relation to the ScrollBar.")]
		[Browsable(false)]
		[DefaultValue(0)]
		protected ThumbStyle DefaultThumbStyle
		{
			get
			{
				return ThumbStyle.Default;
			}
			set
			{
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06000DC8 RID: 3528 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000DC9 RID: 3529 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "")]
		[Description("The border BackColor")]
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

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06000DCA RID: 3530 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000DCB RID: 3531 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06000DCC RID: 3532 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000DCD RID: 3533 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06000DCE RID: 3534 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000DCF RID: 3535 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected int DefaultScrollbarSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06000DD0 RID: 3536 RVA: 0x00002145 File Offset: 0x00000345
		// (set) Token: 0x06000DD1 RID: 3537 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected float DefaultThumbSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06000DD2 RID: 3538 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000DD3 RID: 3539 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected bool DefaultHighlightOnWheel
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06000DD4 RID: 3540 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000DD5 RID: 3541 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06000DD6 RID: 3542 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000DD7 RID: 3543 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06000DD8 RID: 3544 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000DD9 RID: 3545 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06000DDA RID: 3546 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000DDB RID: 3547 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06000DDC RID: 3548 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000DDD RID: 3549 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06000DDE RID: 3550 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000DDF RID: 3551 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06000DE0 RID: 3552 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000DE1 RID: 3553 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected bool InUpdate
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06000DE2 RID: 3554 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000DE3 RID: 3555 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06000DE4 RID: 3556 RVA: 0x000033DC File Offset: 0x000015DC
		// (set) Token: 0x06000DE5 RID: 3557 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Padding DefaultFillOffset
		{
			get
			{
				return default(Padding);
			}
			set
			{
			}
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x00002136 File Offset: 0x00000336
		public bool HitTest(Point point)
		{
			return false;
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x00002134 File Offset: 0x00000334
		[SecuritySafeCritical]
		public void BeginUpdate()
		{
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x00002134 File Offset: 0x00000334
		[SecuritySafeCritical]
		public void EndUpdate()
		{
		}

		// Token: 0x1400002A RID: 42
		// (add) Token: 0x06000DE9 RID: 3561 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000DEA RID: 3562 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler MaximumChanged
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

		// Token: 0x06000DEB RID: 3563 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected virtual void OnMaximumChanged(EventArgs e)
		{
		}

		// Token: 0x1400002B RID: 43
		// (add) Token: 0x06000DEC RID: 3564 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000DED RID: 3565 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler MinimumChanged
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

		// Token: 0x06000DEE RID: 3566 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected virtual void OnMinimumChanged(EventArgs e)
		{
		}

		// Token: 0x1400002C RID: 44
		// (add) Token: 0x06000DEF RID: 3567 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000DF0 RID: 3568 RVA: 0x00002134 File Offset: 0x00000334
		public new event ScrollEventHandler Scroll
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

		// Token: 0x06000DF1 RID: 3569 RVA: 0x00002134 File Offset: 0x00000334
		protected virtual void OnScrollChanged(ScrollEventArgs e)
		{
		}

		// Token: 0x1400002D RID: 45
		// (add) Token: 0x06000DF2 RID: 3570 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000DF3 RID: 3571 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06000DF4 RID: 3572 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected virtual void OnValueChanged(EventArgs e)
		{
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x00002134 File Offset: 0x00000334
		private void method_1(object sender, ScrollEventArgs e)
		{
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x00002134 File Offset: 0x00000334
		private void method_2(object sender, EventArgs e)
		{
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnResize(EventArgs e)
		{
		}

		// Token: 0x1400002E RID: 46
		// (add) Token: 0x06000DF8 RID: 3576 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000DF9 RID: 3577 RVA: 0x00002134 File Offset: 0x00000334
		public new event EventHandler LostFocus
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

		// Token: 0x1400002F RID: 47
		// (add) Token: 0x06000DFA RID: 3578 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000DFB RID: 3579 RVA: 0x00002134 File Offset: 0x00000334
		public new event EventHandler GotFocus
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

		// Token: 0x06000DFC RID: 3580 RVA: 0x00002134 File Offset: 0x00000334
		private void method_3(object sender, EventArgs e)
		{
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x00002134 File Offset: 0x00000334
		private void method_4(object sender, EventArgs e)
		{
		}

		// Token: 0x04000393 RID: 915
		private IContainer icontainer_0;

		// Token: 0x04000394 RID: 916
		private Class0 class0_0;

		// Token: 0x04000395 RID: 917
		private ScrollBar scrollBar_0;

		// Token: 0x04000396 RID: 918
		[CompilerGenerated]
		private Padding padding_0;
	}
}
