using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms.Enums;

namespace Guna.UI2.WinForms
{
	// Token: 0x02000056 RID: 86
	[Description("The component that is used to drag a borderless winform.")]
	[DebuggerStepThrough]
	[ToolboxItem(true)]
	public class Guna2DragControl : Component
	{
		// Token: 0x060005BB RID: 1467 RVA: 0x0000214C File Offset: 0x0000034C
		public Guna2DragControl()
		{
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x0000214C File Offset: 0x0000034C
		public Guna2DragControl(Control control)
		{
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x0000214C File Offset: 0x0000034C
		public Guna2DragControl(IContainer container)
		{
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00002134 File Offset: 0x00000334
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0()
		{
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060005C1 RID: 1473 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x060005C2 RID: 1474 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060005C3 RID: 1475 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
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

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x060005C4 RID: 1476 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060005C5 RID: 1477 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Control), "")]
		[Description("The target control or form to apply drag.")]
		public Control TargetControl
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x060005C6 RID: 1478 RVA: 0x00003424 File Offset: 0x00001624
		// (set) Token: 0x060005C7 RID: 1479 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Allows you to move the form or control on the vertical, horizontal or both axis.")]
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

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x060005C8 RID: 1480 RVA: 0x000039F0 File Offset: 0x00001BF0
		// (set) Token: 0x060005C9 RID: 1481 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(DragMode.Form)]
		[Description("Gets or sets a value indicating whether the parent form or control will be dragging.")]
		public DragMode DragMode
		{
			get
			{
				return DragMode.Form;
			}
			set
			{
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x060005CA RID: 1482 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060005CB RID: 1483 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Gets or sets a value indicating whether the parent form's opacity or transparency will be changed whenever it's being dragged on screen.")]
		[Browsable(false)]
		[DefaultValue(false)]
		public bool UseTransparentDrag
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x060005CC RID: 1484 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060005CD RID: 1485 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(false)]
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

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x060005CE RID: 1486 RVA: 0x00002154 File Offset: 0x00000354
		// (set) Token: 0x060005CF RID: 1487 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("Gets or sets the opacity or transparency value that will be applied when the dragging starts.")]
		[TypeConverter(typeof(OpacityConverter))]
		[DefaultValue(0.9)]
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

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x060005D0 RID: 1488 RVA: 0x00002154 File Offset: 0x00000354
		// (set) Token: 0x060005D1 RID: 1489 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(double), "1")]
		[Browsable(true)]
		[TypeConverter(typeof(OpacityConverter))]
		[Description("Gets or sets the opacity or transparency value that will be applied when the dragging ends.")]
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

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x060005D2 RID: 1490 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060005D3 RID: 1491 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(false)]
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

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x060005D4 RID: 1492 RVA: 0x00002154 File Offset: 0x00000354
		// (set) Token: 0x060005D5 RID: 1493 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(0.2)]
		[Description("Gets or sets the opacity or transparency of the docking indicators.")]
		[TypeConverter(typeof(OpacityConverter))]
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

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x060005D6 RID: 1494 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060005D7 RID: 1495 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Gets or sets the color of the docking indicators.")]
		[DefaultValue(typeof(Color), "White")]
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

		// Token: 0x060005D8 RID: 1496 RVA: 0x00002134 File Offset: 0x00000334
		public void SetDrag(Control control)
		{
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00002134 File Offset: 0x00000334
		private void method_1(object sender, EventArgs e)
		{
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00002134 File Offset: 0x00000334
		private void method_2(object sender, EventArgs e)
		{
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00002134 File Offset: 0x00000334
		private void method_3(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00002134 File Offset: 0x00000334
		private void method_4(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00002134 File Offset: 0x00000334
		private void method_5()
		{
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00002134 File Offset: 0x00000334
		private void method_6()
		{
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x00002134 File Offset: 0x00000334
		private void method_7()
		{
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00002134 File Offset: 0x00000334
		private void method_8(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00002131 File Offset: 0x00000331
		private Form method_9(ContainerControl value)
		{
			return null;
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00002131 File Offset: 0x00000331
		private Form method_10(Control value)
		{
			return null;
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00002134 File Offset: 0x00000334
		public void Grab(Control control)
		{
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00002134 File Offset: 0x00000334
		public void Release()
		{
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00002134 File Offset: 0x00000334
		public void MoveObject(bool Horizontal = true, bool Vertical = true)
		{
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00002134 File Offset: 0x00000334
		private void method_11()
		{
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00002134 File Offset: 0x00000334
		private void method_12(Size size, Point point)
		{
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x00002134 File Offset: 0x00000334
		private void method_13()
		{
		}

		// Token: 0x0400012C RID: 300
		private Size size_0;

		// Token: 0x0400012D RID: 301
		private Form form_0;

		// Token: 0x0400012E RID: 302
		private IContainer icontainer_0;

		// Token: 0x0400012F RID: 303
		private ContainerControl containerControl_0;

		// Token: 0x04000130 RID: 304
		private Control control_0;

		// Token: 0x04000131 RID: 305
		private DragOrientation dragOrientation_0;

		// Token: 0x04000132 RID: 306
		private DragMode dragMode_0;

		// Token: 0x04000133 RID: 307
		private bool bool_0;

		// Token: 0x04000134 RID: 308
		private double double_0;

		// Token: 0x04000135 RID: 309
		private double double_1;

		// Token: 0x04000136 RID: 310
		private bool bool_1;

		// Token: 0x04000137 RID: 311
		private double double_2;

		// Token: 0x04000138 RID: 312
		private Color color_0;

		// Token: 0x04000139 RID: 313
		private bool bool_2;

		// Token: 0x0400013A RID: 314
		private int int_0;

		// Token: 0x0400013B RID: 315
		private int int_1;

		// Token: 0x0400013C RID: 316
		private Control control_1;

		// Token: 0x0400013D RID: 317
		private Guna2DragControl.Enum1 enum1_0;

		// Token: 0x0400013E RID: 318
		private Guna2DragControl.Form1 form1_0;

		// Token: 0x02000057 RID: 87
		private enum Enum1
		{
			// Token: 0x04000140 RID: 320
			const_0,
			// Token: 0x04000141 RID: 321
			const_1,
			// Token: 0x04000142 RID: 322
			const_2,
			// Token: 0x04000143 RID: 323
			const_3,
			// Token: 0x04000144 RID: 324
			const_4,
			// Token: 0x04000145 RID: 325
			const_5,
			// Token: 0x04000146 RID: 326
			const_6,
			// Token: 0x04000147 RID: 327
			const_7
		}

		// Token: 0x02000058 RID: 88
		private class Form1 : Form
		{
			// Token: 0x060005EA RID: 1514 RVA: 0x00002134 File Offset: 0x00000334
			protected override void Dispose(bool disposing)
			{
			}

			// Token: 0x060005EB RID: 1515 RVA: 0x00002134 File Offset: 0x00000334
			private void method_0()
			{
			}

			// Token: 0x04000148 RID: 328
			private IContainer icontainer_0;
		}
	}
}
