using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using ns2;

namespace Guna.UI2.WinForms
{
	// Token: 0x0200006B RID: 107
	[ToolboxItem(true)]
	[DebuggerStepThrough]
	[Description("A resize form control")]
	public class Guna2ResizeForm : Component
	{
		// Token: 0x06000809 RID: 2057 RVA: 0x0000214C File Offset: 0x0000034C
		public Guna2ResizeForm()
		{
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x0000214C File Offset: 0x0000034C
		public Guna2ResizeForm(Form form)
		{
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x0000214C File Offset: 0x0000034C
		public Guna2ResizeForm(IContainer container)
		{
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0()
		{
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00002134 File Offset: 0x00000334
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x0600080E RID: 2062 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x0600080F RID: 2063 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("The target form to apply resizing a borderless form.")]
		[DefaultValue(typeof(Form), "")]
		public Form TargetForm
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00002134 File Offset: 0x00000334
		public void SetResizeForm(Form form)
		{
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x00002134 File Offset: 0x00000334
		private void method_1()
		{
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00002134 File Offset: 0x00000334
		private void method_2()
		{
		}

		// Token: 0x04000190 RID: 400
		private Form form_0;

		// Token: 0x04000191 RID: 401
		private Class10 class10_0;

		// Token: 0x04000192 RID: 402
		private IContainer icontainer_0;
	}
}
