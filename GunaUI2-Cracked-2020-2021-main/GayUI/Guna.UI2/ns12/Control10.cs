using System;
using System.ComponentModel;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace ns12
{
	// Token: 0x0200017B RID: 379
	internal class Control10 : UserControl
	{
		// Token: 0x0600170F RID: 5903 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x06001710 RID: 5904 RVA: 0x00002134 File Offset: 0x00000334
		public void method_0()
		{
		}

		// Token: 0x06001711 RID: 5905 RVA: 0x00002134 File Offset: 0x00000334
		public void method_1(string caption, Control10.ButtonType buttonType)
		{
		}

		// Token: 0x06001712 RID: 5906 RVA: 0x00002134 File Offset: 0x00000334
		private void method_2(object sender, EventArgs e)
		{
		}

		// Token: 0x06001713 RID: 5907 RVA: 0x00002134 File Offset: 0x00000334
		private void method_3(object sender, EventArgs e)
		{
		}

		// Token: 0x06001714 RID: 5908 RVA: 0x00002134 File Offset: 0x00000334
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x06001715 RID: 5909 RVA: 0x00002134 File Offset: 0x00000334
		private void method_4()
		{
		}

		// Token: 0x040009DA RID: 2522
		public Control10.ButtonClick buttonClick_0;

		// Token: 0x040009DB RID: 2523
		public Control10.ButtonClick buttonClick_1;

		// Token: 0x040009DC RID: 2524
		private IContainer icontainer_0;

		// Token: 0x040009DD RID: 2525
		private Guna2Panel guna2Panel_0;

		// Token: 0x040009DE RID: 2526
		private Guna2HtmlLabel guna2HtmlLabel_0;

		// Token: 0x040009DF RID: 2527
		private Guna2Button guna2Button_0;

		// Token: 0x040009E0 RID: 2528
		private Guna2Button guna2Button_1;

		// Token: 0x0200017C RID: 380
		public enum ButtonType
		{
			// Token: 0x040009E2 RID: 2530
			Ok,
			// Token: 0x040009E3 RID: 2531
			OKCancel
		}

		// Token: 0x0200017D RID: 381
		// (Invoke) Token: 0x06001717 RID: 5911
		public delegate void ButtonClick();
	}
}
