using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Guna.UI2.WinForms
{
	// Token: 0x02000048 RID: 72
	[Description("This components animates a winform when loading")]
	[ToolboxItem(true)]
	public class Guna2AnimateWindow : Component
	{
		// Token: 0x06000431 RID: 1073 RVA: 0x0000214C File Offset: 0x0000034C
		public Guna2AnimateWindow()
		{
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x0000214C File Offset: 0x0000034C
		public Guna2AnimateWindow(Form form, Guna2AnimateWindow.AnimateWindowType animateWindowType = Guna2AnimateWindow.AnimateWindowType.AW_CENTER, int interval = 500)
		{
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x0000214C File Offset: 0x0000034C
		public Guna2AnimateWindow(ContextMenuStrip contextMenuStrip, Guna2AnimateWindow.AnimateWindowType animateWindowType = Guna2AnimateWindow.AnimateWindowType.AW_CENTER, int interval = 500)
		{
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x0000214C File Offset: 0x0000034C
		public Guna2AnimateWindow(IContainer container)
		{
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00002134 File Offset: 0x00000334
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0()
		{
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000438 RID: 1080 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(500)]
		[Browsable(true)]
		public int Interval
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x00003930 File Offset: 0x00001B30
		// (set) Token: 0x0600043A RID: 1082 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(16)]
		public Guna2AnimateWindow.AnimateWindowType AnimationType
		{
			[CompilerGenerated]
			get
			{
				return (Guna2AnimateWindow.AnimateWindowType)0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00002134 File Offset: 0x00000334
		public void SetAnimateWindow(Form form, Guna2AnimateWindow.AnimateWindowType animationType, int interval)
		{
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00002134 File Offset: 0x00000334
		internal void method_1(Form form, int animationType, int interval)
		{
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00002134 File Offset: 0x00000334
		public void SetAnimateWindow(ContextMenuStrip contextMenuStrip, Guna2AnimateWindow.AnimateWindowType animationType, int interval)
		{
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00002134 File Offset: 0x00000334
		public void SetAnimateWindow(Form form, Guna2AnimateWindow.AnimateWindowType animationType)
		{
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00002134 File Offset: 0x00000334
		public void SetAnimateWindow(ContextMenuStrip contextMenuStrip, Guna2AnimateWindow.AnimateWindowType animationType)
		{
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00002134 File Offset: 0x00000334
		public void SetAnimateWindow(Form form)
		{
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000442 RID: 1090 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Form), "")]
		[Description("The target form to apply the AnimateWindow")]
		[Browsable(true)]
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

		// Token: 0x06000443 RID: 1091 RVA: 0x00002134 File Offset: 0x00000334
		private void method_2(object sender, EventArgs e)
		{
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00002134 File Offset: 0x00000334
		public void SetAnimateWindow(ContextMenuStrip contextMenuStrip)
		{
		}

		// Token: 0x04000101 RID: 257
		private IContainer icontainer_0;

		// Token: 0x04000102 RID: 258
		[CompilerGenerated]
		private int int_0;

		// Token: 0x04000103 RID: 259
		[CompilerGenerated]
		private Guna2AnimateWindow.AnimateWindowType animateWindowType_0;

		// Token: 0x04000104 RID: 260
		private Form form_0;

		// Token: 0x02000049 RID: 73
		public enum AnimateWindowType
		{
			// Token: 0x04000106 RID: 262
			AW_HOR_POSITIVE = 1,
			// Token: 0x04000107 RID: 263
			AW_HOR_NEGATIVE,
			// Token: 0x04000108 RID: 264
			AW_VER_POSITIVE = 4,
			// Token: 0x04000109 RID: 265
			AW_VER_NEGATIVE = 8,
			// Token: 0x0400010A RID: 266
			AW_CENTER = 16,
			// Token: 0x0400010B RID: 267
			AW_HIDE = 65536,
			// Token: 0x0400010C RID: 268
			AW_ACTIVATE = 131072,
			// Token: 0x0400010D RID: 269
			AW_SLIDE = 262144,
			// Token: 0x0400010E RID: 270
			AW_BLEND = 524288
		}
	}
}
