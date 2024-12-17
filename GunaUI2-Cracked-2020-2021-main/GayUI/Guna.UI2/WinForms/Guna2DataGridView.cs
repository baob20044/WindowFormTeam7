using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.WinForms.Enums;

namespace Guna.UI2.WinForms
{
	// Token: 0x02000054 RID: 84
	[Description("A themed DataGridView control")]
	[DebuggerStepThrough]
	[ToolboxBitmap(typeof(DataGridView))]
	public class Guna2DataGridView : DataGridView
	{
		// Token: 0x06000590 RID: 1424 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0(Color hd, Color hdFr, Color bg, Color fr, Color slBg, Color slFr, Color alBg, Color grid)
		{
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x000039D8 File Offset: 0x00001BD8
		// (set) Token: 0x06000592 RID: 1426 RVA: 0x00002134 File Offset: 0x00000334
		[Category("Guna Properties")]
		[DisplayName("Theme")]
		[DefaultValue(true)]
		[Description("Lets you choose and apply a preset theme from the current list of preset themes.")]
		public DataGridViewPresetThemes Theme
		{
			get
			{
				return DataGridViewPresetThemes.Default;
			}
			set
			{
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000594 RID: 1428 RVA: 0x00002134 File Offset: 0x00000334
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Description("Select a theme style to apply to the DataGridView Control")]
		[Category("Guna Properties")]
		[Browsable(true)]
		public Guna2DataGridViewThemeStyle ThemeStyle
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00002134 File Offset: 0x00000334
		private void method_1(DataGridViewPresetThemes value)
		{
		}

		// Token: 0x04000127 RID: 295
		private int int_0;

		// Token: 0x04000128 RID: 296
		private DataGridViewPresetThemes dataGridViewPresetThemes_0;

		// Token: 0x04000129 RID: 297
		[CompilerGenerated]
		private Guna2DataGridViewThemeStyle guna2DataGridViewThemeStyle_0;
	}
}
