using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Guna.UI2.WinForms
{
	// Token: 0x02000059 RID: 89
	[ToolboxItem(true)]
	[Description("A component to apply radius to the winform edges")]
	public class Guna2Elipse : Component
	{
		// Token: 0x060005EC RID: 1516 RVA: 0x0000214C File Offset: 0x0000034C
		public Guna2Elipse()
		{
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x0000214C File Offset: 0x0000034C
		public Guna2Elipse(Control control)
		{
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x0000214C File Offset: 0x0000034C
		public Guna2Elipse(IContainer container)
		{
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00002134 File Offset: 0x00000334
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0()
		{
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x060005F1 RID: 1521 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060005F2 RID: 1522 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The curve angle of the control on all angles")]
		[DefaultValue(6)]
		[Browsable(true)]
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

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x060005F3 RID: 1523 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060005F4 RID: 1524 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(typeof(Control), "")]
		[Description("The target control to apply curves to the edges")]
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

		// Token: 0x060005F5 RID: 1525 RVA: 0x00002134 File Offset: 0x00000334
		public void SetElipse(Control control)
		{
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00002134 File Offset: 0x00000334
		private void method_1(Control ctrl, int Elipse)
		{
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00002134 File Offset: 0x00000334
		private void method_2(object sender, EventArgs e)
		{
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00002134 File Offset: 0x00000334
		public void Clear()
		{
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00002134 File Offset: 0x00000334
		private void method_3()
		{
		}

		// Token: 0x04000149 RID: 329
		private IContainer icontainer_0;

		// Token: 0x0400014A RID: 330
		private Control control_0;

		// Token: 0x0400014B RID: 331
		private int int_0;
	}
}
