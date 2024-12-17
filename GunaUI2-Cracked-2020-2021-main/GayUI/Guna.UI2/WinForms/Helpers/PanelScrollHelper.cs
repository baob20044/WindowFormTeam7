using System;
using System.Windows.Forms;

namespace Guna.UI2.WinForms.Helpers
{
	// Token: 0x0200008B RID: 139
	public class PanelScrollHelper
	{
		// Token: 0x060009F2 RID: 2546 RVA: 0x00002167 File Offset: 0x00000367
		public PanelScrollHelper(Panel panel, Guna2VScrollBar vScrollBar, bool autoSizeAndLocationOfScrollBar = true)
		{
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x00002167 File Offset: 0x00000367
		public PanelScrollHelper(Panel panel, Guna2HScrollBar hScrollBar, bool autoSizeAndLocationOfScrollBar = true)
		{
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x00002134 File Offset: 0x00000334
		public void UpdateScrollBar()
		{
		}

		// Token: 0x04000229 RID: 553
		private PanelScrollHelper.HScrollBarPanelHelper hscrollBarPanelHelper_0;

		// Token: 0x0400022A RID: 554
		private PanelScrollHelper.VScrollBarPanelHelper vscrollBarPanelHelper_0;

		// Token: 0x0200008C RID: 140
		public class VScrollBarPanelHelper
		{
			// Token: 0x060009F5 RID: 2549 RVA: 0x00002167 File Offset: 0x00000367
			public VScrollBarPanelHelper(Panel panel, Guna2VScrollBar vScrollBar, bool autoSizeAndLocation = true)
			{
			}

			// Token: 0x060009F6 RID: 2550 RVA: 0x00002134 File Offset: 0x00000334
			private void method_0(object sender, EventArgs e)
			{
			}

			// Token: 0x060009F7 RID: 2551 RVA: 0x00002134 File Offset: 0x00000334
			private void method_1(object sender, ControlEventArgs e)
			{
			}

			// Token: 0x060009F8 RID: 2552 RVA: 0x00002134 File Offset: 0x00000334
			private void method_2(object sender, ControlEventArgs e)
			{
			}

			// Token: 0x060009F9 RID: 2553 RVA: 0x00002134 File Offset: 0x00000334
			private void method_3(object sender, MouseEventArgs e)
			{
			}

			// Token: 0x060009FA RID: 2554 RVA: 0x00002134 File Offset: 0x00000334
			private void method_4(object sender, ScrollEventArgs e)
			{
			}

			// Token: 0x060009FB RID: 2555 RVA: 0x00002134 File Offset: 0x00000334
			public void updateScrollBar()
			{
			}

			// Token: 0x0400022B RID: 555
			private Guna2VScrollBar guna2VScrollBar_0;

			// Token: 0x0400022C RID: 556
			private Panel panel_0;

			// Token: 0x0400022D RID: 557
			private bool bool_0;

			// Token: 0x0400022E RID: 558
			private bool bool_1;
		}

		// Token: 0x0200008D RID: 141
		public class HScrollBarPanelHelper
		{
			// Token: 0x060009FC RID: 2556 RVA: 0x00002167 File Offset: 0x00000367
			public HScrollBarPanelHelper(Panel panel, Guna2HScrollBar hScrollBar, bool autoSizeAndLocation = true)
			{
			}

			// Token: 0x060009FD RID: 2557 RVA: 0x00002134 File Offset: 0x00000334
			private void method_0(object sender, EventArgs e)
			{
			}

			// Token: 0x060009FE RID: 2558 RVA: 0x00002134 File Offset: 0x00000334
			private void method_1(object sender, ControlEventArgs e)
			{
			}

			// Token: 0x060009FF RID: 2559 RVA: 0x00002134 File Offset: 0x00000334
			private void method_2(object sender, ControlEventArgs e)
			{
			}

			// Token: 0x06000A00 RID: 2560 RVA: 0x00002134 File Offset: 0x00000334
			private void method_3(object sender, ScrollEventArgs e)
			{
			}

			// Token: 0x06000A01 RID: 2561 RVA: 0x00002134 File Offset: 0x00000334
			public void updateScrollBar()
			{
			}

			// Token: 0x0400022F RID: 559
			private Guna2HScrollBar guna2HScrollBar_0;

			// Token: 0x04000230 RID: 560
			private Panel panel_0;

			// Token: 0x04000231 RID: 561
			private bool bool_0;
		}
	}
}
