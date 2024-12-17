using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms.Enums;
using ns2;

namespace Guna.UI2.WinForms
{
	// Token: 0x0200002E RID: 46
	[Description("It is easier for you to customize the view of the borderless form with some of the combinant components: dragform, dockform, resizeform, formshadow, ellipse and animatewindow.")]
	[ToolboxItem(true)]
	public class Guna2BorderlessForm : Component
	{
		// Token: 0x06000278 RID: 632 RVA: 0x0000214C File Offset: 0x0000034C
		public Guna2BorderlessForm()
		{
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000214C File Offset: 0x0000034C
		public Guna2BorderlessForm(IContainer container)
		{
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00002134 File Offset: 0x00000334
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0()
		{
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x0600027C RID: 636 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x0600027D RID: 637 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public ContainerControl ContainerControl
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600027E RID: 638 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x0600027F RID: 639 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public override ISite Site
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000280 RID: 640 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000281 RID: 641 RVA: 0x00002134 File Offset: 0x00000334
		[Description("")]
		[Category("FormShadow")]
		[DefaultValue(true)]
		public bool HasFormShadow
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000282 RID: 642 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000283 RID: 643 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "Black")]
		[Description("Gets or sets the shadow color")]
		[Browsable(true)]
		[Category("FormShadow")]
		public Color ShadowColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000284 RID: 644 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000285 RID: 645 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(false)]
		[Category("AnimateWindow")]
		public bool AnimateWindow
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000286 RID: 646 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000287 RID: 647 RVA: 0x00002134 File Offset: 0x00000334
		[Category("AnimateWindow")]
		[Browsable(true)]
		[DefaultValue(500)]
		public int AnimationInterval
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000288 RID: 648 RVA: 0x0000340C File Offset: 0x0000160C
		// (set) Token: 0x06000289 RID: 649 RVA: 0x00002134 File Offset: 0x00000334
		[Category("AnimateWindow")]
		[Browsable(true)]
		[DefaultValue(524288)]
		public Guna2BorderlessForm.AnimateWindowType AnimationType
		{
			get
			{
				return (Guna2BorderlessForm.AnimateWindowType)0;
			}
			set
			{
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600028A RID: 650 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600028B RID: 651 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("The curve angle of the form on all angles")]
		[DefaultValue(0)]
		[Category("Ellipse")]
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

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600028C RID: 652 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600028D RID: 653 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(true)]
		[Category("DragForm")]
		[Description("Gets or sets a value indicating whether the parent form will be draggable.")]
		public bool DragForm
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600028E RID: 654 RVA: 0x00003424 File Offset: 0x00001624
		// (set) Token: 0x0600028F RID: 655 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Allows you to move the form or control on the vertical, horizontal or both axis")]
		[Category("DragForm")]
		[DefaultValue(DragOrientation.Both)]
		public DragOrientation DragOrientation
		{
			get
			{
				return DragOrientation.Horizontal;
			}
			set
			{
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000290 RID: 656 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000291 RID: 657 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(false)]
		[Category("DragForm")]
		[Description("Gets or sets a value indicating whether the parent form's opacity or transparency will be changed whenever it's being dragged on screen.")]
		public bool TransparentWhileDrag
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000292 RID: 658 RVA: 0x00002154 File Offset: 0x00000354
		// (set) Token: 0x06000293 RID: 659 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Category("DragForm")]
		[TypeConverter(typeof(OpacityConverter))]
		[DefaultValue(0.9)]
		[Description("Gets or sets the opacity or transparency value that will be applied when the dragging starts.")]
		public double DragStartTransparencyValue
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000294 RID: 660 RVA: 0x00002154 File Offset: 0x00000354
		// (set) Token: 0x06000295 RID: 661 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(double), "1")]
		[Browsable(true)]
		[Description("Gets or sets the opacity or transparency value that will be applied when the dragging ends.")]
		[Category("DragForm")]
		[TypeConverter(typeof(OpacityConverter))]
		public double DragEndTransparencyValue
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000296 RID: 662 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000297 RID: 663 RVA: 0x00002134 File Offset: 0x00000334
		[Category("ResizeForm")]
		[Description("Gets or sets a value indicating whether the parent form will be resizable when borderless.")]
		[DefaultValue(true)]
		public bool ResizeForm
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000298 RID: 664 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000299 RID: 665 RVA: 0x00002134 File Offset: 0x00000334
		[Category("DockForm")]
		[DefaultValue(true)]
		[Description("Gets or sets a value indicating whether the docking indicators will be used on the parent form.")]
		public bool DockForm
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600029A RID: 666 RVA: 0x00002154 File Offset: 0x00000354
		// (set) Token: 0x0600029B RID: 667 RVA: 0x00002134 File Offset: 0x00000334
		[TypeConverter(typeof(OpacityConverter))]
		[Category("DockForm")]
		[Description("Gets or sets the opacity or transparency of the docking indicators.")]
		[DefaultValue(0.2)]
		public double DockIndicatorTransparencyValue
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600029C RID: 668 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600029D RID: 669 RVA: 0x00002134 File Offset: 0x00000334
		[Category("DockForm")]
		[DefaultValue(typeof(Color), "White")]
		[Description("Gets or sets the color of the docking indicators.")]
		public Color DockIndicatorColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600029E RID: 670 RVA: 0x00002131 File Offset: 0x00000331
		public Form TargetForm
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00002134 File Offset: 0x00000334
		private void method_1()
		{
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00002134 File Offset: 0x00000334
		private void method_2()
		{
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00002134 File Offset: 0x00000334
		private void method_3(object sender, EventArgs e)
		{
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00002134 File Offset: 0x00000334
		private void method_4(object sender, EventArgs e)
		{
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00002134 File Offset: 0x00000334
		private void method_5(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00002134 File Offset: 0x00000334
		private void method_6(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00002134 File Offset: 0x00000334
		private void method_7()
		{
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00002134 File Offset: 0x00000334
		private void method_8()
		{
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00002134 File Offset: 0x00000334
		private void method_9()
		{
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00002134 File Offset: 0x00000334
		private void method_10(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00002134 File Offset: 0x00000334
		private void method_11(Form form, int ellise)
		{
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00002131 File Offset: 0x00000331
		private Form method_12(ContainerControl value)
		{
			return null;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00002131 File Offset: 0x00000331
		private Form method_13(Control value)
		{
			return null;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00002134 File Offset: 0x00000334
		public void Grab(Control control)
		{
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00002134 File Offset: 0x00000334
		public void Release()
		{
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00002134 File Offset: 0x00000334
		public void MoveObject(bool Horizontal = true, bool Vertical = true)
		{
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00002136 File Offset: 0x00000336
		private int method_14(Guna2BorderlessForm.AnimateWindowType _animateWindowType)
		{
			return 0;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00002134 File Offset: 0x00000334
		private void method_15()
		{
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00002134 File Offset: 0x00000334
		private void method_16(Size size, Point point)
		{
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00002134 File Offset: 0x00000334
		private void method_17()
		{
		}

		// Token: 0x04000043 RID: 67
		private Size size_0;

		// Token: 0x04000044 RID: 68
		private Form form_0;

		// Token: 0x04000045 RID: 69
		private Guna2ShadowForm guna2ShadowForm_0;

		// Token: 0x04000046 RID: 70
		private Guna2ShadowForm guna2ShadowForm_1;

		// Token: 0x04000047 RID: 71
		private Class10 class10_0;

		// Token: 0x04000048 RID: 72
		private IContainer icontainer_0;

		// Token: 0x04000049 RID: 73
		private ContainerControl containerControl_0;

		// Token: 0x0400004A RID: 74
		private bool bool_0;

		// Token: 0x0400004B RID: 75
		private Color color_0;

		// Token: 0x0400004C RID: 76
		private bool bool_1;

		// Token: 0x0400004D RID: 77
		private int int_0;

		// Token: 0x0400004E RID: 78
		private Guna2BorderlessForm.AnimateWindowType animateWindowType_0;

		// Token: 0x0400004F RID: 79
		private int int_1;

		// Token: 0x04000050 RID: 80
		private bool bool_2;

		// Token: 0x04000051 RID: 81
		private DragOrientation dragOrientation_0;

		// Token: 0x04000052 RID: 82
		private bool bool_3;

		// Token: 0x04000053 RID: 83
		private double double_0;

		// Token: 0x04000054 RID: 84
		private double double_1;

		// Token: 0x04000055 RID: 85
		private bool bool_4;

		// Token: 0x04000056 RID: 86
		private bool bool_5;

		// Token: 0x04000057 RID: 87
		private double double_2;

		// Token: 0x04000058 RID: 88
		private Color color_1;

		// Token: 0x04000059 RID: 89
		private bool bool_6;

		// Token: 0x0400005A RID: 90
		private int int_2;

		// Token: 0x0400005B RID: 91
		private int int_3;

		// Token: 0x0400005C RID: 92
		private Control control_0;

		// Token: 0x0400005D RID: 93
		private Guna2BorderlessForm.Enum0 enum0_0;

		// Token: 0x0400005E RID: 94
		private Guna2BorderlessForm.Form0 form0_0;

		// Token: 0x0200002F RID: 47
		public enum AnimateWindowType
		{
			// Token: 0x04000060 RID: 96
			AW_HOR_POSITIVE = 1,
			// Token: 0x04000061 RID: 97
			AW_HOR_NEGATIVE,
			// Token: 0x04000062 RID: 98
			AW_VER_POSITIVE = 4,
			// Token: 0x04000063 RID: 99
			AW_VER_NEGATIVE = 8,
			// Token: 0x04000064 RID: 100
			AW_CENTER = 16,
			// Token: 0x04000065 RID: 101
			AW_BLEND = 524288
		}

		// Token: 0x02000030 RID: 48
		private enum Enum0
		{
			// Token: 0x04000067 RID: 103
			const_0,
			// Token: 0x04000068 RID: 104
			const_1,
			// Token: 0x04000069 RID: 105
			const_2,
			// Token: 0x0400006A RID: 106
			const_3,
			// Token: 0x0400006B RID: 107
			const_4,
			// Token: 0x0400006C RID: 108
			const_5,
			// Token: 0x0400006D RID: 109
			const_6,
			// Token: 0x0400006E RID: 110
			const_7
		}

		// Token: 0x02000031 RID: 49
		private class Form0 : Form
		{
			// Token: 0x060002B4 RID: 692 RVA: 0x00002134 File Offset: 0x00000334
			protected override void Dispose(bool disposing)
			{
			}

			// Token: 0x060002B5 RID: 693 RVA: 0x00002134 File Offset: 0x00000334
			private void method_0()
			{
			}

			// Token: 0x0400006F RID: 111
			private IContainer icontainer_0;
		}
	}
}
