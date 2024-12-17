using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.WinForms.Suite;

namespace Guna.UI2.WinForms
{
	// Token: 0x0200006D RID: 109
	[Description("A ShadowForm Component")]
	[ToolboxItem(true)]
	public class Guna2ShadowForm : Component
	{
		// Token: 0x06000822 RID: 2082 RVA: 0x0000214C File Offset: 0x0000034C
		public Guna2ShadowForm()
		{
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x0000214C File Offset: 0x0000034C
		public Guna2ShadowForm(Form form)
		{
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x0000214C File Offset: 0x0000034C
		public Guna2ShadowForm(IContainer container)
		{
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00002134 File Offset: 0x00000334
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0()
		{
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x00002134 File Offset: 0x00000334
		private void method_1(object sender, EventArgs e)
		{
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06000828 RID: 2088 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000829 RID: 2089 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler Load
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

		// Token: 0x0600082A RID: 2090 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected virtual void OnLoad(EventArgs e)
		{
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x0600082B RID: 2091 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600082C RID: 2092 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("The curve angle of the shadow on all angles")]
		[DefaultValue(12)]
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

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x0600082D RID: 2093 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600082E RID: 2094 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("Gets or sets the shadow color")]
		[DefaultValue(typeof(Color), "Black")]
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

		// Token: 0x0600082F RID: 2095 RVA: 0x00002134 File Offset: 0x00000334
		public void SetShadowForm(Form form)
		{
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000830 RID: 2096 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000831 RID: 2097 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("The target form to apply the shadow")]
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

		// Token: 0x06000832 RID: 2098 RVA: 0x00002134 File Offset: 0x00000334
		private void method_2()
		{
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x00002134 File Offset: 0x00000334
		public void Clear()
		{
		}

		// Token: 0x04000196 RID: 406
		private ShadowForm shadowForm_0;

		// Token: 0x04000197 RID: 407
		private Form form_0;

		// Token: 0x04000198 RID: 408
		private Guna.UI2.WinForms.Suite.Panel panel_0;

		// Token: 0x04000199 RID: 409
		private IContainer icontainer_0;

		// Token: 0x0400019B RID: 411
		private int int_0;

		// Token: 0x0400019C RID: 412
		private Color color_0;
	}
}
